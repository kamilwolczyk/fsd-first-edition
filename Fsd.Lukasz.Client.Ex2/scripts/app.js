var app = app || {};

(function () {

    var questions, currentQuestion, score;

    currentQuestion = 0;
    score = 0;

    function nextQuestion() {
        currentQuestion = currentQuestion + 1;
    }

    function checkAnswer(answer) {
        if (answer === questions[currentQuestion].correct_answer) {
            score += 1;
        }
    }

  
    app.start = function () {
        currentQuestion = 0;
        score = 0;

        if (typeof(questionsClass) === 'undefined') {
            alert('Brak pliku questions.js');
        } else if (typeof(viewClass) === 'undefined') {
            alert('Brak pliku view.js');
        } else {

            questionsClass.questions(6, function (questionsFromApi) {
                questions = questionsFromApi;
                viewClass.generateQuestion(questions[currentQuestion]);
            });
        }
    };

    app.nextQuestion = function () {

        var answer = viewClass.getAnswer();

        if (answer === null) {
            return;
        }
        checkAnswer(answer);


        if (currentQuestion === questions.length - 1) {
            viewClass.showScore(score, questions.length);
        } else {

            currentQuestion += 1;
            viewClass.generateQuestion(questions[currentQuestion]);
        }

    };


    $("#runQuiz").click(app.start);
    $("#nextQuestion").click(app.nextQuestion);

})();
