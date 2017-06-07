using System.Xml;

namespace Net.Sourceforge.Pinyin4j
{
    internal static class PinyinRomanizationTranslator
    {
        /// <summary>
        /// convert the given unformatted Pinyin string from source Romanization
        /// system to target Romanization system
        /// </summary>
        /// <param name="sourcePinyinStr">the given unformatted Pinyin string</param>
        /// <param name="sourcePinyinSystem">the Romanization system which is currently used by the given unformatted Pinyin string</param>
        /// <param name="targetPinyinSystem">the Romanization system that should be converted to</param>
        /// <returns>unformatted Pinyin string in target Romanization system; null if error happens</returns>
        public static string ConvertRomanizationSystem(string sourcePinyinStr,
                                                       PinyinRomanizationType sourcePinyinSystem,
                                                       PinyinRomanizationType targetPinyinSystem)
        {
            string pinyinString = TextHelper.ExtractPinyinString(sourcePinyinStr);
            string toneNumberStr = TextHelper.ExtractToneNumber(sourcePinyinStr);

            // return value
            string targetPinyinStr = null;
            try
            {
                // find the node of source Pinyin system
                string xpathQuery1 = string.Format("//{0}[text()='{1}']", sourcePinyinSystem.TagName, pinyinString);

                XmlDocument pinyinMappingDoc = PinyinRomanizationResource.Instance.PinyinMappingDoc;

                XmlNode hanyuNode = pinyinMappingDoc.SelectSingleNode(xpathQuery1);

                if (null != hanyuNode)
                {
                    // find the node of target Pinyin system
                    string xpathQuery2 = string.Format("../{0}/text()", targetPinyinSystem.TagName);
                    string targetPinyinStrWithoutToneNumber = hanyuNode.SelectSingleNode(xpathQuery2).Value;

                    targetPinyinStr = string.Format("{0}{1}", targetPinyinStrWithoutToneNumber, toneNumberStr);
                }
            }
            catch (XmlException e)
            {
                throw e;
            }

            return targetPinyinStr;
        }
    }
}