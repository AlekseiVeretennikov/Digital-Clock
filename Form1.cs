using System;
using System.Windows.Forms; // ”бедитесь, что эта строка есть

namespace WinFormsApp1 // ”бедитесь, что это им€ совпадает с вашим проектом
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            timer1_Tick(sender, e);
        }

     
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            string displayString = currentTime.ToString("dddd, dd MMMM yyyy\nHH:mm:ss");
            timeLabel.Text = displayString;
        }

  
        private void label1_Click(object sender, EventArgs e)
        {
            // Ќичего не делаем по клику на метку
        }
    }
}