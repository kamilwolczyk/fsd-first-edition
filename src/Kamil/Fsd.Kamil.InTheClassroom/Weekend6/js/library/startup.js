var library = library || {};

(function () {
  var books = [
    new library.entities.Book('Jarosław Sokołowski', 'Masa, o kobietach polskiej mafii', 200),
    new library.entities.Book('Patryk Vega', 'Złe psy', 280),
  ]

  library.closed = false;
  library.state = {
    books: books
  }
})();