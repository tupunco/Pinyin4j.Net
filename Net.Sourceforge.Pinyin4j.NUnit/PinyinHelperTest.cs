using Net.Sourceforge.Pinyin4j.Format;
using Net.Sourceforge.Pinyin4j.Format.Exception;
using NUnit.Framework;

namespace Net.Sourceforge.Pinyin4j.NUnit
{
    /// <summary>
    /// 
    /// </summary>
    [TestFixture]
    public class PinyinHelperTest
    {
        [Test]
        public void testToTongyongPinyinStringArray()
        {
            // any input of non-Chinese characters will return null
            {
                Assert.IsNull(PinyinHelper.ToTongyongPinyinStringArray('A'));
                Assert.IsNull(PinyinHelper.ToTongyongPinyinStringArray('z'));
                Assert.IsNull(PinyinHelper.ToTongyongPinyinStringArray(','));
                Assert.IsNull(PinyinHelper.ToTongyongPinyinStringArray('。'));
            }

            // Chinese characters
            // single pronounciation
            {
                string[] expectedPinyinArray = new string[] {"li3"};
                string[] pinyinArray = PinyinHelper.ToTongyongPinyinStringArray('李');

                Assert.AreEqual(expectedPinyinArray.Length, pinyinArray.Length);

                for (int i = 0; i < expectedPinyinArray.Length; i++)
                {
                    Assert.AreEqual(expectedPinyinArray[i], pinyinArray[i]);
                }
            }
            {
                string[] expectedPinyinArray = new string[] {"ciou2"};
                string[] pinyinArray = PinyinHelper.ToTongyongPinyinStringArray('球');

                Assert.AreEqual(expectedPinyinArray.Length, pinyinArray.Length);

                for (int i = 0; i < expectedPinyinArray.Length; i++)
                {
                    Assert.AreEqual(expectedPinyinArray[i], pinyinArray[i]);
                }
            }
            {
                string[] expectedPinyinArray = new string[] {"jhuang1"};
                string[] pinyinArray = PinyinHelper.ToTongyongPinyinStringArray('桩');

                Assert.AreEqual(expectedPinyinArray.Length, pinyinArray.Length);

                for (int i = 0; i < expectedPinyinArray.Length; i++)
                {
                    Assert.AreEqual(expectedPinyinArray[i], pinyinArray[i]);
                }
            }

            // multiple pronounciations
            {
                string[] expectedPinyinArray = new string[] {"chuan2", "jhuan4"};
                string[] pinyinArray = PinyinHelper.ToTongyongPinyinStringArray('传');

                Assert.AreEqual(expectedPinyinArray.Length, pinyinArray.Length);

                for (int i = 0; i < expectedPinyinArray.Length; i++)
                {
                    Assert.AreEqual(expectedPinyinArray[i], pinyinArray[i]);
                }
            }

            {
                string[] expectedPinyinArray = new string[] {"lyu4", "lu4"};
                string[] pinyinArray = PinyinHelper.ToTongyongPinyinStringArray('绿');

                Assert.AreEqual(expectedPinyinArray.Length, pinyinArray.Length);

                for (int i = 0; i < expectedPinyinArray.Length; i++)
                {
                    Assert.AreEqual(expectedPinyinArray[i], pinyinArray[i]);
                }
            }
        }

