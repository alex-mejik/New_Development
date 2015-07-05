

$(document).ready(function () {


    $.getJSON('script/data.json', function (info) {
        var output = "";
        for (var i = 0; i <= info.links.length; i++) {
            for (key in info.links[i]) {
                output += '<li>' +
                     '<a href="' + info.links[i][key] + '">' + key + '</a>' +
                     '</li>';
            }
        }
        var update = document.getElementById('links');
        update.innerHTML = output;
    });
});

