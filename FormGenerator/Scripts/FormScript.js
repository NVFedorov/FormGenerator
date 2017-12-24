// специально не использовал jquery для избежания зависимости полученной формы.

function validate(controlToBeValidated) {
    var control = document.querySelector('[valiatedControlId="' + controlToBeValidated.id + '"]');
    if (control) {
        if (control.hasAttribute('pattern')) {
            var ptrn = new RegExp(control.getAttribute("pattern"));
            var text = controlToBeValidated.value;
            return ptrn.test(text);
        }

        if (control.hasAttribute('validatorType')) {
            var type = control.getAttribute('validatorType');
            if (type === 'checkbox') {
                return controlToBeValidated.checked;
            }

            if (type === 'select') {
                return controlToBeValidated.options[controlToBeValidated.selectedIndex].value !== '';
            }

            if (type === 'radio') {
                return controlToBeValidated.querySelectorAll("input[type=radio]:checked").length > 0;
            }
        }
    }

    return true;
}

function send() {
    var elements = document.querySelectorAll('[formElement="true"]');
    var passed = true;

    for (var i = 0; i < elements.length; i++) {
        var e = elements[i];
        var validated = document.querySelector('[valiatedControlId="' + e.id + '"]');
        if (validated && validated.hasAttribute('style')) {
            if (!validate(e)) {
                passed = false;
                validated.style.display = '';
            } else {
                validated.style.display = 'none';
            }
        }
    }

    if (passed) {
        document.getElementById('postMsg').style.display = '';
    }
}