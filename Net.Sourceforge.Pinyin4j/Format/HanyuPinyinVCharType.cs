namespace Net.Sourceforge.Pinyin4j.Format
{
    /// <summary>
    /// Define the output format of character 'ü'
    /// 定义 'ü' 的输出格式
    /// 
    /// <p>
    /// 'ü' is a special character of Hanyu Pinyin, which can not be simply
    /// represented by English letters. In Hanyu Pinyin, such characters include 'ü',
    /// 'üe', 'üan', and 'ün'.
    /// 
    /// <p>
    /// This class provides several options for output of 'ü', which are listed
    /// below.
    /// 
    /// <table>
    /// <tr>
    /// <th>Options</th>
    /// <th>Output</th>
    /// </tr>
    /// <tr>
    /// <td>WITH_U_AND_COLON</td>
    /// <td align = "center">u:</td>
    /// </tr>
    /// <tr>
    /// <td>WITH_V</td>
    /// <td align = "center">v</td>
    /// </tr>
    /// <tr>
    /// <td>WITH_U_UNICODE</td>
    /// <td align = "center">ü</td>
    /// </tr>
    /// </table>
    /// 
    /// </summary>
    public class HanyuPinyinVCharType
    {
        /// <summary>
        /// The option indicates that the output of 'ü' is "u:"
        /// 'ü' 以 "u:" 格式输出
        /// </summary>
        public static readonly HanyuPinyinVCharType WITH_U_AND_COLON = new HanyuPinyinVCharType("WITH_U_AND_COLON");

        /// <summary>
        /// The option indicates that the output of 'ü' is "ü" in Unicode form
        /// </summary>
        public static readonly HanyuPinyinVCharType WITH_U_UNICODE = new HanyuPinyinVCharType("WITH_U_UNICODE");

        /// <summary>
        /// The option indicates that the output of 'ü' is "v"
        /// 'ü' 以 "v" 格式输出
        /// </summary>
        public static readonly HanyuPinyinVCharType WITH_V = new HanyuPinyinVCharType("WITH_V");

        /// <summary>
        /// Name
        /// </summary>
        protected string name;

        /// <summary>
        ///  Constructor
        /// </summary>
        /// <param name="name"></param>
        protected HanyuPinyinVCharType(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Name
        /// </summary>
        public string Name
        {
            get { return name; }
            // set { name = value; }
        }
    }
}