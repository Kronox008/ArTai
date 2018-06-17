using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArTai.Decks
{
    class FriendsDeck
    {
        public static void SetDeckInfo()
        {
            if (Global.LanguageSelectedID == 0)
            {
                string[,] allQuestions_in_orderEN = {
  { "Alice Knight Buffay", "https://drive.google.com/uc?id=160vcQbE4zBEB9itAqPaCkXeXkPzUt2gG" }
, { "Amy Green", "https://drive.google.com/uc?id=1rjvYDXjsoXyD84I75f_njmM2AMO84dZ6" }
, { "Armadillo", "https://drive.google.com/uc?id=1NoN34Gs7tBAHu5EBYfuX-T6xt4a5pvch" }
, { "Barry Farber", "https://drive.google.com/uc?id=1MJDaHTqWWVE8iJFBeV5Zx0usSmSVCDiH" }
, { "Carol Willick", "https://drive.google.com/uc?id=1FbMBu2QC44HnzOa8Z8iMgeiVxephu_ba" }
, { "Central Perk", "https://drive.google.com/uc?id=1UKmbIbrEZXkKeBHf-bwFkOF7uWDToo6j" }
, { "Charlie Wheeler", "https://drive.google.com/uc?id=1FbMBu2QC44HnzOa8Z8iMgeiVxephu_ba" }
, { "David", "https://drive.google.com/uc?id=1pctac4n93rGyzc6DOnmNi6nU4KQ-2PwX" }
, { "Dr. Richard Burke", "https://drive.google.com/uc?id=18NeKmm0tTGbcDTqy_4F14p7cD4OR4Ac2" }
, { "Eddie Manoick", "https://drive.google.com/uc?id=1DKBrPtl53LOaVSJW6L-E6DcECM1U3U9-" }
, { "Elizabeth Stevens", "https://drive.google.com/uc?id=10KvUapCdpjqPL-FZWZ5P2CdBSrgt8ZAP" }
, { "Emily Waltham", "https://drive.google.com/uc?id=1EjlfYszMl63oWrm1Zizi5-SSIg22SENr" }
, { "Erica", "https://drive.google.com/uc?id=1YgYz0dJGB2hSVGsINMBeljhHhdre3CWf" }
, { "Estelle Leonard", "https://drive.google.com/uc?id=1i6ij2jfVBAp9O4sOue3zFSqlzSG1_vke" }
, { "Frank Buffay Jr.", "https://drive.google.com/uc?id=1ELqZXL5XVK4B5VCGc6Cx4MLzb6krSxZP" }
, { "Gary", "https://drive.google.com/uc?id=1mq2gbb_gR3Cmc16Q2ZDqZrjWpeb5Bb6w" }
, { "Gunther", "https://drive.google.com/uc?id=1wQX-iUml2iO_LgDUXEiY0rtc4WRuyhpL" }
, { "Yemen", "https://drive.google.com/uc?id=12tlIEIesfdnn1QQC8f4uIks14S5v5_pJ" }
, { "In Prison!", "https://drive.google.com/uc?id=1OfamY4Lj7qGRobW2uZBA-vIE4efGtcaE" }
, { "Jack Geller", "https://drive.google.com/uc?id=1pnWKw6dUSV5zX5rUG04fIxW90jzna8BN" }
, { "Janice Litman Goralnik", "https://drive.google.com/uc?id=1UmZ6qdU7aIJI6J8anf9ax4OZhxIAu-if" }
, { "Janine LaCroix", "https://drive.google.com/uc?id=1dSvzu4y6mDFeJJJ2By1MYyzIyvYkL8CQ" }
, { "Jill Green", "https://drive.google.com/uc?id=1X_BlZxaoLyd91rve8zuxVEAt_i_cOB3W" }
, { "Joshua Burgin", "https://drive.google.com/uc?id=1N4vrseYnjUafPQTpSYrQSIueCg14pZIJ" }
, { "Judy Geller", "https://drive.google.com/uc?id=14r6s-agH3fWxqVLrGDft_PcZ4dP8ii39" }
, { "Julie", "https://drive.google.com/uc?id=1hGQ_U1WoC6d3TJ89K723psfFDdLUcX5l" }
, { "Kathy", "https://drive.google.com/uc?id=14JwN_F1TicAfK2n8csGJ2BMylXnYXzal" }
, { "Leonard Green", "https://drive.google.com/uc?id=1Qar6qCrxSCfp-XsX90vTyMmo8y8UHtMI" }
, { "Marcel", "https://drive.google.com/uc?id=1N3UnPUUNwq4_htyMWBsRUCxbN1u_ZnFC" }
, { "Mark Robinson", "https://drive.google.com/uc?id=1wEpHxOWWffDrmPFCRJWNb3YRH5w8ZmPh" }
, { "Melon drink", "https://drive.google.com/uc?id=1dx5pMecUKK9QF9M18_z8HDrJX6oJz1Q-" }
, { "Mike Hannigan", "https://drive.google.com/uc?id=1k1zi1oqO2-JOFSjYdahI8UhWB0NEFORv" }
, { "Mona", "https://drive.google.com/uc?id=16lf9bnEkpE4qSksEGLLXHkRqSX21OjZI" }
, { "Mr. Heckles", "https://drive.google.com/uc?id=1MQBUk6ggP-_kVhKi8rEZBtpbDDTFvIQb" }
, { "Mr. Treeger", "https://drive.google.com/uc?id=1VtcFCyYAK8_ycR6jim9JpNBdlmDyW5jC" }
, { "Mr. Zelner", "https://drive.google.com/uc?id=1VFTw1aTKaq3Nzj28YTBdV1BQuvnaSMPr" }
, { "Nora Tyler Bing", "https://drive.google.com/uc?id=1UbBoBsdiouUFuhJZJXYBFk852ZZazYr9" }
, { "Paolo", "https://drive.google.com/uc?id=1F5biFGqNVV1fBsFxG9XUDkpuL4meqy4c" }
, { "Pete Becker", "https://drive.google.com/uc?id=18JaCONQTbrehVCLeMxXgrAzBbSaovlTH" }
, { "Phoebe Abbott", "https://drive.google.com/uc?id=1kjYlHOO5ynQwoa0y3CvcWApWxu4-0Fym" }
, { "Red Ross", "https://drive.google.com/uc?id=1jBygh914e_a-cPjiLowZ6XE_zcxZgO3w" }
, { "Sandra Green", "https://drive.google.com/uc?id=1qOIHkxCN7WAfSIzrbmf5ShxHEZucDaq5" }
, { "Smelly Cat", "https://drive.google.com/uc?id=1tdDNYfh4O3naFTdW3Py7ZKuuYJke5-tS" }
, { "Sophie", "https://drive.google.com/uc?id=12v4urLK6ls4Trc8qVU5_Ff67rxijUWI4" }
, { "Steve", "https://drive.google.com/uc?id=1wOtx72vOdTZF6ie0V-CdtgZcbvfqQvMM" }
, { "Susan Bunch", "https://drive.google.com/uc?id=1f289dPi68DaJtmrhPkl5ZvdQb3CRQPZA" }
, { "Tag Jones", "https://drive.google.com/uc?id=1tu5FEosqJ0c48ZpG9SON_g85dIW-XmeO" }
, { "Unagi", "https://drive.google.com/uc?id=1SJY38k4WtYBZGbqgwVF1JTi0_nMGlN6l" }
, { "Ursula Buffay", "https://drive.google.com/uc?id=1W3Ssu003HxAdc_MAo-JaA1Kqt6rDCd6N" }
, { "Wah! Pah!", "https://drive.google.com/uc?id=1qE3Df08S58qiZNKVY71F58MnJOQooJSD" }


                };

                int countEN = (allQuestions_in_orderEN.Length) / 2;



                Global.Deckcounter = countEN;
                Global.DeckName = "F.R.I.E.N.D.S Deck";
                Global.DeckInfo = "Friends characters, quotes, places, items.";
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

  { "Elis Nait Bufei", "https://drive.google.com/uc?id=160vcQbE4zBEB9itAqPaCkXeXkPzUt2gG" }
, { "Eimi Gryn", "https://drive.google.com/uc?id=1rjvYDXjsoXyD84I75f_njmM2AMO84dZ6" }
, { "Šarvuotis", "https://drive.google.com/uc?id=1NoN34Gs7tBAHu5EBYfuX-T6xt4a5pvch" }
, { "Baris Faberis", "https://drive.google.com/uc?id=1MJDaHTqWWVE8iJFBeV5Zx0usSmSVCDiH" }
, { "Kerol Vilik", "https://drive.google.com/uc?id=1FbMBu2QC44HnzOa8Z8iMgeiVxephu_ba" }
, { "Centrinis Perkas", "https://drive.google.com/uc?id=1UKmbIbrEZXkKeBHf-bwFkOF7uWDToo6j" }
, { "Čarli Vyner", "https://drive.google.com/uc?id=1FbMBu2QC44HnzOa8Z8iMgeiVxephu_ba" }
, { "Deividas", "https://drive.google.com/uc?id=1pctac4n93rGyzc6DOnmNi6nU4KQ-2PwX" }
, { "Ričardas Berkas", "https://drive.google.com/uc?id=18NeKmm0tTGbcDTqy_4F14p7cD4OR4Ac2" }
, { "Edis Manoickas", "https://drive.google.com/uc?id=1DKBrPtl53LOaVSJW6L-E6DcECM1U3U9-" }
, { "Elizabet Styvens", "https://drive.google.com/uc?id=10KvUapCdpjqPL-FZWZ5P2CdBSrgt8ZAP" }
, { "Emili Voltham", "https://drive.google.com/uc?id=1EjlfYszMl63oWrm1Zizi5-SSIg22SENr" }
, { "Erika", "https://drive.google.com/uc?id=1YgYz0dJGB2hSVGsINMBeljhHhdre3CWf" }
, { "Estelė Leonard", "https://drive.google.com/uc?id=1i6ij2jfVBAp9O4sOue3zFSqlzSG1_vke" }
, { "Frenkas Biufei jaunesnynis", "https://drive.google.com/uc?id=1ELqZXL5XVK4B5VCGc6Cx4MLzb6krSxZP" }
, { "Garis", "https://drive.google.com/uc?id=1mq2gbb_gR3Cmc16Q2ZDqZrjWpeb5Bb6w" }
, { "Giunteris", "https://drive.google.com/uc?id=1wQX-iUml2iO_LgDUXEiY0rtc4WRuyhpL" }
, { "Jemenas", "https://drive.google.com/uc?id=12tlIEIesfdnn1QQC8f4uIks14S5v5_pJ" }
, { "Kalėjime!", "https://drive.google.com/uc?id=1OfamY4Lj7qGRobW2uZBA-vIE4efGtcaE" }
, { "Jekas Geleris", "https://drive.google.com/uc?id=1pnWKw6dUSV5zX5rUG04fIxW90jzna8BN" }
, { "Dženis Litman Goralnik", "https://drive.google.com/uc?id=1UmZ6qdU7aIJI6J8anf9ax4OZhxIAu-if" }
, { "Džanin Lacroiks", "https://drive.google.com/uc?id=1dSvzu4y6mDFeJJJ2By1MYyzIyvYkL8CQ" }
, { "Jil Gryn", "https://drive.google.com/uc?id=1X_BlZxaoLyd91rve8zuxVEAt_i_cOB3W" }
, { "Džošuo Burginas", "https://drive.google.com/uc?id=1N4vrseYnjUafPQTpSYrQSIueCg14pZIJ" }
, { "Džiudi Geler", "https://drive.google.com/uc?id=14r6s-agH3fWxqVLrGDft_PcZ4dP8ii39" }
, { "Džiuli", "https://drive.google.com/uc?id=1hGQ_U1WoC6d3TJ89K723psfFDdLUcX5l" }
, { "Keiti", "https://drive.google.com/uc?id=14JwN_F1TicAfK2n8csGJ2BMylXnYXzal" }
, { "Leonardas Grynas", "https://drive.google.com/uc?id=1Qar6qCrxSCfp-XsX90vTyMmo8y8UHtMI" }
, { "Marselis", "https://drive.google.com/uc?id=1N3UnPUUNwq4_htyMWBsRUCxbN1u_ZnFC" }
, { "Markas Robinsonas", "https://drive.google.com/uc?id=1wEpHxOWWffDrmPFCRJWNb3YRH5w8ZmPh" }
, { "Melionų gėrimas", "https://drive.google.com/uc?id=1dx5pMecUKK9QF9M18_z8HDrJX6oJz1Q-" }
, { "Maikas Haniganas", "https://drive.google.com/uc?id=1k1zi1oqO2-JOFSjYdahI8UhWB0NEFORv" }
, { "Mona", "https://drive.google.com/uc?id=16lf9bnEkpE4qSksEGLLXHkRqSX21OjZI" }
, { "Ponas Heklsas", "https://drive.google.com/uc?id=1MQBUk6ggP-_kVhKi8rEZBtpbDDTFvIQb" }
, { "Ponas Trigeris", "https://drive.google.com/uc?id=1VtcFCyYAK8_ycR6jim9JpNBdlmDyW5jC" }
, { "Ponas Zelneris", "https://drive.google.com/uc?id=1VFTw1aTKaq3Nzj28YTBdV1BQuvnaSMPr" }
, { "Nora Tailer Bing", "https://drive.google.com/uc?id=1UbBoBsdiouUFuhJZJXYBFk852ZZazYr9" }
, { "Paulo", "https://drive.google.com/uc?id=1F5biFGqNVV1fBsFxG9XUDkpuL4meqy4c" }
, { "Pitas Bekeris", "https://drive.google.com/uc?id=18JaCONQTbrehVCLeMxXgrAzBbSaovlTH" }
, { "Fibi Abot", "https://drive.google.com/uc?id=1kjYlHOO5ynQwoa0y3CvcWApWxu4-0Fym" }
, { "Raudonasis Rosas", "https://drive.google.com/uc?id=1jBygh914e_a-cPjiLowZ6XE_zcxZgO3w" }
, { "Sandra Gryn", "https://drive.google.com/uc?id=1qOIHkxCN7WAfSIzrbmf5ShxHEZucDaq5" }
, { "Dvokianti Katė", "https://drive.google.com/uc?id=1tdDNYfh4O3naFTdW3Py7ZKuuYJke5-tS" }
, { "Sofi", "https://drive.google.com/uc?id=12v4urLK6ls4Trc8qVU5_Ff67rxijUWI4" }
, { "Styvas", "https://drive.google.com/uc?id=1wOtx72vOdTZF6ie0V-CdtgZcbvfqQvMM" }
, { "Siuzan Bunč", "https://drive.google.com/uc?id=1f289dPi68DaJtmrhPkl5ZvdQb3CRQPZA" }
, { "Tagas Jaunsas", "https://drive.google.com/uc?id=1tu5FEosqJ0c48ZpG9SON_g85dIW-XmeO" }
, { "Unagi", "https://drive.google.com/uc?id=1SJY38k4WtYBZGbqgwVF1JTi0_nMGlN6l" }
, { "Uršula Bufei", "https://drive.google.com/uc?id=1W3Ssu003HxAdc_MAo-JaA1Kqt6rDCd6N" }
, { "Va! Pach!", "https://drive.google.com/uc?id=1qE3Df08S58qiZNKVY71F58MnJOQooJSD" }

                };

                int countLT = (allQuestions_in_orderLT.Length) / 2;



                Global.Deckcounter = countLT;
                Global.DeckName = "D.R.A.U.G.A.I kaladė";
                Global.DeckInfo = "Draugų personažai, citatos, vietos, daiktai.";
                Randomizing.Randomize(allQuestions_in_orderLT);


                //for (int i = 0; i < Global.QuestionQuantity; i++)
                //{
                //    Global.ShuffledQuestion[i, 0] = allQuestions_in_orderLT[Global.Numbers[i], 0];
                //    Global.ShuffledQuestion[i, 1] = allQuestions_in_orderLT[Global.Numbers[i], 1];
                //}
            }
        }

    }
}
