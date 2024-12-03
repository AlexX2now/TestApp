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
    public partial class Form3 : Form
    {
    TistirovanieeEntities db = new TistirovanieeEntities();
        private string userlog;
        public Form3(string userlogin, int idtest)
        {
            InitializeComponent();
            userlog = userlogin;

            List<Тест_> alltests = db.Тест_.ToList();

            for (int i = 0; i < alltests.Count; i++)
            {
                chooseres.Items.Add(alltests[i].Название);
            }

            var neededtesttoshow = db.Тест_.FirstOrDefault(x=>x.Номер == idtest);
            if (neededtesttoshow != null)
            {
                chooseres.Text = neededtesttoshow.Название;
            }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Проходить тест
            if (string.IsNullOrEmpty(chooseres.Text)){
                MessageBox.Show("Выберите тест для тестирования");
            }
            else{
                Form4 form4 = new Form4(userlog, chooseres.SelectedIndex + 1);
                this.Hide();
                form4.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(userlog);
            this.Hide();
            form2.Show();
        }
    }
}
