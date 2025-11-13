namespace UtasszallitoGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnSzamol.Click += BtnSzamol_Click;
        }

        private void BtnSzamol_Click(object? sender, EventArgs e)
        {

            try
            {
                double qc = double.Parse(tBxTorlonyomas.Text.Replace('.', ','));
                double p0 = double.Parse(tBxStatikusnyomas.Text.Replace('.', ','));
                double m = Math.Sqrt(5 * (Math.Pow(qc / p0 + 1, 2 / (double)7) - 1));
                
                rtxEredmenyek.Text += $"qc = {qc} p0 = {p0} Ma = {m}\n";

            }
            catch(Exception ex) 
            {
                if (double.TryParse(tBxTorlonyomas.Text, out double number))
                {
                    MessageBox.Show(ex.Message);
                }
                else
                {
                    MessageBox.Show(
                        text: "Adjon meg egy számot!",
                        caption: "Hiba!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
               
            }
        }
    }
}
