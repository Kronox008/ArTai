using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArTai.Decks
{
    class People
    {
        public static void SetDeckInfo()
        {
            if (Global.LanguageSelectedID == 0)
            {
                string[,] allQuestions_in_orderEN = {
                    { "Achilles", "https://drive.google.com/uc?id=1Ad9SoF06KWHxUwxdAbfgRf5ziNvUQmrp" }
                    , { "Actaeon", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Actaeon", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Actaeon", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Actaeon", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Actaeon", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Actaeon", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Actaeon", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Actaeon", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Actaeon", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Actaeon", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Actaeon", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Actaeon", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Actaeon", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Actaeon", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Actaeon", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Actaeon", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Actaeon", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Actaeon", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Actaeon", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Actaeon", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Actaeon", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Actaeon", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Actaeon", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Actaeon", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }


                };

                int countEN = (allQuestions_in_orderEN.Length) / 2;



                Global.Deckcounter = countEN;
                Global.DeckName = "People";
                Global.DeckInfo = "Famous people.";

                Randomizing.Randomize(allQuestions_in_orderEN);

                //for (int i = 0; i < Global.QuestionQuantity; i++)
                //{
                //    Global.ShuffledQuestion[i, 0] = allQuestions_in_orderEN[Global.Numbers[i] , 0];
                //    Global.ShuffledQuestion[i, 1] = allQuestions_in_orderEN[Global.Numbers[i] , 1];
                //}

            }
            else
            {
                string[,] allQuestions_in_orderLT = {

                     { "Achilas", "https://drive.google.com/uc?id=1Ad9SoF06KWHxUwxdAbfgRf5ziNvUQmrp" }
                    , { "Aktaeonas", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Aktaeonas", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Aktaeonas", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Aktaeonas", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Aktaeonas", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Aktaeonas", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Aktaeonas", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Aktaeonas", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Aktaeonas", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Aktaeonas", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Aktaeonas", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Aktaeonas", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Aktaeonas", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Aktaeonas", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Aktaeonas", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Aktaeonas", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Aktaeonas", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Aktaeonas", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Aktaeonas", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Aktaeonas", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Aktaeonas", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Aktaeonas", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                    , { "Aktaeonas", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }


                };

                int countLT = (allQuestions_in_orderLT.Length) / 2;



                Global.Deckcounter = countLT;
                Global.DeckName = "Žmonės";
                Global.DeckInfo = "Įžymūs žmonės.";
                Randomizing.Randomize(allQuestions_in_orderLT);

            }
        }
    }
}
