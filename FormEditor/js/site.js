/*globals $:false */
(function() {
	'use strict';
	$(document).on('click', '.close', function(e){ //удаление
		e.preventDefault();

		//получаем блок в котором находится кнопка и удаляем его
		//сейчас запрещено удалять единственное поле, т.к. оно служит шаблоном для добавления новых
		//если предполагается, что можно отправить форму без полей то изменю на генерацию
		if($('.content-container .content').length > 1){
			$(this).closest('.content').remove();
		}
	});

	$(document).on('change', '.selector', function(e) { //изменение типа
		e.preventDefault();

		// возможно здесь можно было адекватней получить div для вставки
		var block = $(this).closest('.content').find("div.col-12");
		block.html(' '); // очищаем блок для вставки
		
		if(this.value == 1){ // проверяем значение и в зависимости от него вставляем соответствующее поле
			$('<input>', { type: 'text', placeholder: 'Placeholder', class: 'form-control', required: ''}).appendTo(block);
		} else if (this.value == 2){
			$('<textarea>', { placeholder: 'Список вопросов', class: 'form-control', required: ''}).appendTo(block);
		}
	});

	$(document).on('click', '.btn-link', function(e) { //добавление новых полей
		e.preventDefault();

		var form = $('.content-container'); // получаем контейнер всех полей 

		// копируем
		var clone = form.children().first().clone(true, true);
		// сбрасываем все в начальное состояние
		clone.find('[type=text]').val('');
        clone.find('[type=checkbox]').prop("checked", false);
      	clone.find('div.col-12').html('');

      	// и добавляем к остальным полям
		$(clone).appendTo(form);
	});
}());