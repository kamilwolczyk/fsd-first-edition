var app = app || {};

(function () {
  var megane = new Car('Renault', 'Megane III', 60000, 5);

  var persons = [
    new Person("Kamil", "Wołczyk", megane),
    new Person("Jan", "Kowalski", megane),
    new Person("Franek", "Gitara", new Car('Kia', 'Rio III', 50000, 4)),
    new Person("Robert", "Lewandowski", new Car('Ferrari', 'F50', 200000, 2)),
    new Person("Zygmunt", "Waza", new Car('Audi', 'A4', 90000, 5))
  ];

  app.database = {
    personSet: persons
  }
})();