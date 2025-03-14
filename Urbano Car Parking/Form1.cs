using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urbano_Car_Parking
{
    public partial class Main: Form
    {
        public Main()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddGuestBtn_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.Show();
        }

        private void AddMemberBtn_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.time.Text = DateTime.Now.ToString("hh:mm tt");
            this.date.Text = DateTime.Now.ToString("MM - dd - yy");
        }

        private void InitializeTimer()
        {
            this.timer1 = new Timer();
            this.timer1.Interval = 1000;
            this.timer1.Tick += new EventHandler(this.timer1_Tick);
            this.timer1.Start();
        }
    }
}
