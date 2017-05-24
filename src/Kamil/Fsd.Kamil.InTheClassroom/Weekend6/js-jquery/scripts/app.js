var functions = {};

$(document).ready(function () {
  console.log('document is ready!');

  $('.bold').css({
    fontWeight: 'bold',
    color: 'gray'
  });

  var content = $('#content');

  content.css('display', 'none');
  content.show();

  var list = $('#logList');

  $('#actionButton').click(function () {
    var text = 'you pressed button on ' + new Date();
    list.append($('<li></li>').text(text));
  });

  functions.fillAndSendForm = function () {
    $('#firstName').val('Kamil');
    $('#lastName').val('Wołczyk');
    $('#email').val('k.wolczyk@headchannel.co.uk');
    $('input[type="submit"]').click();
  }

  $('#loadContent').click(function () {
    $('#externalSite').load('views/start.html');
  })

  $('#languageCodeSearch').click(function () {

    var code = $('#languageCode').val();
    var url = 'https://restcountries.eu/rest/v2/lang/' + code;

    $.getJSON(url, function (response) {
      var list = $('#countyList');
      list.empty(); 
      response.forEach(function (item) {
        list.append($('<li></li>').text(item.name))
      });
    });
  });

});