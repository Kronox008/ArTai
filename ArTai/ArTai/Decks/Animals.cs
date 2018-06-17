using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArTai.Decks
{
    class Animals
    {
        public static void SetDeckInfo()
        {
            if (Global.LanguageSelectedID == 0)
            {
                string[,] allQuestions_in_orderEN = {
  { "Ant eater", "https://drive.google.com/uc?id=12CERAGTv_yj7eTijNGILI5aKWUh8SowI" }
, { "Armadillo", "https://drive.google.com/uc?id=10tvARCPCdL2r9BTEbbSHYlHcwX4DSJcB" }
, { "Bear", "https://drive.google.com/uc?id=1n_yUBPisHLzf5wfYXTsBjAIyLlt8Ugox" }
, { "Beaver", "https://drive.google.com/uc?id=1P6J2sVPF1M_0NNnsM3CLYt-0ujrY2xKP" }
, { "Bee", "https://drive.google.com/uc?id=1FIF_d3ZTzRksYcZYVjBmO5kFyCNjvSKh" }
, { "Boa", "https://drive.google.com/uc?id=10Kw2IBZEPpZaL9aeWmMzG5-EQ61YP-5n" }
, { "Boar", "https://drive.google.com/uc?id=1ZR-MDpPUMORD5Zi63tyqG726UpENlKnw" }
, { "Camel", "https://drive.google.com/uc?id=1Mp3ueS3c8XhXODMVrxJVV4wzqFoAHkI5" }
, { "Cat", "https://drive.google.com/uc?id=1g-IeYYHYKNLvrHJpZ5dHBkfr4eRreoMm" }
, { "Cheetah", "https://drive.google.com/uc?id=1qDTodtUGpF_FttP-FtGLXj9OHWuB3-vu" }
, { "Chicken", "https://drive.google.com/uc?id=1zwDMHIkxJHMxqdtFrnbjOQygPEtuFFPl" }
, { "Chimpanzee", "https://drive.google.com/uc?id=1pJU--lEwxAikxGbpBt4mUjHN5GK17YBP" }
, { "Cobra", "https://drive.google.com/uc?id=1vNHzFCTRDx6IqdYfBnltPnvr_QPVudse" }
, { "Cormoran", "https://drive.google.com/uc?id=1_ggoiW6-6leOlUjWUw-Bx4V65VejpR5s" }
, { "Cow", "https://drive.google.com/uc?id=1f-_1D2Wi1KoH_effGz4FCCHQTiK36Aze" }
, { "Crane", "https://drive.google.com/uc?id=1xyoouFhMC5eKDGuhkwO3jezRB-zbrquM" }
, { "Crocodile", "https://drive.google.com/uc?id=1ZocG2JE5GOQgqu2b8mGWgcb4gk4kolAI" }
, { "Crow", "https://drive.google.com/uc?id=1rsue9RGNv86QAZ97vgnt992JAaVgERpM" }
, { "Deer", "https://drive.google.com/uc?id=11XkkI_Do8CDj_XLQVC2W1NL36tAmQvKO" }
, { "Dog", "https://drive.google.com/uc?id=1d00-iFD1wKqdeEmCfY1hAgtnWDN2yNbq" }
, { "Dolphin", "https://drive.google.com/uc?id=18aOwRhHWqoA8q97612soz9KW8kyAmE88" }
, { "Duck", "https://drive.google.com/uc?id=1qDoCWJLF3TJCr_FUoH4v8f-gZ771kBJW" }
, { "Eagle", "https://drive.google.com/uc?id=1UjETWMvjYUupuntvv7zyGDcnc8VhESjf" }
, { "Eel", "https://drive.google.com/uc?id=1jaeLYqWUzW7sIhQOB4xpsy7vYtsREW-0" }
, { "Elephant", "https://drive.google.com/uc?id=1HnX1c9hEDKnnqd68XeFVch3IkvL0xI22" }
, { "European bison", "https://drive.google.com/uc?id=1Jtm7tInjJPUfuWKVlIpEdNs7y4Q46nTZ" }
, { "Flatfish", "https://drive.google.com/uc?id=1li8ju7is-KdM9cGJafHz_dAVHe0uRKHh" }
, { "Fly", "https://drive.google.com/uc?id=1lgimUyNnUZhbVjXd4hR6fqE4m2NR9yZI" }
, { "Fossa", "https://drive.google.com/uc?id=1lPGth9M81e7ABoDOGPJExY1ckpjzxFjr" }
, { "Fox", "https://drive.google.com/uc?id=1_25dIXZkx8pbyx_tZv_1cnKgVLKS11vu" }
, { "Gazelle", "https://drive.google.com/uc?id=16bDnFHZtRDbqBHTwxSZBsMVRTzDjLUfe" }
, { "Giraffe", "https://drive.google.com/uc?id=1F3AdZjb6y6Mky8jLig0Kf7YfsSl0nUcX" }
, { "Goat", "https://drive.google.com/uc?id=148a3YMlEHXHNVH079qesiWPqGsnoY17P" }
, { "Goose", "https://drive.google.com/uc?id=1Q-qFe8bel8fvOc9MS1BrKbwON66Lkfo7" }
, { "Gorilla", "https://drive.google.com/uc?id=1o4NiMyShHqQBpEYV7SHLsENDsdCpXbOo" }
, { "Grass snake", "https://drive.google.com/uc?id=1_YRUngzIRupCls_y2GhQ5mntPEoFR1QH" }
, { "Guinea pig", "https://drive.google.com/uc?id=1WhaGWNMRFh6yM8HwW_P0YaKyADSApDT8" }
, { "Hawk", "https://drive.google.com/uc?id=1yY4I0hAgX4A519yqFwtFcjpshVVzFhVc" }
, { "Hyena", "https://drive.google.com/uc?id=1T1k0ruqHs543OXwKP2aEdgcI7Dxg3n75" }
, { "Hippopotamus", "https://drive.google.com/uc?id=1daiFGmiVcXlw7KdNCRCqxg1U0ckzKd6K" }
, { "Horse", "https://drive.google.com/uc?id=1yo9q4fQWfm7Ss-ukTypsui87xb2dRKXd" }
, { "Jellyfish", "https://drive.google.com/uc?id=153-VDLn-hlb4PMQGGgaqrRmq1WWenGY_" }
, { "Kangaroo", "https://drive.google.com/uc?id=1N8mTy5G7Ztj-c-S_sc7wCy9pIGoyQAkE" }
, { "Killer whale", "https://drive.google.com/uc?id=1N2gd_I8w2jZ05J-5H33AiH8Io0OuTrle" }
, { "Kiwi", "https://drive.google.com/uc?id=14m47hUUTLP4iiX5FImp9T-mbaYNNwYPi" }
, { "Koala", "https://drive.google.com/uc?id=1IJV1G-htETeYquphBfMHdj41VLdX1nm3" }
, { "Lama", "https://drive.google.com/uc?id=1QlJBpPGFT5TH8gsGOoOj0HrGQDIxuExX" }
, { "Lemurs", "https://drive.google.com/uc?id=1mjeJ6Jv3K-kqfOhw2ZzJP4vvuuq3GXjd" }
, { "Leopard", "https://drive.google.com/uc?id=1jQN0FwxDIV8oej9fF4Ibpni5YPkQRwSA" }
, { "Lynx", "https://drive.google.com/uc?id=1DVg_tR0PjXrQrnhj2E4y46K0223Pe9Mc" }
, { "Lion", "https://drive.google.com/uc?id=1s2zZVMi8zAttTQAHIeqYqwUWd7Vd8qtn" }
, { "Lizard", "https://drive.google.com/uc?id=1D1r1WOSwYRwGr3dtRJ3xjs_2s47ULVKd" }
, { "Macaque", "https://drive.google.com/uc?id=1HDwedJuvz6zNl9YGs8vWg-qvGA-xh_pV" }
, { "Marten", "https://drive.google.com/uc?id=1wq6iL3IrWGIwSRaarB1prQfHkkZ-BLU2" }
, { "Monitor lizard", "https://drive.google.com/uc?id=1MA2PsifzsOhuQ19-eKJGfpuCjCKaD9H7" }
, { "Moose", "https://drive.google.com/uc?id=1RC4xxrsXvw1OUNC3WLAPj7kgxmlf7S_7" }
, { "Mouse", "https://drive.google.com/uc?id=1AFk9fwrb0IihugxVQmG6H3UxX1Rcy121" }
, { "Narwhal", "https://drive.google.com/uc?id=1hbLUbHBZewdyzeKtcfNvdV68KGqIL4qL" }
, { "Northern pike", "https://drive.google.com/uc?id=178Sf_ky28GR6cj6i7TX6gVAW4_5DvQqK" }
, { "Octopus", "https://drive.google.com/uc?id=1sdMZEwLJMpDF7HO4Hbl4crdQEg-0sMr1" }
, { "Orangutan", "https://drive.google.com/uc?id=11S_rwj0Pqg3YGjTY74FMGnmKM6GZviR8" }
, { "Ostrich", "https://drive.google.com/uc?id=10N4h48lqaOZjAjoZZgCKDcMbCWyiL8gW" }
, { "Otter", "https://drive.google.com/uc?id=1UhScoBTcYyY1O_BX8bLhireOZAXUtFjj" }
, { "Panda", "https://drive.google.com/uc?id=1s-BGZhC8WkMSzsRhJe4JTSKlZvLxsvM0" }
, { "Peacock", "https://drive.google.com/uc?id=1rcWl2aG_Cu8e5Ao_4SoU5zPowvC78Q_z" }
, { "Penguin", "https://drive.google.com/uc?id=1ftnE-kvX3gLb5x0IepToMTiYU1gkVk09" }
, { "Pig", "https://drive.google.com/uc?id=1g_4J8D1Vj4hiYTXZCtXSKGiU6rc_0-_F" }
, { "Piranha", "https://drive.google.com/uc?id=1Rsb2qswCPcjCSHEiyheAlcmMJoXk9mVz" }
, { "Platypus", "https://drive.google.com/uc?id=1KdMTfNBOhgG6QHvqQPgOBexEhuk3DVtL" }
, { "Polar bear", "https://drive.google.com/uc?id=13tceZyZNge3zdUvxw2yOlXEbioAKk4MM" }
, { "Puma", "https://drive.google.com/uc?id=1SmcJPQwbwLrM1nDRId3iEAvHqrESUzyo" }
, { "Rabbit", "https://drive.google.com/uc?id=1HixJuOvx32HcopARyDnYGC1zpsX9mXA_" }
, { "Raccoon", "https://drive.google.com/uc?id=1gr94HUcoajoaJjhFQSJoVQ0E99NkNbGY" }
, { "Raccoon dog", "https://drive.google.com/uc?id=1I0eBc2CAgkTxsQ58RaBWoysFVMy6utFO" }
, { "Rat", "https://drive.google.com/uc?id=11ajZm60X4U8dWf9k8bMpqRKGgobyeKW0" }
, { "Rhino", "https://drive.google.com/uc?id=1vKTQfU2BY3eXwRWAUuC9jMrUCFXagmH1" }
, { "Roe deer", "https://drive.google.com/uc?id=1OrAgPyT-Cb2vn-3W2X75q-FPTRDOiWnp" }
, { "Rooster", "https://drive.google.com/uc?id=1Wh5ZlpVKdq5XVr22pyeQ2RD_L4iI62Wf" }
, { "Saiga", "https://drive.google.com/uc?id=1NYNEh-YjBdflCjos3QcAj86XadTey9pg" }
, { "Salmon", "https://drive.google.com/uc?id=1m-yEuNRrUKJBf2uWyC8DhTRiOpbkkCGq" }
, { "Seal", "https://drive.google.com/uc?id=1B8iIwlWhROif-RqUShPBDNdD2DzdZtAm" }
, { "Shark", "https://drive.google.com/uc?id=12jJmJniU7smOWfgKNrZVmKQ9swtSKFTN" }
, { "Sheep", "https://drive.google.com/uc?id=1REIuhJx6x5UUN3NrcUyUaT4WYybB45eO" }
, { "Spider", "https://drive.google.com/uc?id=1dfrrnGlQ4eQkI9juNYyCMxssyUebXN2d" }
, { "Squirrel", "https://drive.google.com/uc?id=1fzQYlHOovcneA9bAQ-lUGmeyUaCjPKc-" }
, { "Stork", "https://drive.google.com/uc?id=1czH-IMH9SOViLN_9M5NgvHZkOFx4yR5F" }
, { "Swan", "https://drive.google.com/uc?id=1JdkK9hChFBaWAHvxVgbwyGVn8w9REBIp" }
, { "Tiger", "https://drive.google.com/uc?id=1zx2qGdtPCisMBj4u_ABSXvqJDOuDrxag" }
, { "Turkey", "https://drive.google.com/uc?id=1oDZVfauI5ny3udU8eT7O9TrB-GUZ1KES" }
, { "Turtle", "https://drive.google.com/uc?id=1414nGHvMAgtwF1zlq8WvaN9_x6iuum3b" }
, { "Walrus", "https://drive.google.com/uc?id=1jjrOMlg1VKlfxXGNZK8qOlIcYwhbeUoq" }
, { "Whale", "https://drive.google.com/uc?id=1GfEZF5tXVwsvU_2ybRP4YQOrRFcrNVZ8" }
, { "Wild yak", "https://drive.google.com/uc?id=1nhg8aQAg8Z13uLq1tU1_LliQDlg6ZCSY" }
, { "Wolf", "https://drive.google.com/uc?id=12kZn5IyX960rAwAU5bMhQUllzh3HsHAS" }
, { "Wolverene", "https://drive.google.com/uc?id=1APB1oOvE6H3lQtxCMfiBmkh_jSrDipe7" }
, { "Woodpecker", "https://drive.google.com/uc?id=1NL5Rp5dOEcMRU6U9cYFAzwBjkflvi5mB" }
, { "Worm", "https://drive.google.com/uc?id=1ynW9rvjuc-s4F-yKTBNJi7gIjcBOcnJ4" }
, { "Zebra", "https://drive.google.com/uc?id=1gEGPDVh1-7KDAxGMeG7zLf8UDdXHU51I" }
, { "Marmot", "https://drive.google.com/uc?id=1RSit6jjYoF5d7pe9RBjlLPCJwXHKDJ3F" }


                };

                int countEN = (allQuestions_in_orderEN.Length) / 2;



                Global.Deckcounter = countEN;
                Global.DeckName = "Animals";
                Global.DeckInfo = "Animals around the world.";
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

  { "Skruzdėda", "https://drive.google.com/uc?id=12CERAGTv_yj7eTijNGILI5aKWUh8SowI" }
, { "Šarvuotis", "https://drive.google.com/uc?id=10tvARCPCdL2r9BTEbbSHYlHcwX4DSJcB" }
, { "Meška", "https://drive.google.com/uc?id=1n_yUBPisHLzf5wfYXTsBjAIyLlt8Ugox" }
, { "Bebras", "https://drive.google.com/uc?id=1P6J2sVPF1M_0NNnsM3CLYt-0ujrY2xKP" }
, { "Bitė", "https://drive.google.com/uc?id=1FIF_d3ZTzRksYcZYVjBmO5kFyCNjvSKh" }
, { "Smauglys", "https://drive.google.com/uc?id=10Kw2IBZEPpZaL9aeWmMzG5-EQ61YP-5n" }
, { "Šernas", "https://drive.google.com/uc?id=1ZR-MDpPUMORD5Zi63tyqG726UpENlKnw" }
, { "Kupranugaris", "https://drive.google.com/uc?id=1Mp3ueS3c8XhXODMVrxJVV4wzqFoAHkI5" }
, { "Katinas", "https://drive.google.com/uc?id=1g-IeYYHYKNLvrHJpZ5dHBkfr4eRreoMm" }
, { "Gepardas", "https://drive.google.com/uc?id=1qDTodtUGpF_FttP-FtGLXj9OHWuB3-vu" }
, { "Višta", "https://drive.google.com/uc?id=1zwDMHIkxJHMxqdtFrnbjOQygPEtuFFPl" }
, { "Šimpanzė", "https://drive.google.com/uc?id=1pJU--lEwxAikxGbpBt4mUjHN5GK17YBP" }
, { "Kobra", "https://drive.google.com/uc?id=1vNHzFCTRDx6IqdYfBnltPnvr_QPVudse" }
, { "Kormoranas", "https://drive.google.com/uc?id=1_ggoiW6-6leOlUjWUw-Bx4V65VejpR5s" }
, { "Karvė", "https://drive.google.com/uc?id=1f-_1D2Wi1KoH_effGz4FCCHQTiK36Aze" }
, { "Gervė", "https://drive.google.com/uc?id=1xyoouFhMC5eKDGuhkwO3jezRB-zbrquM" }
, { "Krokodilas", "https://drive.google.com/uc?id=1ZocG2JE5GOQgqu2b8mGWgcb4gk4kolAI" }
, { "Varna", "https://drive.google.com/uc?id=1rsue9RGNv86QAZ97vgnt992JAaVgERpM" }
, { "Elnias", "https://drive.google.com/uc?id=11XkkI_Do8CDj_XLQVC2W1NL36tAmQvKO" }
, { "Šuo", "https://drive.google.com/uc?id=1d00-iFD1wKqdeEmCfY1hAgtnWDN2yNbq" }
, { "Delfinas", "https://drive.google.com/uc?id=18aOwRhHWqoA8q97612soz9KW8kyAmE88" }
, { "Antis", "https://drive.google.com/uc?id=1qDoCWJLF3TJCr_FUoH4v8f-gZ771kBJW" }
, { "Erelis", "https://drive.google.com/uc?id=1UjETWMvjYUupuntvv7zyGDcnc8VhESjf" }
, { "Ungurys", "https://drive.google.com/uc?id=1jaeLYqWUzW7sIhQOB4xpsy7vYtsREW-0" }
, { "Dramblys", "https://drive.google.com/uc?id=1HnX1c9hEDKnnqd68XeFVch3IkvL0xI22" }
, { "Stumbras", "https://drive.google.com/uc?id=1Jtm7tInjJPUfuWKVlIpEdNs7y4Q46nTZ" }
, { "Plekšnė", "https://drive.google.com/uc?id=1li8ju7is-KdM9cGJafHz_dAVHe0uRKHh" }
, { "Musė", "https://drive.google.com/uc?id=1lgimUyNnUZhbVjXd4hR6fqE4m2NR9yZI" }
, { "Fosa", "https://drive.google.com/uc?id=1lPGth9M81e7ABoDOGPJExY1ckpjzxFjr" }
, { "Lapė", "https://drive.google.com/uc?id=1_25dIXZkx8pbyx_tZv_1cnKgVLKS11vu" }
, { "Gazelė", "https://drive.google.com/uc?id=16bDnFHZtRDbqBHTwxSZBsMVRTzDjLUfe" }
, { "Žirafa", "https://drive.google.com/uc?id=1F3AdZjb6y6Mky8jLig0Kf7YfsSl0nUcX" }
, { "Ožka", "https://drive.google.com/uc?id=148a3YMlEHXHNVH079qesiWPqGsnoY17P" }
, { "Žąsis", "https://drive.google.com/uc?id=1Q-qFe8bel8fvOc9MS1BrKbwON66Lkfo7" }
, { "Gorila", "https://drive.google.com/uc?id=1o4NiMyShHqQBpEYV7SHLsENDsdCpXbOo" }
, { "Žaltys", "https://drive.google.com/uc?id=1_YRUngzIRupCls_y2GhQ5mntPEoFR1QH" }
, { "Jūrų kiaulytė", "https://drive.google.com/uc?id=1WhaGWNMRFh6yM8HwW_P0YaKyADSApDT8" }
, { "Vanagas", "https://drive.google.com/uc?id=1yY4I0hAgX4A519yqFwtFcjpshVVzFhVc" }
, { "Hiena", "https://drive.google.com/uc?id=1T1k0ruqHs543OXwKP2aEdgcI7Dxg3n75" }
, { "Begemotas", "https://drive.google.com/uc?id=1daiFGmiVcXlw7KdNCRCqxg1U0ckzKd6K" }
, { "Arklys", "https://drive.google.com/uc?id=1yo9q4fQWfm7Ss-ukTypsui87xb2dRKXd" }
, { "Medūza", "https://drive.google.com/uc?id=153-VDLn-hlb4PMQGGgaqrRmq1WWenGY_" }
, { "Kengūra", "https://drive.google.com/uc?id=1N8mTy5G7Ztj-c-S_sc7wCy9pIGoyQAkE" }
, { "Orka", "https://drive.google.com/uc?id=1N2gd_I8w2jZ05J-5H33AiH8Io0OuTrle" }
, { "Kivis", "https://drive.google.com/uc?id=14m47hUUTLP4iiX5FImp9T-mbaYNNwYPi" }
, { "Koala", "https://drive.google.com/uc?id=1IJV1G-htETeYquphBfMHdj41VLdX1nm3" }
, { "Lama", "https://drive.google.com/uc?id=1QlJBpPGFT5TH8gsGOoOj0HrGQDIxuExX" }
, { "Lemūras", "https://drive.google.com/uc?id=1mjeJ6Jv3K-kqfOhw2ZzJP4vvuuq3GXjd" }
, { "Leopardas", "https://drive.google.com/uc?id=1jQN0FwxDIV8oej9fF4Ibpni5YPkQRwSA" }
, { "Lūšis", "https://drive.google.com/uc?id=1DVg_tR0PjXrQrnhj2E4y46K0223Pe9Mc" }
, { "Liūtas", "https://drive.google.com/uc?id=1s2zZVMi8zAttTQAHIeqYqwUWd7Vd8qtn" }
, { "Driežas", "https://drive.google.com/uc?id=1D1r1WOSwYRwGr3dtRJ3xjs_2s47ULVKd" }
, { "Makaka", "https://drive.google.com/uc?id=1HDwedJuvz6zNl9YGs8vWg-qvGA-xh_pV" }
, { "Kiaunė", "https://drive.google.com/uc?id=1wq6iL3IrWGIwSRaarB1prQfHkkZ-BLU2" }
, { "Varanas", "https://drive.google.com/uc?id=1MA2PsifzsOhuQ19-eKJGfpuCjCKaD9H7" }
, { "Briedis", "https://drive.google.com/uc?id=1RC4xxrsXvw1OUNC3WLAPj7kgxmlf7S_7" }
, { "Pelė", "https://drive.google.com/uc?id=1AFk9fwrb0IihugxVQmG6H3UxX1Rcy121" }
, { "Narvalas", "https://drive.google.com/uc?id=1hbLUbHBZewdyzeKtcfNvdV68KGqIL4qL" }
, { "Lydeka", "https://drive.google.com/uc?id=178Sf_ky28GR6cj6i7TX6gVAW4_5DvQqK" }
, { "Aštuonkojis", "https://drive.google.com/uc?id=1sdMZEwLJMpDF7HO4Hbl4crdQEg-0sMr1" }
, { "Orangutanas", "https://drive.google.com/uc?id=11S_rwj0Pqg3YGjTY74FMGnmKM6GZviR8" }
, { "Strutis", "https://drive.google.com/uc?id=10N4h48lqaOZjAjoZZgCKDcMbCWyiL8gW" }
, { "Ūdra", "https://drive.google.com/uc?id=1UhScoBTcYyY1O_BX8bLhireOZAXUtFjj" }
, { "Panda", "https://drive.google.com/uc?id=1s-BGZhC8WkMSzsRhJe4JTSKlZvLxsvM0" }
, { "Povas", "https://drive.google.com/uc?id=1rcWl2aG_Cu8e5Ao_4SoU5zPowvC78Q_z" }
, { "Pingvinas", "https://drive.google.com/uc?id=1ftnE-kvX3gLb5x0IepToMTiYU1gkVk09" }
, { "Kiaulė", "https://drive.google.com/uc?id=1g_4J8D1Vj4hiYTXZCtXSKGiU6rc_0-_F" }
, { "Piranija", "https://drive.google.com/uc?id=1Rsb2qswCPcjCSHEiyheAlcmMJoXk9mVz" }
, { "Ančiasnapis", "https://drive.google.com/uc?id=1KdMTfNBOhgG6QHvqQPgOBexEhuk3DVtL" }
, { "Baltasis lokys", "https://drive.google.com/uc?id=13tceZyZNge3zdUvxw2yOlXEbioAKk4MM" }
, { "Puma", "https://drive.google.com/uc?id=1SmcJPQwbwLrM1nDRId3iEAvHqrESUzyo" }
, { "Kiškis", "https://drive.google.com/uc?id=1HixJuOvx32HcopARyDnYGC1zpsX9mXA_" }
, { "Meškėnas", "https://drive.google.com/uc?id=1gr94HUcoajoaJjhFQSJoVQ0E99NkNbGY" }
, { "Usūrinis šuo", "https://drive.google.com/uc?id=1I0eBc2CAgkTxsQ58RaBWoysFVMy6utFO" }
, { "Žiurkė", "https://drive.google.com/uc?id=11ajZm60X4U8dWf9k8bMpqRKGgobyeKW0" }
, { "Raganosis", "https://drive.google.com/uc?id=1vKTQfU2BY3eXwRWAUuC9jMrUCFXagmH1" }
, { "Stirna", "https://drive.google.com/uc?id=1OrAgPyT-Cb2vn-3W2X75q-FPTRDOiWnp" }
, { "Gaidys", "https://drive.google.com/uc?id=1Wh5ZlpVKdq5XVr22pyeQ2RD_L4iI62Wf" }
, { "Saiga", "https://drive.google.com/uc?id=1NYNEh-YjBdflCjos3QcAj86XadTey9pg" }
, { "Lašiša", "https://drive.google.com/uc?id=1m-yEuNRrUKJBf2uWyC8DhTRiOpbkkCGq" }
, { "Ruonis", "https://drive.google.com/uc?id=1B8iIwlWhROif-RqUShPBDNdD2DzdZtAm" }
, { "Riklys", "https://drive.google.com/uc?id=12jJmJniU7smOWfgKNrZVmKQ9swtSKFTN" }
, { "Avis", "https://drive.google.com/uc?id=1REIuhJx6x5UUN3NrcUyUaT4WYybB45eO" }
, { "Voras", "https://drive.google.com/uc?id=1dfrrnGlQ4eQkI9juNYyCMxssyUebXN2d" }
, { "Voverė", "https://drive.google.com/uc?id=1fzQYlHOovcneA9bAQ-lUGmeyUaCjPKc-" }
, { "Gandras", "https://drive.google.com/uc?id=1czH-IMH9SOViLN_9M5NgvHZkOFx4yR5F" }
, { "Gulbė", "https://drive.google.com/uc?id=1JdkK9hChFBaWAHvxVgbwyGVn8w9REBIp" }
, { "Tigras", "https://drive.google.com/uc?id=1zx2qGdtPCisMBj4u_ABSXvqJDOuDrxag" }
, { "Kalakutas", "https://drive.google.com/uc?id=1oDZVfauI5ny3udU8eT7O9TrB-GUZ1KES" }
, { "Vėžlys", "https://drive.google.com/uc?id=1414nGHvMAgtwF1zlq8WvaN9_x6iuum3b" }
, { "Vėplys", "https://drive.google.com/uc?id=1jjrOMlg1VKlfxXGNZK8qOlIcYwhbeUoq" }
, { "Banginis", "https://drive.google.com/uc?id=1GfEZF5tXVwsvU_2ybRP4YQOrRFcrNVZ8" }
, { "Jakas", "https://drive.google.com/uc?id=1nhg8aQAg8Z13uLq1tU1_LliQDlg6ZCSY" }
, { "Vilkas", "https://drive.google.com/uc?id=12kZn5IyX960rAwAU5bMhQUllzh3HsHAS" }
, { "Ernis", "https://drive.google.com/uc?id=1APB1oOvE6H3lQtxCMfiBmkh_jSrDipe7" }
, { "Genys", "https://drive.google.com/uc?id=1NL5Rp5dOEcMRU6U9cYFAzwBjkflvi5mB" }
, { "Sliekas", "https://drive.google.com/uc?id=1ynW9rvjuc-s4F-yKTBNJi7gIjcBOcnJ4" }
, { "Zebras", "https://drive.google.com/uc?id=1gEGPDVh1-7KDAxGMeG7zLf8UDdXHU51I" }
, { "Švilpikas", "https://drive.google.com/uc?id=1RSit6jjYoF5d7pe9RBjlLPCJwXHKDJ3F" }


                };

                int countLT = (allQuestions_in_orderLT.Length) / 2;



                Global.Deckcounter = countLT;
                Global.DeckName = "Gyvūnai";
                Global.DeckInfo = "Pasaulio gyvūnai.";
                Randomizing.Randomize(allQuestions_in_orderLT);

            }
        }
    }
}
