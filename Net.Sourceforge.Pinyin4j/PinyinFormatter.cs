using System;
using System.Text;
using System.Text.RegularExpressions;
using Net.Sourceforge.Pinyin4j.Format;
using Net.Sourceforge.Pinyin4j.Format.Exception;

namespace Net.Sourceforge.Pinyin4j
{
    /// <summary>
    /// Contains logic to format given Pinyin string
    /// </summary>
    internal class PinyinFormatter
    {
        /// <summary>
        /// formatted Hanyu Pinyin string
        /// </summary>
        /// <param name="pinyinStr">unformatted Hanyu Pinyin string</param>
        /// <param name="outputFormat">given format of Hanyu Pinyin</param>
        /// <returns>formatted Hanyu Pinyin string</returns>
        /// <exception cref="BadHanyuPinyinOutputFormatCombination"></exception>
        public static string FormatHanyuPinyin(string pinyinStr, HanyuPinyinOutputFormat outputFormat)
        {
            if ((HanyuPinyinToneType.WITH_TONE_MARK == outputFormat.ToneType)
                &&
                ((HanyuPinyinVCharType.WITH_V == outputFormat.VCharType) ||
                 (HanyuPinyinVCharType.WITH_U_AND_COLON == outputFormat.VCharType)))
            {
                throw new BadHanyuPinyinOutputFormatCombination("tone marks cannot be added to v or u:");
            }

            if (HanyuPinyinToneType.WITHOUT_TONE == outputFormat.ToneType)
            {
                //Using Regular Expressions
                pinyinStr = Regex.Replace(pinyinStr, "[1-5]", "");
            }
            else if (HanyuPinyinToneType.WITH_TONE_MARK == outputFormat.ToneType)
            {
                pinyinStr = pinyinStr.Replace("u:", "v");
                pinyinStr = ConvertToneNumber2ToneMark(pinyinStr);
            }

            if (HanyuPinyinVCharType.WITH_V == outputFormat.VCharType)
            {
                pinyinStr = pinyinStr.Replace("u:", "v");
            }
            else if (HanyuPinyinVCharType.WITH_U_UNICODE == outputFormat.VCharType)
            {
                pinyinStr = pinyinStr.Replace("u:", "ü");
            }

            if (HanyuPinyinCaseType.UPPERCASE == outputFormat.CaseType)
            {
                pinyinStr = pinyinStr.ToUpper();
            }
            return pinyinStr;
        }

        /// <summary>
        /// Convert tone numbers to tone marks using Unicode <br/><br/>
        /// 
        /// <b>Algorithm for determining location of tone mark</b><br/>
        /// 
        /// A simple algorithm for determining the vowel on which the tone mark
        /// appears is as follows:<br/>
        /// 
        /// <ol>
        /// <li>First, look for an "a" or an "e". If either vowel appears, it takes
        /// the tone mark. There are no possible pinyin syllables that contain both
        /// an "a" and an "e".</li>
        /// 
        /// <li>If there is no "a" or "e", look for an "ou". If "ou" appears, then
        /// the "o" takes the tone mark.</li>
        /// 
        /// <li>If none of the above cases hold, then the last vowel in the syllable
        /// takes the tone mark.</li>
        /// 
        /// </ol>
        /// </summary>
        /// <param name="pinyinStr">the ascii represention with tone numbers</param>
        /// <returns>the unicode represention with tone marks</returns>
        private static string ConvertToneNumber2ToneMark(string pinyinStr)
        {
            string lowerCasePinyinStr = pinyinStr.ToLower();

            if (TextHelper.PatternMatches(lowerCasePinyinStr, "[a-z]*[1-5]?"))
            {
                char defautlCharValue = '$';
                int defautlIndexValue = -1;

                char unmarkedVowel = defautlCharValue;
                int indexOfUnmarkedVowel = defautlIndexValue;

                char charA = 'a';
                char charE = 'e';
                string ouStr = "ou";
                string allUnmarkedVowelStr = "aeiouv";
                string allMarkedVowelStr = "āáăàaēéĕèeīíĭìiōóŏòoūúŭùuǖǘǚǜü";

                if (TextHelper.PatternMatches(lowerCasePinyinStr, "[a-z]*[1-5]"))
                {
                    int tuneNumber = (int) Char.GetNumericValue(lowerCasePinyinStr[lowerCasePinyinStr.Length - 1]);

                    int indexOfA = lowerCasePinyinStr.IndexOf(charA);
                    int indexOfE = lowerCasePinyinStr.IndexOf(charE);
                    int ouIndex = lowerCasePinyinStr.IndexOf(ouStr);

                    if (-1 != indexOfA)
                    {
                        indexOfUnmarkedVowel = indexOfA;
                        unmarkedVowel = charA;
                    }
                    else if (-1 != indexOfE)
                    {
                        indexOfUnmarkedVowel = indexOfE;
                        unmarkedVowel = charE;
                    }
                    else if (-1 != ouIndex)
                    {
                        indexOfUnmarkedVowel = ouIndex;
                        unmarkedVowel = ouStr[0];
                    }
                    else
                    {
                        for (int i = lowerCasePinyinStr.Length - 1; i >= 0; i--)
                        {
                            if (
                                TextHelper.PatternMatches(lowerCasePinyinStr[i].ToString(),
                                                          string.Format("[{0}]", allUnmarkedVowelStr)))
                            {
                                indexOfUnmarkedVowel = i;
                                unmarkedVowel = lowerCasePinyinStr[i];
                                break;
                            }
                        }
                    }

                    if ((defautlCharValue != unmarkedVowel)
                        && (defautlIndexValue != indexOfUnmarkedVowel))
                    {
                        int rowIndex = allUnmarkedVowelStr.IndexOf(unmarkedVowel);
                        int columnIndex = tuneNumber - 1;

                        int vowelLocation = rowIndex*5 + columnIndex;

                        char markedVowel = allMarkedVowelStr[vowelLocation];

                        StringBuilder resultBuffer = new StringBuilder();

                        resultBuffer.Append(lowerCasePinyinStr.Substring(0, indexOfUnmarkedVowel).Replace("v", "ü"));
                        resultBuffer.Append(markedVowel);
                        resultBuffer.Append(
                            lowerCasePinyinStr.Substring(indexOfUnmarkedVowel + 1, lowerCasePinyinStr.Length - 3).
                                Replace("v", "ü"));

                        return resultBuffer.ToString();
                    }
                    else
                        // error happens in the procedure of locating vowel
                    {
                        return lowerCasePinyinStr;
                    }
                }
                else
                    // input string has no any tune number
                {
                    // only replace v with ü (umlat) character
                    return lowerCasePinyinStr.Replace("v", "ü");
                }
            }
            else
                // bad format
            {
                return lowerCasePinyinStr;
            }
        }
    }
}