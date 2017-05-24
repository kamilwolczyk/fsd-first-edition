var x1 = {
  firstName: "kamil",
  lastName: "wolczyk",
  showMe: function(callback){
    var self = this;
    callback.call(this);
  }
};

var x2 = {
  producer: "audi",
  model: "a4",
  presentMe: function(callback){
    callback.call(this);
  }
};

test();
x1.showMe(test);
x2.presentMe(test);