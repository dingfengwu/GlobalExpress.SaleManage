(function ($) {
    $("#siderbarMenu a").bind("click", function (e) {
        var url = $(this).attr("href");
        if (url.substr(0, 1) != "#") {
            e.preventDefault();
            e.stopPropagation();

            var root = window.location.href;
            url = url + (url.indexOf("?") >= 0 ? "&" : "?") + "part=1";
            $.get(url).done(function (content) {
                $("#childBody").empty().append(content);
            });
        }
    });
})(jQuery);
