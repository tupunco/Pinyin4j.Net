using System.Text;

namespace Net.Sourceforge.Pinyin4j.WinFormDemo
{
    /// <summary>
    /// 
    /// </summary>
    internal static class PinyinMoreHelper
    {
        /// <summary>
        /// 根据不同拼音类型的拼音字符串
        /// </summary>
        /// <param name="input">指定的汉字字符串</param>
        /// <param name="pinyinType">拼音类型</param>
        /// <param name="spaceChar">分割字符串</param>
        /// <returns></returns>
        public static string GetPinyinStringByPinyinType(string input, PinyinType pinyinType, string spaceChar)
        {
            if (string.IsNullOrEmpty(input))
                return null;

            switch (pinyinType)
            {
                case PinyinType.Hanyu:
                    return
                        GetPinyinString(input, spaceChar,
                                        PinyinHelper.ToHanyuPinyinStringArray);
                case PinyinType.Wade:
                    return
                        GetPinyinString(input, spaceChar,
                                        PinyinHelper.ToWadeGilesPinyinStringArray);
                case PinyinType.MPSII:
                    return
                        GetPinyinString(input, spaceChar,
                                        PinyinHelper.ToMPS2PinyinStringArray);
                case PinyinType.Yale:
                    return
                        GetPinyinString(input, spaceChar,
                                        PinyinHelper.ToYalePinyinStringArray);
                case PinyinType.Tongyong:
                    return
                        GetPinyinString(input, spaceChar,
                                        PinyinHelper.ToTongyongPinyinStringArray);
                case PinyinType.Gwoyeu:
                    return
                        GetPinyinString(input, spaceChar,
                                        PinyinHelper.ToGwoyeuRomatzyhStringArray);
                default:
                    return
                        GetPinyinString(input, spaceChar,
                                        PinyinHelper.ToHanyuPinyinStringArray);
            }
        }

        /// <summary>
        /// 指定字符串的拼音字符串
        /// </summary>
        /// <param name="str">字符串</param>
        /// <param name="spaceChar">分割字符串</param>
        /// <param name="m">得到指定汉字的所有拼音 方法代理</param>
        /// <returns></returns>
        private static string GetPinyinString(string str, string spaceChar, ToPinyinStringArrayDelegate m)
        {
            StringBuilder resultPinyinStrBuf = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                string mainPinyinStrOfChar = GetFirstPinyinString(str[i], m);

                if (null != mainPinyinStrOfChar)
                {
                    resultPinyinStrBuf.AppendFormat("{0}{1}", mainPinyinStrOfChar, spaceChar);
                }
                else
                {
                    resultPinyinStrBuf.Append(str[i]);
                }
            }
            return resultPinyinStrBuf.ToString();
        }

        /// <summary>
        /// 得到指定汉字所有拼音的第一个拼音
        /// </summary>
        /// <param name="c">指定汉字</param>
        /// <param name="m">得到指定汉字的所有拼音 方法代理</param>
        /// <returns></returns>
        private static string GetFirstPinyinString(char c, ToPinyinStringArrayDelegate m)
        {
            string[] pinyinStrArray = m(c);

            if ((null != pinyinStrArray) && (pinyinStrArray.Length > 0))
            {
                return pinyinStrArray[0];
            }
            else
            {
                return null;
            }
        }

        #region Nested type: ToPinyinStringArrayDelegate

        /// <summary>
        /// 得到指定汉字的所有拼音 代理
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private delegate string[] ToPinyinStringArrayDelegate(char c);

        #endregion
    }

    #region 内部类

    /// <summary>
    /// 拼音类型枚举
    /// </summary>
    internal enum PinyinType
    {
        /// <summary>
        /// 汉语
        /// </summary>
        Hanyu,
        /// <summary>
        /// 威妥玛
        /// </summary>
        Wade,
        /// <summary>
        /// 国语罗马化第二式
        /// </summary>
        MPSII,
        /// <summary>
        /// 耶鲁
        /// </summary>
        Yale,
        /// <summary>
        /// 通用
        /// </summary>
        Tongyong,
        /// <summary>
        /// 国语罗马化
        /// </summary>
        Gwoyeu
    }

    #endregion
}