using System;
using System.Collections.Generic;
using System.IO;

namespace Net.Sourceforge.Pinyin4j
{
    /// <summary>
    /// Manage all external resources required in PinyinHelper class.
    /// </summary>
    internal class ChineseToPinyinResource
    {
        /// <summary>
        /// Singleton Instance 
        /// </summary>
        public static readonly ChineseToPinyinResource Instance = new ChineseToPinyinResource();

        /// <summary>
        ///  A hash table contains <Unicode, HanyuPinyin> pairs
        /// </summary>
        private Dictionary<int, string> unicodeToHanyuPinyinTable = null;

        /// <summary>
        ///  Private constructor as part of the singleton pattern.
        /// </summary>
        private ChineseToPinyinResource()
        {
            initializeResource();
        }

        /// <summary>
        ///  A hash table contains <Unicode, HanyuPinyin> pairs
        /// </summary>
        private Dictionary<int, string> UnicodeToHanyuPinyinTable
        {
            get { return unicodeToHanyuPinyinTable; }
            set { unicodeToHanyuPinyinTable = value; }
        }

        /// <summary>
        /// Initialize a hash-table contains <Unicode, HanyuPinyin> pairs
        /// </summary>
        private void initializeResource()
        {
            try
            {
                string resourceName = "pinyindb.unicode_to_hanyu_pinyin.txt";

                UnicodeToHanyuPinyinTable = new Dictionary<int, string>();
                string line = string.Empty;
                string left = string.Empty;
                string right = string.Empty;
                string[] lines = new string[2];
                StreamReader reader = new StreamReader(ResourceHelper.GetResourceInputStream(resourceName));
                while ((line = reader.ReadLine()) != null)
                {
                    lines = line.Split(' ');
                    left = lines[0];
                    right = lines[1];
                    UnicodeToHanyuPinyinTable.Add(Convert.ToInt32(left, 16), right);
                }
            }
            catch (FileNotFoundException ex)
            {
                throw ex;
            }
            catch (IOException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get the unformatted Hanyu Pinyin representations of the given Chinese
        /// character in array format.
        /// </summary>
        /// <param name="ch">given Chinese character in Unicode</param>
        /// <returns>he Hanyu Pinyin strings of the given Chinese character in array 
        ///          format; return null if there is no corresponding Pinyin string.</returns>
        public string[] GetHanyuPinyinStringArray(char ch)
        {
            string pinyinRecord = GetHanyuPinyinRecordFromChar(ch);

            if (null != pinyinRecord)
            {
                int indexOfLeftBracket = pinyinRecord.IndexOf(Field.LEFT_BRACKET);
                int indexOfRightBracket = pinyinRecord.LastIndexOf(Field.RIGHT_BRACKET);

                string stripedString = pinyinRecord.Substring(indexOfLeftBracket + 1, indexOfRightBracket - 1);
                return stripedString.Split(Field.COMMA);
            }
            else
                return null; // no record found or mal-formatted record
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="record"> given record string of Hanyu Pinyin</param>
        /// <returns>return true if record is not null and record is not "none0" and
        ///          record is not mal-formatted, else return false</returns>
        private static bool IsValidRecord(string record)
        {
            string noneStr = "(none0)";

            if ((null != record) && !record.Equals(noneStr)
                && record.StartsWith(Field.LEFT_BRACKET.ToString())
                && record.EndsWith(Field.RIGHT_BRACKET.ToString()))
            {
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ch">given Chinese character in Unicode</param>
        /// <returns>corresponding Hanyu Pinyin Record in Properties file; null if no 
        ///         record found</returns>
        private string GetHanyuPinyinRecordFromChar(char ch)
        {
            // convert Chinese character to code point (integer)
            // please refer to http://www.unicode.org/glossary/#code_point
            // Another reference: http://en.wikipedia.org/wiki/Unicode
            int codePointOfChar = ch;

            //string codepointHexStr = codePointOfChar.ToString("X").ToUpper();

            // fetch from hashtable
            string foundRecord = null;
            if (UnicodeToHanyuPinyinTable.ContainsKey(codePointOfChar))
                foundRecord = UnicodeToHanyuPinyinTable[codePointOfChar];

            return IsValidRecord(foundRecord) ? foundRecord : null;
        }

        #region Nested type: Field

        /// <summary>
        ///  A class encloses common string constants used in Properties files
        ///  @author Li Min (xmlerlimin@gmail.com)
        /// </summary>
        private class Field
        {
            /// <summary>
            /// Comma
            /// </summary>
            public const char COMMA = ',';

            /// <summary>
            /// Left Bracket
            /// </summary>
            public const char LEFT_BRACKET = '(';

            /// <summary>
            /// Right Bracket
            /// </summary>
            public const char RIGHT_BRACKET = ')';
        }

        #endregion
    }
}