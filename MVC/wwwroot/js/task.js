
var myModal = new bootstrap.Modal(document.getElementById('staticBackdrop'), {
})


let parentId = null;

function setParentId(id) {
    parentId = id;
    document.getElementById('staticBackdropLabel').innerText = 'Create SubTask';
}
function changeTitle() {
    document.getElementById('staticBackdropLabel').innerText = 'Create Task';
}

const languages = $('#languages').filterMultiSelect({
    placeholderText: "",
});

var formData = null

$('#form').on('submit', (event) => {
    event.preventDefault();
    formData = new FormData($('#form').get(0));
    JSON.parse(languages.getSelectedOptionsAsJson()).language.forEach(e => {
        formData.append('Task.SelectedEmployees[]', +e)
    });
    formData.append('Task.ParentId', parentId);
    $.ajax({
        url: $('#form').attr('action'),
        data: formData,
        type: 'POST',
        processData: false,
        contentType: false,
        success: (res) => {
            if (res.success) {
                parentId = null;
                myModal.toggle();
            } 
        }
    })
})