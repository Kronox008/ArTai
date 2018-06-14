using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArTai.Decks
{
    class GotDeck
    {
        public static void SetDeckInfo()
        {
            if (Global.LanguageSelectedID == 0)
            {
                string[,] allQuestions_in_orderEN = {
  { "Arya Stark", "https://drive.google.com/uc?id=1PxAvWM71IETbLfQcQNx1uF4aY0RwmvKx" }
, { "Brandon Stark", "https://drive.google.com/uc?id=1Vh05C0I8dpsteR_ABmNK7q0bfVLS41PF" }
, { "Brienne of Tarth", "https://drive.google.com/uc?id=1HiLebXDV-M5e57YLCi7VXaHI80ptrzxf" }
, { "Bronn", "https://drive.google.com/uc?id=1F2--7xG2SB9aQciOMpW4v1HEKyh7rTw8" }
, { "Brotherhood Without Banners", "https://drive.google.com/uc?id=1g29SYcsYYVWuanuGYMP_EDFHb2sU9TYo" }
, { "Catelyn Tully", "https://drive.google.com/uc?id=16DHMYqNSKkCl4528U-Ac5QjLvSgxcO-1" }
, { "Cersei Lannister", "https://drive.google.com/uc?id=1pl1r7vVsd_jahFI7kokuEFpX63IF7Q5l" }
, { "Children of the Forest", "https://drive.google.com/uc?id=1sIwJcchey37aMtTkX3veucmNCfKCmZVS" }
, { "Daario Naharis", "https://drive.google.com/uc?id=12DZVmQ7CjDK4kW22ei-6D5E9ddZnHaJc" }
, { "Daenerys Targaryen", "https://drive.google.com/uc?id=1GBIxQgC62ajYF15Crte0T1TL_dOm5ovJ" }
, { "Direwolf", "https://drive.google.com/uc?id=1HbKnY0qB1qn-VblboYR7HBz5LCjUCXfo" }
, { "Dothraki", "https://drive.google.com/uc?id=1yANOchUGIoW1GoThsGN-WwCITJFFrnrZ" }
, { "Dracarys", "https://drive.google.com/uc?id=1kv5Bk3O9GoTkAXwidnXLs8CDraBseRzi" }
, { "Drowned God", "https://drive.google.com/uc?id=1TeP9WoJQ4-t20YDWdxA6QzzRptv2gqzc" }
, { "Eddard Stark", "https://drive.google.com/uc?id=1ZZY1CinyuRO5KPls0rXBuwjkmy2xhLak" }
, { "Faceless Men", "https://drive.google.com/uc?id=1NwsNvqeaE_lhkluCApTAwt2S0V5L9LlF" }
, { "Faith of the Seven", "https://drive.google.com/uc?id=1dYOPQnZ8xua-3BqZg8phQXpcIeuuiSsh" }
, { "Free Folk", "https://drive.google.com/uc?id=1gmq0kPWgb09nfGdbXue2l0HPOK4SkzA9" }
, { "Giants", "https://drive.google.com/uc?id=17HzaDRsx_IPHBxsg-8C6eBZd9_TA9C0b" }
, { "Gilly", "https://drive.google.com/uc?id=1_KufWS18eToaHOsvMPh9Ex93bqIleWg8" }
, { "Golden cloaks", "https://drive.google.com/uc?id=15IkftvjBZmg1A-Zmwu0s2DrOQH0a215W" }
, { "High Sparrow", "https://drive.google.com/uc?id=1sw1dYJes_RXEGX_-EcXs89FK_QMzguTi" }
, { "House Arryn", "https://drive.google.com/uc?id=108qkxtVlmwFO8Lb-N62sD1md2g_xIlfZ" }
, { "House Baelish", "https://drive.google.com/uc?id=1ZUlBLN87sPX-2H0oDc-kM7F1UJyZ7WOl" }
, { "House Baratheon", "https://drive.google.com/uc?id=1G1doy1TTjdxBB3abwtamdC0TuF8iTFBf" }
, { "House Bolton", "https://drive.google.com/uc?id=1V0VmOuGfumRwWXC5CDsleW1xbmghr2Gn" }
, { "House Forrester", "https://drive.google.com/uc?id=1Jub0Tg_r8aUY1MKhhOxGgOSUpIfDpd-4" }
, { "House Frey", "https://drive.google.com/uc?id=1PvdEJjLlv_AWiOfIabvHHTcB75MkNS1n" }
, { "House Greyjoy", "https://drive.google.com/uc?id=1Rta9DxH1rVsx2GWUArjU1hw4TlXQgp_D" }
, { "House Karstark", "https://drive.google.com/uc?id=1yUuShj6nX6IntO5yy7aL4hMk4nvmiwWE" }
, { "House Lannister", "https://drive.google.com/uc?id=1uVaG7Sj-IBt9X6KAa8gfvYzBxjixGEhr" }
, { "House Martell", "https://drive.google.com/uc?id=1kbTmz1sFLPnIrbwln5k1rMYiV_NbU5-L" }
, { "House Mormont", "https://drive.google.com/uc?id=1WqvPV-TjF6zzoC2K9L1UpSQYN9qLq99A" }
, { "House Reed", "https://drive.google.com/uc?id=1io3q4A35wU2AC5Gili3-osXKA9sckfI6" }
, { "House Stark", "https://drive.google.com/uc?id=1bizoMVA-Xx7e5fVMA2IrQTbl9Y5Oz5Q7" }
, { "House Targaryen", "https://drive.google.com/uc?id=1EayzaiHrDMxd6AGbgUSL_gXT2vjTUDKx" }
, { "House Tyrell", "https://drive.google.com/uc?id=1qr3VExThiZf_Y76SR97bbQ9OnTGVHtqL" }
, { "House Tully", "https://drive.google.com/uc?id=1nzd96Zis5JckYt1MUGBn8mYbA7JWlv_j" }
, { "House Umber", "https://drive.google.com/uc?id=1jrYeV8DQFeb5E7pwX6GTtJgUuoUUXXHZ" }
, { "Yara Greyjoy", "https://drive.google.com/uc?id=1VlEOBrPJJCODHO-3igKH4Cmkp9Pn4O7s" }
, { "Iron Bank of Braavos", "https://drive.google.com/uc?id=1oqpf9CG7AuwivH6T7FV0lZ73zjKE1WFr" }
, { "Jaime Lannister", "https://drive.google.com/uc?id=1nPMtj8QWql58sMVGqKPFfR4mPDbpTFgp" }
, { "Joffrey Baratheon", "https://drive.google.com/uc?id=10qzakLcDkIFs155xwLUHsDq6r0uJk7OL" }
, { "Jon Snow", "https://drive.google.com/uc?id=1XiphClfqgH3fRIfA8RkKI0lU3j8Esbwy" }
, { "Jorah Mormont", "https://drive.google.com/uc?id=1Wu5_jYuI8bRSOH76aOwtHNuafooIDRPD" }
, { "Khal Drogo", "https://drive.google.com/uc?id=1fF3SfwgcBdFVv57cvauGfpOC--F3fRNp" }
, { "Kingsguard", "https://drive.google.com/uc?id=1dfRmpK5qJltd6aLzsKqC6-y-f9kdgD7l" }
, { "Loras Tyrell", "https://drive.google.com/uc?id=1Xfws1QeLMKfFb7tAVINO6-taJkfegDj2" }
, { "Many-Faced God", "https://drive.google.com/uc?id=1dmIuUrbhwyWpbvUPMh79C6nX4zJtKdTK" }
, { "Margaery Tyrell", "https://drive.google.com/uc?id=1RnoBA9CcHUYlIVO9DLDH6y4_0bLzYjs4" }
, { "Melisandre", "https://drive.google.com/uc?id=1utos2a93GsR0AUpgZ5D-sPk3uVvXEwyn" }
, { "Missandei", "https://drive.google.com/uc?id=1oXMn5I0ttFwTLHqOXzojhEYuXPJ8XVV6" }
, { "Night's Watch", "https://drive.google.com/uc?id=1gq0qofsI7cevjiezLF-GBuOpKTcTsxVD" }
, { "Old Gods of the Forest", "https://drive.google.com/uc?id=1-ftYcmWsWRTRrMb_PKmWDQAYaYnthTbR" }
, { "Onion Knight", "https://drive.google.com/uc?id=1bNSA3e3QTC-hjbwHTIbxKhJASeq3_nAl" }
, { "Petyr Baelish", "https://drive.google.com/uc?id=1SPPmnHe8n8wUs709ZH2Z8bKUR89OxBUk" }
, { "Qarth", "https://drive.google.com/uc?id=192nqTw0qph1CLFp_rjNBA2bwEl_8ETrv" }
, { "Ramsay Snow", "https://drive.google.com/uc?id=17TYugXY6GVF1nwT8LfMmM3xc1tDos-PN" }
, { "Rob Stark", "https://drive.google.com/uc?id=1PbXWivY2aLlJWv7McrIMZA3E5A9_6_wN" }
, { "Robert Baratheon", "https://drive.google.com/uc?id=1i2fLOvniNoplbbd0pGm50bQu03nl9G5-" }
, { "Roose Bolton", "https://drive.google.com/uc?id=1u3IScttfe2eLgcAcSedCtdWMlgSdTQ_V" }
, { "Samwell Tarly", "https://drive.google.com/uc?id=1eM_I-7Xm6U6NpmlZTRka2biHdtwxWyoB" }
, { "Sandor Clegane", "https://drive.google.com/uc?id=1E-ZP_N-LmWbTeRaWe7DhJVIRPRreIIOY" }
, { "Sansa Stark", "https://drive.google.com/uc?id=1gxu_WCQQ8Ohe4puzM0Fa4_UUu9tnX3zK" }
, { "Shae", "https://drive.google.com/uc?id=1quqfpl2ETEDGCRdZEeqG4AZAyxpxUWMZ" }
, { "Slaver's Bay", "https://drive.google.com/uc?id=1aqMiq0l5_R-qwCVyMkukgE_oTYUWjL-j" }
, { "Small Council", "https://drive.google.com/uc?id=1mGFLNrsONUxTSB_VZl96k9kOg9yEC7YM" }
, { "Theon Greyjoy", "https://drive.google.com/uc?id=19N6rScvWLILVppddayFDV-zi7yTM8fRA" }
, { "Tyrion Lannister", "https://drive.google.com/uc?id=1RNzdOPR4WDNb0GcDPw7TMDzNXp4C8pEI" }
, { "Tommen Baratheon", "https://drive.google.com/uc?id=1qO5RfQ-Mq9TtB6_O7n1sNUBqa4L2fiem" }
, { "Tormund", "https://drive.google.com/uc?id=11eSsQJMW4eLb0a-MGT2z8VVRB3E72sfK" }
, { "Unsullied", "https://drive.google.com/uc?id=11ALjMDqvTZ2RKWBCjdP5bSb2I20VloB6" }
, { "Valyria", "https://drive.google.com/uc?id=1wFWKRcW45H-y0Mkkcqo2rysf8I5xZpss" }
, { "Varys", "https://drive.google.com/uc?id=1hGqArdlJmIfl01rFgV9rpXALkzmH-eSP" }
, { "White walkers", "https://drive.google.com/uc?id=1xlXk2G0tq3pOwfdgiL5KSMTrvFLfPQit" }


                };

                int countEN = (allQuestions_in_orderEN.Length) / 2;



                Global.Deckcounter = countEN;
                Global.DeckName = "Game of Thrones";
                Global.DeckInfo = "Game Of Thrones characters, quotes, cities, places.";
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

  { "Arija Stark", "https://drive.google.com/uc?id=1PxAvWM71IETbLfQcQNx1uF4aY0RwmvKx" }
, { "Brandonas Starkas", "https://drive.google.com/uc?id=1Vh05C0I8dpsteR_ABmNK7q0bfVLS41PF" }
, { "Briana iš Tarto", "https://drive.google.com/uc?id=1HiLebXDV-M5e57YLCi7VXaHI80ptrzxf" }
, { "Bronas", "https://drive.google.com/uc?id=1F2--7xG2SB9aQciOMpW4v1HEKyh7rTw8" }
, { "Brolija be vėliavų", "https://drive.google.com/uc?id=1g29SYcsYYVWuanuGYMP_EDFHb2sU9TYo" }
, { "Ketlina Tuli", "https://drive.google.com/uc?id=16DHMYqNSKkCl4528U-Ac5QjLvSgxcO-1" }
, { "Sersėja Lanister", "https://drive.google.com/uc?id=1pl1r7vVsd_jahFI7kokuEFpX63IF7Q5l" }
, { "Miškavaikiai", "https://drive.google.com/uc?id=1sIwJcchey37aMtTkX3veucmNCfKCmZVS" }
, { "Dario Naharis", "https://drive.google.com/uc?id=12DZVmQ7CjDK4kW22ei-6D5E9ddZnHaJc" }
, { "Deineris Targarian", "https://drive.google.com/uc?id=1GBIxQgC62ajYF15Crte0T1TL_dOm5ovJ" }
, { "Didvilkis", "https://drive.google.com/uc?id=1HbKnY0qB1qn-VblboYR7HBz5LCjUCXfo" }
, { "Dotrakiai", "https://drive.google.com/uc?id=1yANOchUGIoW1GoThsGN-WwCITJFFrnrZ" }
, { "Drakaris", "https://drive.google.com/uc?id=1kv5Bk3O9GoTkAXwidnXLs8CDraBseRzi" }
, { "Nuskrendęs dievas", "https://drive.google.com/uc?id=1TeP9WoJQ4-t20YDWdxA6QzzRptv2gqzc" }
, { "Edardas Starkas", "https://drive.google.com/uc?id=1ZZY1CinyuRO5KPls0rXBuwjkmy2xhLak" }
, { "Beveidžiai žmonės", "https://drive.google.com/uc?id=1NwsNvqeaE_lhkluCApTAwt2S0V5L9LlF" }
, { "Septynetas", "https://drive.google.com/uc?id=1dYOPQnZ8xua-3BqZg8phQXpcIeuuiSsh" }
, { "Laisvoji tauta", "https://drive.google.com/uc?id=1gmq0kPWgb09nfGdbXue2l0HPOK4SkzA9" }
, { "Milžinai", "https://drive.google.com/uc?id=17HzaDRsx_IPHBxsg-8C6eBZd9_TA9C0b" }
, { "Gilė", "https://drive.google.com/uc?id=1_KufWS18eToaHOsvMPh9Ex93bqIleWg8" }
, { "MIesto sargyba", "https://drive.google.com/uc?id=15IkftvjBZmg1A-Zmwu0s2DrOQH0a215W" }
, { "Vyriausiasis žvirblis", "https://drive.google.com/uc?id=1sw1dYJes_RXEGX_-EcXs89FK_QMzguTi" }
, { "Arinų giminė", "https://drive.google.com/uc?id=108qkxtVlmwFO8Lb-N62sD1md2g_xIlfZ" }
, { "Belišų giminė", "https://drive.google.com/uc?id=1ZUlBLN87sPX-2H0oDc-kM7F1UJyZ7WOl" }
, { "Barateonų giminė", "https://drive.google.com/uc?id=1G1doy1TTjdxBB3abwtamdC0TuF8iTFBf" }
, { "Boltonų giminė", "https://drive.google.com/uc?id=1V0VmOuGfumRwWXC5CDsleW1xbmghr2Gn" }
, { "Foresterių giminė", "https://drive.google.com/uc?id=1Jub0Tg_r8aUY1MKhhOxGgOSUpIfDpd-4" }
, { "Frėjų giminė", "https://drive.google.com/uc?id=1PvdEJjLlv_AWiOfIabvHHTcB75MkNS1n" }
, { "Greidžojų giminė", "https://drive.google.com/uc?id=1Rta9DxH1rVsx2GWUArjU1hw4TlXQgp_D" }
, { "Karstarkų giminė", "https://drive.google.com/uc?id=1yUuShj6nX6IntO5yy7aL4hMk4nvmiwWE" }
, { "Lanisterių giminė", "https://drive.google.com/uc?id=1uVaG7Sj-IBt9X6KAa8gfvYzBxjixGEhr" }
, { "Martelių giminė", "https://drive.google.com/uc?id=1kbTmz1sFLPnIrbwln5k1rMYiV_NbU5-L" }
, { "Mormontų giminė", "https://drive.google.com/uc?id=1WqvPV-TjF6zzoC2K9L1UpSQYN9qLq99A" }
, { "Rydų giminė", "https://drive.google.com/uc?id=1io3q4A35wU2AC5Gili3-osXKA9sckfI6" }
, { "Starkų giminė", "https://drive.google.com/uc?id=1bizoMVA-Xx7e5fVMA2IrQTbl9Y5Oz5Q7" }
, { "Targarienų giminė", "https://drive.google.com/uc?id=1EayzaiHrDMxd6AGbgUSL_gXT2vjTUDKx" }
, { "Tairelių giminė", "https://drive.google.com/uc?id=1qr3VExThiZf_Y76SR97bbQ9OnTGVHtqL" }
, { "Tulių giminė", "https://drive.google.com/uc?id=1nzd96Zis5JckYt1MUGBn8mYbA7JWlv_j" }
, { "Amberių giminė", "https://drive.google.com/uc?id=1jrYeV8DQFeb5E7pwX6GTtJgUuoUUXXHZ" }
, { "Jara Greidžoj", "https://drive.google.com/uc?id=1VlEOBrPJJCODHO-3igKH4Cmkp9Pn4O7s" }
, { "Geležinis Bravoso bankas", "https://drive.google.com/uc?id=1oqpf9CG7AuwivH6T7FV0lZ73zjKE1WFr" }
, { "Džeimis Lanisteris", "https://drive.google.com/uc?id=1nPMtj8QWql58sMVGqKPFfR4mPDbpTFgp" }
, { "Džofris Barateonas", "https://drive.google.com/uc?id=10qzakLcDkIFs155xwLUHsDq6r0uJk7OL" }
, { "Džonas Snou", "https://drive.google.com/uc?id=1XiphClfqgH3fRIfA8RkKI0lU3j8Esbwy" }
, { "Džora Mormontas", "https://drive.google.com/uc?id=1Wu5_jYuI8bRSOH76aOwtHNuafooIDRPD" }
, { "Khalas Drogas", "https://drive.google.com/uc?id=1fF3SfwgcBdFVv57cvauGfpOC--F3fRNp" }
, { "Karaliaus sargyba", "https://drive.google.com/uc?id=1dfRmpK5qJltd6aLzsKqC6-y-f9kdgD7l" }
, { "Loras Tairelis", "https://drive.google.com/uc?id=1Xfws1QeLMKfFb7tAVINO6-taJkfegDj2" }
, { "Daugiaveidis dievas", "https://drive.google.com/uc?id=1dmIuUrbhwyWpbvUPMh79C6nX4zJtKdTK" }
, { "Mardžeri Tairel", "https://drive.google.com/uc?id=1RnoBA9CcHUYlIVO9DLDH6y4_0bLzYjs4" }
, { "Melisandra", "https://drive.google.com/uc?id=1utos2a93GsR0AUpgZ5D-sPk3uVvXEwyn" }
, { "Misandėja", "https://drive.google.com/uc?id=1oXMn5I0ttFwTLHqOXzojhEYuXPJ8XVV6" }
, { "Nakties sargyba", "https://drive.google.com/uc?id=1gq0qofsI7cevjiezLF-GBuOpKTcTsxVD" }
, { "Senieji miško dievai", "https://drive.google.com/uc?id=1-ftYcmWsWRTRrMb_PKmWDQAYaYnthTbR" }
, { "Svogunų riteris", "https://drive.google.com/uc?id=1bNSA3e3QTC-hjbwHTIbxKhJASeq3_nAl" }
, { "Peteris Belišas", "https://drive.google.com/uc?id=1SPPmnHe8n8wUs709ZH2Z8bKUR89OxBUk" }
, { "Kvartas", "https://drive.google.com/uc?id=192nqTw0qph1CLFp_rjNBA2bwEl_8ETrv" }
, { "Ramzis Snou", "https://drive.google.com/uc?id=17TYugXY6GVF1nwT8LfMmM3xc1tDos-PN" }
, { "Robas Starkas", "https://drive.google.com/uc?id=1PbXWivY2aLlJWv7McrIMZA3E5A9_6_wN" }
, { "Robertas Barateonas", "https://drive.google.com/uc?id=1i2fLOvniNoplbbd0pGm50bQu03nl9G5-" }
, { "Ruzas Boltonas", "https://drive.google.com/uc?id=1u3IScttfe2eLgcAcSedCtdWMlgSdTQ_V" }
, { "Semvelas Tarlis", "https://drive.google.com/uc?id=1eM_I-7Xm6U6NpmlZTRka2biHdtwxWyoB" }
, { "Sandoras Klegeinas", "https://drive.google.com/uc?id=1E-ZP_N-LmWbTeRaWe7DhJVIRPRreIIOY" }
, { "Sansa Stark", "https://drive.google.com/uc?id=1gxu_WCQQ8Ohe4puzM0Fa4_UUu9tnX3zK" }
, { "Šėja", "https://drive.google.com/uc?id=1quqfpl2ETEDGCRdZEeqG4AZAyxpxUWMZ" }
, { "Vergų įlanka", "https://drive.google.com/uc?id=1aqMiq0l5_R-qwCVyMkukgE_oTYUWjL-j" }
, { "Mažoji taryba", "https://drive.google.com/uc?id=1mGFLNrsONUxTSB_VZl96k9kOg9yEC7YM" }
, { "Teonas Greidžojus", "https://drive.google.com/uc?id=19N6rScvWLILVppddayFDV-zi7yTM8fRA" }
, { "Tyrionas Lanisteris", "https://drive.google.com/uc?id=1RNzdOPR4WDNb0GcDPw7TMDzNXp4C8pEI" }
, { "Tomenas Barateonas", "https://drive.google.com/uc?id=1qO5RfQ-Mq9TtB6_O7n1sNUBqa4L2fiem" }
, { "Tormundas", "https://drive.google.com/uc?id=11eSsQJMW4eLb0a-MGT2z8VVRB3E72sfK" }
, { "Nesuteptieji", "https://drive.google.com/uc?id=11ALjMDqvTZ2RKWBCjdP5bSb2I20VloB6" }
, { "Senoji Valyrija", "https://drive.google.com/uc?id=1wFWKRcW45H-y0Mkkcqo2rysf8I5xZpss" }
, { "Varis", "https://drive.google.com/uc?id=1hGqArdlJmIfl01rFgV9rpXALkzmH-eSP" }
, { "Baltieji klajūnai", "https://drive.google.com/uc?id=1xlXk2G0tq3pOwfdgiL5KSMTrvFLfPQit" }


                };

                int countLT = (allQuestions_in_orderLT.Length) / 2;



                Global.Deckcounter = countLT;
                Global.DeckName = "Sostų karai";
                Global.DeckInfo = "Kaladės informacija";
                Randomizing.Randomize(allQuestions_in_orderLT);

            }
        }
    }
}