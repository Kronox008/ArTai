using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArTai.Decks
{
    class HarryDeck
    {
        public static void SetDeckInfo()
        {
            if (Global.LanguageSelectedID == 0)
            {
                string[,] allQuestions_in_orderEN = {
  { "Alastor Moody", "https://drive.google.com/uc?id=1a0-X1nDej5vHnZK01NZj33diSNp96ilD" }
, { "Albus Dumbledore", "https://drive.google.com/uc?id=1kjYHYHN4TsPvGw47wNPfg2mo_N-wFhs8" }
, { "Alohomora", "https://drive.google.com/uc?id=168uUC0OWah13vB6mDMCt2Jifv2o6Xva4" }
, { "Animagus", "https://drive.google.com/uc?id=1lBIOElSu9ZgyaQlXom51bExHm2ysevox" }
, { "Aragog", "https://drive.google.com/uc?id=13GG3q_RpIU2Y6F9xi5rKb5hJxJlgfE_M" }
, { "Argus Filch", "https://drive.google.com/uc?id=1Lc9tLBUTFvl6z38n2iDIk2jUKtWWjFdu" }
, { "Basilisk", "https://drive.google.com/uc?id=1GPqPJeYtmBdEWYt6P0IHO3Cee3Mc3CrR" }
, { "Bellatrix Lestrange", "https://drive.google.com/uc?id=1qs08Ka-oxAQzjGSVpT_BP5YxqQSfY0j7" }
, { "Boggart", "https://drive.google.com/uc?id=1opG0aCOpiSn_CxGS2WMq4AY9HvKqjQ5v" }
, { "Cedric Diggory", "https://drive.google.com/uc?id=1t2OOtzho-2HY_vjoPIxaOHeRQzJZQXsn" }
, { "Chamber of Secrets", "https://drive.google.com/uc?id=15u9XjEHVpGGQeTciqlfOPaTt1iICx1Bz" }
, { "Chinese Fireball", "https://drive.google.com/uc?id=1-bknadmKEI5-pPKvjf7I25kwX3rPFqZ_" }
, { "Chocolate Frog", "https://drive.google.com/uc?id=17vEUmT8WgTOlUtcvNF9sfg5-fiJmHcM5" }
, { "Common Welsh Green", "https://drive.google.com/uc?id=1ALnPR-KLMNvgAiVmpRea9SchXDT-Fr9d" }
, { "Cruciatus", "https://drive.google.com/uc?id=1Sra3-Pcg82Mw3IQA5ZgE4_XUM3QI9ykB" }
, { "Cupboard Under the Stairs", "https://drive.google.com/uc?id=1wCsEEqz_FDeE2DkSy0Y2m11wam23L9wK" }
, { "Death Eaters", "https://drive.google.com/uc?id=1JMJ0i4_rHq2aCRrOaK_wtg-n4whSHLRq" }
, { "Deathly Hallows", "https://drive.google.com/uc?id=1h6j5HsVKMh_iM_c9Jla0OJLcqXp3waTh" }
, { "Dementor", "https://drive.google.com/uc?id=1rhRUA4Zl5Oqdnj-4QCKyaZpjItoNbm65" }
, { "Diagon Alley", "https://drive.google.com/uc?id=1_QyjAyLISiLlHeRO7NL4suFRHThmwdAc" }
, { "Dobby", "https://drive.google.com/uc?id=1NdAHKHYV0jpJ2FYo1Nyx2CarWJGynQsv" }
, { "Dolores Umbridge", "https://drive.google.com/uc?id=1xzkW6jnSzZLSGQ6_QhER0FW4B_lgvilq" }
, { "Draco Malfoy", "https://drive.google.com/uc?id=1X6LerBNxuS0M_R1a-PBk07tDnD6Uhz0O" }
, { "Elder Wand", "https://drive.google.com/uc?id=12-_Y5Tz0c6Qiii4FjYb77QDaHYSghcfp" }
, { "Every flavour beans", "https://drive.google.com/uc?id=12jznIc92lrUVeA8r4cD-W4t_QASMwlxw" }
, { "Floo Powder", "https://drive.google.com/uc?id=1-snHlmzrWyaaMxQdB3VX6lj1M84RZDB9" }
, { "Forbidden Forest", "https://drive.google.com/uc?id=1M7LLjwsn3aCZ5uF3py3cPO4WQL9mLokB" }
, { "Garrick Ollivander", "https://drive.google.com/uc?id=1p551eZfsS3RRolNvZVvmJ0mfiyApR5Ym" }
, { "Gaunt's Ring", "https://drive.google.com/uc?id=1qgKgj4VTkfngXOrG46ARUv5lg_0Ytia_" }
, { "Gilderoy Lockhart", "https://drive.google.com/uc?id=1FVSCwhyCLwYlv5oWA6EJ0UTM5o8_ENSF" }
, { "Gillyweed", "https://drive.google.com/uc?id=1z2N23soKtug4O8p5jChj3EB6Zvs8xtjb" }
, { "Ginny Weasley", "https://drive.google.com/uc?id=15r8Crw_rmGjpiq5UIaS0ckycWMhot1OQ" }
, { "Goblin", "https://drive.google.com/uc?id=1VD6waCqpevgEPh6BVlsJdk-QCOFj_yzm" }
, { "Griffin", "https://drive.google.com/uc?id=1rfb1Bb3qa25U6mdjQWgoON6qUTej4Efr" }
, { "Gryffindor", "https://drive.google.com/uc?id=1nG5u1Bv4_xvYEuc2cAyQxqGuGBAkNiLw" }
, { "Grim", "https://drive.google.com/uc?id=1TwImoq2-vy1NtDcaZrnp-GKLnC3xKc9X" }
, { "Gringotts Wizarding Bank", "https://drive.google.com/uc?id=1BUc61cEuoE0zDlxH893OCI1OryO2h5FM" }
, { "Half-Blood Prince", "https://drive.google.com/uc?id=19TbF28DLNY86RbWtBMZf9CHKLMt40Oh5" }
, { "Harry Potter", "https://drive.google.com/uc?id=1BFKC3_vjW41wMbm4vMN8w8HDQQOBFUjn" }
, { "Hedwig", "https://drive.google.com/uc?id=1d4AwCUrdipTsRLBknfBYC_M5ZX23wA6C" }
, { "Hermione Granger", "https://drive.google.com/uc?id=1EGkgTeyfGG6aPyZHNvr6JpOS3hXxeCII" }
, { "Hogsmeade", "https://drive.google.com/uc?id=1lKte9SSGUAW0eMw9kcyPf_brWWG-tEFp" }
, { "Hogwarts", "https://drive.google.com/uc?id=1Tzp_-fAR4B94cMIUhYH0R8Tw3eqANE9l" }
, { "Hogwarts Express", "https://drive.google.com/uc?id=1aI-3FvLlaUWfeemGJmZ969xeNjSvpmXb" }
, { "Horace Slughorn", "https://drive.google.com/uc?id=1YWOfMPun_0ZUQysL3mb351sDkr_Eau8S" }
, { "Horcrux", "https://drive.google.com/uc?id=1MYFVsV6U3gdKisVTHl_iMdOrhF8cGk6y" }
, { "House cup", "https://drive.google.com/uc?id=1RO-vdX9wqH-lhZzuZWyq1ZtSGJeta2J4" }
, { "House-elf", "https://drive.google.com/uc?id=1NdAHKHYV0jpJ2FYo1Nyx2CarWJGynQsv" }
, { "Hufflepuff", "https://drive.google.com/uc?id=10EScbzFG7ssqEYeK8lraZoUZJyVDMjwT" }
, { "Hufflepuff's Cup", "https://drive.google.com/uc?id=1zbrvWfzaKmbNnKYGc51BVcRK3xKVc9jU" }
, { "Hungarian Horntail", "https://drive.google.com/uc?id=1JB4OMK25_M2yMXpPBlkNk15TJLID8rCW" }
, { "Imperio", "https://drive.google.com/uc?id=1Ye1_5bYTJUZyj6IttSx6-jqEBjJ82Q3A" }
, { "Invisibility cloak", "https://drive.google.com/uc?id=1vrlfSODBFXqbEeF3hs_j-W-5Aghjz7uO" }
, { "Lucius Malfoy", "https://drive.google.com/uc?id=1z81gcb_bkoVwQrgBm2o3QmB9iMH5D3ba" }
, { "Lumos", "https://drive.google.com/uc?id=1diz2deS4wAbh1JIPeX0tOIsmhDM525SC" }
, { "Luna Lovegood", "https://drive.google.com/uc?id=1XIxfZth9Pk0tajeef6vW84k_Nb3dlboD" }
, { "Minerva McGonagall", "https://drive.google.com/uc?id=1fQ6vn7fBgnkmLwGdPqalD-1_XJqbYS79" }
, { "Ministry of Magic", "https://drive.google.com/uc?id=1YbttfZvXjz0fwpUFZNkju7QnmV3PbYMx" }
, { "Molly Weasley", "https://drive.google.com/uc?id=1Kvgv_octWA3LOq8dd3D8L49w9AsT41BV" }
, { "Mrs Norris", "https://drive.google.com/uc?id=1OHmOf70zRFcAKBFNrg8l0ck-879vuGxE" }
, { "Muggles", "https://drive.google.com/uc?id=1CsKmok5IBjreTDP6m9dhvz90KQiMuI3p" }
, { "Nagini", "https://drive.google.com/uc?id=1ASsGbgdNJp9M4AuOESqePRF9roHo6pnY" }
, { "Neville Longbottom", "https://drive.google.com/uc?id=1gtUUqdQ5dTNzgvYTOvvn1fgRFdp6WmUj" }
, { "Nimbus 2000", "https://drive.google.com/uc?id=1wtdMybPsUGjOD9wQSQEvj_vz3ACrOTWc" }
, { "Parselmouth", "https://drive.google.com/uc?id=1rGFshjfZ835Bu2zpJKml1xVkE-sRDyim" }
, { "Peron 9¾ ", "https://drive.google.com/uc?id=1TMX9SdTmWJ9kfK8eiiH9aO2dlFXYyoZi" }
, { "Peter Pettigrew", "https://drive.google.com/uc?id=1WE2nmIfCE7S54T7799Zlq7MnZlWd3TQt" }
, { "Philosopher's Stone ", "https://drive.google.com/uc?id=1yGdROaCaAk30KrYSxunE5kfMLCFzYrG5" }
, { "Pixie", "https://drive.google.com/uc?id=1--Zk28uuhaKnFFBzmWaG-W732-2sk47F" }
, { "Privet drive", "https://drive.google.com/uc?id=1R06xyhn9HzKCmE-7XkhpIWIxj15qytCt" }
, { "Protego", "https://drive.google.com/uc?id=1WMkXcWyz00PRSqQ4kSZGZBssR1PC3wPv" }
, { "Ravenclaw", "https://drive.google.com/uc?id=1iCJZZbdEECqYXj_zW0C-dgRSwaCWwVTG" }
, { "Ravenclaw's Diadem", "https://drive.google.com/uc?id=1PUFlJWQVOSGCTawEgOXKPwqZhRvC6vPa" }
, { "Remus Lupin", "https://drive.google.com/uc?id=1vFJZUDsnLXlInPZTM1KwH1YKcn6-zGE9" }
, { "Resurrection Stone", "https://drive.google.com/uc?id=1G8lGx0bQgu8aGUrxO0wz2u8sXWdnCFRV" }
, { "Ron Weasley", "https://drive.google.com/uc?id=1k3XZcVSTumWj_vyicRlSR0KHoY33nw8O" }
, { "Room of Requirement", "https://drive.google.com/uc?id=11PzuYbUU1FFgcfAps8v7npsLyHPl0V0v" }
, { "Rubeus Hagrid", "https://drive.google.com/uc?id=1_m0XvhIuWnRiwjU_HPLjKtWV3-9cOYG-" }
, { "Sectumsempra", "https://drive.google.com/uc?id=1jgj8F8P4rLFu6QcykqGI9oQwnT7mOxfE" }
, { "Severus Snape", "https://drive.google.com/uc?id=1TuYo_GLkydn5nxI-gWB1U2GkiofguTt_" }
, { "Sherbet Lemon", "https://drive.google.com/uc?id=1uutbI65GSFYBFHR6duIafv_gyLew8bfQ" }
, { "Sirius Black", "https://drive.google.com/uc?id=1yrBBSgmRW6GVbrJhndVTm7K5tzNzb1NM" }
, { "Slytherin", "https://drive.google.com/uc?id=1oVpKSpDLnfE8T23vZdKRUubw0iJvQ37f" }
, { "Slytherin's Locket", "https://drive.google.com/uc?id=1kGXD3e1MMl2ZfoigV2_nqKmxQo3kEguc" }
, { "Sorting hat", "https://drive.google.com/uc?id=1dQtPeOg5qBfzQdF2Y6IkvM6NMTJDqeFF" }
, { "Spell", "https://drive.google.com/uc?id=1l1q_jpsL8ZgKxATYM9uExOYoyiY1PGyG" }
, { "Stupefy", "https://drive.google.com/uc?id=1TuYo_GLkydn5nxI-gWB1U2GkiofguTt_" }
, { "Swedish Short-Snout", "https://drive.google.com/uc?id=1O4aTASu9bDXSOGfv_t3kRMae5R42WGlL" }
, { "Testral", "https://drive.google.com/uc?id=1PQ78vTUADWjQhIqq_FdMz44DAPJ753Be" }
, { "Tom Riddle", "https://drive.google.com/uc?id=1LqjRGZsFyrBFapqc_qVJh4lxCBG6IbAG" }
, { "Tom Riddle's diary", "https://drive.google.com/uc?id=1EcdbqZxru9z7cIlUiw7KosKthM_5HdoD" }
, { "Triwizard Tournament", "https://drive.google.com/uc?id=1NidzxOu-ngPWVP1ZwIHDP7HGljoEluRj" }
, { "Troll", "https://drive.google.com/uc?id=1JV20ACU2d0A7cpj4JmU_2ul5gljqA_LJ" }
, { "Vault 713", "https://drive.google.com/uc?id=1uwycxNNN62ackSTr8qRbndr7gVIOdmVE" }
, { "Vera verto", "https://drive.google.com/uc?id=1USC0A5Q2Hi9sGupDJ7lYsWd9KVUOvrpO" }
, { "Voldemort", "https://drive.google.com/uc?id=1o_SIczScL-3au8yh1OQTdtLWbSFRLaZ5" }
, { "Wand", "https://drive.google.com/uc?id=12-_Y5Tz0c6Qiii4FjYb77QDaHYSghcfp" }
, { "Whomping Willow", "https://drive.google.com/uc?id=1Jr9M-xZ29otmqbeXQVTCrVWJ21yQ3byz" }
, { "Wingardium Leviosa", "https://drive.google.com/uc?id=1cqawBNTEWVtTvEHJee5ku58EUF_K7j3O" }



                };

                int countEN = (allQuestions_in_orderEN.Length) / 2;



                Global.Deckcounter = countEN;
                Global.DeckName = "Harry Potter deck";
                Global.DeckInfo = "deck info";
                Randomizing.Randomize(allQuestions_in_orderEN);

            }
            else
            {
                string[,] allQuestions_in_orderLT = {

  { "Alastoras Rukna", "https://drive.google.com/uc?id=1a0-X1nDej5vHnZK01NZj33diSNp96ilD" }
, { "Albas Dumbldoras", "https://drive.google.com/uc?id=1kjYHYHN4TsPvGw47wNPfg2mo_N-wFhs8" }
, { "Alohomora", "https://drive.google.com/uc?id=168uUC0OWah13vB6mDMCt2Jifv2o6Xva4" }
, { "Animagas", "https://drive.google.com/uc?id=1lBIOElSu9ZgyaQlXom51bExHm2ysevox" }
, { "Aragogas", "https://drive.google.com/uc?id=13GG3q_RpIU2Y6F9xi5rKb5hJxJlgfE_M" }
, { "Argas Filčas", "https://drive.google.com/uc?id=1Lc9tLBUTFvl6z38n2iDIk2jUKtWWjFdu" }
, { "Basiliskas", "https://drive.google.com/uc?id=1GPqPJeYtmBdEWYt6P0IHO3Cee3Mc3CrR" }
, { "Belatriks Lestreindž", "https://drive.google.com/uc?id=1qs08Ka-oxAQzjGSVpT_BP5YxqQSfY0j7" }
, { "Kaukas", "https://drive.google.com/uc?id=1opG0aCOpiSn_CxGS2WMq4AY9HvKqjQ5v" }
, { "Sedrikas Digoris", "https://drive.google.com/uc?id=1t2OOtzho-2HY_vjoPIxaOHeRQzJZQXsn" }
, { "Paslapčių kambarys", "https://drive.google.com/uc?id=15u9XjEHVpGGQeTciqlfOPaTt1iICx1Bz" }
, { "Kinijos ugninis", "https://drive.google.com/uc?id=1-bknadmKEI5-pPKvjf7I25kwX3rPFqZ_" }
, { "Šokoladinė varlė", "https://drive.google.com/uc?id=17vEUmT8WgTOlUtcvNF9sfg5-fiJmHcM5" }
, { "Velso slibinas", "https://drive.google.com/uc?id=1ALnPR-KLMNvgAiVmpRea9SchXDT-Fr9d" }
, { "Krusijo", "https://drive.google.com/uc?id=1Sra3-Pcg82Mw3IQA5ZgE4_XUM3QI9ykB" }
, { "Sandėliukas po laiptais", "https://drive.google.com/uc?id=1wCsEEqz_FDeE2DkSy0Y2m11wam23L9wK" }
, { "Mirties valgytojas", "https://drive.google.com/uc?id=1JMJ0i4_rHq2aCRrOaK_wtg-n4whSHLRq" }
, { "Mirties relikvijos", "https://drive.google.com/uc?id=1h6j5HsVKMh_iM_c9Jla0OJLcqXp3waTh" }
, { "Psichas", "https://drive.google.com/uc?id=1rhRUA4Zl5Oqdnj-4QCKyaZpjItoNbm65" }
, { "Skersinis skersgatvis", "https://drive.google.com/uc?id=1_QyjAyLISiLlHeRO7NL4suFRHThmwdAc" }
, { "Dobis", "https://drive.google.com/uc?id=1NdAHKHYV0jpJ2FYo1Nyx2CarWJGynQsv" }
, { "Dolores Umbridž", "https://drive.google.com/uc?id=1xzkW6jnSzZLSGQ6_QhER0FW4B_lgvilq" }
, { "Drakas Smirdžius", "https://drive.google.com/uc?id=1X6LerBNxuS0M_R1a-PBk07tDnD6Uhz0O" }
, { "Šeivamedžio lazdelė", "https://drive.google.com/uc?id=12-_Y5Tz0c6Qiii4FjYb77QDaHYSghcfp" }
, { "Visokių skonių pupelės", "https://drive.google.com/uc?id=12jznIc92lrUVeA8r4cD-W4t_QASMwlxw" }
, { "Kelionmilčiai", "https://drive.google.com/uc?id=1-snHlmzrWyaaMxQdB3VX6lj1M84RZDB9" }
, { "Uždraustasis miškas", "https://drive.google.com/uc?id=1M7LLjwsn3aCZ5uF3py3cPO4WQL9mLokB" }
, { "Olivanderis", "https://drive.google.com/uc?id=1p551eZfsS3RRolNvZVvmJ0mfiyApR5Ym" }
, { "Gonto žiedas", "https://drive.google.com/uc?id=1qgKgj4VTkfngXOrG46ARUv5lg_0Ytia_" }
, { "Gilderojus Lokhartas", "https://drive.google.com/uc?id=1FVSCwhyCLwYlv5oWA6EJ0UTM5o8_ENSF" }
, { "Žiaunažolės", "https://drive.google.com/uc?id=1z2N23soKtug4O8p5jChj3EB6Zvs8xtjb" }
, { "Džinė Vizli", "https://drive.google.com/uc?id=15r8Crw_rmGjpiq5UIaS0ckycWMhot1OQ" }
, { "Goblinas", "https://drive.google.com/uc?id=1VD6waCqpevgEPh6BVlsJdk-QCOFj_yzm" }
, { "Grifas", "https://drive.google.com/uc?id=1rfb1Bb3qa25U6mdjQWgoON6qUTej4Efr" }
, { "Grifo gūžta", "https://drive.google.com/uc?id=1nG5u1Bv4_xvYEuc2cAyQxqGuGBAkNiLw" }
, { "Kraupas", "https://drive.google.com/uc?id=1TwImoq2-vy1NtDcaZrnp-GKLnC3xKc9X" }
, { "Gringoco bankas", "https://drive.google.com/uc?id=1BUc61cEuoE0zDlxH893OCI1OryO2h5FM" }
, { "Netikras princas", "https://drive.google.com/uc?id=19TbF28DLNY86RbWtBMZf9CHKLMt40Oh5" }
, { "Haris Poteris", "https://drive.google.com/uc?id=1BFKC3_vjW41wMbm4vMN8w8HDQQOBFUjn" }
, { "Hedviga", "https://drive.google.com/uc?id=1d4AwCUrdipTsRLBknfBYC_M5ZX23wA6C" }
, { "Hermiona Įkyrelė", "https://drive.google.com/uc?id=1EGkgTeyfGG6aPyZHNvr6JpOS3hXxeCII" }
, { "Kiauliasodis", "https://drive.google.com/uc?id=1lKte9SSGUAW0eMw9kcyPf_brWWG-tEFp" }
, { "Hogvartsas", "https://drive.google.com/uc?id=1Tzp_-fAR4B94cMIUhYH0R8Tw3eqANE9l" }
, { "Hogvartso ekspresas", "https://drive.google.com/uc?id=1aI-3FvLlaUWfeemGJmZ969xeNjSvpmXb" }
, { "Horacijus Trimitas", "https://drive.google.com/uc?id=1YWOfMPun_0ZUQysL3mb351sDkr_Eau8S" }
, { "Horokrusas", "https://drive.google.com/uc?id=1MYFVsV6U3gdKisVTHl_iMdOrhF8cGk6y" }
, { "Koledžo taurė", "https://drive.google.com/uc?id=1RO-vdX9wqH-lhZzuZWyq1ZtSGJeta2J4" }
, { "Namų elfas", "https://drive.google.com/uc?id=1NdAHKHYV0jpJ2FYo1Nyx2CarWJGynQsv" }
, { "Švilpynė", "https://drive.google.com/uc?id=10EScbzFG7ssqEYeK8lraZoUZJyVDMjwT" }
, { "Helgos Švilpynės taurė", "https://drive.google.com/uc?id=1zbrvWfzaKmbNnKYGc51BVcRK3xKVc9jU" }
, { "Vengrijos ragauodegis", "https://drive.google.com/uc?id=1JB4OMK25_M2yMXpPBlkNk15TJLID8rCW" }
, { "Imperijo", "https://drive.google.com/uc?id=1Ye1_5bYTJUZyj6IttSx6-jqEBjJ82Q3A" }
, { "Neregimumo apsiaustas", "https://drive.google.com/uc?id=1vrlfSODBFXqbEeF3hs_j-W-5Aghjz7uO" }
, { "Liucijus Smirdžius", "https://drive.google.com/uc?id=1z81gcb_bkoVwQrgBm2o3QmB9iMH5D3ba" }
, { "Lumos", "https://drive.google.com/uc?id=1diz2deS4wAbh1JIPeX0tOIsmhDM525SC" }
, { "Luna Geranorė", "https://drive.google.com/uc?id=1XIxfZth9Pk0tajeef6vW84k_Nb3dlboD" }
, { "Minerva Makonagal", "https://drive.google.com/uc?id=1fQ6vn7fBgnkmLwGdPqalD-1_XJqbYS79" }
, { "Magijos ministerija", "https://drive.google.com/uc?id=1YbttfZvXjz0fwpUFZNkju7QnmV3PbYMx" }
, { "Molė Vizli", "https://drive.google.com/uc?id=1Kvgv_octWA3LOq8dd3D8L49w9AsT41BV" }
, { "Ponia Noris", "https://drive.google.com/uc?id=1OHmOf70zRFcAKBFNrg8l0ck-879vuGxE" }
, { "Žiobaras", "https://drive.google.com/uc?id=1CsKmok5IBjreTDP6m9dhvz90KQiMuI3p" }
, { "Nadžinė", "https://drive.google.com/uc?id=1ASsGbgdNJp9M4AuOESqePRF9roHo6pnY" }
, { "Nevilis Nevėkšla", "https://drive.google.com/uc?id=1gtUUqdQ5dTNzgvYTOvvn1fgRFdp6WmUj" }
, { "Aureolė 2000", "https://drive.google.com/uc?id=1wtdMybPsUGjOD9wQSQEvj_vz3ACrOTWc" }
, { "Šnypštuolis", "https://drive.google.com/uc?id=1rGFshjfZ835Bu2zpJKml1xVkE-sRDyim" }
, { "9¾  peronas", "https://drive.google.com/uc?id=1TMX9SdTmWJ9kfK8eiiH9aO2dlFXYyoZi" }
, { "Pyteris Trumpulis", "https://drive.google.com/uc?id=1WE2nmIfCE7S54T7799Zlq7MnZlWd3TQt" }
, { "Išminties akmuo", "https://drive.google.com/uc?id=1yGdROaCaAk30KrYSxunE5kfMLCFzYrG5" }
, { "Kornvalio elfas", "https://drive.google.com/uc?id=1--Zk28uuhaKnFFBzmWaG-W732-2sk47F" }
, { "Liguistrų gatvė", "https://drive.google.com/uc?id=1R06xyhn9HzKCmE-7XkhpIWIxj15qytCt" }
, { "Protego", "https://drive.google.com/uc?id=1WMkXcWyz00PRSqQ4kSZGZBssR1PC3wPv" }
, { "Varno nagas", "https://drive.google.com/uc?id=1iCJZZbdEECqYXj_zW0C-dgRSwaCWwVTG" }
, { "Varnanagės diadema", "https://drive.google.com/uc?id=1PUFlJWQVOSGCTawEgOXKPwqZhRvC6vPa" }
, { "Remas Lupinas", "https://drive.google.com/uc?id=1vFJZUDsnLXlInPZTM1KwH1YKcn6-zGE9" }
, { "Prisikėlimo akmuo", "https://drive.google.com/uc?id=1G8lGx0bQgu8aGUrxO0wz2u8sXWdnCFRV" }
, { "Ronas Vizlis", "https://drive.google.com/uc?id=1k3XZcVSTumWj_vyicRlSR0KHoY33nw8O" }
, { "Kambarys iki pareikalavimo", "https://drive.google.com/uc?id=11PzuYbUU1FFgcfAps8v7npsLyHPl0V0v" }
, { "Rubijus Hagridas", "https://drive.google.com/uc?id=1_m0XvhIuWnRiwjU_HPLjKtWV3-9cOYG-" }
, { "Sanktum sempra", "https://drive.google.com/uc?id=1jgj8F8P4rLFu6QcykqGI9oQwnT7mOxfE" }
, { "Severas Sneipas", "https://drive.google.com/uc?id=1TuYo_GLkydn5nxI-gWB1U2GkiofguTt_" }
, { "Citrinų šerbetas", "https://drive.google.com/uc?id=1uutbI65GSFYBFHR6duIafv_gyLew8bfQ" }
, { "Sirijus Blekas", "https://drive.google.com/uc?id=1yrBBSgmRW6GVbrJhndVTm7K5tzNzb1NM" }
, { "Klastunynas", "https://drive.google.com/uc?id=1oVpKSpDLnfE8T23vZdKRUubw0iJvQ37f" }
, { "Salazaro Klastuolio medalionas", "https://drive.google.com/uc?id=1kGXD3e1MMl2ZfoigV2_nqKmxQo3kEguc" }
, { "Paskirstymo kepurė", "https://drive.google.com/uc?id=1dQtPeOg5qBfzQdF2Y6IkvM6NMTJDqeFF" }
, { "Burtažodis", "https://drive.google.com/uc?id=1l1q_jpsL8ZgKxATYM9uExOYoyiY1PGyG" }
, { "Stupifai", "https://drive.google.com/uc?id=1TuYo_GLkydn5nxI-gWB1U2GkiofguTt_" }
, { "Švedijos trumpasnukis", "https://drive.google.com/uc?id=1O4aTASu9bDXSOGfv_t3kRMae5R42WGlL" }
, { "Testralis", "https://drive.google.com/uc?id=1PQ78vTUADWjQhIqq_FdMz44DAPJ753Be" }
, { "Tomas Ridlis", "https://drive.google.com/uc?id=1LqjRGZsFyrBFapqc_qVJh4lxCBG6IbAG" }
, { "Tomo Ridlio dienoraštis", "https://drive.google.com/uc?id=1EcdbqZxru9z7cIlUiw7KosKthM_5HdoD" }
, { "Burtų trikovės turnyras", "https://drive.google.com/uc?id=1NidzxOu-ngPWVP1ZwIHDP7HGljoEluRj" }
, { "Trolis", "https://drive.google.com/uc?id=1JV20ACU2d0A7cpj4JmU_2ul5gljqA_LJ" }
, { "713 saugykla", "https://drive.google.com/uc?id=1uwycxNNN62ackSTr8qRbndr7gVIOdmVE" }
, { "Vera verto", "https://drive.google.com/uc?id=1USC0A5Q2Hi9sGupDJ7lYsWd9KVUOvrpO" }
, { "Voldemortas", "https://drive.google.com/uc?id=1o_SIczScL-3au8yh1OQTdtLWbSFRLaZ5" }
, { "Burtų lazdelė", "https://drive.google.com/uc?id=12-_Y5Tz0c6Qiii4FjYb77QDaHYSghcfp" }
, { "Gluosnis galiūnas", "https://drive.google.com/uc?id=1Jr9M-xZ29otmqbeXQVTCrVWJ21yQ3byz" }
, { "Vingardium leviosa", "https://drive.google.com/uc?id=1cqawBNTEWVtTvEHJee5ku58EUF_K7j3O" }


                };

                int countLT = (allQuestions_in_orderLT.Length) / 2;



                Global.Deckcounter = countLT;
                Global.DeckName = "Hario Poterio kaladė";
                Global.DeckInfo = "Kaladės informacija";
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

