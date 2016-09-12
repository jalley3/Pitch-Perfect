using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PitchPerfect.model;
using System.Text.RegularExpressions;

namespace PitchPerfect
{
    public partial class PitchPerfect_ : Form
    {
        public PitchPerfect_()
        {
            InitializeComponent();
           
        }

        private void PitchPerfect_Load(object sender, EventArgs e)
        {
            //only set login screen as visible
            lessonPanel.Visible = false;
            lessonFinal.Visible = false;
            menuPanel.Visible = false;
            quizFinal.Visible = false;
            quiz.Visible = false;
            LogInPanel.Visible = true;
            //initialize labels/textboxes
            NoteLabel.Text = Sounds.SoundList[lessonCounter].Name;
            quizQuestions = Quiz_Load();
            textBoxName.Text = "Put your name here...";
            textBoxName.ForeColor = Color.Gray;

        }
        //linking functions that transport from one screen to another 
        private void toMenu_Click(object sender, EventArgs e)
        {
            lessonFinal.Visible = false;
            quizFinal.Visible = false;
            menuPanel.Visible = true;
        }

        private void toLesson_Click(object sender, EventArgs e)
        {
            menuPanel.Visible = false;
            lessonPanel.Visible = true;
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            menuPanel.Visible = false;
            LogInPanel.Visible = true;

        }
        private void toQuiz_Click(object sender, EventArgs e)
        {
            quizQuestions = Quiz_Load();
            menuPanel.Visible = false;
            quizFinal.Visible = false;
            lessonFinal.Visible = false;
            quiz.Visible = true;
        }
        //lesson functions, click back, click next, and play sound
        private void prev_Click(object sender, EventArgs e)
        {
            lessonCounter--;
            if (lessonCounter >= 0) //send to menu if user tries to go back on the first sound
            {
                NoteLabel.Text = Sounds.SoundList[lessonCounter].Name; //change label to match current sound
            }
            else
            {
                lessonPanel.Visible = false;
                menuPanel.Visible = true;
            }
        }

        private void playSoundBtn_Click(object sender, EventArgs e)
        {
            Sounds.SoundList[lessonCounter].PlaySound(); //play the sound
        }

        private void next_Click(object sender, EventArgs e)
        {
            lessonCounter++;
            if (lessonCounter < Sounds.GetSoundCount()) //check for the end of the lesson
            {
                NoteLabel.Text = Sounds.SoundList[lessonCounter].Name; //change the label
            }
            else
            {
                lessonFinal.Visible = true;
                lessonPanel.Visible = false;

            }
        }
        //log in functions (log in, and log in as guest and two text box interaction functions)
        //validate name - if valid store user
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string pattern = @"^[a-zA-Z\s-.]+$";
            //Regex reg = new Regex(pattern);
            if (name.Length > 0 && name != "Put your name here...")
            {
                if (Regex.IsMatch(name, pattern))
                {
                    try
                    {
                        User player = Users.GetUser(name);
                        if (player == null)
                        {
                            player = new User(name);
                            Users.AddUser(player);
                            Users.Save();

                        }
                        userID = player.Id;
                    }
                    catch (TypeInitializationException ex)
                    {
                        Console.WriteLine("In catch block of Main method.");
                        Console.WriteLine("Caught: {0}", ex.Message);
                        if (ex.InnerException != null)
                            Console.WriteLine("Inner exception: {0}", ex.InnerException);
                    }

                    //**continue to main menu here**
                    //**get player to next screen
                    guest = false;

                    LogInPanel.Visible = false;
                    menuPanel.Visible = true;
                    labelWarning.Text = "";


                }
                else
                {
                    labelWarning.Text = "Invalid Name: please remove any special characters or numbers.";
                }

            }
            else
            {
                labelWarning.Text = "Invalid Name: please enter your name or play as a guest.";
            }
        }

