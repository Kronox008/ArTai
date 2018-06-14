using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArTai.Decks
{
    class Randomizing
    {
        public static void Randomize(string[,] allQuestions_in_order)
        {
            Global.IsCorrectCount = 0; //reseting score
            for (int i = 0; i < 50; i++)
            {
                Global.IsCorrect[i] = 2;  //reseting  arrays
                Global.IsGuessed[i] = 2;
            }



            System.Random randomnumber = new System.Random();

            List<int> galimi = Enumerable.Range(0, Global.Deckcounter).ToList();             //shuffling numbers in range of selected deck size
            List<int> shuffledlistas = new List<int>();
            for (int i = 0; i < Global.QuestionQuantity; i++)
            {
                int index = randomnumber.Next(0, galimi.Count);
                shuffledlistas.Add(galimi[index]);
                galimi.RemoveAt(index);
            }

            Global.Numbers = shuffledlistas.ToArray();

            for (int i = 0; i < Global.QuestionQuantity; i++)
            {
                Global.ShuffledQuestion[i, 0] = allQuestions_in_order[Global.Numbers[i], 0];

                if (Global.DownloadImages)
                {
                    Global.ShuffledQuestion[i, 1] = allQuestions_in_order[Global.Numbers[i], 1];
                }
                else
                {
                    Global.ShuffledQuestion[i, 1] = Global.DeckWallpaper;
                }
            }

        }
    }
}


//              List<int> possible = Enumerable.Range(0, (Global.Deckcounter - 1)).ToList();
//              List<int> listNumbers = new List<int>();
//               for (int i = 0; i<Global.QuestionQuantity; i++)
//                {
//                int index = rand.Next(0, possible.Count);
//                 listNumbers.Add(possible[index]);
//                possible.RemoveAt(index);
//                 }

//            Global.Numbers = listNumbers.ToArray();



