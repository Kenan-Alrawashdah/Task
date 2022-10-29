
var myModal = new bootstrap.Modal(document.getElementById('staticBackdrop'), {
})


let parentId = null;

function setParentId(id) {
    parentId = id;
    document.getElementById('staticBackdropLabel').innerText = 'Create Sub Task';
}
function changeTitle() {
    parentId = null;
    document.getElementById('staticBackdropLabel').innerText = 'Create New Task';
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
    if (parentId) {
    formData.append('Task.ParentId', parentId);
    }
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
                location.reload();
            } 
        }
    })
})



function toggle(classN) {
    $('tr.' + classN).toggle();
    $('i.' + classN).toggleClass('bi-chevron-right bi-chevron-down');

}


$(document).ready(() => {
    $('.status').each((i, e) => {
        console.log(e.id);
        const tooltip = document.getElementById(e.id + '-tooltip');
        tippy('#' + e.id, {
            content: tooltip.innerHTML,
            allowHTML: true,
        })
    });
})

