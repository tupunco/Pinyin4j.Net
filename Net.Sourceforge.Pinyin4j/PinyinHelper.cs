using System.Text;
using Net.Sourceforge.Pinyin4j.Format;
using Net.Sourceforge.Pinyin4j.Format.Exception;

namespace Net.Sourceforge.Pinyin4j
{
    /// <summary>
    /// A class provides several utility functions to convert Chinese characters
    /// (both Simplified and Tranditional) into various Chinese Romanization
    /// representations
    /// </summary>
    public static class PinyinHelper
    {
        /// <summary>
        /// Get all unformmatted Hanyu Pinyin presentations of a single Chinese
        /// character (both Simplified and Tranditional)
        /// 
        /// <p>
        /// For example, <br/> If the input is '间', the return will be an array with
        /// two Hanyu Pinyin strings: <br/> "jian1" <br/> "jian4" <br/> <br/> If the
        /// input is '李', the return will be an array with single Hanyu Pinyin
        /// string: <br/> "li3"
        /// </p>
        /// <p>
        /// <b>Special Note</b>: If the return is "none0", that means the input
        /// Chinese character exists in Unicode CJK talbe, however, it has no
        /// pronounciation in Chinese
        /// </p>
        /// </summary>
        /// <param name="ch">the given Chinese character</param>
        /// <returns> a String array contains all unformmatted Hanyu Pinyin  presentations with tone numbers; null for non-Chinese character</returns>
        public static string[] ToHanyuPinyinStringArray(char ch)
        {
            return GetUnformattedHanyuPinyinStringArray(ch);
        }

        /// <summary>
        /// Get all Hanyu Pinyin presentations of a single Chinese character (both
        /// Simplified and Tranditional)
        /// 
        /// <p>
        /// For example, <br/> If the input is '间', the return will be an array with
        /// two Hanyu Pinyin strings: <br/> "jian1" <br/> "jian4" <br/> <br/> If the
        /// input is '李', the return will be an array with single Hanyu Pinyin
        /// string: <br/> "li3"
        /// </p>
        /// <p>
        /// <b>Special Note</b>: If the return is "none0", that means the input
        /// Chinese character is in Unicode CJK talbe, however, it has no
        /// pronounciation in Chinese 
        /// </p>
        /// </summary>
        /// <param name="ch">the given Chinese character</param>
        /// <param name="outputFormat"> describes the desired format of returned Hanyu Pinyin String</param>
        /// <returns>a String array contains all Hanyu Pinyin presentations with tone
        ///         numbers; return null for non-Chinese character
        /// </returns>
        /// <exception cref="BadHanyuPinyinOutputFormatCombination"> if certain combination of output formats happens</exception>
        /// <see cref="HanyuPinyinOutputFormat"/>
        /// <see cref="BadHanyuPinyinOutputFormatCombination"/>
        public static string[] ToHanyuPinyinStringArray(char ch,
                                                        HanyuPinyinOutputFormat outputFormat)
        {
            return GetFormattedHanyuPinyinStringArray(ch, outputFormat);
        }

        /// <summary>
        /// Return the formatted Hanyu Pinyin representations of the given Chinese
        /// character (both in Simplified and Tranditional) in array format.
        /// </summary>
        /// <param name="ch">the given Chinese character</param>
        /// <param name="outputFormat"> Describes the desired format of returned Hanyu Pinyin string</param>
        /// <returns>The formatted Hanyu Pinyin representations of the given codepoint
        /// in array format; null if no record is found in the hashtable.
        /// </returns>
        /// <exception cref="BadHanyuPinyinOutputFormatCombination">BadHanyuPinyinOutputFormatCombination</exception>
        private static string[] GetFormattedHanyuPinyinStringArray(char ch,
                                                                   HanyuPinyinOutputFormat outputFormat)
        {
            string[] pinyinStrArray = GetUnformattedHanyuPinyinStringArray(ch);

            if (null != pinyinStrArray)
            {
                for (int i = 0; i < pinyinStrArray.Length; i++)
                {
                    pinyinStrArray[i] = PinyinFormatter.FormatHanyuPinyin(pinyinStrArray[i], outputFormat);
                }

                return pinyinStrArray;
            }
            else
                return null;
        }

        /// <summary>
        /// Delegate function
        /// </summary>
        /// <param name="ch">the given Chinese character</param>
        /// <returns>unformatted Hanyu Pinyin strings; null if the record is not found</returns>
        private static string[] GetUnformattedHanyuPinyinStringArray(char ch)
        {
            return ChineseToPinyinResource.Instance.GetHanyuPinyinStringArray(ch);
        }

