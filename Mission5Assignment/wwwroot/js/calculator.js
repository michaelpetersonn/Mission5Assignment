$(document).ready(function() {
    $('#calculateBtn').click(function() {
        // 1. Read input values
        var hours = parseFloat($('#hoursInput').val());
        var rate = parseFloat($('#rateInput').val());

        // 2. Validate hours
        if (hours === "" || isNaN(hours) || hours <= 0) {
            alert("Please enter a valid positive number to continue!");
            return; // stop calculation if invalid
        }

        // 3. Calculate total
        var total = hours * rate;

        // 4. Display total in output field
        $('#totalOutput').val(total.toFixed(2));
    });
});