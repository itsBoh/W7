

namespace W7
{
    public partial class FormW7 : Form
    {
        int beda;
        char[] huruf = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        List<string> huruf2 = new List<string>();
        List<string> answ = new List<string>();
        int index;
        public FormW7()
        {
            InitializeComponent();
            tbInputHuruf2.MaxLength = 1;
            tbInputHuruf1.MaxLength = 1;
            lbOutput.Text = "";
            for (int i = 0; i < huruf.Length; i++)
                huruf2.Add(huruf[i].ToString());
        }

        private void btnKonversi_Click(object sender, EventArgs e)
        {
            answ.Clear();
            if (tbInputKalimat.Text.Length == 0 || tbInputHuruf1.Text.Length == 0 || tbInputHuruf2.Text.Length == 0)
                MessageBox.Show("Masukkan input!");
            else
            {
                tbInputKalimat.Text = tbInputKalimat.Text.ToUpper();
                char[] kalimat = tbInputKalimat.Text.ToCharArray();
                beda = huruf2.IndexOf(tbInputHuruf2.Text.ToUpper());
                beda -= huruf2.IndexOf(tbInputHuruf1.Text.ToUpper());
                if (beda < 0)
                    beda += 26;
                for (int i = 0; i < kalimat.Count(); i++)
                {
                    index = huruf2.IndexOf(tbInputKalimat.Text[i].ToString());
                    answ.Add(huruf2[index+beda].ToString());
                }
                lbOutput.Text = string.Join("", answ);

            }
        }

        private void tbInputKalimat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tbInputHuruf1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tbInputHuruf2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}