        [Test]
        public void testToWadeGilesPinyinStringArray()
        {
            // any input of non-Chinese characters will return null
            {
                Assert.IsNull(PinyinHelper.ToWadeGilesPinyinStringArray('A'));
                Assert.IsNull(PinyinHelper.ToWadeGilesPinyinStringArray('z'));
                Assert.IsNull(PinyinHelper.ToWadeGilesPinyinStringArray(','));
                Assert.IsNull(PinyinHelper.ToWadeGilesPinyinStringArray('。'));
            }

            // Chinese characters
            // single pronounciation
            {
                string[] expectedPinyinArray = new string[] {"li3"};
                string[] pinyinArray = PinyinHelper.ToWadeGilesPinyinStringArray('李');

                Assert.AreEqual(expectedPinyinArray.Length, pinyinArray.Length);

                for (int i = 0; i < expectedPinyinArray.Length; i++)
                {
                    Assert.AreEqual(expectedPinyinArray[i], pinyinArray[i]);
                }
            }
            {
                string[] expectedPinyinArray = new string[] {"ch`iu2"};
                string[] pinyinArray = PinyinHelper.ToWadeGilesPinyinStringArray('球');

                Assert.AreEqual(expectedPinyinArray.Length, pinyinArray.Length);

                for (int i = 0; i < expectedPinyinArray.Length; i++)
                {
                    Assert.AreEqual(expectedPinyinArray[i], pinyinArray[i]);
                }
            }
            {
                string[] expectedPinyinArray = new string[] {"chuang1"};
                string[] pinyinArray = PinyinHelper.ToWadeGilesPinyinStringArray('桩');

                Assert.AreEqual(expectedPinyinArray.Length, pinyinArray.Length);

                for (int i = 0; i < expectedPinyinArray.Length; i++)
                {
                    Assert.AreEqual(expectedPinyinArray[i], pinyinArray[i]);
                }
            }

            // multiple pronounciations
            {
                string[] expectedPinyinArray = new string[] {"ch`uan2", "chuan4"};
                string[] pinyinArray = PinyinHelper.ToWadeGilesPinyinStringArray('传');

                Assert.AreEqual(expectedPinyinArray.Length, pinyinArray.Length);

                for (int i = 0; i < expectedPinyinArray.Length; i++)
                {
                    Assert.AreEqual(expectedPinyinArray[i], pinyinArray[i]);
                }
            }

            {
                string[] expectedPinyinArray = new string[] {"lu:4", "lu4"};
                string[] pinyinArray = PinyinHelper.ToWadeGilesPinyinStringArray('绿');

                Assert.AreEqual(expectedPinyinArray.Length, pinyinArray.Length);

                for (int i = 0; i < expectedPinyinArray.Length; i++)
                {
                    Assert.AreEqual(expectedPinyinArray[i], pinyinArray[i]);
                }
            }
        }

        [Test]
        public void testToMPS2PinyinStringArray()
        {
            // any input of non-Chinese characters will return null
            {
                Assert.IsNull(PinyinHelper.ToMPS2PinyinStringArray('A'));
                Assert.IsNull(PinyinHelper.ToMPS2PinyinStringArray('z'));
                Assert.IsNull(PinyinHelper.ToMPS2PinyinStringArray(','));
                Assert.IsNull(PinyinHelper.ToMPS2PinyinStringArray('。'));
            }

            // Chinese characters
            // single pronounciation
            {
                string[] expectedPinyinArray = new string[] {"li3"};
                string[] pinyinArray = PinyinHelper.ToMPS2PinyinStringArray('李');

                Assert.AreEqual(expectedPinyinArray.Length, pinyinArray.Length);

                for (int i = 0; i < expectedPinyinArray.Length; i++)
                {
                    Assert.AreEqual(expectedPinyinArray[i], pinyinArray[i]);
                }
            }
            {
                string[] expectedPinyinArray = new string[] {"chiou2"};
                string[] pinyinArray = PinyinHelper.ToMPS2PinyinStringArray('球');

                Assert.AreEqual(expectedPinyinArray.Length, pinyinArray.Length);

                for (int i = 0; i < expectedPinyinArray.Length; i++)
                {
                    Assert.AreEqual(expectedPinyinArray[i], pinyinArray[i]);
                }
            }
            {
                string[] expectedPinyinArray = new string[] {"juang1"};
                string[] pinyinArray = PinyinHelper.ToMPS2PinyinStringArray('桩');

                Assert.AreEqual(expectedPinyinArray.Length, pinyinArray.Length);

                for (int i = 0; i < expectedPinyinArray.Length; i++)
                {
                    Assert.AreEqual(expectedPinyinArray[i], pinyinArray[i]);
                }
            }

            // multiple pronounciations
            {
                string[] expectedPinyinArray = new string[] {"chuan2", "juan4"};
                string[] pinyinArray = PinyinHelper.ToMPS2PinyinStringArray('传');

                Assert.AreEqual(expectedPinyinArray.Length, pinyinArray.Length);

                for (int i = 0; i < expectedPinyinArray.Length; i++)
                {
                    Assert.AreEqual(expectedPinyinArray[i], pinyinArray[i]);
                }
            }

            {
                string[] expectedPinyinArray = new string[] {"liu4", "lu4"};
                string[] pinyinArray = PinyinHelper.ToMPS2PinyinStringArray('绿');

                Assert.AreEqual(expectedPinyinArray.Length, pinyinArray.Length);

                for (int i = 0; i < expectedPinyinArray.Length; i++)
                {
                    Assert.AreEqual(expectedPinyinArray[i], pinyinArray[i]);
                }
            }
        }

