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
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void gunaLabel7_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
           this.Dispose();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();

            SuccessMsgBox successMsgBox = new SuccessMsgBox();
            successMsgBox.Show();

        }
    }
}
