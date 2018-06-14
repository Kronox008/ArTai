using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArTai.Decks
{
    class Myth
    {
        public static void SetDeckInfo()
        {
            if (Global.LanguageSelectedID == 0)
            {
                string[,] allQuestions_in_orderEN = {
                                                            { "Achilles", "https://drive.google.com/uc?id=1Ad9SoF06KWHxUwxdAbfgRf5ziNvUQmrp" }
                                                            , { "Actaeon", "https://drive.google.com/uc?id=1sEPoTBXDS94TtnY-vjNZWPsaK3aeUQ9k" }
                                                            , { "Aegis", "https://drive.google.com/uc?id=12xM7kyfI0o-CgWyyle8Oz0lnDdNdvJko" }
                                                            , { "Aetos Dios", "https://drive.google.com/uc?id=1vGQuxweix5UYX8AzNqWmFqRdxoh9Y2Vm" }
                                                            , { "Aloadae", "https://drive.google.com/uc?id=1J-xwYbuaU2siIERFNLc5up9UXn3Bq0bQ" }
                                                            , { "Amazons", "https://drive.google.com/uc?id=1STaBWob4zrAdBPhVExF6rxV5EZbuG7N-" }
                                                            , { "Ambrosia", "https://drive.google.com/uc?id=1BDUuX82osLyZApZWMjJchvpg-XOSOs8U" }
                                                            , { "Amphion", "https://drive.google.com/uc?id=1LV94gotaQ38vNVTZzgiIcBWE5Vn7IFEu" }
                                                            , { "Amphisbaena", "https://drive.google.com/uc?id=1GkPZO6IklDdjPJSffzb7IgBY-nOEt_Ee" }
                                                            , { "Aphrodite", "https://drive.google.com/uc?id=1pRq38BPih-JatmRwRWjy8wQHvK00ITkB" }
                                                            , { "Apollo", "https://drive.google.com/uc?id=1_VoBK5Kn5S78Q8QrD5r_aRPXCtV5qPVe" }
                                                            , { "Ares", "https://drive.google.com/uc?id=1zDPcjnLPgNnNjo4tyfUcfBxhkIMVG8Lq" }
                                                            , { "Argus Panoptes", "https://drive.google.com/uc?id=1JuIpAgnKiisQclRDV9HcpWggFU0Rm6YU" }
                                                            , { "Arion", "https://drive.google.com/uc?id=1EviefBggvbyw0kNADMmt8WVpss7CXnoz" }
                                                            , { "Artemis", "https://drive.google.com/uc?id=1OY2vSOQkBGAlT8wHtJ3ldSilb1B4zZjW" }
                                                            , { "Athena", "https://drive.google.com/uc?id=1Zs1ZmAMezeQVmwUP6KQrz_CQWHIfLGI7" }
                                                            , { "Atlanta", "https://drive.google.com/uc?id=1RFlGdmErdmouMtxaNkbRaiXsE1npxwTe" }
                                                            , { "Calydonian Boar", "https://drive.google.com/uc?id=1p5qteiZMchioyGDM6xN1PtNiFYfPMnME" }
                                                            , { "Campe", "https://drive.google.com/uc?id=19bi5pjbR6wNDq20x2T6ACdO8PzQ7LV47" }
                                                            , { "Centaur", "https://drive.google.com/uc?id=1FfKdNzt1Y_ioyZzj9gxXDoMeACjw40sb" }
                                                            , { "Cerberus", "https://drive.google.com/uc?id=1DnIp9XExFwAHKIWa46LMI4G2QM57PnoA" }
                                                            , { "Ceryneian Hind", "https://drive.google.com/uc?id=1eHHb1-nGzUkU9NsT_exQB5Is_c2nead0" }
                                                            , { "Charybdis", "https://drive.google.com/uc?id=1_c9__m8an2DQmmD50B6lzgIjzlQkT6ys" }
                                                            , { "Chimaera", "https://drive.google.com/uc?id=1vztHpJYAXmY8I3WMoLr_w_8lzO_6rxUH" }
                                                            , { "Chiron", "https://drive.google.com/uc?id=1jGEvV59oA4dhNR5Uuy4pWDOJeAQ6zp9g" }
                                                            , { "Chrysaor", "https://drive.google.com/uc?id=1OlbejHFAKPZ-nok5abhpMcgtl0Bmi4M_" }
                                                            , { "Cyclopes", "https://drive.google.com/uc?id=13nMuDA6NtYz2W3OoMSc7dwlsZgTwqQnZ" }
                                                            , { "Cretan Bull", "https://drive.google.com/uc?id=1hiKDCXI_08rCcpPmYkjEjq2I_d3MBrrr" }
                                                            , { "Delphyne", "https://drive.google.com/uc?id=119OUw0VnfbxJyjHn_Tf_jAEG0CwZlOmP" }
                                                            , { "Echidna", "https://drive.google.com/uc?id=1ep6g-VY66J1bOEJA7jz7pqrDgot2lZ2V" }
                                                            , { "Empusa", "https://drive.google.com/uc?id=1Kg8GUoLHhSIJ5WaWPuylIHN_ki_Xe8oK" }
                                                            , { "Erymanthian Boar", "https://drive.google.com/uc?id=1QhECQUj8CC1gN-cElsi1Wrgvwj2NSryn" }
                                                            , { "Geryon", "https://drive.google.com/uc?id=1EhY3a1KTKXKF7MBhZo_cgBWTsWdWNqnn" }
                                                            , { "Giants", "https://drive.google.com/uc?id=1AHpeLGXoZMKQQJt-1mO32UK6G-aedhdh" }
                                                            , { "Golden Fleece", "https://drive.google.com/uc?id=1wzXwiArV_fmPWVt2s9sQHXfmhBLfdCRW" }
                                                            , { "Gorgons", "https://drive.google.com/uc?id=1Hvf8LunOJYEpTPbiKZ55-P4w1XGb_1gW" }
                                                            , { "Griffin", "https://drive.google.com/uc?id=1uj5ovFvKtPVIJu21xyomqUj-D2n5Fego" }
                                                            , { "Hades", "https://drive.google.com/uc?id=14t25tOFDf_dz5cueCqxC0lurIaL0HTea" }
                                                            , { "Harpies", "https://drive.google.com/uc?id=1n7oVX4kdv0H2pcg88u3L_ZLjvjnphNMy" }
                                                            , { "Hecatoncheires", "https://drive.google.com/uc?id=1z3Rh7bYgN-0Fd69SPZ_GdK55Hpt-zCFD" }
                                                            , { "Hephaestus", "https://drive.google.com/uc?id=1pSMZDlZfi0Llb2OTCFxwDPVJbybXwQdl" }
                                                            , { "Hera", "https://drive.google.com/uc?id=1MC6ug0ZFqDEj7-j5OqDhvU_7ZggwUGdC" }
                                                            , { "Heracles", "https://drive.google.com/uc?id=1E8x4HItW14t2x6rdy2uJIA5AftiCQyjA" }
                                                            , { "Hermes", "https://drive.google.com/uc?id=1iV9wYLZCmArSlnfxRjSkN_1e2p_3Jp7T" }
                                                            , { "Hestia", "https://drive.google.com/uc?id=1QtgiD0VXP5X9bQVQ5fJ-bgNRhkQt7crN" }
                                                            , { "Ichor", "https://drive.google.com/uc?id=1TrxFa4GY5BfUlzrX4nRKngBZJPnaY1WB" }
                                                            , { "Jason", "https://drive.google.com/uc?id=1z3CnC7vXHjiU9bt35X-wAe3100P1sJ1_" }
                                                            , { "Ladon", "https://drive.google.com/uc?id=1EqwyU-iloac76EifaUSGzVNdPp6pp2Wa" }
                                                            , { "Laelaps", "https://drive.google.com/uc?id=1X6dLrZ1JnAm6N2_6mznQ-2ugMW4IFYO7" }
                                                            , { "Lamia", "https://drive.google.com/uc?id=1bvYF5GbedqX50y8H4nEW5K2zVixOOjTp" }
                                                            , { "Lernaean Hydra", "https://drive.google.com/uc?id=1d0PqAGOz6bLX1EcT_oE-518vdAsNm-cZ" }
                                                            , { "Mares of Diomedes", "https://drive.google.com/uc?id=1zh2X23aPoZ7vNrpzs8I-jj3RA0TlixSE" }
                                                            , { "Marsyas", "https://drive.google.com/uc?id=1IeKAGfh56W2hZoXEywfGqtKwYQ9QoI3M" }
                                                            , { "Medusa", "https://drive.google.com/uc?id=16xoqFYqTtYz8xIAZ2Df-PhBEDNRmhGLT" }
                                                            , { "Minos", "https://drive.google.com/uc?id=1EkSsg4kQMim3tC27PC8elY5YTR6hhCCn" }
                                                            , { "Minotaur", "https://drive.google.com/uc?id=1z07K4A_vVzJwn8BIUpJ-PojUX5cQjlx5" }
                                                            , { "Mount Olympus", "https://drive.google.com/uc?id=1iGNI2mU2SMFcIfWhFQS4Ay8dLptz1hw9" }
                                                            , { "Necklace of Harmonia", "https://drive.google.com/uc?id=1YYehYkpLwx9KDofcuGckbvy-LAbt4Uk8" }
                                                            , { "Nectar", "https://drive.google.com/uc?id=1B3PWZZWth4BeGweYwa_XMfDRh2ChUJSa" }
                                                            , { "Nemean Lion", "https://drive.google.com/uc?id=1quTUhLPFAd-Y0YNEY0HExNPwUFagrESv" }
                                                            , { "Nessus", "https://drive.google.com/uc?id=1EqcOPsQY4PyJPUVWfVxP8twngvJnjpka" }
                                                            , { "Odysseus", "https://drive.google.com/uc?id=1nMXDDadfmE7W0IKfdNlt6ZDZKp0NOyCA" }
                                                            , { "Orthrus", "https://drive.google.com/uc?id=1-6XqR3HsC5D_MDbOIMOQa9E0AZxKGNZd" }
                                                            , { "Ouroboros", "https://drive.google.com/uc?id=1EqRipnEpqRc-QJM67ce6Vg_yMnOdVL2h" }
                                                            , { "Pegasus", "https://drive.google.com/uc?id=1qcLz8-GCl-L4Vh0RLsroTjq6mz-aSoXo" }
                                                            , { "Peleus", "https://drive.google.com/uc?id=1mKSw9zkhd6w9iGy3BX_NysunN0xrS-Jw" }
                                                            , { "Perseus", "https://drive.google.com/uc?id=1pweytjLAKBbi9DEMmml6N6UoEZHCNe-N" }
                                                            , { "Phoenix", "https://drive.google.com/uc?id=17yNdUhoWODflPUted0_hEw8hJMgR3xmy" }
                                                            , { "Polyphemus", "https://drive.google.com/uc?id=1-lR5gY30MPtwpH_5UH1g5nMiPJX27RTo" }
                                                            , { "Poseidon", "https://drive.google.com/uc?id=16Af1ZWGB8HtRl7TbWbGkIZH7fqsiknig" }
                                                            , { "Scylla", "https://drive.google.com/uc?id=1dxrZ4JQX9SBCUIO1Ax0a7PGBzlEAllrK" }
                                                            , { "Shield of Achilles", "https://drive.google.com/uc?id=1fweNYq3dZJK24Y_cxuhf7gzBdCjcrDNU" }
                                                            , { "Shirt of Nessus", "https://drive.google.com/uc?id=1xmGBmuC7xxidNkKCW_3u3FSzVWTkc-Vd" }
                                                            , { "Silenus", "https://drive.google.com/uc?id=1vY0HiWtil9yzuYHfmuDmytZqf8Fonlgl" }
                                                            , { "Sirens", "https://drive.google.com/uc?id=16rty7sEo2a0HbJm79t-ROZdG3ZlPx2F9" }
                                                            , { "Sphinx", "https://drive.google.com/uc?id=1B706NkodQWKUYIM6QduQZqqeuMaoc5m7" }
                                                            , { "Stymphalian Birds", "https://drive.google.com/uc?id=1mRptvbLnvuG-bi1qf7a7EkHFJ-zZWit5" }
                                                            , { "Talos", "https://drive.google.com/uc?id=1gmSfwjEtDPszQYcKt2U4kpludZoWMj9R" }
                                                            , { "Teumessian fox", "https://drive.google.com/uc?id=1otciQ6Pz3_dMfPLAgE5CM31dNcIO36uc" }
                                                            , { "The Underworld", "https://drive.google.com/uc?id=1i01GapRSGdiGt_OpG8aDwh7hJXUMB6VD" }
                                                            , { "Theseus", "https://drive.google.com/uc?id=1OSZRRqXXmt_oxvLA_9-8j3xjOv2PYKg3" }
                                                            , { "Typhon", "https://drive.google.com/uc?id=1_M8Jm66O2kMxEUSY76CEea9QPn9hNYdF" }
                                                            , { "Troy", "https://drive.google.com/uc?id=1qVHjLD9cvZVlMoIjl5gpPv8INnoW10aC" }
                                                            , { "Zeus", "https://drive.google.com/uc?id=1KCvMFp9sJW5JTCd-7s_d81WKqb4oPJ56" }


                };

                int countEN = (allQuestions_in_orderEN.Length) / 2;



                Global.Deckcounter = countEN;
                Global.DeckName = "Mythology";
                Global.DeckInfo = "Mythology gods, characters, quotes, cities, places, items.";

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
                                                            , { "Aegis", "https://drive.google.com/uc?id=12xM7kyfI0o-CgWyyle8Oz0lnDdNdvJko" }
                                                            , { "Etonas", "https://drive.google.com/uc?id=1vGQuxweix5UYX8AzNqWmFqRdxoh9Y2Vm" }
                                                            , { "Aloadai", "https://drive.google.com/uc?id=1J-xwYbuaU2siIERFNLc5up9UXn3Bq0bQ" }
                                                            , { "Amazonės", "https://drive.google.com/uc?id=1STaBWob4zrAdBPhVExF6rxV5EZbuG7N-" }
                                                            , { "Ambrosija", "https://drive.google.com/uc?id=1BDUuX82osLyZApZWMjJchvpg-XOSOs8U" }
                                                            , { "Amfionas", "https://drive.google.com/uc?id=1LV94gotaQ38vNVTZzgiIcBWE5Vn7IFEu" }
                                                            , { "Amfisbaena ", "https://drive.google.com/uc?id=1GkPZO6IklDdjPJSffzb7IgBY-nOEt_Ee" }
                                                            , { "Afroditė", "https://drive.google.com/uc?id=1pRq38BPih-JatmRwRWjy8wQHvK00ITkB" }
                                                            , { "Apolonas", "https://drive.google.com/uc?id=1_VoBK5Kn5S78Q8QrD5r_aRPXCtV5qPVe" }
                                                            , { "Arėjas", "https://drive.google.com/uc?id=1zDPcjnLPgNnNjo4tyfUcfBxhkIMVG8Lq" }
                                                            , { "Argas", "https://drive.google.com/uc?id=1JuIpAgnKiisQclRDV9HcpWggFU0Rm6YU" }
                                                            , { "Arionas", "https://drive.google.com/uc?id=1EviefBggvbyw0kNADMmt8WVpss7CXnoz" }
                                                            , { "Artemisė", "https://drive.google.com/uc?id=1OY2vSOQkBGAlT8wHtJ3ldSilb1B4zZjW" }
                                                            , { "Atėnė", "https://drive.google.com/uc?id=1Zs1ZmAMezeQVmwUP6KQrz_CQWHIfLGI7" }
                                                            , { "Atlanta", "https://drive.google.com/uc?id=1RFlGdmErdmouMtxaNkbRaiXsE1npxwTe" }
                                                            , { "Kalidono šernas", "https://drive.google.com/uc?id=1p5qteiZMchioyGDM6xN1PtNiFYfPMnME" }
                                                            , { "Kampė", "https://drive.google.com/uc?id=19bi5pjbR6wNDq20x2T6ACdO8PzQ7LV47" }
                                                            , { "Kentauras", "https://drive.google.com/uc?id=1FfKdNzt1Y_ioyZzj9gxXDoMeACjw40sb" }
                                                            , { "Cerberis", "https://drive.google.com/uc?id=1DnIp9XExFwAHKIWa46LMI4G2QM57PnoA" }
                                                            , { "Kerinėjos stirna", "https://drive.google.com/uc?id=1eHHb1-nGzUkU9NsT_exQB5Is_c2nead0" }
                                                            , { "Charibdė", "https://drive.google.com/uc?id=1_c9__m8an2DQmmD50B6lzgIjzlQkT6ys" }
                                                            , { "Chimera", "https://drive.google.com/uc?id=1vztHpJYAXmY8I3WMoLr_w_8lzO_6rxUH" }
                                                            , { "Chironas", "https://drive.google.com/uc?id=1jGEvV59oA4dhNR5Uuy4pWDOJeAQ6zp9g" }
                                                            , { "Chrisaoras", "https://drive.google.com/uc?id=1OlbejHFAKPZ-nok5abhpMcgtl0Bmi4M_" }
                                                            , { "Ciklopas", "https://drive.google.com/uc?id=13nMuDA6NtYz2W3OoMSc7dwlsZgTwqQnZ" }
                                                            , { "Kretos bulius", "https://drive.google.com/uc?id=1hiKDCXI_08rCcpPmYkjEjq2I_d3MBrrr" }
                                                            , { "Pitonas", "https://drive.google.com/uc?id=119OUw0VnfbxJyjHn_Tf_jAEG0CwZlOmP" }
                                                            , { "Echidna", "https://drive.google.com/uc?id=1ep6g-VY66J1bOEJA7jz7pqrDgot2lZ2V" }
                                                            , { "Empusa", "https://drive.google.com/uc?id=1Kg8GUoLHhSIJ5WaWPuylIHN_ki_Xe8oK" }
                                                            , { "Erimanto šernas", "https://drive.google.com/uc?id=1QhECQUj8CC1gN-cElsi1Wrgvwj2NSryn" }
                                                            , { "Gerionas", "https://drive.google.com/uc?id=1EhY3a1KTKXKF7MBhZo_cgBWTsWdWNqnn" }
                                                            , { "Milžinai", "https://drive.google.com/uc?id=1AHpeLGXoZMKQQJt-1mO32UK6G-aedhdh" }
                                                            , { "Auksinė vilna", "https://drive.google.com/uc?id=1wzXwiArV_fmPWVt2s9sQHXfmhBLfdCRW" }
                                                            , { "Gorgonės", "https://drive.google.com/uc?id=1Hvf8LunOJYEpTPbiKZ55-P4w1XGb_1gW" }
                                                            , { "Grifai", "https://drive.google.com/uc?id=1uj5ovFvKtPVIJu21xyomqUj-D2n5Fego" }
                                                            , { "Hadas", "https://drive.google.com/uc?id=14t25tOFDf_dz5cueCqxC0lurIaL0HTea" }
                                                            , { "Harpijos", "https://drive.google.com/uc?id=1n7oVX4kdv0H2pcg88u3L_ZLjvjnphNMy" }
                                                            , { "Hekatonkheirai", "https://drive.google.com/uc?id=1z3Rh7bYgN-0Fd69SPZ_GdK55Hpt-zCFD" }
                                                            , { "Hefaistas", "https://drive.google.com/uc?id=1pSMZDlZfi0Llb2OTCFxwDPVJbybXwQdl" }
                                                            , { "Hera", "https://drive.google.com/uc?id=1MC6ug0ZFqDEj7-j5OqDhvU_7ZggwUGdC" }
                                                            , { "Heraklis", "https://drive.google.com/uc?id=1E8x4HItW14t2x6rdy2uJIA5AftiCQyjA" }
                                                            , { "Hermis", "https://drive.google.com/uc?id=1iV9wYLZCmArSlnfxRjSkN_1e2p_3Jp7T" }
                                                            , { "Hestija", "https://drive.google.com/uc?id=1QtgiD0VXP5X9bQVQ5fJ-bgNRhkQt7crN" }
                                                            , { "Limfa", "https://drive.google.com/uc?id=1TrxFa4GY5BfUlzrX4nRKngBZJPnaY1WB" }
                                                            , { "Jasonas", "https://drive.google.com/uc?id=1z3CnC7vXHjiU9bt35X-wAe3100P1sJ1_" }
                                                            , { "Ladonas", "https://drive.google.com/uc?id=1EqwyU-iloac76EifaUSGzVNdPp6pp2Wa" }
                                                            , { "Lelapas", "https://drive.google.com/uc?id=1X6dLrZ1JnAm6N2_6mznQ-2ugMW4IFYO7" }
                                                            , { "Lamija", "https://drive.google.com/uc?id=1bvYF5GbedqX50y8H4nEW5K2zVixOOjTp" }
                                                            , { "Lernos hidra", "https://drive.google.com/uc?id=1d0PqAGOz6bLX1EcT_oE-518vdAsNm-cZ" }
                                                            , { "Diomedo žirgai", "https://drive.google.com/uc?id=1zh2X23aPoZ7vNrpzs8I-jj3RA0TlixSE" }
                                                            , { "Marsijas", "https://drive.google.com/uc?id=1IeKAGfh56W2hZoXEywfGqtKwYQ9QoI3M" }
                                                            , { "Meduza", "https://drive.google.com/uc?id=16xoqFYqTtYz8xIAZ2Df-PhBEDNRmhGLT" }
                                                            , { "Minas", "https://drive.google.com/uc?id=1EkSsg4kQMim3tC27PC8elY5YTR6hhCCn" }
                                                            , { "Minotauras", "https://drive.google.com/uc?id=1z07K4A_vVzJwn8BIUpJ-PojUX5cQjlx5" }
                                                            , { "Olimpo kalnas", "https://drive.google.com/uc?id=1iGNI2mU2SMFcIfWhFQS4Ay8dLptz1hw9" }
                                                            , { "Harmonijos karoliai", "https://drive.google.com/uc?id=1YYehYkpLwx9KDofcuGckbvy-LAbt4Uk8" }
                                                            , { "Nektaras", "https://drive.google.com/uc?id=1B3PWZZWth4BeGweYwa_XMfDRh2ChUJSa" }
                                                            , { "Nemėjos liūtas", "https://drive.google.com/uc?id=1quTUhLPFAd-Y0YNEY0HExNPwUFagrESv" }
                                                            , { "Nesas", "https://drive.google.com/uc?id=1EqcOPsQY4PyJPUVWfVxP8twngvJnjpka" }
                                                            , { "Odisėjas", "https://drive.google.com/uc?id=1nMXDDadfmE7W0IKfdNlt6ZDZKp0NOyCA" }
                                                            , { "Ortras", "https://drive.google.com/uc?id=1-6XqR3HsC5D_MDbOIMOQa9E0AZxKGNZd" }
                                                            , { "Uroboras", "https://drive.google.com/uc?id=1EqRipnEpqRc-QJM67ce6Vg_yMnOdVL2h" }
                                                            , { "Pegasas", "https://drive.google.com/uc?id=1qcLz8-GCl-L4Vh0RLsroTjq6mz-aSoXo" }
                                                            , { "Pelėlas", "https://drive.google.com/uc?id=1mKSw9zkhd6w9iGy3BX_NysunN0xrS-Jw" }
                                                            , { "Persėjas", "https://drive.google.com/uc?id=1pweytjLAKBbi9DEMmml6N6UoEZHCNe-N" }
                                                            , { "Feniksas", "https://drive.google.com/uc?id=17yNdUhoWODflPUted0_hEw8hJMgR3xmy" }
                                                            , { "Polifemas", "https://drive.google.com/uc?id=1-lR5gY30MPtwpH_5UH1g5nMiPJX27RTo" }
                                                            , { "Poseidonas", "https://drive.google.com/uc?id=16Af1ZWGB8HtRl7TbWbGkIZH7fqsiknig" }
                                                            , { "Scilė", "https://drive.google.com/uc?id=1dxrZ4JQX9SBCUIO1Ax0a7PGBzlEAllrK" }
                                                            , { "Achilo skydas", "https://drive.google.com/uc?id=1fweNYq3dZJK24Y_cxuhf7gzBdCjcrDNU" }
                                                            , { "Neso marškiniai", "https://drive.google.com/uc?id=1xmGBmuC7xxidNkKCW_3u3FSzVWTkc-Vd" }
                                                            , { "Silenai", "https://drive.google.com/uc?id=1vY0HiWtil9yzuYHfmuDmytZqf8Fonlgl" }
                                                            , { "Sirenos", "https://drive.google.com/uc?id=16rty7sEo2a0HbJm79t-ROZdG3ZlPx2F9" }
                                                            , { "Sfinksas", "https://drive.google.com/uc?id=1B706NkodQWKUYIM6QduQZqqeuMaoc5m7" }
                                                            , { "Stimfalo paukščiai", "https://drive.google.com/uc?id=1mRptvbLnvuG-bi1qf7a7EkHFJ-zZWit5" }
                                                            , { "Talas", "https://drive.google.com/uc?id=1gmSfwjEtDPszQYcKt2U4kpludZoWMj9R" }
                                                            , { "Teumesijos lapė", "https://drive.google.com/uc?id=1otciQ6Pz3_dMfPLAgE5CM31dNcIO36uc" }
                                                            , { "Požemių pasaulis", "https://drive.google.com/uc?id=1i01GapRSGdiGt_OpG8aDwh7hJXUMB6VD" }
                                                            , { "Tesėjas", "https://drive.google.com/uc?id=1OSZRRqXXmt_oxvLA_9-8j3xjOv2PYKg3" }
                                                            , { "Tifonas", "https://drive.google.com/uc?id=1_M8Jm66O2kMxEUSY76CEea9QPn9hNYdF" }
                                                            , { "Troja", "https://drive.google.com/uc?id=1qVHjLD9cvZVlMoIjl5gpPv8INnoW10aC" }
                                                            , { "Dzeusas", "https://drive.google.com/uc?id=1KCvMFp9sJW5JTCd-7s_d81WKqb4oPJ56" }


                };

                int countLT = (allQuestions_in_orderLT.Length) / 2;



                Global.Deckcounter = countLT;
                Global.DeckName = "Mitologija";
                Global.DeckInfo = "Kaladės informacija";
                Randomizing.Randomize(allQuestions_in_orderLT);

            }
        }
    }
}
