namespace projectNameHere // edit this part
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // COMBO BOX
        private void addBtn1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                comboBox1.Items.Add(textBox1.Text);
                MessageBox.Show(String.Format("\"{0}\" Successfully Added.", textBox1.Text));
            }
        }

        private void delBtn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("\"{0}\" Successfully Removed.", comboBox1.SelectedItem));
            comboBox1.Items.Remove(comboBox1.SelectedItem);
        }


        // CHECK BOX
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            DisplayListBox();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            DisplayListBox();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            DisplayListBox();
        }

        private void DisplayListBox()
        {
            listBox2.Items.Clear();
            if (checkBox1.Checked == true) listBox2.Items.Add(checkBox1.Text);
            if (checkBox2.Checked == true) listBox2.Items.Add(checkBox2.Text);
            if (checkBox3.Checked == true) listBox2.Items.Add(checkBox3.Text);
        }


        // LIST BOX
        private void addBtn2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                listBox1.Items.Add(textBox2.Text);
                MessageBox.Show(String.Format("\"{0}\" Successfully Added.", textBox2.Text));
            }
        }

        private void delBtn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("\"{0}\" Successfully Removed.", listBox1.SelectedItem));
            listBox1.Items.Remove(listBox1.SelectedItem);
        }


        // RADIO BUTTON
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = radioButton3.Text;
        }
    }
}