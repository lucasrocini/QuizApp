namespace QuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Question[] questions = new Question[]
            {
                new Question(
                    "What is the capital of Germany?",
                    new String[] { "Paris", "Berlin", "London", "Madrid"},
                    1
                ),
                new Question(
                    "What is the year of Brazil Discovery??",
                    new String[] { "1498", "1499", "1500", "1504"},
                    2
                ),
                new Question(
                    "Who worte Hamlet??",
                    new String[] { "Goethe", "Austen", "Shakespeare", "Disckens"},
                    2
                )
            };

            Quiz myQuiz = new Quiz(questions);
            myQuiz.StartQuiz();

            Console.ReadLine();
        }
    }
}