        [Test]
        public void testToYalePinyinStringArray()
        {
            // any input of non-Chinese characters will return null
            {
                Assert.IsNull(PinyinHelper.ToYalePinyinStringArray('A'));
                Assert.IsNull(PinyinHelper.ToYalePinyinStringArray('z'));
                Assert.IsNull(PinyinHelper.ToYalePinyinStringArray(','));
                Assert.IsNull(PinyinHelper.ToYalePinyinStringArray('。'));
            }

            // Chinese characters
            // single pronounciation
            {
                string[] expectedPinyinArray = new string[] {"li3"};
                string[] pinyinArray = PinyinHelper.ToYalePinyinStringArray('李');

                Assert.AreEqual(expectedPinyinArray.Length, pinyinArray.Length);

                for (int i = 0; i < expectedPinyinArray.Length; i++)
                {
                    Assert.AreEqual(expectedPinyinArray[i], pinyinArray[i]);
                }
            }
            {
                string[] expectedPinyinArray = new string[] {"chyou2"};
                string[] pinyinArray = PinyinHelper.ToYalePinyinStringArray('球');

                Assert.AreEqual(expectedPinyinArray.Length, pinyinArray.Length);

                for (int i = 0; i < expectedPinyinArray.Length; i++)
                {
                    Assert.AreEqual(expectedPinyinArray[i], pinyinArray[i]);
                }
            }
            {
                string[] expectedPinyinArray = new string[] {"jwang1"};
                string[] pinyinArray = PinyinHelper.ToYalePinyinStringArray('桩');

                Assert.AreEqual(expectedPinyinArray.Length, pinyinArray.Length);

                for (int i = 0; i < expectedPinyinArray.Length; i++)
                {
                    Assert.AreEqual(expectedPinyinArray[i], pinyinArray[i]);
                }
            }

            // multiple pronounciations
            {
                string[] expectedPinyinArray = new string[] {"chwan2", "jwan4"};
                string[] pinyinArray = PinyinHelper.ToYalePinyinStringArray('传');

                Assert.AreEqual(expectedPinyinArray.Length, pinyinArray.Length);

                for (int i = 0; i < expectedPinyinArray.Length; i++)
                {
                    Assert.AreEqual(expectedPinyinArray[i], pinyinArray[i]);
                }
            }

            {
                string[] expectedPinyinArray = new string[] {"lyu4", "lu4"};
                string[] pinyinArray = PinyinHelper.ToYalePinyinStringArray('绿');

                Assert.AreEqual(expectedPinyinArray.Length, pinyinArray.Length);

                for (int i = 0; i < expectedPinyinArray.Length; i++)
                {
                    Assert.AreEqual(expectedPinyinArray[i], pinyinArray[i]);
                }
            }
        }

