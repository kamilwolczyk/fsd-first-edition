function Car(producer, model, price, doorCount) {
  this.producer = producer;
  this.model = model;
  this.price = price;
  this.doorCount = doorCount;
}

Car.prototype.toString = function () {
  return this.producer + ' ' + this.model;
}

Car.prototype.number = 625;

function Person(firstName, lastName, car) {
  this.firstName = firstName;
  this.lastName = lastName;
  this.car = car;
}

Person.prototype.toString = function () {
  return this.firstName + ' ' + this.lastName + ' has ' + this.car.toString();
}