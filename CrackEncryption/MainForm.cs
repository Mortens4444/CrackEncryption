using CrackEncryption.Ciphers;
using CrackEncryption.Enums;

namespace CrackEncryption
{
    public partial class MainForm : Form
    {
        private List<char> triedChars = [];

        public MainForm()
        {
            InitializeComponent();

            cbCipher.DataSource = Enum.GetValues(typeof(Cipher));
            cbLanguage.DataSource = Enum.GetValues(typeof(Language));
            cbCipher.SelectedIndex = 0;
            cbLanguage.SelectedIndex = 0;
        }

        private void CbCipher_SelectedIndexChanged(object sender, EventArgs e)
        {
            triedChars = [];
            switch (cbCipher.SelectedIndex)
            {
                case 0:
                    gbCaesarSettings.Enabled = true;
                    gbVigenereSettings.Enabled = false;
                    rtbCipherText.Text = "Ymj%Hfjxfw%hnumjw%nx%tsj%tk%ymj%jfwqnjxy%pst|s%jshw~uynts%rjymtix1%zxji%ns%fshnjsy%ynrjx3%Ny%xzgxynyzyjx%jfhm%qjyyjw%ns%ymj%uqfnsyj}y%|nym%f%kn}ji%xmnky%ns%ymj%fqumfgjy1%rfpnsl%ny%jfxnq~%hwfhpfgqj%ymwtzlm%kwjvzjsh~%fsfq~xnx%gfxji%ts%ymj%qfslzflj,x%qjyyjw%inxywngzynts3%Ymj%[nljsȭwj%hnumjw%nruwt{ji%ts%ymnx%g~%zxnsl%f%pj~|twi%yt%xmnky%qjyyjwx1%xt%jfhm%qjyyjw%nx%jshw~uyji%inkkjwjsyq~3%Mt|j{jw1%j{js%ymj%[nljsȭwj%hnumjw%nx%{zqsjwfgqj%yt%kwjvzjsh~%fsfq~xnx%nk%ymj%pj~|twi%qjslym%nx%pst|s%fsi%ymj%hnumjwyj}y%nx%xzkknhnjsyq~%qtsl3\u000f";
                    break;
                case 1:
                    gbCaesarSettings.Enabled = false;
                    gbVigenereSettings.Enabled = true;
                    rtbCipherText.Text = "µÔÒ\u0081©ÂÆßÎÓ\u0086ÄÊÜÕÆØ\u0081Êß\u008dÐÔÆ\u0081ÛÓ\u0081ÚÉÆ\u008cÒÂØÍÊÑàÕ\u0086ÌÏÛäÏ\u0086ÆÏÏßÚÖÕÊÛÛ\u0081ÓÆÕÔÜÅÙ\u008d\u0081áàÆÊ\u0081ÊÚ\u008dÂÔÄÊÑÛÕ\u0086ÕÊÙÒÔ\u0094\u0081ªà\u008dÔÛÃÔàÖÕÛÕÆß\u008dÆÇÄÉ\u008cÙÆÚÕÆÞ\u008dÊÔ\u0081ÕÔÒ\u0081ÖÍÂÕÛÕËÙÕ\u008cäÊÚÉ\u0081Í\u008dÇÏÙÆÐ\u008dÔÎÊÇà\u008dÊÔ\u0081ÕÔÒ\u0081ÇÍÑÔÎÃËÕ\u008d\u008cÚÂÑÊÏÓ\u008dÊÚ\u0081ÆÍàÊÒÚ\u0081ÏßÂÉÌÂÎÙÆ\u0086ÕÉÞÜÖÍÉ\u0081ÒßÆ×ÖÆÚÐÚ\u0086ÂÏÍÙÚÙÊÔ\u008cÏÂÙÆÅ\u008cÜÏ\u0086ÕÉÑ\u008dÍÇÏÈáÎÈË\u0088Ô\u008cÙÆÚÕÆÞ\u008dÅÏÔÕÞÖÃÛÕÊÛÛ\u008f\u0086µÉÑ\u008d·ÏÈÆÚUÓË\u0081ÄÕÝÉËÓ\u0081ÕÚÑØÐ×ÑÑ\u0081ÕÏ\u0081àÕÊÙ\u0081Ãå\u008dÖÙÊÏÓ\u008dÂ\u0086ÌÆåäÐØÅ\u0081àÜ\u0081ÙÉÊÒá\u0081ÒÆÕàÒÓÙ\u008d\u0081ßÜ\u0081ËÂÄÔ\u008dÍËÕÕÑß\u0081ÏÔ\u0081ÑÛÄØÚÑàÒÅ\u0086ÅÊÒÓÆØÆÏàÙÚ\u0094\u0081©ÛäÆÜÆÓ\u0098\u008dÆÜÆÏ\u008cáÉË\u0081·ÕÔÆÔIÓÑ\u008dÄÏÑÉÑß\u0081ÏÔ\u0081ââÍÔÆÓÍÏÍË\u0081ÕÛ\u008dÇØÆÒáÒÏÉÚ\u0081ÍÛÂÒÚÔÕà\u0081ÏÇ\u0081àÕÆ\u0086ÌÆåäÐØÅ\u0081ØÒÏÍÕÉ\u008cÖÔ\u0086ÌÏÛäÏ\u0086ÂÏÐ\u008dÕÎÆ\u0081ÏÖÑÎÆÓàÒÙÚ\u0081Êß\u008dÔÛÇÇÕÐÊËÏÕØæ\u0081ÒÐÏÓ\u009bk";
                    nudPasswordLength.Value = 6;
                    break;
            }
        }