        [Test]
        public void testToGwoyeuRomatzyhStringArray()
        {
            // any input of non-Chinese characters will return null
            {
                Assert.IsNull(PinyinHelper.ToGwoyeuRomatzyhStringArray('A'));
                Assert.IsNull(PinyinHelper.ToGwoyeuRomatzyhStringArray('z'));
                Assert.IsNull(PinyinHelper.ToGwoyeuRomatzyhStringArray(','));
                Assert.IsNull(PinyinHelper.ToGwoyeuRomatzyhStringArray('。'));
            }

            // Chinese characters
            // single pronounciation
            {
                string[] expectedPinyinArray = new string[] {"lii"};
                string[] pinyinArray = PinyinHelper.ToGwoyeuRomatzyhStringArray('李');

                Assert.AreEqual(expectedPinyinArray.Length, pinyinArray.Length);

                for (int i = 0; i < expectedPinyinArray.Length; i++)
                {
                    Assert.AreEqual(expectedPinyinArray[i], pinyinArray[i]);
                }
            }
            {
                string[] expectedPinyinArray = new string[] {"chyou"};
                string[] pinyinArray = PinyinHelper.ToGwoyeuRomatzyhStringArray('球');

                Assert.AreEqual(expectedPinyinArray.Length, pinyinArray.Length);

                for (int i = 0; i < expectedPinyinArray.Length; i++)
                {
                    Assert.AreEqual(expectedPinyinArray[i], pinyinArray[i]);
                }
            }
            {
                string[] expectedPinyinArray = new string[] {"juang"};
                string[] pinyinArray = PinyinHelper.ToGwoyeuRomatzyhStringArray('桩');

                Assert.AreEqual(expectedPinyinArray.Length, pinyinArray.Length);

                for (int i = 0; i < expectedPinyinArray.Length; i++)
                {
                    Assert.AreEqual(expectedPinyinArray[i], pinyinArray[i]);
                }
            }

            {
                string[] expectedPinyinArray = new string[] {"fuh"};
                string[] pinyinArray = PinyinHelper.ToGwoyeuRomatzyhStringArray('付');

                Assert.AreEqual(expectedPinyinArray.Length, pinyinArray.Length);

                for (int i = 0; i < expectedPinyinArray.Length; i++)
                {
                    Assert.AreEqual(expectedPinyinArray[i], pinyinArray[i]);
                }
            }

            // multiple pronounciations
            {
                string[] expectedPinyinArray = new string[] {"chwan", "juann"};
                string[] pinyinArray = PinyinHelper.ToGwoyeuRomatzyhStringArray('传');

                Assert.AreEqual(expectedPinyinArray.Length, pinyinArray.Length);

                for (int i = 0; i < expectedPinyinArray.Length; i++)
                {
                    Assert.AreEqual(expectedPinyinArray[i], pinyinArray[i]);
                }
            }

            {
                string[] expectedPinyinArray = new string[] {".me", ".mha", "iau"};
                string[] pinyinArray = PinyinHelper.ToGwoyeuRomatzyhStringArray('么');

                Assert.AreEqual(expectedPinyinArray.Length, pinyinArray.Length);

                for (int i = 0; i < expectedPinyinArray.Length; i++)
                {
                    Assert.AreEqual(expectedPinyinArray[i], pinyinArray[i]);
                }
            }

            {
                string[] expectedPinyinArray = new string[] {"liuh", "luh"};
                string[] pinyinArray = PinyinHelper.ToGwoyeuRomatzyhStringArray('绿');

                Assert.AreEqual(expectedPinyinArray.Length, pinyinArray.Length);

                for (int i = 0; i < expectedPinyinArray.Length; i++)
                {
                    Assert.AreEqual(expectedPinyinArray[i], pinyinArray[i]);
                }
            }
        }

