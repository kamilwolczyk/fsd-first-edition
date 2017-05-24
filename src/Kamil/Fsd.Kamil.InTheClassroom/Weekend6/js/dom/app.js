var app = app || {};

(function () {
  function datetimeToDateString(date, separator) {
    return date.getDate() + separator + (date.getMonth() + 1) + separator + date.getFullYear();
  }

  function datetimeToTimeString(date){
    return date.toTimeString();
  }

  // var content = document.getElementById('content');
  // var child = document.createElement('p');
  // child.innerText = datetimeToDateString(new Date(), '-');
  // content.appendChild(child);
  app.keyPressed = function (event) {
    console.log("You pressed key:" + event.key);
  }

  var logPanel = document.getElementById('log');
  app.someClick = function (event) {
    var item = document.createElement('li');
    item.innerText = 'You have clicked button on '+new Date().toTimeString();
    logPanel.appendChild(item);
  }

  function setTwoDigits(number) {
    return number >= 10 ? number : ('0' + number);
  }

  function refreshWatch(hoursPanel, minutesPanel, secondsPanel) {
    var date = new Date();
    hoursPanel.innerText = setTwoDigits(date.getHours());
    minutesPanel.innerText = setTwoDigits(date.getMinutes());
    secondsPanel.innerText = setTwoDigits(date.getSeconds());
  }

  var PI = 3.14;

  var hoursPanel = document.getElementById('hours'),
    minutesPanel = document.getElementById('minutes'),
    secondsPanel = document.getElementById('seconds');

  refreshWatch(hoursPanel, minutesPanel, secondsPanel);
  setInterval(function () {
    refreshWatch(hoursPanel, minutesPanel, secondsPanel);
  }, 1000);

})();