$(document).ready(function () {

var  url= "https://restcountries.eu/rest/v2/capital/london";

$.getJSON( url, function( data ) {
    $('#externalSite').text(data[0].name); 
});

});