using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Net.Sourceforge.Pinyin4j.WinFormDemo
{
    public partial class MainDemoForm : Form
    {
        public MainDemoForm()
        {
            InitializeComponent();

            //绑定拼音类型 列表框
            Bind_PinyinTypeComboBox();
        }

        /// <summary>
        /// 绑定拼音类型 列表框
        /// </summary>
        private void Bind_PinyinTypeComboBox()
        {
            List<PinyinItem> pinyinItems = new List<PinyinItem>();
            pinyinItems.Add(new PinyinItem(PinyinType.Hanyu, "汉语拼音系统 (Hanyu)"));
            pinyinItems.Add(new PinyinItem(PinyinType.Wade, "威妥玛系统 (Wade-Giles)"));
            pinyinItems.Add(new PinyinItem(PinyinType.Yale, "耶鲁系统 (Yale)"));
            pinyinItems.Add(new PinyinItem(PinyinType.Gwoyeu, "国语罗马化系统 (Gwoyeu)"));
            pinyinItems.Add(new PinyinItem(PinyinType.MPSII, "国语罗马化第二式系统 (MPSII)"));
            pinyinItems.Add(new PinyinItem(PinyinType.Tongyong, "通用拼音系统 (Tongyong)"));
            comboBoxPinyinType.DataSource = pinyinItems;
        }

        /// <summary>
        /// 拼音类型转化时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxPinyinType_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonTODO.PerformClick();
        }

        /// <summary>
        /// 转化按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTODO_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxInput.Text))
            {
                PinyinType pinyintype = (PinyinType) comboBoxPinyinType.SelectedValue;
                textBoxOutput.Text = PinyinMoreHelper.GetPinyinStringByPinyinType(textBoxInput.Text, pinyintype, " ");
            }
        }

        #region Nested type: PinyinItem

        /// <summary>
        /// 
        /// </summary>
        internal class PinyinItem
        {
            /// <summary>
            /// 
            /// </summary>
            private string _displayMember;

            /// <summary>
            /// 
            /// </summary>
            private PinyinType _valueMember;

            /// <summary>
            /// 
            /// </summary>
            public PinyinItem()
            {
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="valueMember"></param>
            /// <param name="displayMember"></param>
            public PinyinItem(PinyinType valueMember, string displayMember)
            {
                _valueMember = valueMember;
                _displayMember = displayMember;
            }

            /// <summary>
            /// 
            /// </summary>
            public PinyinType ValueMember
            {
                get { return _valueMember; }
                set { _valueMember = value; }
            }

            /// <summary>
            /// 
            /// </summary>
            public string DisplayMember
            {
                get { return _displayMember; }
                set { _displayMember = value; }
            }
        }

        #endregion
    }
}