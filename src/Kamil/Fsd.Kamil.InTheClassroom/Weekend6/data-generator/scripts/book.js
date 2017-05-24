var app = app || {};

(function () {
  function Book(id, author, title, pageCount) {
    this.id = id;
    this.author = author;
    this.title = title;
    this.pageCount = pageCount;
  }

  app.types = {
    Book: Book
  };
})();
