$(document).ready(function () {
    $('#calculate-button').click(function () {
        let hours = parseFloat($('#hours').val());
        let rate = 2938.78;

        if (isNaN(hours) || hours <= 0) {
            $('#hours').addClass('is-invalid');
        } else {
            $('#hours').removeClass('is-invalid');
            let total = hours * rate;
            $('#total').val(`$${total.toFixed(2)}`);
        }
    });
});
