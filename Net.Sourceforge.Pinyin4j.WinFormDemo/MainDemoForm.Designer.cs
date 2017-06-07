namespace Net.Sourceforge.Pinyin4j.WinFormDemo
{
    partial class MainDemoForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelInput = new System.Windows.Forms.Panel();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.panelOutput = new System.Windows.Forms.Panel();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.panelTool = new System.Windows.Forms.Panel();
            this.panelToolLeft = new System.Windows.Forms.Panel();
            this.labelPinyinType = new System.Windows.Forms.Label();
            this.comboBoxPinyinType = new System.Windows.Forms.ComboBox();
            this.panelToolRight = new System.Windows.Forms.Panel();
            this.buttonTODO = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.panelOutput.SuspendLayout();
            this.panelTool.SuspendLayout();
            this.panelToolLeft.SuspendLayout();
            this.panelToolRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.panelInput, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panelOutput, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.panelTool, 0, 1);
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(11, 11);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(415, 280);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.textBoxInput);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInput.Location = new System.Drawing.Point(3, 3);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(409, 114);
            this.panelInput.TabIndex = 0;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInput.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBoxInput.Location = new System.Drawing.Point(0, 0);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(409, 114);
            this.textBoxInput.TabIndex = 0;
            // 
            // panelOutput
            // 
            this.panelOutput.Controls.Add(this.textBoxOutput);
            this.panelOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutput.Location = new System.Drawing.Point(3, 163);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Size = new System.Drawing.Size(409, 114);
            this.panelOutput.TabIndex = 1;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutput.Location = new System.Drawing.Point(0, 0);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(409, 114);
            this.textBoxOutput.TabIndex = 0;
            // 
            // panelTool
            // 
            this.panelTool.Controls.Add(this.panelToolLeft);
            this.panelTool.Controls.Add(this.panelToolRight);
            this.panelTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTool.Location = new System.Drawing.Point(3, 123);
            this.panelTool.Name = "panelTool";
            this.panelTool.Size = new System.Drawing.Size(409, 34);
            this.panelTool.TabIndex = 2;
            // 
            // panelToolLeft
            // 
            this.panelToolLeft.Controls.Add(this.labelPinyinType);
            this.panelToolLeft.Controls.Add(this.comboBoxPinyinType);
            this.panelToolLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelToolLeft.Location = new System.Drawing.Point(0, 0);
            this.panelToolLeft.Name = "panelToolLeft";
            this.panelToolLeft.Size = new System.Drawing.Size(294, 34);
            this.panelToolLeft.TabIndex = 1;
            // 
            // labelPinyinType
            // 
            this.labelPinyinType.AutoSize = true;
            this.labelPinyinType.Location = new System.Drawing.Point(20, 8);
            this.labelPinyinType.Name = "labelPinyinType";
            this.labelPinyinType.Size = new System.Drawing.Size(53, 12);
            this.labelPinyinType.TabIndex = 1;
            this.labelPinyinType.Text = "拼音类型";
            // 
            // comboBoxPinyinType
            // 
            this.comboBoxPinyinType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPinyinType.DisplayMember = "DisplayMember";
            this.comboBoxPinyinType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPinyinType.FormattingEnabled = true;
            this.comboBoxPinyinType.Location = new System.Drawing.Point(79, 3);
            this.comboBoxPinyinType.Name = "comboBoxPinyinType";
            this.comboBoxPinyinType.Size = new System.Drawing.Size(190, 20);
            this.comboBoxPinyinType.TabIndex = 0;
            this.comboBoxPinyinType.ValueMember = "ValueMember";
            this.comboBoxPinyinType.SelectedIndexChanged += new System.EventHandler(this.comboBoxPinyinType_SelectedIndexChanged);
            // 
            // panelToolRight
            // 
            this.panelToolRight.Controls.Add(this.buttonTODO);
            this.panelToolRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelToolRight.Location = new System.Drawing.Point(294, 0);
            this.panelToolRight.Name = "panelToolRight";
            this.panelToolRight.Size = new System.Drawing.Size(115, 34);
            this.panelToolRight.TabIndex = 0;
            // 
            // buttonTODO
            // 
            this.buttonTODO.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonTODO.Location = new System.Drawing.Point(24, 3);
            this.buttonTODO.Name = "buttonTODO";
            this.buttonTODO.Size = new System.Drawing.Size(75, 23);
            this.buttonTODO.TabIndex = 0;
            this.buttonTODO.Text = "转化";
            this.buttonTODO.UseVisualStyleBackColor = true;
            this.buttonTODO.Click += new System.EventHandler(this.buttonTODO_Click);
            // 
            // MainDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 305);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "MainDemoForm";
            this.Text = "汉字转拼音";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelOutput.ResumeLayout(false);
            this.panelOutput.PerformLayout();
            this.panelTool.ResumeLayout(false);
            this.panelToolLeft.ResumeLayout(false);
            this.panelToolLeft.PerformLayout();
            this.panelToolRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Panel panelOutput;
        private System.Windows.Forms.Panel panelTool;
        private System.Windows.Forms.Panel panelToolLeft;
        private System.Windows.Forms.Panel panelToolRight;
        private System.Windows.Forms.ComboBox comboBoxPinyinType;
        private System.Windows.Forms.Label labelPinyinType;
        private System.Windows.Forms.Button buttonTODO;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxOutput;
    }
}

