var viewClass = viewClass || {};

(function () {

    function shuffle(array) {
        let counter = array.length;

        // While there are elements in the array
        while (counter > 0) {
            // Pick a random index
            let index = Math.floor(Math.random() * counter);

            // Decrease counter by 1
            counter--;

            // And swap the last element with it
            let temp = array[counter];
            array[counter] = array[index];
            array[index] = temp;
        }

        return array;
    };

    function allAnswersShuffled(question) {
        var allAnswers = question.incorrect_answers.concat(question.correct_answer);
        allAnswers = shuffle(allAnswers);
        return allAnswers;
    };

    function makeAnswer(data) {
        return $('<div></div>').html(data).addClass('answer').addClass('well');
    };

    var hideRunButton = function () {
        $('#runQuiz').hide();
    };

    var showRunButton = function () {
        $('#runQuiz').show();
    };

    var showNextButton = function () {
        $('#nextQuestion').show();
    };

    var hideNextButton = function () {
        $('#nextQuestion').hide();
    };

    var hideAnswerDiv = function () {
        $('#answer').hide();
    };

    var showAnswerDiv = function () {
        $('#answer').show();
    };

    var hideQuestionDiv = function () {
        $('#question').hide();
    };

    var showQuestionDiv = function () {
        $('#question').show();
    };

    var clearFields = function () {
        $('#question').empty();
        $('#answer').empty();
    };


    var clicked = function (item) {

        $('.selected').removeClass('selected');
        item.addClass('selected');
    };

    viewClass.showScore = function (score, numberOfQuestions) {
        clearFields();
        hideAnswerDiv();
        hideNextButton();
        showRunButton();
        var text = "Uzyskales " + score + " na " + numberOfQuestions + ".";
        var title = $('<p></p>').text(text);
        $('#question').append(title);
    };

    viewClass.generateQuestion = function (question) {

        clearFields();
        hideRunButton();
        showQuestionDiv();
        showAnswerDiv();
        showNextButton();

        var title = $('<p></p>').html(question.question);
        $('#question').append(title);

        $.each(allAnswersShuffled(question), function (index, value) {
            var answer = makeAnswer(value);
            answer.click(function () {
                clicked(answer);
            });
            $('#answer').append(answer);
        });

    };

    viewClass.getAnswer = function () {
        var answer = $('.selected');
        if (answer.length === 1) {
            return answer[0].innerText;
        };
        return null;
    };


    hideQuestionDiv();
    hideAnswerDiv();
    hideNextButton();

})();
