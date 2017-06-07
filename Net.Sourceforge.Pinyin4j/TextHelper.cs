using System.Text.RegularExpressions;

namespace Net.Sourceforge.Pinyin4j
{
    /// <summary>
    /// Contains the utility functions supporting text processing
    /// </summary>
    internal static class TextHelper
    {
        /// <summary>
        /// Hanyu Pinyin string without tone number
        /// </summary>
        /// <param name="hanyuPinyinWithToneNumber">hanyuPinyinWithToneNumber</param>
        /// <returns>Hanyu Pinyin string without tone number</returns>
        public static string ExtractToneNumber(string hanyuPinyinWithToneNumber)
        {
            return hanyuPinyinWithToneNumber.Substring(hanyuPinyinWithToneNumber.Length - 1);
        }

        /// <summary>
        /// only tone number
        /// </summary>
        /// <param name="hanyuPinyinWithToneNumber">hanyuPinyinWithToneNumber</param>
        /// <returns>only tone number</returns>
        public static string ExtractPinyinString(string hanyuPinyinWithToneNumber)
        {
            return hanyuPinyinWithToneNumber.Substring(0, hanyuPinyinWithToneNumber.Length - 1);
        }

        /// <summary>
        /// Regex.IsMatch
        /// </summary>
        /// <param name="regex"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool PatternMatches(string input, string regex)
        {
            return Regex.IsMatch(input, regex);
        }
    }
}