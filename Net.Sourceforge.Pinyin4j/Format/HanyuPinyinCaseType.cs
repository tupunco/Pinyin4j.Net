namespace Net.Sourceforge.Pinyin4j.Format
{
    /// <summary>
    /// Define the output case of Hanyu Pinyin string
    /// <p>
    /// This class provides several options for outputted cases of Hanyu Pinyin
    /// string, which are listed below. For example, Chinese character '民'
    /// </p>
    /// <table>
    /// <tr>
    /// <th>Options</th>
    /// <th>Output</th>
    /// </tr>
    /// <tr>
    /// <td>LOWERCASE</td>
    /// <td align = "center">min2</td>
    /// </tr>
    /// <tr>
    /// <td>UPPERCASE</td>
    /// <td align = "center">MIN2</td>
    /// </tr>
    /// </table>
    /// 
    /// </summary>
    public class HanyuPinyinCaseType
    {
        /// <summary>
        /// The option indicates that hanyu pinyin is outputted as lowercase letters
        /// </summary>
        public static readonly HanyuPinyinCaseType LOWERCASE = new HanyuPinyinCaseType("LOWERCASE");

        /// <summary>
        /// The option indicates that hanyu pinyin is outputted as uppercase letters
        /// </summary>
        public static readonly HanyuPinyinCaseType UPPERCASE = new HanyuPinyinCaseType("UPPERCASE");

        /// <summary>
        /// Name
        /// </summary>
        protected string name;

        /// <summary>
        ///  Constructor
        /// </summary>
        /// <param name="name">name</param>
        protected HanyuPinyinCaseType(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Name
        /// </summary>
        public string Name
        {
            get { return name; }
            //set { name = value; }
        }
    }
}