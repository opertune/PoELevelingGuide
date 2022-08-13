const { contextBridge, ipcRenderer } = require('electron')

contextBridge.exposeInMainWorld('closeApp', {
    close: () => ipcRenderer.invoke('close-app:close')
})

// preload ipcRenderer in renderer.js
contextBridge.exposeInMainWorld('ipcRenderer', ipcRenderer)