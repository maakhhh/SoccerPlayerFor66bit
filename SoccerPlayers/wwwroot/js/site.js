let button = document.querySelector('#change_command')
let selectCommand = document.querySelector('#command_names')
let newCommand = document.querySelector('#new_command_name')

button.onclick = function () {
    if (newCommand.value !== "") {
        let option = document.createElement("option")
        option.text = newCommand.value
        option.value = newCommand.value
        selectCommand.add(option)
        option.selected = true
    }

}