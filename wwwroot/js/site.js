$(document).ready(function () {
    $('.slickCarousel').slick({
        dots: false,
        arrows: false,
        infinite: true,
        speed: 300,
        centerMode: true,
        variableWidth: true,
        autoplay: true,
        autoplaySpeed: 2000
    });

    $('#logobutton').css('background-color', 'transparent');
    $('#logobutton').css('border', 'none');
    $('#logobutton').click(function () {
        $.ajax({
            url: '/Home/CarouselImages',
            type: "GET",
            success: function (data) {
                $("#carousel").html(data);
                $('.slickCarousel').slick({
                    initialSlide: 3,
                    dots: false,
                    arrows: false,
                    infinite: true,
                    speed: 300,
                    centerMode: true,
                    variableWidth: true,
                    autoplay: true,
                    autoplaySpeed: 2000
                });
            },
            error: function (xhr, status, error) {
                alert(xhr.responseText);
            },
        });
    });
});

function validateData(form) {
    // Get variables for validation
    var name = document.getElementById('username').value;
    var msg = document.getElementById('message').value;

    // Username validation
    if (name.length < 5) {
        alert("Username too short. Username should be between 5-18 characters.");
        return false;
    } else if (name.length > 18) {
        alert("Username too long. Username should be between 5-18 characters.");
        return false;
    }

    // Message validation
    if (msg.length > 500) {
        alert("Comment should not exceed 500 characters.");
        return false;
    }

    return true;
}