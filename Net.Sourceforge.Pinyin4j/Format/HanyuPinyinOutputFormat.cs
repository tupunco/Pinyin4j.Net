namespace Net.Sourceforge.Pinyin4j.Format
{
    /// <summary>
    /// This classes define how the Hanyu Pinyin should be outputted.
    /// 
    /// 本类定义 汉语拼音 应当怎样输出
    /// <p>
    /// The output feature includes:</p>
    /// <ul>
    /// <li>Output format of character 'ü';</li>
    /// <li>Output format of Chinese tones;
    /// <li>Cases of letters in outputted string</li>
    /// </ul>
    /// 
    /// <p>
    /// Default values of these features are listed below:
    /// </p>
    /// 
    /// <p>
    /// HanyuPinyinVCharType := WITH_U_AND_COLON <br>
    /// HanyuPinyinCaseType := LOWERCASE <br>
    /// HanyuPinyinToneType := WITH_TONE_NUMBER <br>
    /// </br>
    /// 
    /// <p>
    /// <b>Some combinations of output format options are meaningless. For example,
    /// WITH_TONE_MARK and WITH_U_AND_COLON.</b></p>
    /// 
    /// <p>
    /// The combination of different output format options are listed below. For
    /// example, '吕'</p>
    /// 
    /// <table border="1">
    /// <tr>
    /// <th colspan="4"> LOWERCASE </th>
    /// </tr>
    /// <tr>
    /// <th>Combination</th>
    /// <th>WITH_U_AND_COLON</th>
    /// <th>WITH_V</th>
    /// <th>WITH_U_UNICODE</th>
    /// </tr>
    /// <tr>
    /// <th>WITH_TONE_NUMBER</th>
    /// <td>lu:3</td>
    /// <td>lv3</td>
    /// <td>lü3</td>
    /// </tr>
    /// <tr>
    /// <th>WITHOUT_TONE</th>
    /// <td>lu:</td>
    /// <td>lv</td>
    /// <td>lü</td>
    /// </tr>
    /// <tr>
    /// <th>WITH_TONE_MARK</th>
    /// <td><font color="red">throw exception</font></td>
    /// <td><font color="red">throw exception</font></td>
    /// <td>lǚ</td>
    /// </tr>
    /// </table>
    /// 
    /// <table border="1">
    /// <tr>
    /// <th colspan="4"> UPPERCASE </th>
    /// </tr>
    /// <tr>
    /// <th>Combination</th>
    /// <th>WITH_U_AND_COLON</th>
    /// <th>WITH_V</th>
    /// <th>WITH_U_UNICODE</th>
    /// </tr>
    /// <tr>
    /// <th>WITH_TONE_NUMBER</th>
    /// <td>LU:3</td>
    /// <td>LV3</td>
    /// <td>LÜ3</td>
    /// </tr>
    /// <tr>
    /// <th>WITHOUT_TONE</th>
    /// <td>LU:</td>
    /// <td>LV</td>
    /// <td>LÜ</td>
    /// </tr>
    /// <tr>
    /// <th>WITH_TONE_MARK</th>
    /// <td><font color="red">throw exception</font></td>
    /// <td><font color="red">throw exception</font></td>
    /// <td>LǙ</td>
    /// </tr>
    /// </table>
    /// </summary>
    /// <see cref="HanyuPinyinVCharType"/>
    /// <see cref="HanyuPinyinCaseType"/>
    /// <see cref="HanyuPinyinToneType"/>
    public class HanyuPinyinOutputFormat
    {
        /// <summary>
        /// output cases of Hanyu Pinyin characters
        /// 汉语拼音字符 输出情况
        /// </summary>
        private HanyuPinyinCaseType caseType;

        /// <summary>
        /// output format of Chinese tones
        /// 声调 输出格式
        /// </summary>
        private HanyuPinyinToneType toneType;

        /// <summary>
        /// the output format of character 'ü'
        ///  'ü' 字符输出格式
        /// </summary>
        private HanyuPinyinVCharType vCharType;

        /// <summary>
        /// 
        /// </summary>
        public HanyuPinyinOutputFormat()
        {
            RestoreDefault();
        }

        /// <summary>
        /// the output format of character 'ü'
        ///  'ü'字符 输出格式
        /// </summary>
        public HanyuPinyinVCharType VCharType
        {
            get { return vCharType; }
            set { vCharType = value; }
        }

        /// <summary>
        /// output cases of Hanyu Pinyin characters
        ///  汉语拼音字符 输出情况
        /// </summary>
        public HanyuPinyinCaseType CaseType
        {
            get { return caseType; }
            set { caseType = value; }
        }

        /// <summary>
        ///  output format of Chinese tones
        ///  声调 输出格式
        /// </summary>
        public HanyuPinyinToneType ToneType
        {
            get { return toneType; }
            set { toneType = value; }
        }

        /// <summary>
        /// Restore default variable values for this class
        /// 重新加载本类的默认变量值
        /// 
        /// Default values are listed below:
        /// 默认变量值如下
        /// <p>
        /// HanyuPinyinVCharType := WITH_U_AND_COLON <br />
        /// HanyuPinyinCaseType := LOWERCASE <br/>
        /// HanyuPinyinToneType := WITH_TONE_NUMBER <br/>
        /// </p>
        /// </summary>
        public void RestoreDefault()
        {
            vCharType = HanyuPinyinVCharType.WITH_U_AND_COLON;
            caseType = HanyuPinyinCaseType.LOWERCASE;
            toneType = HanyuPinyinToneType.WITH_TONE_NUMBER;
        }
    }
}