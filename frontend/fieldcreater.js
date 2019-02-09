//
// ����� �����.
//

function createField() {
    //���� �������� ���� �����
    var fields = document.getElementById("fields");
    var fieldContainer = document.createElement("div");
    fieldContainer.className = "fieldContainer";
    fields.appendChild(fieldContainer);

    //�������
    var divCross = document.createElement("div");
    divCross.setAttribute("class", "divCross");
    divCross.innerText = "X";
    fieldContainer.appendChild(divCross);
    divCross.addEventListener("click", function () {
        fields.removeChild(fieldContainer);
    });

    //��������� ����
    var inputTextHead = document.createElement("input");
    inputTextHead.type = "text";
    inputTextHead.setAttribute("placeholder", "��������� ����");
    inputTextHead.setAttribute("class", "fieldHead");
    fieldContainer.appendChild(inputTextHead);

    //select
    var selectList = document.createElement("select");
    var possibleOptions = ["����� - ������", "����� - �����", "���� �� ������", "��������� �� ������", "�������������� ������"];
    fieldContainer.appendChild(selectList);
    for (var i = 0; i < possibleOptions.length; i++) {
        var option = document.createElement("option");
        option.value = possibleOptions[i];
        option.text = possibleOptions[i];
        selectList.appendChild(option);
    }
    selectList.addEventListener("change", function () {
        if (selectList.selectedIndex == 0 || selectList.selectedIndex == 1) {
            textAreaQuestions.setAttribute("class", "hidden inputTextQuestions");
            inputTextPlaceholder.setAttribute("class", "shown inputTextQuestions");
        }
        else {
            textAreaQuestions.setAttribute("class", "shown inputTextQuestions");
            inputTextPlaceholder.setAttribute("class", "hidden inputTextQuestions");
        }
    });

    //���� ��� ����� ������ ��������
    var textAreaQuestions = document.createElement("textarea");
    textAreaQuestions.setAttribute("rows", 4);
    textAreaQuestions.value = "������ 1\n������ 2\n������ 3";
    fieldContainer.appendChild(textAreaQuestions);
    textAreaQuestions.setAttribute("class", "hidden inputTextQuestions");
    //Placeholder text
    var inputTextPlaceholder = document.createElement("input");
    inputTextPlaceholder.type = "text";
    inputTextPlaceholder.value = "Placeholder";
    fieldContainer.appendChild(inputTextPlaceholder);
    inputTextPlaceholder.setAttribute("class", "inputTextQuestions");
    //��������� ������������
    var textAreaExtenderSpace = document.createElement("textarea");
    textAreaExtenderSpace.setAttribute("rows", 4);
    textAreaExtenderSpace.setAttribute("class", "hidden block");
    fieldContainer.appendChild(textAreaExtenderSpace);
    //������������ ������
    var divCheckBox = document.createElement("div");
    divCheckBox.setAttribute("class", "checkbox");
    fieldContainer.appendChild(divCheckBox);
    var checkBox = document.createElement("input");
    checkBox.type = "checkbox";
    divCheckBox.appendChild(checkBox);
    var labelForCheckBox = document.createElement("Label");
    labelForCheckBox.innerHTML = "������������ ������";
    divCheckBox.appendChild(labelForCheckBox);
    

}

function addBr(container) {
    var br = document.createElement("br");
    container.appendChild(br);
    container.appendChild(br);
}
