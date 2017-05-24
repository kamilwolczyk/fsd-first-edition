var library = library || {};

(function () {
  function Book(author, title, pageCount) {
    this.author = author;
    this.title = title;
    this.pageCount = pageCount;
  }

  Book.prototype.show = function (index) {
    return index + ' ' + this.author + ' ' + this.title + ' ' + this.pageCount;
  }

  library.entities = {
    Book: Book
  };
})();

function test(){
  console.log(this);
}

