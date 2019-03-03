/*globals $:false */
'use strict';
(function () {

    /* Удаление поля. */
    $(document).on('click', '.close', function (e) {
        e.preventDefault();

        /* По условию в форме должно быть как минимум 1 поле, поэтому запрещаем пользователю удалять последнее оставшееся. */
        if ($('.content-container .content').length > 1) {
            $(this).closest('.content').remove();
        }

        /* Удаление скрытого сгенерированного поля */
        var text = $(this).closest('.content').find('select').attr('id');
        var index = text.slice(7, text.length - 6);
        $('input[value=' + index + ']').remove();
    });

    /* Генерация input для вопроса в зависимости от Select'a. */
    $(document).on('change', '.selector', function (e) {
        e.preventDefault();
        var text = $(this).attr('id');
        var index = text.slice(7, text.length - 6);

        var field = $(this).closest('.content').find("div.col-12");
        field.html(' ');

        if (this.value == 1 || this.value == 2) {
            $('<input>', {
                type: 'text', 'data-val-required': "Требуется поле Question.",
                placeholder: 'Placeholder', 'data-val': 'true',
                class: 'form-control text-box single-line',
                id: 'Fields_' + index + '__Question',
                name: 'Fields[' + index + '].Question',
            }).appendTo(field);
        } else if (this.value == 3 || this.value == 4 || this.value == 5) {
            $('<textarea>', {
                placeholder: 'Список вопросов', 'data-val-required': "Требуется поле Question.",
                class: 'form-control text-box single-line',
                id: 'Fields_' + index + '__Question', 'data-val': 'true',
                name: 'Fields[' + index + '].Question'
            }).appendTo(field);
        }

        if (this.value > 0 && this.value < 6) {
            $('<span>', {
                class: 'text-danger field-validation-valid', 'data-valmsg-for': 'Fields[' + index + '].Question',
                'data-valmsg-replace': 'true'
            }).appendTo(field);
        }
    });

    /* Добавление нового поля. */
    $(document).on('click', '.btn-link', function (e) {
        e.preventDefault();

        /* Генерация id для поля. */
        var id = Math.random().toString(36).substr(2, 9);
        var container = $('.content-container');

        var clone = container.children().last().clone(true, true);

        // input hidden Id
        clone.find("input:first").
            val(0);

        // input 
        clone.find('[type = text]').
            attr('name', 'Fields[' + id + '].FieldTitle').
            attr('id', 'Fields_' + id + '__FieldTitle').val('');
        clone.find('.col-6:first').find('span').
            attr('data-valmsg-for', 'Fields[' + id + '].FieldTitle');

        // select
        clone.find('select').
            attr('name', 'Fields[' + id + '].Type').
            attr('id', 'Fields_' + id + '__Type');
        clone.find('.col-6:last').find('span').
            attr('data-valmsg-for', 'Fields[' + id + '].Type');

        // checkbox
        clone.find('[type=checkbox]').
            attr('name', 'Fields[' + id + '].Required').
            attr('id', 'Fields_' + id + '__Required').prop("checked", false);
        clone.find('.form-check-label').find('input:last').
            attr('name', 'Fields[' + id + '].Required');

        // input/textarea
        clone.find('div.col-12').html('');

        // input hidden
        $('<input>', {
            type: 'hidden', name: 'Fields.index', autocomplete: "off",
            value: id
        }).appendTo(container);

        $(clone).appendTo(container);
    });

    if ($('#messageModal').length == 1) {
        $('#messageModal').modal('show');
    }
}());