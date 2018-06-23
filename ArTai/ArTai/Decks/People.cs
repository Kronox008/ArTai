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
                      { "Nikola Tesla", "https://drive.google.com/uc?id=1tAXw3fgWv29DDJxHUw1W9ZozcECj9xG1" }
                    , { "Marilyn Monroe", "https://drive.google.com/uc?id=1_2adUXroXHp9QnY5d1i-RMQbBtSPThDu" }
                    , { "Abraham Lincoln", "https://drive.google.com/uc?id=1bRm2nDVwNOL1G0gMRIcUZBhanszIJICB" }
                    , { "Nelson Mandela", "https://drive.google.com/uc?id=1hY-ma2u-eGs1jOG-lE3VtN71SfhaDH7X" }
                    , { "Queen Elizabeth II", "https://drive.google.com/uc?id=1uPIM7G8asC6a4RHfCexHb7GN4bplsQT4" }
                    , { "Winston Churchill", "https://drive.google.com/uc?id=1BeQg8uZG1_hWjGJXHXBbFONIO6DdlROM" }
                    , { "Bill Gates", "https://drive.google.com/uc?id=1UkHiUVkC0RV5ZYKdnFnNweuqP5xtNdg5" }
                    , { "Muhammad Ali", "https://drive.google.com/uc?id=1xf0v8Jteg-zQKRkV1PvvfIJwUSuB9SYc" }
                    , { "Mahatma Gandhi", "https://drive.google.com/uc?id=181esPaAtSywE3s_ZEYBeMk1pGAzuJXlk" }
                    , { "Christopher Columbus", "https://drive.google.com/uc?id=1JRZhXj4lLM2QXBOnS9ENh_A-qFzNshuX" }
                    , { "Charles Darwin", "https://drive.google.com/uc?id=1HNA1DmtEsAzDmxtvK4vs1Rp8b1OZ7n2Y" }
                    , { "Elvis Presley", "https://drive.google.com/uc?id=1YvBbdtRob40xqeA79KHgA0jjmPIjcuu5" }
                    , { "Albert Einstein", "https://drive.google.com/uc?id=1-a-VKr8C-1Kq2Nel91HfEZz3I2OMocvP" }
                    , { "Leonardo da Vinci", "https://drive.google.com/uc?id=1cL7kezmvLHNA9J16RbTR0wjM3UMp8ZRs" }
                    , { "Vincent Van Gogh", "https://drive.google.com/uc?id=1M5Yb9mfifqoptVeinHd7OzWAbA1b0EjT" }
                    , { "Thomas Edison", "https://drive.google.com/uc?id=16k_E4jyFrR8bVGArtx__35LN_h3qOXzX" }
                    , { "Ludwig van Beethoven", "https://drive.google.com/uc?id=1QpmyV7eRMCpzHkv5yR58oDDcogk-_pc8" }
                    , { "George Orwell", "https://drive.google.com/uc?id=1STTvrSXXuF8jsKrX3WckY7P8SF44OFkS" }
                    , { "Dalai Lama", "https://drive.google.com/uc?id=15lZrACX-tq_NZdHA-wJV01jkC9-Z-YuU" }
                    , { "Walt Disney", "https://drive.google.com/uc?id=1T8Vpc8VOSddlXjVkImyOAXrz62XC-KxV" }
                    , { "Neil Armstrong", "https://drive.google.com/uc?id=15EGvkmljE5D8TmD3Ch7xqlowzTb7LAz0" }
                    , { "J.K.Rowling", "https://drive.google.com/uc?id=1AlMAlBf0bod4tJQ2rSgAiShgeC4j4caz" }
                    , { "Pele", "https://drive.google.com/uc?id=1XJbQF0WIgLAqt4D51xwosGoUGIKuUO8K" }
                    , { "Angelina Jolie", "https://drive.google.com/uc?id=1fOTzoCtC2rnOYOJdHSXsW5KxQrj_kDDX" }
                    , { "Ernest Hemingway", "https://drive.google.com/uc?id=1-s17nOVmyhymbjB7keL4T-Ol7QZCqHGI" }
                    , { "Henry Ford", "https://drive.google.com/uc?id=1P9cjd2A6cqV7jMvEUwX7ZY2IdhZYQMnV" }
                    , { "Michael Jordon", "https://drive.google.com/uc?id=1TuelW8KT6F6fQagiGwHjpFc2-9PB4Q1f" }
                    , { "Fidel Castro", "https://drive.google.com/uc?id=1CmNHE8PDOrYJJtapZIksA8I0cGPobtkF" }
                    , { "Leo Tolstoy", "https://drive.google.com/uc?id=1DaHQKYj_dWi8EWbbvA1YYhkezspNpcgD" }
                    , { "Pablo Picasso", "https://drive.google.com/uc?id=1xwOOGr5AwA7BNwlX1w0RvSSHF7vrfUKc" }
                    , { "Oscar Wilde", "https://drive.google.com/uc?id=1qOjihdleEPRzLjywIXdv5Qg-7Ff0jljJ" }
                    , { "Coco Chanel", "https://drive.google.com/uc?id=15-2pXuC9S6RhhGjXoFMvVxiCrZfu8d_t" }
                    , { "Alfred Hitchcock", "https://drive.google.com/uc?id=1scTVI9-aKzRoqtyZKX3NN0VWjtnI8q6k" }
                    , { "Cleopatra VII", "https://drive.google.com/uc?id=1dQZ90K5PkS4nZle6-AFn_Mu4uGUYea_5" }
                    , { "Steve Jobs", "https://drive.google.com/uc?id=1n-9HbFMWxjnAua9OPmH0p6MmcckIxXmk" }
                    , { "Lionel Messi", "https://drive.google.com/uc?id=1mElFX-Bd-SaHH6ZpIlqXMqrarxzfCPnM" }
                    , { "Sigmund Freud", "https://drive.google.com/uc?id=1kewQe0FcRlDb7e5szIJxObkYMxc_Ve4t" }
                    , { "Mao Zedong", "https://drive.google.com/uc?id=1X_4EaLsXRZcUdEKbhXggsWmBifPKJdy7" }
                    , { "Tiger Woods", "https://drive.google.com/uc?id=1RMPrLgm0TbpyeZTDNJP_6cXlQj84QBfL" }
                    , { "Usain Bolt", "https://drive.google.com/uc?id=1O9JgpfKr58YKWq2TQ53jN1DeOvwu8wG4" }
                    , { "C.S. Lewis", "https://drive.google.com/uc?id=1LbOy7ymcPZc2SSTsGgIOOvCtFXxiJoQv" }
                    , { "J.R.R. Tolkien", "https://drive.google.com/uc?id=1HHbqQ9H6EN4uVqVX5TBvf5sr_EG8abcc" }
                    , { "Marie Curie", "https://drive.google.com/uc?id=1X8X4VH_vA-2kfZH9cJJ5EOCB0muXp8_z" }
                    , { "Stephen Hawking", "https://drive.google.com/uc?id=1Y2B1vf-xNjHVJAZ4LyIZFFUsrMd_-w5H" }
                    , { "Brad Pitt", "https://drive.google.com/uc?id=1ZJQP3zmnDgKwRZ4YvZ6_yQyhqZmVSJX1" }
                    , { "Isaac Newton", "https://drive.google.com/uc?id=15EM8rwVwOwWkv01i8RUDplquuyG1yHmo" }
                    , { "Confucius", "https://drive.google.com/uc?id=11agnyCAczMsRbtwIdmY-G0iF15FDUBll" }
                    , { "Galileo Galilei", "https://drive.google.com/uc?id=1FHwk0pLHD6te1Fc7j5UOy-psJAKx-bco" }
                    , { "James Watt", "https://drive.google.com/uc?id=1LARAHmh7z3ktkyVc_-ULW2bJG5S0YXXN" }
                    , { "Alexander the Great", "https://drive.google.com/uc?id=1q3BMczrPxvy6xhNl_YjjxqzLpL5altcN" }
                    , { "Alexander Fleming", "https://drive.google.com/uc?id=1ur_cwhq_vJteLd0p_586RG_ddVjjoBcp" }


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

                      { "Nikola Tesla", "https://drive.google.com/uc?id=1tAXw3fgWv29DDJxHUw1W9ZozcECj9xG1" }
                    , { "Merilin Monro", "https://drive.google.com/uc?id=1_2adUXroXHp9QnY5d1i-RMQbBtSPThDu" }
                    , { "Abraomas Linkolnas", "https://drive.google.com/uc?id=1bRm2nDVwNOL1G0gMRIcUZBhanszIJICB" }
                    , { "Nelsonas Mandela", "https://drive.google.com/uc?id=1hY-ma2u-eGs1jOG-lE3VtN71SfhaDH7X" }
                    , { "Karalienė Elžbieta II", "https://drive.google.com/uc?id=1uPIM7G8asC6a4RHfCexHb7GN4bplsQT4" }
                    , { "Vinstonas Čerčilis", "https://drive.google.com/uc?id=1BeQg8uZG1_hWjGJXHXBbFONIO6DdlROM" }
                    , { "Bilas Geitsas", "https://drive.google.com/uc?id=1UkHiUVkC0RV5ZYKdnFnNweuqP5xtNdg5" }
                    , { "Muhamedas Ali", "https://drive.google.com/uc?id=1xf0v8Jteg-zQKRkV1PvvfIJwUSuB9SYc" }
                    , { "Mohandas Gandhi", "https://drive.google.com/uc?id=181esPaAtSywE3s_ZEYBeMk1pGAzuJXlk" }
                    , { "Kristupas Kolumbas", "https://drive.google.com/uc?id=1JRZhXj4lLM2QXBOnS9ENh_A-qFzNshuX" }
                    , { "Čarlzas Darvinas", "https://drive.google.com/uc?id=1HNA1DmtEsAzDmxtvK4vs1Rp8b1OZ7n2Y" }
                    , { "Elvis Preslis", "https://drive.google.com/uc?id=1YvBbdtRob40xqeA79KHgA0jjmPIjcuu5" }
                    , { "Albertas Einšteinas", "https://drive.google.com/uc?id=1-a-VKr8C-1Kq2Nel91HfEZz3I2OMocvP" }
                    , { "Leonardas da Vinčis", "https://drive.google.com/uc?id=1cL7kezmvLHNA9J16RbTR0wjM3UMp8ZRs" }
                    , { "Vincentas van Gogas", "https://drive.google.com/uc?id=1M5Yb9mfifqoptVeinHd7OzWAbA1b0EjT" }
                    , { "Tomas Edisonas", "https://drive.google.com/uc?id=16k_E4jyFrR8bVGArtx__35LN_h3qOXzX" }
                    , { "Liudvikas Van Bethovenas", "https://drive.google.com/uc?id=1QpmyV7eRMCpzHkv5yR58oDDcogk-_pc8" }
                    , { "Džordžas Orvelas", "https://drive.google.com/uc?id=1STTvrSXXuF8jsKrX3WckY7P8SF44OFkS" }
                    , { "Dalai Lama", "https://drive.google.com/uc?id=15lZrACX-tq_NZdHA-wJV01jkC9-Z-YuU" }
                    , { "Voltas Disnėjus", "https://drive.google.com/uc?id=1T8Vpc8VOSddlXjVkImyOAXrz62XC-KxV" }
                    , { "Neilas Armstrongas", "https://drive.google.com/uc?id=15EGvkmljE5D8TmD3Ch7xqlowzTb7LAz0" }
                    , { "J.K.Rowling", "https://drive.google.com/uc?id=1AlMAlBf0bod4tJQ2rSgAiShgeC4j4caz" }
                    , { "Pele", "https://drive.google.com/uc?id=1XJbQF0WIgLAqt4D51xwosGoUGIKuUO8K" }
                    , { "Andželina Džoli", "https://drive.google.com/uc?id=1fOTzoCtC2rnOYOJdHSXsW5KxQrj_kDDX" }
                    , { "Ernestas Hemingvėjus", "https://drive.google.com/uc?id=1-s17nOVmyhymbjB7keL4T-Ol7QZCqHGI" }
                    , { "Henris Fordas", "https://drive.google.com/uc?id=1P9cjd2A6cqV7jMvEUwX7ZY2IdhZYQMnV" }
                    , { "Maiklas Džordanas", "https://drive.google.com/uc?id=1TuelW8KT6F6fQagiGwHjpFc2-9PB4Q1f" }
                    , { "Fidel Castro", "https://drive.google.com/uc?id=1CmNHE8PDOrYJJtapZIksA8I0cGPobtkF" }
                    , { "Levas Tolstojus", "https://drive.google.com/uc?id=1DaHQKYj_dWi8EWbbvA1YYhkezspNpcgD" }
                    , { "Pablas Pikasas", "https://drive.google.com/uc?id=1xwOOGr5AwA7BNwlX1w0RvSSHF7vrfUKc" }
                    , { "Oskaras Vaildas", "https://drive.google.com/uc?id=1qOjihdleEPRzLjywIXdv5Qg-7Ff0jljJ" }
                    , { "Koko Šanel", "https://drive.google.com/uc?id=15-2pXuC9S6RhhGjXoFMvVxiCrZfu8d_t" }
                    , { "Alfredas Hičkokas", "https://drive.google.com/uc?id=1scTVI9-aKzRoqtyZKX3NN0VWjtnI8q6k" }
                    , { "Kleopatra VII", "https://drive.google.com/uc?id=1dQZ90K5PkS4nZle6-AFn_Mu4uGUYea_5" }
                    , { "Styvas Džobsas", "https://drive.google.com/uc?id=1n-9HbFMWxjnAua9OPmH0p6MmcckIxXmk" }
                    , { "Lionelis Mesis", "https://drive.google.com/uc?id=1mElFX-Bd-SaHH6ZpIlqXMqrarxzfCPnM" }
                    , { "Zigmundas Froidas", "https://drive.google.com/uc?id=1kewQe0FcRlDb7e5szIJxObkYMxc_Ve4t" }
                    , { "Mao Dzedongas", "https://drive.google.com/uc?id=1X_4EaLsXRZcUdEKbhXggsWmBifPKJdy7" }
                    , { "Tigeris Vodsas", "https://drive.google.com/uc?id=1RMPrLgm0TbpyeZTDNJP_6cXlQj84QBfL" }
                    , { "Jusainas Boltas", "https://drive.google.com/uc?id=1O9JgpfKr58YKWq2TQ53jN1DeOvwu8wG4" }
                    , { "Klaivas Lujis", "https://drive.google.com/uc?id=1LbOy7ymcPZc2SSTsGgIOOvCtFXxiJoQv" }
                    , { "Dž. R. R.Tolkinas", "https://drive.google.com/uc?id=1HHbqQ9H6EN4uVqVX5TBvf5sr_EG8abcc" }
                    , { "Marija Kiuri", "https://drive.google.com/uc?id=1X8X4VH_vA-2kfZH9cJJ5EOCB0muXp8_z" }
                    , { "Stivenas Hokingas", "https://drive.google.com/uc?id=1Y2B1vf-xNjHVJAZ4LyIZFFUsrMd_-w5H" }
                    , { "Bredas Pitas", "https://drive.google.com/uc?id=1ZJQP3zmnDgKwRZ4YvZ6_yQyhqZmVSJX1" }
                    , { "Izaokas Niutonas", "https://drive.google.com/uc?id=15EM8rwVwOwWkv01i8RUDplquuyG1yHmo" }
                    , { "Konfucijus", "https://drive.google.com/uc?id=11agnyCAczMsRbtwIdmY-G0iF15FDUBll" }
                    , { "Galilėjus", "https://drive.google.com/uc?id=1FHwk0pLHD6te1Fc7j5UOy-psJAKx-bco" }
                    , { "James Watt", "https://drive.google.com/uc?id=1LARAHmh7z3ktkyVc_-ULW2bJG5S0YXXN" }
                    , { "Aleksandras Makedonietis", "https://drive.google.com/uc?id=1q3BMczrPxvy6xhNl_YjjxqzLpL5altcN" }
                    , { "Aleksandras Flemingas", "https://drive.google.com/uc?id=1ur_cwhq_vJteLd0p_586RG_ddVjjoBcp" }



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
