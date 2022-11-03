namespace ProgressBarDz
{
    public partial class Form1 : Form
    {
        string filetext = "";

        public Form1()
        {
            InitializeComponent();

            using (StreamReader sr = new StreamReader("text.txt"))
            {
                filetext += sr.ReadLine();
            }
            progressBar1.Maximum = filetext.Length;
        }

        private void progressBar1_Click(object sender, EventArgs e){}

        private void btStart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= filetext.Length; i++)
            {
                progressBar1.PerformStep();
                Update();
            }
            MessageBox.Show($"Было прочитанно {filetext.Length} символов");
        }

        private void btAnc_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}