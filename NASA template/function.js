var url = window.location.href;
var delovi = url.split("/");
var ime = delovi[delovi.length-1].split(".");

$(document).ready(function(){
    $("."+ime[0]+"Link").addClass("active");
});

