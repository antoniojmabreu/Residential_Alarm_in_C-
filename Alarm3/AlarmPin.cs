using System;
using System.Windows.Forms;

namespace Alarm3
{
    public partial class AlarmPin : Form
    {
        public Boolean correctPin = false;
        public int attempt = 0;

        public AlarmPin()
        {
            InitializeComponent();
        }

        
        private void textBoxPIN_TextChanged(object sender, EventArgs e)
        {
            DateTime dateNow = DateTime.Now;
            Form1 form1 = new Form1();
            

            if (textBoxPIN.TextLength == 4)
            {

                String input = textBoxPIN.Text.ToString();
                if (textBoxPIN.Text.ToString().Equals("1234"))
                {
                    correctPin = true;
                    form1.Focus();
                    this.Close();
                }
                else
                {
                    attempt += 1;
                    if (attempt == 3)
                    {
                        form1.alarmSound("play");
                        this.Close();
                    }
                    else
                    {
                        textBoxPIN.Clear();
                    }
                    this.Close();
                }
            }
        }

        private void AlarmPin_Load(object sender, EventArgs e)
        {

        }
    }
}
