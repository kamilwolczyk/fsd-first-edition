var app = app || {};

(function () {
  var selectionClass = "danger",
    idAttribute = "data-id";

  function selectEvent() {
    var row = $(this).parent().parent();

    if (row.hasClass(selectionClass)) {
      row.removeClass(selectionClass)
    } else {
      row.addClass(selectionClass)
    }
  }

  function editEvent() {
    var row = $(this).parent().parent();
    var id = parseInt(row.attr(idAttribute), 10);
    alert('Edytujesz element ID=' + id);
  }

  function buildActionButton(text, event) {
    return $('<button></button>').attr('class', 'btn btn-link').text(text).click(event);
  }

  function buildActionCell() {
    return $('<td></td>')
      .append(buildActionButton('Zaznacz', selectEvent))
      .append(buildActionButton('Edytuj', editEvent));
  }

  function buildCell(value) {
    return $('<td></td>').text(value);
  }

  function buildRowForBook(book, index) {
    var cells = [
      buildCell(index + 1),
      buildCell(book.author),
      buildCell(book.title),
      buildActionCell(),
    ];

    var row = $('<tr></tr>').attr(idAttribute, book.id);

    cells.forEach(function (cell) {
      row.append(cell);
    });

    return row;
  }

  app.generateTable = function (table, books) {
    var tableBody = table.find('tbody');

    tableBody.empty();

    books.forEach(function (book, index) {
      tableBody.append(buildRowForBook(book, index));
    });
  }
})();