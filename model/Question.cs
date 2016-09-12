using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PitchPerfect.model
{
    // Random class to fix seed looping problem
    // source: csharpindepth.com/Articles/Chapter12/Random.aspx
    public static class RandomProvider
    {
        private static int seed = Environment.TickCount;

        private static ThreadLocal<Random> randomWrapper = new ThreadLocal<Random>(() =>
            new Random(Interlocked.Increment(ref seed))
        );

        public static Random GetThreadRandom()
        {
            return randomWrapper.Value;
        }
    }

    // Class used to create and operate individual questions.
    public class Question
    {
        #region fields
        private Sound _qsound;
        private string _answer;
        private string[] _answers;
        #endregion

        #region properties (getters/setters)
        public Sound Qsound { get { return _qsound; } set { _qsound = value; } }
        public string Answer { get { return _answer; } set { _answer = value; } }
        public string[] Answers { get { return _answers; } set { _answers = value; } }
        #endregion

        #region constructors
        // Default constructor.
        public Question() { }

        // Constructor overloaded with sound parameter.
        public Question(Sound sound)
        {
            _qsound = sound;
            _answer = sound.Name;
            _answers = randAnswers(sound.Name);
        }
        #endregion

        #region methods
        public void swapElements(int index1, int index2, ref string[] a)
        {
            string temp = a[index1];
            a[index1] = a[index2];
            a[index2] = temp;
        }

        //create multiple choice answers for each sound
        public string[] randAnswers(string qsoundName)
        {
            int max = Sounds.SoundList.Count;
            string[] answers = new string[4];
            string randName;

            if (qsoundName.Length == 0 || max == 0)
                return answers;
            //generate 3 random incorrect answers
            for (int i = 0; i < answers.Length - 1; i++)
            {
                //get random sound name that is: 
                //not yet in answers and not equal to real answers
                do
                {
                    randName = Sounds.SoundList[RandomProvider.GetThreadRandom().Next(max)].Name;
                } while (answers.Contains(randName) || randName == qsoundName);
                answers[i] = randName;
            }
            //insert real answer as last element
            answers[answers.Length - 1] = qsoundName;
            //shuffle real answer
            swapElements(answers.Length - 1, RandomProvider.GetThreadRandom().Next(answers.Length), ref answers);

            return answers;
        }
        #endregion
    }
}