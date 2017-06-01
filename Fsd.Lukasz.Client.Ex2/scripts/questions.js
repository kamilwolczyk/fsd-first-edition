var questionsClass = questionsClass || {};

(function () {



    var getQuestions = function (count, callback) {

        var apiAddress = 'https://opentdb.com/api.php?amount=' + count;

        if (typeof callback !== 'function') {
            callback = false;
        }

        if (callback) {
            $.getJSON(apiAddress, function (data) {
                callback(data.results);
            });
        }
    };

    questionsClass.questions = getQuestions;

})();
