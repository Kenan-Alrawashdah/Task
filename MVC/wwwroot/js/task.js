
var myModal = new bootstrap.Modal(document.getElementById('staticBackdrop'), {
})

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

    $.ajax({
        url: $('#form').attr('action'),
        data: formData,
        type: 'POST',
        processData: false,
        contentType: false,
        success: (res) => {
            if (res.success) {
                myModal.toggle();
            } 
        }
    })
})