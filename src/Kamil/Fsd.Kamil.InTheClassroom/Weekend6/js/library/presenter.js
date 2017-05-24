var library = library || {};

(function(){
  library.state.books.forEach(function(book, index){
    console.log(book.show(index+1));
  });
})();