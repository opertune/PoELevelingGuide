// Close window when user click on cross
document.getElementById('close').addEventListener('click', async () => {
    await window.closeApp.close()
})

// Send act number to main.js when user change combobox value
document.getElementById('selectedAct').addEventListener('change', () => {
    ipcRenderer.sendSync('synchronous-message', document.getElementById('selectedAct').value)
})
