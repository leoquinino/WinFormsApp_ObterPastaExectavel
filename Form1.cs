namespace WinFormsApp_ObterPastaExectavel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
            string path2 = path.Remove(path.LastIndexOf("\\"));
            path = path2.Remove(path2.LastIndexOf("\\") + 1);
            //path += "log";
            //System.IO.Directory.CreateDirectory(path);

            MessageBox.Show($"Pasta de Trabalho : {path}");
        }
    }
}