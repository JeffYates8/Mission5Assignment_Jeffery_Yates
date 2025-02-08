
// Function to calculate the total tutoring cost on a per hour basis.
$(document).ready(function () { // waits for the site to be ready before running
    $('#calculate-button').click(function () {
        let hours = parseFloat($('#hours').val()); // converts user input to a float type
        let rate = 2938.78; // defines the cost per hour

        if (isNaN(hours) || hours <= 0) {           // ensures user input is a positive number & not 0
            $('#hours').addClass('is-invalid');     // tell user invalid
        } else {
            $('#hours').removeClass('is-invalid');  // removes error message once user gets it right
            let total = hours * rate;
            $('#total').val(`$${total.toFixed(2)}`); // return the cost for display
        }
    });
});