        [Test]
        public void testToHanyuPinyinStringArray()
        {
            // any input of non-Chinese characters will return null
            {
                HanyuPinyinOutputFormat defaultFormat = new HanyuPinyinOutputFormat();
                try
                {
                    Assert.IsNull(PinyinHelper.ToHanyuPinyinStringArray('A', defaultFormat));
                    Assert.IsNull(PinyinHelper.ToHanyuPinyinStringArray('z', defaultFormat));
                    Assert.IsNull(PinyinHelper.ToHanyuPinyinStringArray(',', defaultFormat));
                    Assert.IsNull(PinyinHelper.ToHanyuPinyinStringArray('。', defaultFormat));
                }
                catch (BadHanyuPinyinOutputFormatCombination e)
                {
                    throw e;
                }
            }

            // Chinese characters
            // single pronounciation
            {
                try
                {
                    HanyuPinyinOutputFormat defaultFormat = new HanyuPinyinOutputFormat();

                    string[] expectedPinyinArray = new string[] {"li3"};
                    string[] pinyinArray = PinyinHelper.ToHanyuPinyinStringArray('李', defaultFormat);

                    Assert.AreEqual(expectedPinyinArray.Length, pinyinArray.Length);

                    for (int i = 0; i < expectedPinyinArray.Length; i++)
                    {
                        Assert.AreEqual(expectedPinyinArray[i], pinyinArray[i]);
                    }
                }
                catch (BadHanyuPinyinOutputFormatCombination e)
                {
                    throw e;
                }
            }
            {
                try
                {
                    HanyuPinyinOutputFormat upperCaseFormat = new HanyuPinyinOutputFormat();
                    upperCaseFormat.CaseType = HanyuPinyinCaseType.UPPERCASE;

                    string[] expectedPinyinArray = new string[] {"LI3"};
                    string[] pinyinArray = PinyinHelper.ToHanyuPinyinStringArray('李', upperCaseFormat);

                    Assert.AreEqual(expectedPinyinArray.Length, pinyinArray.Length);

                    for (int i = 0; i < expectedPinyinArray.Length; i++)
                    {
                        Assert.AreEqual(expectedPinyinArray[i], pinyinArray[i]);
                    }
                }
                catch (BadHanyuPinyinOutputFormatCombination e)
                {
                    throw e;
                }
            }
            {
                try
                {
                    HanyuPinyinOutputFormat defaultFormat = new HanyuPinyinOutputFormat();

                    string[] expectedPinyinArray = new string[] {"lu:3"};
                    string[] pinyinArray = PinyinHelper.ToHanyuPinyinStringArray('吕', defaultFormat);

                    Assert.AreEqual(expectedPinyinArray.Length, pinyinArray.Length);

                    for (int i = 0; i < expectedPinyinArray.Length; i++)
                    {
                        Assert.AreEqual(expectedPinyinArray[i], pinyinArray[i]);
                    }
                }
                catch (BadHanyuPinyinOutputFormatCombination e)
                {
                    throw e;
                }
            }
            {
                try
                {
                    HanyuPinyinOutputFormat vCharFormat = new HanyuPinyinOutputFormat();
                    vCharFormat.VCharType = HanyuPinyinVCharType.WITH_V;

                    string[] expectedPinyinArray = new string[] {"lv3"};
                    string[] pinyinArray = PinyinHelper.ToHanyuPinyinStringArray('吕', vCharFormat);

                    Assert.AreEqual(expectedPinyinArray.Length, pinyinArray.Length);

                    for (int i = 0; i < expectedPinyinArray.Length; i++)
                    {
                        Assert.AreEqual(expectedPinyinArray[i], pinyinArray[i]);
                    }
                }
                catch (BadHanyuPinyinOutputFormatCombination e)
                {
                    throw e;
                }
            }

            // multiple pronounciations
            {
                try
                {
                    HanyuPinyinOutputFormat defaultFormat = new HanyuPinyinOutputFormat();

                    string[] expectedPinyinArray = new string[] {"jian1", "jian4"};
                    string[] pinyinArray = PinyinHelper.ToHanyuPinyinStringArray('间', defaultFormat);

                    Assert.AreEqual(expectedPinyinArray.Length, pinyinArray.Length);

                    for (int i = 0; i < expectedPinyinArray.Length; i++)
                    {
                        Assert.AreEqual(expectedPinyinArray[i], pinyinArray[i]);
                    }
                }
                catch (BadHanyuPinyinOutputFormatCombination e)
                {
                    throw e;
                }
            }

            {
                try
                {
                    HanyuPinyinOutputFormat defaultFormat = new HanyuPinyinOutputFormat();

                    string[] expectedPinyinArray = new string[] {"hao3", "hao4"};
                    string[] pinyinArray = PinyinHelper.ToHanyuPinyinStringArray('好', defaultFormat);

                    Assert.AreEqual(expectedPinyinArray.Length, pinyinArray.Length);

                    for (int i = 0; i < expectedPinyinArray.Length; i++)
                    {
                        Assert.AreEqual(expectedPinyinArray[i], pinyinArray[i]);
                    }
                }
                catch (BadHanyuPinyinOutputFormatCombination e)
                {
                    throw e;
                }
            }
        }

        /**
         * test for combination of output formats
         */

