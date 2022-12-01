namespace 整合物件範例
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Multiselect= true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach(string s in openFileDialog1.FileNames)
                {   
                    comboBox1.Items.Add(s);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileNames[comboBox1.SelectedIndex]);
            textBox1.Text = openFileDialog1.FileNames[comboBox1.SelectedIndex];
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
                if (checkBox2.Checked)
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                else pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Interval= 500;
            timer1.Enabled = true;
        }
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count >= openFileDialog1.FileNames.Length - 1) count = 0;
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileNames[count]);
            textBox1.Text = openFileDialog1.FileNames[count];      
            count++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

    }
}