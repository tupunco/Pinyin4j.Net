using System;
using System.Collections.Generic;
using System.Text;
using Net.Sourceforge.Pinyin4j.Format;

namespace Net.Sourceforge.Pinyin4j.Demo
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            // deal with Chinese sentence
            {
                HanyuPinyinOutputFormat outputFormat = new HanyuPinyinOutputFormat();
                Console.WriteLine("Chinese : 我的中国心");
                // defautlt output format
                Console.WriteLine("defautlt output format 默认输出格式");
                Console.WriteLine(PinyinHelper.ToHanyuPinyinString("我的中国心", outputFormat, ""));
                Console.WriteLine("***");

                // with seperater
                Console.WriteLine("with seperater 空白分割符");
                Console.WriteLine(PinyinHelper.ToHanyuPinyinString("我的中国心", outputFormat, " "));
                Console.WriteLine("***");

                // output uppercase
                Console.WriteLine("output uppercase 大写输出");
                outputFormat.CaseType = HanyuPinyinCaseType.UPPERCASE;
                Console.WriteLine(PinyinHelper.ToHanyuPinyinString("我的中国心", outputFormat, " "));
                Console.WriteLine("***");

                // without tone numbers or tone marks
                Console.WriteLine("without tone numbers or tone marks 无声调模式");
                outputFormat.RestoreDefault();
                outputFormat.ToneType = HanyuPinyinToneType.WITHOUT_TONE;
                Console.WriteLine(PinyinHelper.ToHanyuPinyinString("我的中国心", outputFormat, " "));
                Console.WriteLine("***");

                Console.WriteLine("'ü' 测试");
                // use u: as an alternative of 'ü'
                Console.WriteLine("use u: as an alternative of 'ü' 越女剑");
                outputFormat.RestoreDefault();
                Console.WriteLine(PinyinHelper.ToHanyuPinyinString("越女剑", outputFormat, " "));
                Console.WriteLine("***");

                // use v as an alternative of 'ü'
                Console.WriteLine("use v as an alternative of 'ü' 越女剑");
                outputFormat.VCharType = HanyuPinyinVCharType.WITH_V;
                Console.WriteLine(PinyinHelper.ToHanyuPinyinString("越女剑", outputFormat, " "));
                Console.WriteLine("***");

                // deal with combination of Chinese and non-Chinese
                Console.WriteLine("deal with combination of Chinese and non-Chinese 道琼斯指数上扬5%");
                outputFormat.RestoreDefault();
                Console.WriteLine(PinyinHelper.ToHanyuPinyinString("道琼斯指数上扬5%", outputFormat, " "));
                Console.WriteLine("***");
            }

            // deal with Chinese character
            {
                HanyuPinyinOutputFormat outputFormat = new HanyuPinyinOutputFormat();
                {
                    // single pronounciation
                    string[] pinyinArray = PinyinHelper.ToHanyuPinyinStringArray('我', outputFormat);

                    Console.WriteLine("***");
                    for (int i = 0; i < pinyinArray.Length; i++)
                    {
                        StringBuilder stringbuf = new StringBuilder();
                        stringbuf.Append("pinyin ");
                        stringbuf.Append(i);
                        stringbuf.Append(": ");
                        stringbuf.Append(pinyinArray[i]);
                        Console.WriteLine(stringbuf.ToString());
                    }
                    Console.WriteLine("***");
                }
                {
                    // multiple pronounciations
                    string[] pinyinArray = PinyinHelper.ToHanyuPinyinStringArray('中', outputFormat);

                    Console.WriteLine("***");

                    for (int i = 0; i < pinyinArray.Length; i++)
                    {
                        StringBuilder stringbuf = new StringBuilder();
                        stringbuf.Append("pinyin ");
                        stringbuf.Append(i);
                        stringbuf.Append(": ");
                        stringbuf.Append(pinyinArray[i]);
                        Console.WriteLine(stringbuf.ToString());
                    }
                    Console.WriteLine("***");
                }
            }
            //WadeGiles
            {
                Console.WriteLine("WadeGiles 拼音方案");
                Console.WriteLine(GetWadeGilesPinyinString("我的中国心"));
                Console.WriteLine(GetWadeGilesPinyinString("拼音方案"));
                Console.WriteLine(GetWadeGilesPinyinString("北京"));
                Console.WriteLine(GetWadeGilesPinyinString("台北"));
                Console.WriteLine(GetWadeGilesPinyinString("国语"));
            }
            //Yele
            {
                Console.WriteLine("Yele 拼音方案");
                Console.WriteLine(GetYelePinyinString("我的中国心"));
                Console.WriteLine(GetYelePinyinString("拼音方案"));
                Console.WriteLine(GetYelePinyinString("北京"));
                Console.WriteLine(GetYelePinyinString("台北"));
                Console.WriteLine(GetYelePinyinString("国语"));
            }
            Console.Read();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static string GetWadeGilesPinyinString(string str)
        {
            StringBuilder resultPinyinStrBuf = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                string mainPinyinStrOfChar = GetFirstWadeGilesPinyinString(str[i]);

                if (null != mainPinyinStrOfChar)
                {
                    resultPinyinStrBuf.AppendFormat("{0} ", mainPinyinStrOfChar);
                }
                else
                {
                    resultPinyinStrBuf.Append(str[i]);
                }
            }
            return resultPinyinStrBuf.ToString();
        }

        /// <summary>
        /// 耶鲁方案
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static string GetYelePinyinString(string str)
        {
            StringBuilder resultPinyinStrBuf = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                string mainPinyinStrOfChar = GetFirstYelePinyinString(str[i]);

                if (null != mainPinyinStrOfChar)
                {
                    resultPinyinStrBuf.AppendFormat("{0} ", mainPinyinStrOfChar);
                }
                else
                {
                    resultPinyinStrBuf.Append(str[i]);
                }
            }
            return resultPinyinStrBuf.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ch"></param>
        /// <returns></returns>
        private static string GetFirstWadeGilesPinyinString(char ch)
        {
            string[] pinyinStrArray = PinyinHelper.ToWadeGilesPinyinStringArray(ch);

            if ((null != pinyinStrArray) && (pinyinStrArray.Length > 0))
            {
                return pinyinStrArray[0];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 耶鲁方案
        /// </summary>
        /// <param name="ch"></param>
        /// <returns></returns>
        private static string GetFirstYelePinyinString(char ch)
        {
            string[] pinyinStrArray = PinyinHelper.ToYalePinyinStringArray(ch);

            if ((null != pinyinStrArray) && (pinyinStrArray.Length > 0))
            {
                return pinyinStrArray[0];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Pring String Array To Console
        /// </summary>
        /// <param name="strs"></param>
        private static void ConsoleStringArray(IEnumerable<string> strs)
        {
            foreach (string s in strs)
            {
                Console.Write("{0} ", s);
            }
            Console.Write("\r\n");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="strs"></param>
        private static void ConsoleStringArray(string str, IEnumerable<string> strs)
        {
            if (strs == null) throw new ArgumentNullException("strs");
            Console.Write("{0}: ", str);
            foreach (string s in strs)
            {
                Console.Write("{0} ", s);
            }
            Console.Write("\r\n");
        }
    }
}