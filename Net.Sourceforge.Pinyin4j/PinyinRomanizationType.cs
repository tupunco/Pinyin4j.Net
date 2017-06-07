namespace Net.Sourceforge.Pinyin4j
{
    /// <summary>
    /// The class describes variable Chinese Pinyin Romanization System
    /// 中文拼音罗马表示系统
    /// </summary>
    internal class PinyinRomanizationType
    {
        /// <summary>
        /// Gwoyeu Romatzyh system
        /// 
        /// </summary>
        public static readonly PinyinRomanizationType GWOYEU_ROMATZYH = new PinyinRomanizationType("Gwoyeu");

        /// <summary>
        /// Hanyu Pinyin system
        /// 汉语 拼音系统
        /// </summary>
        public static readonly PinyinRomanizationType HANYU_PINYIN = new PinyinRomanizationType("Hanyu");

        /// <summary>
        /// Mandarin Phonetic Symbols 2 (MPS2) Pinyin system
        /// 注音符号2(MPS2) 拼音系统
        /// </summary>
        public static readonly PinyinRomanizationType MPS2_PINYIN = new PinyinRomanizationType("MPSII");

        /// <summary>
        /// Tongyong Pinyin system
        /// 通用 拼音系统
        /// </summary>
        public static readonly PinyinRomanizationType TONGYONG_PINYIN = new PinyinRomanizationType("Tongyong");

        /// <summary>
        /// Wade-Giles Pinyin system
        /// 威妥玛 拼音系统
        /// </summary>
        public static readonly PinyinRomanizationType WADEGILES_PINYIN = new PinyinRomanizationType("Wade");

        /// <summary>
        /// Yale Pinyin system
        /// 耶鲁 拼音系统
        /// </summary>
        public static readonly PinyinRomanizationType YALE_PINYIN = new PinyinRomanizationType("Yale");

        protected string tagName;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="tagName"></param>
        protected PinyinRomanizationType(string tagName)
        {
            this.tagName = tagName;
        }

        /// <summary>
        /// TagName
        /// </summary>
        public string TagName
        {
            get { return tagName; }
            //set { tagName = value; }
        }
    }
}