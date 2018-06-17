using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArTai.Decks
{
    class LordDeck
    {

        public static void SetDeckInfo()
        {
            if (Global.LanguageSelectedID == 0)
            {
                string[,] allQuestions_in_orderEN = {
  { "Aragorn", "https://drive.google.com/uc?id=1JGdq6EvIkQJkYG22fIBdQhAM5yNpAq30" }
, { "Arkenstone", "https://drive.google.com/uc?id=1SgcOTypYKukJ6Rgp-8oBOlR_BMI1k2Am" }
, { "Arwen Evenstar", "https://drive.google.com/uc?id=1RyMsEBK6Z35wqwyBfAmeDBo-kBwXE76Z" }
, { "Athelas", "https://drive.google.com/uc?id=1uLimw7TX1CzE_vhmgTdpyyH03FjUTeHm" }
, { "Azog", "https://drive.google.com/uc?id=1JeJj8OFQAdfknb1-FYPP-5zT-s8wbO_m" }
, { "Balin", "https://drive.google.com/uc?id=18WjSkqw1rOuWMJ6gVch3daWqeKFHVjpr" }
, { "Balrog", "https://drive.google.com/uc?id=11ZDyWRED_K9hh8lmWSS70uCl4cbRg8CY" }
, { "Barahir", "https://drive.google.com/uc?id=10sXEfGvtBStsN6EK2fuebZbO30SX5zBr" }
, { "Beorn", "https://drive.google.com/uc?id=1trzXHI2qkVzdorqZLLp63wErfHD4k7QP" }
, { "Bilbo Baggins", "https://drive.google.com/uc?id=16U4n1LaHahmw3uruAkWByaaxLUlwB_hA" }
, { "Bolg", "https://drive.google.com/uc?id=1FsYH-K9RWsa7p3XOJfbRgztOE_sbMfTk" }
, { "Boromir", "https://drive.google.com/uc?id=1raEjDUFQlqZ8mVYyWe5ESKXbRsd0IfFf" }
, { "Bowman Bard", "https://drive.google.com/uc?id=16_KCm9Rg6hNKEopPAaEMB2Wv60rdwots" }
, { "Dain II Ironfoot", "https://drive.google.com/uc?id=1KTbHGZJomw1Pn1anQzY5Rg_fCzVCX-mZ" }
, { "Denethor", "https://drive.google.com/uc?id=1jATABiQiRnepck8ilQnaunVV19oPii0q" }
, { "Elrond", "https://drive.google.com/uc?id=19j00cdFwgAd2xcoTgWgmxWMvy9wV9ZPk" }
, { "Eomer", "https://drive.google.com/uc?id=1-10IAgtxNaD3ZIXmFde5qpDLEiERInmB" }
, { "Eowyn", "https://drive.google.com/uc?id=1ndMEcpl4wyofLMFfh_OO4UFnqVcIEmlu" }
, { "Faramir", "https://drive.google.com/uc?id=1_99oI3i8hl4ioTlcCw7CVDpYdtd9v31I" }
, { "Frodo Baggins", "https://drive.google.com/uc?id=1XRdns65YK9goZD_8xJ2LEgIJY6t0mFmx" }
, { "Galadriel", "https://drive.google.com/uc?id=1BIAuUFa0KiI5bcKQTYdov18Q1Hn3neWc" }
, { "Gandalf the Grey", "https://drive.google.com/uc?id=1J8OZDDqb_iLw5e4EfG9N6neSpc3F02z2" }
, { "Gimli", "https://drive.google.com/uc?id=1jJjTLeArLOMv9gBT1xc4InpdRgGprZ8y" }
, { "Gollum", "https://drive.google.com/uc?id=16Ayc46q687kR3o4LimdBHEwKI-d0BObX" }
, { "Grima Wormtongue", "https://drive.google.com/uc?id=1ANBQJ6y83ZL5fBUsv0kDiMYtS3ybrQN-" }
, { "Isildur", "https://drive.google.com/uc?id=1gVVB010zMD1hz3b5xNPkNqDwR5cSmbO3" }
, { "Legolas", "https://drive.google.com/uc?id=1cwfc8ia0RlarsqPzV9HOIklARJy17mp3" }
, { "Lembas bread", "https://drive.google.com/uc?id=1omGo6D__711lqZdU5ZjxItxwsK5p9Mq7" }
, { "Lonely mountain", "https://drive.google.com/uc?id=1SOFIgb29qeL3ybFnPVfCg6L4IT0zDaRg" }
, { "Merry", "https://drive.google.com/uc?id=1JBwePcmG31kLPkZisuDGAOU7ZXwY4PaP" }
, { "Mithril", "https://drive.google.com/uc?id=1atnP5tH40LG7guXXJn5weggWpbXX7rOw" }
, { "Morgul blades", "https://drive.google.com/uc?id=13bOwax3OygN41TS_q0FprcfO9txth5pI" }
, { "Narya", "https://drive.google.com/uc?id=1uswR3O-96lDvyXAh1AvykHOVEiaCLzgA" }
, { "Nenya", "https://drive.google.com/uc?id=1jy_Lp1zV-hut-wyHvSUL7ATpwxGq3PVw" }
, { "Palantiri", "https://drive.google.com/uc?id=1VAbw7KXHnGuiV6q_Meg5k_ddhVVbkJaM" }
, { "Phial of Galadriel", "https://drive.google.com/uc?id=1TXZiSehh7V0g4SHeInPK_fObdNp9jtvO" }
, { "Pippin", "https://drive.google.com/uc?id=1LH0ljlbQS31nVWY3At2-xmwrfnahpg9u" }
, { "Radagast", "https://drive.google.com/uc?id=14ni4O9_zVSbws8lEOCCZgsMdt2KvP7zV" }
, { "Sam", "https://drive.google.com/uc?id=1XEwkXddgN60HgYz2Yqf4vXJKBYaoJ4fS" }
, { "Saruman the White", "https://drive.google.com/uc?id=1jQ0_jq20xcbkg0NjCrTQWD1Ga-3FHBa4" }
, { "Sauron", "https://drive.google.com/uc?id=1WEBOGbAIUe5XVSiNWlkIFGnJHSQ5xUD8" }
, { "Shadowfax", "https://drive.google.com/uc?id=1UUMh6xfvEsRCBZjzwxA_kP4D9NJh-oWF" }
, { "Shelob", "https://drive.google.com/uc?id=1fllCixlHp_fpi1tYRajP9QY2jEacXO9p" }
, { "Smaug", "https://drive.google.com/uc?id=1oUL5Z7Pqh6UdFDiIPkK6DQfLRgeGzr4L" }
, { "The Nazgul", "https://drive.google.com/uc?id=1dDBQntjnFdi-3K63DjgqElM-z6d5rTKH" }
, { "Theoden", "https://drive.google.com/uc?id=1jOv4gATjZRSlQHkzrBVEW8sYpMkUbd9Z" }
, { "Thorin Oakenshield", "https://drive.google.com/uc?id=1zn-dSjeSyGmO7ropGdK0CI7d5IqOtYz8" }
, { "Tranduil", "https://drive.google.com/uc?id=17uYRN3SlLKxRZmiV6pJKOsBNzbZXVqdf" }
, { "Treebeard", "https://drive.google.com/uc?id=1TXGa0xqL-7TtTCw48NX836fxglvsdh4V" }
, { "Vilya", "https://drive.google.com/uc?id=1dwaxjpA2G7T414zdxMEnrBODVZnRwzTO" }
, { "Witch-king of Angmar", "https://drive.google.com/uc?id=1HMG_sbDoCBjxJC4b7EW1QlPizRAyQ32R" }


                };

                int countEN = (allQuestions_in_orderEN.Length) / 2;



                Global.Deckcounter = countEN;
                Global.DeckName = "Lord of the Rings & Hobbit Deck";
                Global.DeckInfo = "Lord of the Rings & Hobbit characters, quotes, places, items.";
                Randomizing.Randomize(allQuestions_in_orderEN);


                //for (int i = 0; i < Global.QuestionQuantity; i++)
                //{
                //    Global.ShuffledQuestion[i, 0] = allQuestions_in_orderEN[Global.Numbers[i], 0];
                //    Global.ShuffledQuestion[i, 1] = allQuestions_in_orderEN[Global.Numbers[i], 1];
                //}
            }
            else
            {
                string[,] allQuestions_in_orderLT = {


  { "Aragornas", "https://drive.google.com/uc?id=1JGdq6EvIkQJkYG22fIBdQhAM5yNpAq30" }
, { "Treino akmuo", "https://drive.google.com/uc?id=1SgcOTypYKukJ6Rgp-8oBOlR_BMI1k2Am" }
, { "Arvena", "https://drive.google.com/uc?id=1RyMsEBK6Z35wqwyBfAmeDBo-kBwXE76Z" }
, { "Atelasas", "https://drive.google.com/uc?id=1uLimw7TX1CzE_vhmgTdpyyH03FjUTeHm" }
, { "Azogas", "https://drive.google.com/uc?id=1JeJj8OFQAdfknb1-FYPP-5zT-s8wbO_m" }
, { "Balinas", "https://drive.google.com/uc?id=18WjSkqw1rOuWMJ6gVch3daWqeKFHVjpr" }
, { "Balgoras", "https://drive.google.com/uc?id=11ZDyWRED_K9hh8lmWSS70uCl4cbRg8CY" }
, { "Barahir", "https://drive.google.com/uc?id=10sXEfGvtBStsN6EK2fuebZbO30SX5zBr" }
, { "Beornas", "https://drive.google.com/uc?id=1trzXHI2qkVzdorqZLLp63wErfHD4k7QP" }
, { "Bilbas Beginsas", "https://drive.google.com/uc?id=16U4n1LaHahmw3uruAkWByaaxLUlwB_hA" }
, { "Bolgas", "https://drive.google.com/uc?id=1FsYH-K9RWsa7p3XOJfbRgztOE_sbMfTk" }
, { "Boromiras", "https://drive.google.com/uc?id=1raEjDUFQlqZ8mVYyWe5ESKXbRsd0IfFf" }
, { "Lankininkas Bardas", "https://drive.google.com/uc?id=16_KCm9Rg6hNKEopPAaEMB2Wv60rdwots" }
, { "Deinas II ", "https://drive.google.com/uc?id=1KTbHGZJomw1Pn1anQzY5Rg_fCzVCX-mZ" }
, { "Denetoras", "https://drive.google.com/uc?id=1jATABiQiRnepck8ilQnaunVV19oPii0q" }
, { "Elroldas", "https://drive.google.com/uc?id=19j00cdFwgAd2xcoTgWgmxWMvy9wV9ZPk" }
, { "Eomeras", "https://drive.google.com/uc?id=1-10IAgtxNaD3ZIXmFde5qpDLEiERInmB" }
, { "Eovyna", "https://drive.google.com/uc?id=1ndMEcpl4wyofLMFfh_OO4UFnqVcIEmlu" }
, { "Faramiras", "https://drive.google.com/uc?id=1_99oI3i8hl4ioTlcCw7CVDpYdtd9v31I" }
, { "Frodas Beginsas", "https://drive.google.com/uc?id=1XRdns65YK9goZD_8xJ2LEgIJY6t0mFmx" }
, { "Galandrielė", "https://drive.google.com/uc?id=1BIAuUFa0KiI5bcKQTYdov18Q1Hn3neWc" }
, { "Gendalfas Pilkasis", "https://drive.google.com/uc?id=1J8OZDDqb_iLw5e4EfG9N6neSpc3F02z2" }
, { "Gimlis", "https://drive.google.com/uc?id=1jJjTLeArLOMv9gBT1xc4InpdRgGprZ8y" }
, { "Golumas", "https://drive.google.com/uc?id=16Ayc46q687kR3o4LimdBHEwKI-d0BObX" }
, { "Grima Sliužburnis", "https://drive.google.com/uc?id=1ANBQJ6y83ZL5fBUsv0kDiMYtS3ybrQN-" }
, { "Isilduras", "https://drive.google.com/uc?id=1gVVB010zMD1hz3b5xNPkNqDwR5cSmbO3" }
, { "Legolasas", "https://drive.google.com/uc?id=1cwfc8ia0RlarsqPzV9HOIklARJy17mp3" }
, { "Lambaso duona", "https://drive.google.com/uc?id=1omGo6D__711lqZdU5ZjxItxwsK5p9Mq7" }
, { "Vienišasis kalnas", "https://drive.google.com/uc?id=1SOFIgb29qeL3ybFnPVfCg6L4IT0zDaRg" }
, { "Meris", "https://drive.google.com/uc?id=1JBwePcmG31kLPkZisuDGAOU7ZXwY4PaP" }
, { "Mitrilas", "https://drive.google.com/uc?id=1atnP5tH40LG7guXXJn5weggWpbXX7rOw" }
, { "Morgulo durklas", "https://drive.google.com/uc?id=13bOwax3OygN41TS_q0FprcfO9txth5pI" }
, { "Naria", "https://drive.google.com/uc?id=1uswR3O-96lDvyXAh1AvykHOVEiaCLzgA" }
, { "Nenia", "https://drive.google.com/uc?id=1jy_Lp1zV-hut-wyHvSUL7ATpwxGq3PVw" }
, { "Palantiras", "https://drive.google.com/uc?id=1VAbw7KXHnGuiV6q_Meg5k_ddhVVbkJaM" }
, { "Žvaigždės šviesa", "https://drive.google.com/uc?id=1TXZiSehh7V0g4SHeInPK_fObdNp9jtvO" }
, { "Pipinas", "https://drive.google.com/uc?id=1LH0ljlbQS31nVWY3At2-xmwrfnahpg9u" }
, { "Radagastas", "https://drive.google.com/uc?id=14ni4O9_zVSbws8lEOCCZgsMdt2KvP7zV" }
, { "Semas", "https://drive.google.com/uc?id=1XEwkXddgN60HgYz2Yqf4vXJKBYaoJ4fS" }
, { "Sarumanas Baltasis", "https://drive.google.com/uc?id=1jQ0_jq20xcbkg0NjCrTQWD1Ga-3FHBa4" }
, { "Sauronas", "https://drive.google.com/uc?id=1WEBOGbAIUe5XVSiNWlkIFGnJHSQ5xUD8" }
, { "Žvaigždikis", "https://drive.google.com/uc?id=1UUMh6xfvEsRCBZjzwxA_kP4D9NJh-oWF" }
, { "Šeloba", "https://drive.google.com/uc?id=1fllCixlHp_fpi1tYRajP9QY2jEacXO9p" }
, { "Smogas", "https://drive.google.com/uc?id=1oUL5Z7Pqh6UdFDiIPkK6DQfLRgeGzr4L" }
, { "Nazgulai", "https://drive.google.com/uc?id=1dDBQntjnFdi-3K63DjgqElM-z6d5rTKH" }
, { "Theodenas", "https://drive.google.com/uc?id=1jOv4gATjZRSlQHkzrBVEW8sYpMkUbd9Z" }
, { "Torinas Ąžuolskydis", "https://drive.google.com/uc?id=1zn-dSjeSyGmO7ropGdK0CI7d5IqOtYz8" }
, { "Tranduilas", "https://drive.google.com/uc?id=17uYRN3SlLKxRZmiV6pJKOsBNzbZXVqdf" }
, { "Medžiabarzdis", "https://drive.google.com/uc?id=1TXGa0xqL-7TtTCw48NX836fxglvsdh4V" }
, { "Vilia", "https://drive.google.com/uc?id=1dwaxjpA2G7T414zdxMEnrBODVZnRwzTO" }
, { "Angmaro Karalius", "https://drive.google.com/uc?id=1HMG_sbDoCBjxJC4b7EW1QlPizRAyQ32R" }

                };

                int countLT = (allQuestions_in_orderLT.Length) / 2;



                Global.Deckcounter = countLT;
                Global.DeckName = "Žiedų valdovo ir Hobito kaladė";
                Global.DeckInfo = "Žiedų valdovo ir Hobito personažai, citatos, vietos, daiktai.";
                Randomizing.Randomize(allQuestions_in_orderLT);

            }
        }
    }
}
