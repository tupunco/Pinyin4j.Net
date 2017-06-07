using System.Xml;

namespace Net.Sourceforge.Pinyin4j
{
    /// <summary>
    ///  A class contains logic that translates from Hanyu Pinyin to Gwoyeu Romatzyh
    /// </summary>
    internal class GwoyeuRomatzyhTranslator
    {
        /// <summary>
        /// The postfixs to distinguish different tone of Gwoyeu Romatzyh
        /// <i>Should be removed if new xPath parser supporting tag name with number.</i>
        /// </summary>
        private static readonly string[] tones = new string[] {"_I", "_II", "_III", "_IV", "_V"};

        /// <summary>
        /// Corresponding Gwoyeu Romatzyh; null if no mapping is found
        /// </summary>
        /// <param name="hanyuPinyinStr">Given unformatted Hanyu Pinyin with tone number</param>
        /// <returns>Corresponding Gwoyeu Romatzyh; null if no mapping is found</returns>
        public static string ConvertHanyuPinyinToGwoyeuRomatzyh(string hanyuPinyinStr)
        {
            string pinyinString = TextHelper.ExtractPinyinString(hanyuPinyinStr);
            string toneNumberStr = TextHelper.ExtractToneNumber(hanyuPinyinStr);

            // return value
            string gwoyeuStr = null;
            try
            {
                // find the node of source Pinyin system
                string xpathQuery1 =
                    string.Format("//{0}[text()='{1}']", PinyinRomanizationType.HANYU_PINYIN.TagName, pinyinString);
                XmlDocument pinyinToGwoyeuMappingDoc = GwoyeuRomatzyhResource.Instance.PinyinToGwoyeuMappingDoc;
                XmlNode hanyuNode = pinyinToGwoyeuMappingDoc.SelectSingleNode(xpathQuery1);

                if (null != hanyuNode)
                {
                    // find the node of target Pinyin system
                    string xpathQuery2 =
                        string.Format("../{0}{1}/text()", PinyinRomanizationType.GWOYEU_ROMATZYH.TagName,
                                      tones[int.Parse(toneNumberStr) - 1]);
                    string targetPinyinStrWithoutToneNumber = hanyuNode.SelectSingleNode(xpathQuery2).Value;

                    gwoyeuStr = targetPinyinStrWithoutToneNumber;
                }
            }
            catch (XmlException e)
            {
                throw e;
            }

            return gwoyeuStr;
        }
    }
}