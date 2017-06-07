namespace Net.Sourceforge.Pinyin4j.Format.Exception
{
    /// <summary>
    /// An exception class indicates the wrong combination of pinyin output formats
    /// </summary>
    public class BadHanyuPinyinOutputFormatCombination : System.Exception
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="message">the exception message</param>
        public BadHanyuPinyinOutputFormatCombination(string message)
            : base(message)
        {
        }
    }
}