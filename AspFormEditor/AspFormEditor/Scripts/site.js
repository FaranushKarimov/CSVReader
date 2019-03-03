/*globals $:false */
'use strict';
(function () {

    $(document).on('click', '.close', function (e) {
        e.preventDefault();

        /* По условию в форме должен быть как минимум 1 блок, поэтому запрещаем пользователю удалять последний оставшийся */

        if ($('.content-container .content').length > 1) {
            $(this).closest('.content').remove();
        }
    });

    /* Генерация поля в зависимости от Select'a */
    $(document).on('change', '.selector', function (e) {
        e.preventDefault();
        var text = $(this).attr('id');
        var index = text.slice(7, text.length - 6);

        var block = $(this).closest('.content').find("div.col-12");
        block.html(' ');

        if (this.value == '1' || this.value == '2') {
            $('<input>', {
                type: 'text', 'data-val-required': "Требуется поле Question.",
                placeholder: 'Placeholder', 'data-val': 'true',
                class: 'form-control text-box single-line',
                id: 'Fields_' + index + '__Question',
                name: 'Fields[' + index + '].Question',
            }).appendTo(block);
        } else if (this.value == '3' || this.value == '4' || this.value == "5") {
            $('<textarea>', {
                placeholder: 'Список вопросов', 'data-val-required': "Требуется поле Question.",
                class: 'form-control text-box single-line',
                id: 'Fields_' + index + '__Question', 'data-val': 'true',
                name: 'Fields[' + index + '].Question'
            }).appendTo(block);
        }
    });

    $(document).on('click', '.btn-link', function (e) {
        e.preventDefault();

        $.ajax({
            url: '/admin/generatefield',
            success: function (html) {
                $(".content-container").append(html);
            }
        });
    });

    if ($('#exampleModal').length == 1) {
        $('#exampleModal').modal('show')
    }
}());