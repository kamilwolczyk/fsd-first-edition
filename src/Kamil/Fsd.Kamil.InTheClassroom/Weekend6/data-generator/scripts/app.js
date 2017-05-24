var app = app || {};

$(document).ready(function () {

  $('#generateDataButton').click(function () {
    var spinner = $('#spinner'),
      table = $('#contentTable');

    table.hide();
    spinner.show();

    setTimeout(function () {
      app.generateTable(table, app.books);
      table.show('slow');
      spinner.hide();
    }, 2000);

  });
});