        /// <summary>
        /// Get all unformmatted Tongyong Pinyin presentations of a single Chinese
        /// character (both Simplified and Tranditional)
        /// </summary>
        /// <param name="ch"> the given Chinese character</param>
        /// <returns> a String array contains all unformmatted Tongyong Pinyin
        ///         presentations with tone numbers; null for non-Chinese characte
        ///</returns>
        ///<see cref="ToHanyuPinyinStringArray(char)"/>
        public static string[] ToTongyongPinyinStringArray(char ch)
        {
            return ConvertToTargetPinyinStringArray(ch, PinyinRomanizationType.TONGYONG_PINYIN);
        }

        /// <summary>
        /// Get all unformmatted Wade-Giles presentations of a single Chinese
        /// character (both Simplified and Tranditional)
        /// </summary>
        /// <param name="ch">the given Chinese character</param>
        /// <returns>a String array contains all unformmatted Wade-Giles presentations
        ///         with tone numbers; null for non-Chinese character
        ///</returns>
        ///<see cref="ToHanyuPinyinStringArray(char)"/>
        public static string[] ToWadeGilesPinyinStringArray(char ch)
        {
            return ConvertToTargetPinyinStringArray(ch, PinyinRomanizationType.WADEGILES_PINYIN);
        }

        /// <summary>
        /// Get all unformmatted MPS2 (Mandarin Phonetic Symbols 2) presentations of
        /// a single Chinese character (both Simplified and Tranditional)
        /// </summary>
        /// <param name="ch"> the given Chinese character</param>
        /// <returns> a String array contains all unformmatted MPS2 (Mandarin Phonetic
        ///  Symbols 2) presentations with tone numbers; null for non-Chinese character
        ///</returns>
        ///<see cref="ToHanyuPinyinStringArray(char)"/>
        public static string[] ToMPS2PinyinStringArray(char ch)
        {
            return ConvertToTargetPinyinStringArray(ch, PinyinRomanizationType.MPS2_PINYIN);
        }

        /// <summary>
        /// Get all unformmatted Yale Pinyin presentations of a single Chinese
        /// character (both Simplified and Tranditional)
        /// </summary>
        /// <param name="ch"> the given Chinese character</param>
        /// <returns>a String array contains all unformmatted Yale Pinyin
        ///         presentations with tone numbers; null for non-Chinese character
        ///</returns>
        ///<see cref="ToHanyuPinyinStringArray(char)"/>
        public static string[] ToYalePinyinStringArray(char ch)
        {
            return ConvertToTargetPinyinStringArray(ch, PinyinRomanizationType.YALE_PINYIN);
        }

        /// <summary>
        /// string representations of target Chinese Romanization system
        ///        corresponding to the given Chinese character in array format;
        ///         null if error happens
        /// </summary>
        /// <param name="ch">the given Chinese character</param>
        /// <param name="targetPinyinSystem"> indicates target Chinese Romanization system should be
        ///           converted to
        /// </param>
        /// <returns></returns>
        /// <see cref="PinyinRomanizationType"/>
        private static string[] ConvertToTargetPinyinStringArray(char ch,
                                                                 PinyinRomanizationType targetPinyinSystem)
        {
            string[] hanyuPinyinStringArray = GetUnformattedHanyuPinyinStringArray(ch);

            if (null != hanyuPinyinStringArray)
            {
                string[] targetPinyinStringArray = new string[hanyuPinyinStringArray.Length];

                for (int i = 0; i < hanyuPinyinStringArray.Length; i++)
                {
                    targetPinyinStringArray[i] =
                        PinyinRomanizationTranslator.ConvertRomanizationSystem(hanyuPinyinStringArray[i],
                                                                               PinyinRomanizationType.HANYU_PINYIN,
                                                                               targetPinyinSystem);
                }

                return targetPinyinStringArray;
            }
            else
                return null;
        }

        /// <summary>
        /// Get all unformmatted Gwoyeu Romatzyh presentations of a single Chinese
        /// character (both Simplified and Tranditional)
        /// </summary>
        /// <param name="ch"> the given Chinese character</param>
        /// <returns>a String array contains all unformmatted Gwoyeu Romatzyh
        ///        presentations with tone numbers; null for non-Chinese character
        ///</returns>
        ///<see cref="ToHanyuPinyinStringArray(char)"/>
        public static string[] ToGwoyeuRomatzyhStringArray(char ch)
        {
            return ConvertToGwoyeuRomatzyhStringArray(ch);
        }

