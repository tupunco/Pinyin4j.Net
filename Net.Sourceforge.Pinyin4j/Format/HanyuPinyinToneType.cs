namespace Net.Sourceforge.Pinyin4j.Format
{
    /// <summary>
    /// Define the output format of Hanyu Pinyin tones
    /// 
    /// 定义 汉语拼音声调 的输出格式
    /// <p>
    /// Chinese has four pitched tones and a "toneless" tone. They are called Píng(平,
    /// flat), Shǎng(上, rise), Qù(去, high drop), Rù(入, drop) and Qing(轻, toneless).
    /// Usually, we use 1, 2, 3, 4 and 5 to represent them.
    /// 
    /// <p>
    /// This class provides several options for output of Chinese tones, which are
    /// listed below. For example, Chinese character '打'
    /// </p>
    /// <table>
    /// <tr>
    /// <th>Options</th>
    /// <th>Output</th>
    /// </tr>
    /// <tr>
    /// <td>WITH_TONE_NUMBER</td>
    /// <td align = "center">da3</td>
    /// </tr>
    /// <tr>
    /// <td>WITHOUT_TONE</td>
    /// <td align = "center">da</td>
    /// </tr>
    /// <tr>
    /// <td>WITH_TONE_MARK</td>
    /// <td align = "center">dǎ</td>
    /// </tr>
    /// </table>
    /// 
    /// </summary>
    public class HanyuPinyinToneType
    {
        /// <summary>
        /// The option indicates that hanyu pinyin is outputted with tone marks
        /// </summary>
        public static readonly HanyuPinyinToneType WITH_TONE_MARK = new HanyuPinyinToneType("WITH_TONE_MARK");

        /// <summary>
        /// The option indicates that hanyu pinyin is outputted with tone numbers
        /// </summary>
        public static readonly HanyuPinyinToneType WITH_TONE_NUMBER = new HanyuPinyinToneType("WITH_TONE_NUMBER");

        /// <summary>
        /// The option indicates that hanyu pinyin is outputted without tone numbers
        /// or tone marks
        /// </summary>
        public static readonly HanyuPinyinToneType WITHOUT_TONE = new HanyuPinyinToneType("WITHOUT_TONE");

        /// <summary>
        /// Name
        /// </summary>
        protected string name;

        /// <summary>
        ///  Constructor
        /// </summary>
        /// <param name="name"></param>
        protected HanyuPinyinToneType(string name)
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