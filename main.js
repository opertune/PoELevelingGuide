const { app, BrowserWindow, ipcMain, globalShortcut } = require('electron')
const path = require('path');
const { exit } = require('process');
require('electron-reload')(__dirname);
const QuestSelection = require('./src/js/QuestSelection')
const fs = require('fs');

if (handleSquirrelEvent(app)) {
    // squirrel event handled and app will exit in 1000ms, so don't do anything else
    return;
}

app.whenReady().then(() => {
    const win = new BrowserWindow({
        transparent: true,
        titleBarStyle: 'hidden',
        width: 250,
        height: 250,
        resizable: false,
        webPreferences: {
            contextIsolation: true,
            nodeIntegration: true,
            preload: path.join(__dirname, './src/js/preload.js'),
        }
    })
    win.setMenuBarVisibility(false)
    win.setAlwaysOnTop(true, 'screen')

    win.loadFile('./index.html')
    app.on('activate', () => {
        if (BrowserWindow.getAllWindows().length === 0) {
            createWindow()
        }
    })

    // Data file path
    const dataFilePath = __dirname + '/data.json'
    // If file doesn't exist => create and write first act and first quest
    if (!fs.existsSync(dataFilePath)) {
        fs.writeFileSync(dataFilePath, '{ "actNum": 0, "questNum": 0 }', function (err) {
            if (err) return console.log(err)
        })
    }


    // Read file content
    var fileContent = fs.readFileSync(dataFilePath)
    var fileContentParse = JSON.parse(fileContent)
    // Init new QuestSelection Object
    const questSelection = new QuestSelection(fileContentParse.actNum, fileContentParse.questNum)
    // Display quest
    win.webContents.executeJavaScript('document.getElementById("quest").innerHTML = "' + questSelection.getQuest() + '"')
    // Set combobox value
    win.webContents.executeJavaScript('document.getElementById("selectedAct").value = "' + (fileContentParse.actNum + 1) + '"')

    // Previous quest
    globalShortcut.register('left', () => {
        questSelection.prevQuest()
        win.webContents.executeJavaScript('document.getElementById("quest").innerHTML = "' + questSelection.getQuest() + '"')
        console.log() // Here because lagging without ¯\_(ツ)_/¯
    })

    // Next quest
    globalShortcut.register('right', () => {
        questSelection.nextQuest()
        win.webContents.executeJavaScript('document.getElementById("quest").innerHTML = "' + questSelection.getQuest() + '"')
        console.log() // Here because lagging without ¯\_(ツ)_/¯
    })

    // Get act number from renderer.js when user change combobox value
    ipcMain.on('synchronous-message', (event, arg) => {
        questSelection.setQuestNum(0)
        questSelection.setActNum(arg - 1)
        win.webContents.executeJavaScript('document.getElementById("quest").innerHTML = "' + questSelection.getQuest() + '"')


        // Synchronous event emmision
        event.returnValue = ''
    })

    // Close app and save actNum and questNum
    ipcMain.handle('close-app:close', () => {
        var actNum = questSelection.getActNum()
        var questNum = questSelection.getQuestNum()

        fs.writeFileSync(dataFilePath, '{ "actNum": ' + actNum + ', "questNum": ' + questNum + ' }', function (err) {
            if (err) return console.log(err)
        })

        exit()
    })
})

app.on('window-all-closed', () => {
    app.quit()
})

function handleSquirrelEvent(application) {
    if (process.argv.length === 1) {
        return false;
    }
    const ChildProcess = require('child_process');
    const path = require('path');
    const appFolder = path.resolve(process.execPath, '..');
    const rootAtomFolder = path.resolve(appFolder, '..');
    const updateDotExe = path.resolve(path.join(rootAtomFolder, 'Update.exe'));
    const exeName = path.basename(process.execPath);
    const spawn = function (command, args) {
        let spawnedProcess, error;
        try {
            spawnedProcess = ChildProcess.spawn(command, args, {
                detached: true
            });
        } catch (error) { }
        return spawnedProcess;
    };
    const spawnUpdate = function (args) {
        return spawn(updateDotExe, args);
    };
    const squirrelEvent = process.argv[1];
    switch (squirrelEvent) {
        case '--squirrel-install':
        case '--squirrel-updated':
            // Optionally do things such as:
            // - Add your .exe to the PATH
            // - Write to the registry for things like file associations and
            //   explorer context menus
            // Install desktop and start menu shortcuts
            spawnUpdate(['--createShortcut', exeName]);
            setTimeout(application.quit, 1000);
            return true;
        case '--squirrel-uninstall':
            // Undo anything you did in the --squirrel-install and
            // --squirrel-updated handlers
            // Remove desktop and start menu shortcuts
            spawnUpdate(['--removeShortcut', exeName]);
            setTimeout(application.quit, 1000);
            return true;
        case '--squirrel-obsolete':
            // This is called on the outgoing version of your app before
            // we update to the new version - it's the opposite of
            // --squirrel-updated
            application.quit();
            return true;
    }
};