        /// <summary>
        ///  Gwoyeu Romatzyh string representations corresponding to the given
        ///         Chinese character in array format; null if error happens
        /// </summary>
        /// <param name="ch">the given Chinese character</param>
        /// <returns>Gwoyeu Romatzyh string representations corresponding to the given
        ///        Chinese character in array format; null if error happens
        /// </returns>
        /// <see cref="PinyinRomanizationType"/>
        private static string[] ConvertToGwoyeuRomatzyhStringArray(char ch)
        {
            string[] hanyuPinyinStringArray = GetUnformattedHanyuPinyinStringArray(ch);

            if (null != hanyuPinyinStringArray)
            {
                string[] targetPinyinStringArray = new string[hanyuPinyinStringArray.Length];

                for (int i = 0; i < hanyuPinyinStringArray.Length; i++)
                {
                    targetPinyinStringArray[i] =
                        GwoyeuRomatzyhTranslator.ConvertHanyuPinyinToGwoyeuRomatzyh(hanyuPinyinStringArray[i]);
                }

                return targetPinyinStringArray;
            }
            else
                return null;
        }

        /// <summary>
        /// Get a string which all Chinese characters are replaced by corresponding
        /// main (first) Hanyu Pinyin representation.
        /// 
        /// <p>
        /// <b>Special Note</b>: If the return contains "none0", that means that
        /// Chinese character is in Unicode CJK talbe, however, it has not
        /// pronounciation in Chinese. <b> This interface will be removed in next
        /// release. </b>
        /// </p>
        ///  Deprecated: DO NOT use it again because the first retrived pinyin string
        ///             may be a wrong pronouciation in a certain sentence context.
        ///             <b> This interface will be removed in next release. </b> 
        /// </summary>
        /// <param name="str">A given string contains Chinese characters</param>
        /// <param name="outputFormat">Describes the desired format of returned Hanyu Pinyin string</param>
        /// <param name="seperater">The string is appended after a Chinese character (excluding
        ///            the last Chinese character at the end of sentence). <b>Note!
        ///            Seperater will not appear after a non-Chinese character</b>
        /// </param>
        /// <returns> a String identical to the original one but all recognizable
        ///         Chinese characters are converted into main (first) Hanyu Pinyin
        ///         representation
        /// </returns>
        ///  <exception cref="BadHanyuPinyinOutputFormatCombination">BadHanyuPinyinOutputFormatCombination</exception>       
        public static string ToHanyuPinyinString(string str,
                                                 HanyuPinyinOutputFormat outputFormat, string seperater)
        {
            StringBuilder resultPinyinStrBuf = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                string mainPinyinStrOfChar = GetFirstHanyuPinyinString(str[i], outputFormat);

                if (null != mainPinyinStrOfChar)
                {
                    resultPinyinStrBuf.Append(mainPinyinStrOfChar);
                    if (i != str.Length - 1)
                    {
                        // avoid appending at the end
                        resultPinyinStrBuf.Append(seperater);
                    }
                }
                else
                {
                    resultPinyinStrBuf.Append(str[i]);
                }
            }

            return resultPinyinStrBuf.ToString();
        }

        /// <summary>
        /// Get the first Hanyu Pinyin of a Chinese character <b> This function will
        /// be removed in next release. </b>
        /// 
        /// Deprecated: DO NOT use it again because the first retrived pinyin string
        ///             may be a wrong pronouciation in a certain sentence context.
        ///             <b> This function will be removed in next release. </b>
        /// </summary>
        /// <param name="ch">The given Unicode character</param>
        /// <param name="outputFormat"> Describes the desired format of returned Hanyu Pinyin string</param>
        /// <returns>Return the first Hanyu Pinyin of given Chinese character; return
        ///  null if the input is not a Chinese character</returns>
        /// <exception cref="BadHanyuPinyinOutputFormatCombination">BadHanyuPinyinOutputFormatCombination</exception>
        private static string GetFirstHanyuPinyinString(char ch,
                                                        HanyuPinyinOutputFormat outputFormat)
        {
            string[] pinyinStrArray = GetFormattedHanyuPinyinStringArray(ch, outputFormat);

            if ((null != pinyinStrArray) && (pinyinStrArray.Length > 0))
            {
                return pinyinStrArray[0];
            }
            else
            {
                return null;
            }
        }
    }
}