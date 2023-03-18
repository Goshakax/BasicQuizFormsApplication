using System.ComponentModel;
using System.Drawing.Printing;
using System.Net;
using System.Reflection.Metadata;
using System.Text;

namespace TestProject_9v_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Creating a List of questions prop. Each Question has a Text, Possible Answers, Right Answer and Number porp.
        private Queue<Question> questions;

        //Declaring and initializing the readers and writer props.
        private StreamReader questionReader = new StreamReader("../../../TextDocuments/questions.txt");
        private StreamReader rightAnswersReader = new StreamReader("../../../TextDocuments/answers.txt");
        private StreamWriter givenAnswersDocumentator = new StreamWriter("../../../TextDocuments/givenAnswers.txt", false);

        private StringBuilder results = new();
        private int points = 0;
        private int time = 120;

        private void Form1_Load(object sender, EventArgs e)
        {
            questions = GetAllQuestions();
            Question firstQuestion = questions.Peek();
            UpdateForm(firstQuestion);

        }



        private void nextQuestionButt_Click(object sender, EventArgs e)
        {


            Question question = questions.Dequeue();

            if (!aAnswerRadioBttn.Checked && !bAnswerRadioBttn.Checked && !cAnswerRadioBttn.Checked && !dAnswerRadioBttn.Checked)
            {
                MessageBox.Show("Изберете отговор преди да продължите със следващ въпрос!");
                return;
            }
            else
            {
                string givenAnswer = GetGivenAnswer();
                question.GivenAnswer = givenAnswer;

                if (question.RightAnswer == givenAnswer)
                {
                    points++;
                }

                results.AppendLine(question.ToString());
            }

            if (nextQuestionBttn.Text == "Край на теста")
            {
                pointsLbl.Visible = true;
                resultsBttn.Visible = true;
                chooseAnswerLbl.Visible = false;
                currQuestionLbl.Visible = false;
                bAnswerRadioBttn.Visible = false;
                aAnswerRadioBttn.Visible = false;
                dAnswerRadioBttn.Visible = false;
                cAnswerRadioBttn.Visible = false;
                nextQuestionBttn.Visible = false;
                questionsLeftLbl.Visible = false;
                questionTxtBox.Visible = false;
                timeLeftLbl.Visible = false;
                pointsLbl.Text += points.ToString();

            }


            if (questions.Count > 0)
            {
                Question nextQuesion = questions.Peek();
                UpdateForm(nextQuesion);

                if (questions.Count == 1)
                {
                    nextQuestionBttn.Text = "Край на теста";
                }
            }



        }


        //Returns the answer selected by the user.
        private string GetGivenAnswer()
        {
            string selectedAnswer = string.Empty;

            if (aAnswerRadioBttn.Checked)
            {
                selectedAnswer = "а";
            }
            else if (bAnswerRadioBttn.Checked)
            {
                selectedAnswer = "б";
            }
            else if (cAnswerRadioBttn.Checked)
            {
                selectedAnswer = "в";
            }
            else if (dAnswerRadioBttn.Checked)
            {
                selectedAnswer = "г";
            }

            return selectedAnswer;
        }


        //A method that updates the Form's props to match the current Question's info.
        private void UpdateForm(Question question)
        {
            questionTxtBox.Text = question.QuestionText;
            currQuestionLbl.Text = $"Въпрос {question.Number}.";
            questionsLeftLbl.Text = $"Оставащи въпроси {questions.Count - 1}.";
            aAnswerRadioBttn.Text = question.AllAnswers[0];
            bAnswerRadioBttn.Text = question.AllAnswers[1];
            cAnswerRadioBttn.Text = question.AllAnswers[2];
            dAnswerRadioBttn.Text = question.AllAnswers[3];
            aAnswerRadioBttn.Checked = false;
            bAnswerRadioBttn.Checked = false;
            cAnswerRadioBttn.Checked = false;
            dAnswerRadioBttn.Checked = false;
        }


        //A method that returns all the questions.
        private Queue<Question> GetAllQuestions()
        {
            Queue<Question> questions = new();

            using (questionReader)
            {
                using (rightAnswersReader)
                {
                    //Creating variables for the current question's text, its right answer and its number.
                    string questionText = string.Empty;
                    string rightAnswer = string.Empty;
                    int questionNumber = 1;

                    //Reading each question and its answer.
                    while ((questionText = questionReader.ReadLine()) != null && (rightAnswer = rightAnswersReader.ReadLine()) != null)
                    {
                        //Creating a collection that holds all possible answers for the current question.
                        List<string> allAnswers = new();

                        //Adding all the possible answers for the question.
                        for (int i = 0; i < 4; i++)
                        {
                            string currAnswer = questionReader.ReadLine();
                            allAnswers.Add(currAnswer);
                        }

                        questionReader.ReadLine();//Skipping the empty row in questions.txt.

                        Question question = new(questionText, rightAnswer, allAnswers, questionNumber++); //Creating a question.
                        questions.Enqueue(question); //Adding the question to the collection.
                    }
                }
            }

            return questions;
        }

        private void resultsBttn_Click(object sender, EventArgs e)
        {

            if (resultsBttn.Text == "Край на теста")
            {
                Close();
            }
            else
            {
                timer.Stop();
                questionTxtBox.Visible = true;
                pointsLbl.Visible = false;
                using (givenAnswersDocumentator)
                {
                    givenAnswersDocumentator.Write(results.ToString().TrimEnd());
                }

                questionTxtBox.Text = results.ToString().TrimEnd();
                resultsBttn.Text = "Край на теста";
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer.Enabled = true;
            timer.Start();
            time--;
            timeLeftLbl.Text = $"Оставащо време: {time/60}мин {time%60}сек.";

            if (time == 0)
            {
                timer.Stop();
                noTimeLbl.Visible = true;
                endTestBttn.Visible = true;
                chooseAnswerLbl.Visible = false;
                currQuestionLbl.Visible = false;
                bAnswerRadioBttn.Visible = false;
                aAnswerRadioBttn.Visible = false;
                dAnswerRadioBttn.Visible = false;
                cAnswerRadioBttn.Visible = false;
                nextQuestionBttn.Visible = false;
                questionsLeftLbl.Visible = false;
                questionTxtBox.Visible = false;
                timeLeftLbl.Visible = false;
            }
        }

        private void endTestBttn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}