        [Test]
        public void testOutputCombination()
        {
            try
            {
                HanyuPinyinOutputFormat outputFormat = new HanyuPinyinOutputFormat();

                // fix case type to lowercase firstly, change VChar and Tone
                // combination
                outputFormat.CaseType = HanyuPinyinCaseType.LOWERCASE;

                // WITH_U_AND_COLON and WITH_TONE_NUMBER
                outputFormat.VCharType = HanyuPinyinVCharType.WITH_U_AND_COLON;
                outputFormat.ToneType = HanyuPinyinToneType.WITH_TONE_NUMBER;

                Assert.AreEqual("lu:3", PinyinHelper.ToHanyuPinyinStringArray('吕', outputFormat)[0]);

                // WITH_V and WITH_TONE_NUMBER
                outputFormat.VCharType = HanyuPinyinVCharType.WITH_V;
                outputFormat.ToneType = HanyuPinyinToneType.WITH_TONE_NUMBER;

                Assert.AreEqual("lv3", PinyinHelper.ToHanyuPinyinStringArray('吕', outputFormat)[0]);

                // WITH_U_UNICODE and WITH_TONE_NUMBER
                outputFormat.VCharType = HanyuPinyinVCharType.WITH_U_UNICODE;
                outputFormat.ToneType = HanyuPinyinToneType.WITH_TONE_NUMBER;

                Assert.AreEqual("lü3", PinyinHelper.ToHanyuPinyinStringArray('吕', outputFormat)[0]);

                // // WITH_U_AND_COLON and WITHOUT_TONE
                outputFormat.VCharType = HanyuPinyinVCharType.WITH_U_AND_COLON;
                outputFormat.ToneType = HanyuPinyinToneType.WITHOUT_TONE;

                Assert.AreEqual("lu:", PinyinHelper.ToHanyuPinyinStringArray('吕', outputFormat)[0]);

                // WITH_V and WITHOUT_TONE
                outputFormat.VCharType = HanyuPinyinVCharType.WITH_V;
                outputFormat.ToneType = HanyuPinyinToneType.WITHOUT_TONE;

                Assert.AreEqual("lv", PinyinHelper.ToHanyuPinyinStringArray('吕', outputFormat)[0]);

                // WITH_U_UNICODE and WITHOUT_TONE
                outputFormat.VCharType = HanyuPinyinVCharType.WITH_U_UNICODE;
                outputFormat.ToneType = HanyuPinyinToneType.WITHOUT_TONE;

                Assert.AreEqual("lü", PinyinHelper.ToHanyuPinyinStringArray('吕', outputFormat)[0]);

                // WITH_U_AND_COLON and WITH_TONE_MARK is forbidden

                // WITH_V and WITH_TONE_MARK is forbidden

                // WITH_U_UNICODE and WITH_TONE_MARK
                outputFormat.VCharType = HanyuPinyinVCharType.WITH_U_UNICODE;
                outputFormat.ToneType = HanyuPinyinToneType.WITH_TONE_MARK;

                Assert.AreEqual("lǚ", PinyinHelper.ToHanyuPinyinStringArray('吕', outputFormat)[0]);

                // fix case type to UPPERCASE, change VChar and Tone
                // combination
                outputFormat.CaseType = HanyuPinyinCaseType.UPPERCASE;

                // WITH_U_AND_COLON and WITH_TONE_NUMBER
                outputFormat.VCharType = HanyuPinyinVCharType.WITH_U_AND_COLON;
                outputFormat.ToneType = HanyuPinyinToneType.WITH_TONE_NUMBER;

                Assert.AreEqual("LU:3", PinyinHelper.ToHanyuPinyinStringArray('吕', outputFormat)[0]);

                // WITH_V and WITH_TONE_NUMBER
                outputFormat.VCharType = HanyuPinyinVCharType.WITH_V;
                outputFormat.ToneType = HanyuPinyinToneType.WITH_TONE_NUMBER;

                Assert.AreEqual("LV3", PinyinHelper.ToHanyuPinyinStringArray('吕', outputFormat)[0]);

                // WITH_U_UNICODE and WITH_TONE_NUMBER
                outputFormat.VCharType = HanyuPinyinVCharType.WITH_U_UNICODE;
                outputFormat.ToneType = HanyuPinyinToneType.WITH_TONE_NUMBER;

                Assert.AreEqual("LÜ3", PinyinHelper.ToHanyuPinyinStringArray('吕', outputFormat)[0]);

                // // WITH_U_AND_COLON and WITHOUT_TONE
                outputFormat.VCharType = HanyuPinyinVCharType.WITH_U_AND_COLON;
                outputFormat.ToneType = HanyuPinyinToneType.WITHOUT_TONE;

                Assert.AreEqual("LU:", PinyinHelper.ToHanyuPinyinStringArray('吕', outputFormat)[0]);

                // WITH_V and WITHOUT_TONE
                outputFormat.VCharType = HanyuPinyinVCharType.WITH_V;
                outputFormat.ToneType = HanyuPinyinToneType.WITHOUT_TONE;

                Assert.AreEqual("LV", PinyinHelper.ToHanyuPinyinStringArray('吕', outputFormat)[0]);

                // WITH_U_UNICODE and WITHOUT_TONE
                outputFormat.VCharType = HanyuPinyinVCharType.WITH_U_UNICODE;
                outputFormat.ToneType = HanyuPinyinToneType.WITHOUT_TONE;

                Assert.AreEqual("LÜ", PinyinHelper.ToHanyuPinyinStringArray('吕', outputFormat)[0]);

                // WITH_U_AND_COLON and WITH_TONE_MARK is forbidden

                // WITH_V and WITH_TONE_MARK is forbidden

                // WITH_U_UNICODE and WITH_TONE_MARK
                outputFormat.VCharType = HanyuPinyinVCharType.WITH_U_UNICODE;
                outputFormat.ToneType = HanyuPinyinToneType.WITH_TONE_MARK;

                Assert.AreEqual("LǙ", PinyinHelper.ToHanyuPinyinStringArray('吕', outputFormat)[0]);
            }
            catch (BadHanyuPinyinOutputFormatCombination e)
            {
                throw e;
            }
        }
    }
}