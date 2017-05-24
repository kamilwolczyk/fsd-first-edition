var library = library || {};

(function () {

  library.status = function (callback) {
    if(typeof(callback) != "function")
      throw new Error('Callback is not a function');

    var message = "Aktualnie biblioteka jest " + (library.closed ? "zamknięta" : "otwarta");
    callback.call(message);
  }

})();