        private void BtnFrequencyAnalysis_Click(object sender, EventArgs e)
        {
            switch (cbCipher.SelectedIndex)
            {
                case 0:
                    CrackCaesarEncyption();
                    break;
                case 1:
                    tbEstimatedPassword.Text = CrackVigenereEncyption(rtbCipherText.Text, (int)nudPasswordLength.Value);
                    rtbPlainText.Text = VigenèreCipher.Decrypt(rtbCipherText.Text, tbEstimatedPassword.Text, chkCryptWhiteSpaces.Checked);
                    break;
            }
        }

        private static string CrackVigenereEncyption(string cipherText, int keywordLength)
        {
            var estimatedKeyword = new char[keywordLength];

            for (int i = 0; i < keywordLength; i++)
            {
                var subText = GetNthCharacters(cipherText, keywordLength, i);
                estimatedKeyword[i] = (char)CharacterFrequencyProvider.PerformFrequencyAnalysis(subText, ' ');
            }

            return new string(estimatedKeyword);
        }

        private static string GetNthCharacters(string text, int step, int start)
        {
            return new string(text.Where((c, index) => (index - start) % step == 0).ToArray());
        }

        private void CrackCaesarEncyption()
        {
            var frequencies = CharacterFrequencyProvider.LanguageFrequencies[(Language)cbLanguage.SelectedItem!];
            var frequencyInfo = frequencies.FirstOrDefault(f => !triedChars.Contains(f.Letter));
            if (frequencyInfo != null)
            {
                var shift = CharacterFrequencyProvider.PerformFrequencyAnalysis(rtbCipherText.Text, frequencyInfo.Letter);
                nudEstimatedShift.Value = shift;
                triedChars.Add(frequencyInfo.Letter);
                rtbPlainText.Text = CaesarCipher.Decrypt(rtbCipherText.Text, shift, chkCryptWhiteSpaces.Checked);
            }
            else
            {
                MessageBox.Show("No more freqency data available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            switch (cbCipher.SelectedIndex)
            {
                case 0:
                    rtbPlainText.Text = CaesarCipher.Decrypt(rtbCipherText.Text, (int)nudEstimatedShift.Value, chkCryptWhiteSpaces.Checked);
                    break;
                case 1:
                    rtbPlainText.Text = VigenèreCipher.Decrypt(rtbCipherText.Text, tbEstimatedPassword.Text, chkCryptWhiteSpaces.Checked);
                    break;
            }
        }
    }
}
