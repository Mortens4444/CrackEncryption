

namespace CrackEncryption
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pMain = new Panel();
            rtbPlainText = new RichTextBox();
            splitter = new Splitter();
            rtbCipherText = new RichTextBox();
            pControls = new Panel();
            chkCryptWhiteSpaces = new CheckBox();
            lblLanguage = new Label();
            cbLanguage = new ComboBox();
            btnDecrypt = new Button();
            btnFrequencyAnalysis = new Button();
            gbVigenereSettings = new GroupBox();
            tbEstimatedPassword = new TextBox();
            lblEstimatedPassword = new Label();
            lblPasswordLength = new Label();
            nudPasswordLength = new NumericUpDown();
            gbCaesarSettings = new GroupBox();
            lblShift = new Label();
            nudEstimatedShift = new NumericUpDown();
            lblCipher = new Label();
            cbCipher = new ComboBox();
            pMain.SuspendLayout();
            pControls.SuspendLayout();
            gbVigenereSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPasswordLength).BeginInit();
            gbCaesarSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudEstimatedShift).BeginInit();
            SuspendLayout();
            // 
            // pMain
            // 
            pMain.Controls.Add(rtbPlainText);
            pMain.Controls.Add(splitter);
            pMain.Controls.Add(rtbCipherText);
            pMain.Controls.Add(pControls);
            pMain.Dock = DockStyle.Fill;
            pMain.Location = new Point(0, 0);
            pMain.Name = "pMain";
            pMain.Size = new Size(800, 450);
            pMain.TabIndex = 0;
            // 
            // rtbPlainText
            // 
            rtbPlainText.Dock = DockStyle.Fill;
            rtbPlainText.Location = new Point(383, 100);
            rtbPlainText.Name = "rtbPlainText";
            rtbPlainText.Size = new Size(417, 350);
            rtbPlainText.TabIndex = 3;
            rtbPlainText.Text = "";
            // 
            // splitter
            // 
            splitter.Location = new Point(375, 100);
            splitter.Name = "splitter";
            splitter.Size = new Size(8, 350);
            splitter.TabIndex = 2;
            splitter.TabStop = false;
            // 
            // rtbCipherText
            // 
            rtbCipherText.Dock = DockStyle.Left;
            rtbCipherText.Location = new Point(0, 100);
            rtbCipherText.Name = "rtbCipherText";
            rtbCipherText.Size = new Size(375, 350);
            rtbCipherText.TabIndex = 1;
            rtbCipherText.Text = "";
            // 
            // pControls
            // 
            pControls.Controls.Add(chkCryptWhiteSpaces);
            pControls.Controls.Add(lblLanguage);
            pControls.Controls.Add(cbLanguage);
            pControls.Controls.Add(btnDecrypt);
            pControls.Controls.Add(btnFrequencyAnalysis);
            pControls.Controls.Add(gbVigenereSettings);
            pControls.Controls.Add(gbCaesarSettings);
            pControls.Controls.Add(lblCipher);
            pControls.Controls.Add(cbCipher);
            pControls.Dock = DockStyle.Top;
            pControls.Location = new Point(0, 0);
            pControls.Name = "pControls";
            pControls.Size = new Size(800, 100);
            pControls.TabIndex = 0;
            // 
            // chkCryptWhiteSpaces
            // 
            chkCryptWhiteSpaces.AutoSize = true;
            chkCryptWhiteSpaces.Checked = true;
            chkCryptWhiteSpaces.CheckState = CheckState.Checked;
            chkCryptWhiteSpaces.Location = new Point(157, 29);
            chkCryptWhiteSpaces.Name = "chkCryptWhiteSpaces";
            chkCryptWhiteSpaces.Size = new Size(133, 19);
            chkCryptWhiteSpaces.TabIndex = 8;
            chkCryptWhiteSpaces.Text = "Encrypt whitespaces";
            chkCryptWhiteSpaces.UseVisualStyleBackColor = true;
            // 
            // lblLanguage
            // 
            lblLanguage.AutoSize = true;
            lblLanguage.Location = new Point(21, 53);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new Size(59, 15);
            lblLanguage.TabIndex = 7;
            lblLanguage.Text = "Language";
            // 
            // cbLanguage
            // 
            cbLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLanguage.FormattingEnabled = true;
            cbLanguage.Items.AddRange(new object[] { "Cæsar", "Vigenère" });
            cbLanguage.Location = new Point(21, 71);
            cbLanguage.Name = "cbLanguage";
            cbLanguage.Size = new Size(121, 23);
            cbLanguage.TabIndex = 6;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(660, 71);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(132, 23);
            btnDecrypt.TabIndex = 5;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += BtnDecrypt_Click;
            // 
            // btnFrequencyAnalysis
            // 
            btnFrequencyAnalysis.Location = new Point(660, 16);
            btnFrequencyAnalysis.Name = "btnFrequencyAnalysis";
            btnFrequencyAnalysis.Size = new Size(132, 23);
            btnFrequencyAnalysis.TabIndex = 4;
            btnFrequencyAnalysis.Text = "Frequency Analysis";
            btnFrequencyAnalysis.UseVisualStyleBackColor = true;
            btnFrequencyAnalysis.Click += BtnFrequencyAnalysis_Click;
            // 
            // gbVigenereSettings
            // 
            gbVigenereSettings.Controls.Add(tbEstimatedPassword);
            gbVigenereSettings.Controls.Add(lblEstimatedPassword);
            gbVigenereSettings.Controls.Add(lblPasswordLength);
            gbVigenereSettings.Controls.Add(nudPasswordLength);
            gbVigenereSettings.Location = new Point(473, 3);
            gbVigenereSettings.Name = "gbVigenereSettings";
            gbVigenereSettings.Size = new Size(181, 94);
            gbVigenereSettings.TabIndex = 3;
            gbVigenereSettings.TabStop = false;
            gbVigenereSettings.Text = "Vigenère settings";
            // 
            // tbEstimatedPassword
            // 
            tbEstimatedPassword.Location = new Point(0, 68);
            tbEstimatedPassword.Name = "tbEstimatedPassword";
            tbEstimatedPassword.Size = new Size(164, 23);
            tbEstimatedPassword.TabIndex = 5;
            // 
            // lblEstimatedPassword
            // 
            lblEstimatedPassword.AutoSize = true;
            lblEstimatedPassword.Location = new Point(0, 52);
            lblEstimatedPassword.Name = "lblEstimatedPassword";
            lblEstimatedPassword.Size = new Size(112, 15);
            lblEstimatedPassword.TabIndex = 4;
            lblEstimatedPassword.Text = "Estimated Password";
            // 
            // lblPasswordLength
            // 
            lblPasswordLength.AutoSize = true;
            lblPasswordLength.Location = new Point(6, 31);
            lblPasswordLength.Name = "lblPasswordLength";
            lblPasswordLength.Size = new Size(94, 15);
            lblPasswordLength.TabIndex = 3;
            lblPasswordLength.Text = "Password length";
            // 
            // nudPasswordLength
            // 
            nudPasswordLength.Location = new Point(106, 26);
            nudPasswordLength.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudPasswordLength.Name = "nudPasswordLength";
            nudPasswordLength.Size = new Size(58, 23);
            nudPasswordLength.TabIndex = 2;
            // 
            // gbCaesarSettings
            // 
            gbCaesarSettings.Controls.Add(lblShift);
            gbCaesarSettings.Controls.Add(nudEstimatedShift);
            gbCaesarSettings.Location = new Point(337, 3);
            gbCaesarSettings.Name = "gbCaesarSettings";
            gbCaesarSettings.Size = new Size(132, 94);
            gbCaesarSettings.TabIndex = 2;
            gbCaesarSettings.TabStop = false;
            gbCaesarSettings.Text = "Caesar settings";
            // 
            // lblShift
            // 
            lblShift.AutoSize = true;
            lblShift.Location = new Point(6, 31);
            lblShift.Name = "lblShift";
            lblShift.Size = new Size(86, 15);
            lblShift.TabIndex = 1;
            lblShift.Text = "Estimated Shift";
            // 
            // nudEstimatedShift
            // 
            nudEstimatedShift.Location = new Point(6, 50);
            nudEstimatedShift.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudEstimatedShift.Name = "nudEstimatedShift";
            nudEstimatedShift.Size = new Size(58, 23);
            nudEstimatedShift.TabIndex = 0;
            // 
            // lblCipher
            // 
            lblCipher.AutoSize = true;
            lblCipher.Location = new Point(21, 9);
            lblCipher.Name = "lblCipher";
            lblCipher.Size = new Size(42, 15);
            lblCipher.TabIndex = 1;
            lblCipher.Text = "Cipher";
            // 
            // cbCipher
            // 
            cbCipher.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCipher.FormattingEnabled = true;
            cbCipher.Location = new Point(21, 27);
            cbCipher.Name = "cbCipher";
            cbCipher.Size = new Size(121, 23);
            cbCipher.TabIndex = 0;
            cbCipher.SelectedIndexChanged += CbCipher_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AcceptButton = btnFrequencyAnalysis;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pMain);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cipher Cracker";
            pMain.ResumeLayout(false);
            pControls.ResumeLayout(false);
            pControls.PerformLayout();
            gbVigenereSettings.ResumeLayout(false);
            gbVigenereSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPasswordLength).EndInit();
            gbCaesarSettings.ResumeLayout(false);
            gbCaesarSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudEstimatedShift).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pMain;
        private Panel pControls;
        private Label lblCipher;
        private ComboBox cbCipher;
        private GroupBox gbVigenereSettings;
        private GroupBox gbCaesarSettings;
        private RichTextBox rtbPlainText;
        private Splitter splitter;
        private RichTextBox rtbCipherText;
        private Label lblPasswordLength;
        private NumericUpDown nudPasswordLength;
        private Label lblShift;
        private NumericUpDown nudEstimatedShift;
        private Button btnFrequencyAnalysis;
        private Button btnDecrypt;
        private Label lblLanguage;
        private ComboBox cbLanguage;
        private CheckBox chkCryptWhiteSpaces;
        private TextBox tbEstimatedPassword;
        private Label lblEstimatedPassword;
    }
}
