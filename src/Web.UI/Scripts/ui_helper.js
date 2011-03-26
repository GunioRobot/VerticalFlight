$(document).ready(function () {
    // jquery UI helpers
    $("input:text.date").datepicker({ showOn: "both", buttonImage: "/content/images/calendar.png" });
//    $("input:text.ssn").mask("999-99-9999");
    $("input:text.phone").mask("(999)999-9999");
    $("input:text.zip").mask("99999");

//    // form appearance
//    $("input").focus(function () { $(this).addClass("highlight"); });
//    $("input").blur(function () { $(this).removeClass("highlight"); });

//    $("input:submit").button();
//    $(".create-button").button({ icons: { secondary: "ui-icon-circle-plus"} });
//    $(".search-button").button({ icons: { secondary: "ui-icon-search"} });
//    $(".login-button").button({ icons: { secondary: "ui-icon-unlocked"} });
});

// editable grid
function EditGridItem(grid, id) {
    $('#' + grid + ' [id^=EditRow]').hide();
    $('#' + grid + ' [id^=DisplayRow]').show();
    $('#' + grid + ' #EditRow' + id).show();
    $('#' + grid + ' #DisplayRow' + id).hide();
}

function CancelEditGridItem(grid) {
    $('#' + grid + ' [id^=EditRow]').hide();
    $('#' + grid + ' [id^=DisplayRow]').show();   
}

function Clearform() {
    $('#CreateRow input[type="text"]').val("");
    $('#CreateRow select').val("");
    $("input:text.date").datepicker({ showOn: "both", buttonImage: "/content/images/calendar.png" });
}