        private void buttonGuest_Click(object sender, EventArgs e)
        {
            guest = true;
            LogInPanel.Visible = false;
            menuPanel.Visible = true;
        }
        //allows user to log in by clicking enter rather than having to hit login
        private void textBoxName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin_Click(this, new EventArgs());
            }
        }
        //gets rid of the default text in the text box
        private void textBoxName_MouseEnter(object sender, EventArgs e)
        {
            if (textBoxName.Text == "Put your name here...")
            {
                textBoxName.Text = "";
                textBoxName.ForeColor = Color.Black;
            }
        }
        //
        //
        //quiz functions : quiz load, check for correct answer, advance through quiz, play sound
        private List<Question> Quiz_Load()
        {
            //reset right answers and question counter
            correctAnswers = 0;
            qCount = 0;
            List<Question> questions = new List<Question>(); //generate list
            int maxQ = 10;
            Random rand = new Random();
            int maxS = Sounds.SoundList.Count;
            Sound randSound;
            int listCount = qCount + 1;
            string labelNum = listCount.ToString();
            labelNum += ')';


            //create list of questions from different random sounds
            for (int i = 0; i < maxQ; i++)
            {
                do
                {
                    randSound = Sounds.SoundList[RandomProvider.GetThreadRandom().Next(maxS)];
                } while (questions.Exists(x => x.Qsound == randSound));
                questions.Add(new Question(randSound));
            }
            qNum.Text = labelNum; //display question number
            //assign answers to radio buttons 
            q1.Text = questions[qCount].Answers[0];
            q2.Text = questions[qCount].Answers[1];
            q3.Text = questions[qCount].Answers[2];
            q4.Text = questions[qCount].Answers[3];
            return questions;
        }

        private void playQuizSound_Click(object sender, EventArgs e)
        {
            quizQuestions[qCount].Qsound.PlaySound(); //play the sound of the correct answer
        }

        private void quizNext_Click(object sender, EventArgs e)
        {
            //call function to test the radio buttons and see if the right answer was selected;
            if (!checkAns(q1))
            {
                if (!checkAns(q2))
                {
                    if (!checkAns(q3))
                    {
                        checkAns(q4);
                    }
                }
            }

            qCount++;
            //go to next question
            if (qCount < 10)
            { //change answers and question number label
                q1.Text = quizQuestions[qCount].Answers[0];
                q2.Text = quizQuestions[qCount].Answers[1];
                q3.Text = quizQuestions[qCount].Answers[2];
                q4.Text = quizQuestions[qCount].Answers[3];
                int listCount = qCount + 1;
                string labelNum = listCount.ToString();
                labelNum += ')';
                Console.WriteLine(labelNum);
                qNum.Text = labelNum;
            }
            else
            {
                //calculate score and print appropriate message
                float score = (correctAnswers / 10) * 100;
                if (score == 0)
                {
                    scoreLabel.Text = "Aw Man, A Goose Egg";
                }
                else if (score < 60)
                {
                    scoreLabel.Text = "Hmm. Valiant effort! " + score + '%';
                }
                else if (score < 100)
                {
                    scoreLabel.Text = "Nice Job! " + score + '%';
                }
                else if (score == 100)
                {
                    scoreLabel.Text = "Congratulations! A Perfect Score!";
                }

                //assign new high score if necessary
                User player = Users.GetUser(userID);
                if (guest == false)
                {
                    if (score > player.HighScores)
                    {
                        player.HighScores = (int)score;
                        Users.Save();
                    }
                }
                //link to final panel
                quiz.Visible = false;
                quizFinal.Visible = true;
            }
        }
        private bool checkAns(RadioButton rdobtn) //check to see if selected answer was correct
        {
            if (rdobtn.Checked && rdobtn.Text == quizQuestions[qCount].Answer)
            {
                correctAnswers++;
                return true;
            }
            return false;
        }
        //high score function
        private void highS_Click(object sender, EventArgs e)
        {
            if (guest == true) //error if guest
            {
                MessageBox.Show("You are currently logged in as a guest.", "Guest");
            }
            else
            {
                User player = Users.GetUser(userID);
                string score = player.HighScores.ToString();
                string output = String.Format("{0}, Your High Score is {1}!", player.Name, score);
                MessageBox.Show(output, "High Score", MessageBoxButtons.OK);
            }
        }     
    }
}
