namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String f, GG;
            GG = "";
            String[] ss = listBox1.Text.Split(' ');
            for (int i = 0; i < ss.Count(); i++)
            {
                f = ss[i].Substring(1, ss[i].Length - 1);
                GG += (f + " ");
            }
            label1.Text = GG;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
            }
        }
    }
}