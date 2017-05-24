var app = app || {};

(function () {
  app.database.personSet.forEach(function (person) {
    console.log(person.toString())
  });
})();
