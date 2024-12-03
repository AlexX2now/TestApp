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
    public partial class Form2 : Form
    {
    TistirovanieeEntities db = new TistirovanieeEntities();
        private string userlog;
        public Form2(string userlogin)
        {
            InitializeComponent();
            userlog = userlogin;

            List<Тест_> alltests = db.Тест_.ToList();

            for (int i = 0; i < alltests.Count; i++)
            {
                chooseres.Items.Add(alltests[i].Название);
            }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void showres_Click(object sender, EventArgs e)
        {
            //Проход тестов
            Form3 form3 = new Form3(userlog, chooseres.SelectedIndex + 1);
            this.Hide(); 
            form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showneedres.Text = "";

            List<История_> allhist = db.История_.ToList();
            List<История_> neededhist = allhist.Where(x=>x.Логин == userlog && x.Номер_теста == chooseres.SelectedIndex + 1).ToList();

            if (neededhist.Count != 0){
                for (int i = 0; i < neededhist.Count; i++)
                {
                    showneedres.Text += neededhist[i].Тест_.Название + "/Результат: " + neededhist[i].Результат +
                    "/ Баллы: " + neededhist[i].Кол__Баллов + "/ Дата: " + neededhist[i].Дата.Value.ToShortDateString() +
                    "/ Время: " + neededhist[i].Время.Value + Environment.NewLine;
                }
            }
        }
    }
}
