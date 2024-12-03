using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tesstrterrr
{
    public partial class Form5 : Form
    {
        private int realresfr, needresfr;
        private string userlog;

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(userlog);
            this.Hide();
            form2.Show();
        }

        public Form5(int realres, int needres, string loginuser)
        {
            InitializeComponent();
            realresfr = realres;
            needresfr = needres;
            userlog = loginuser;

            label2.Text = "Вы набрали " + realres + " баллов из " + needres; 
        }
    }
}
