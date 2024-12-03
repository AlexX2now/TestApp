using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tesstrterrr
{
    public partial class Form4 : Form
    {
        TistirovanieeEntities db = new TistirovanieeEntities();
        int numofquest = 0;
        private int testid, otvet, itgballov, numvopr = 1;
        private string userlog;
        private int neededmin, neededsec;

        public Form4(string userlogin, int idtest)
        {
            InitializeComponent();
            testid = idtest;
            userlog = userlogin;

            List<Вопрос_> allvopr = db.Вопрос_.ToList();
            List<Вопрос_> neededvops = allvopr.Where(x => x.Номер_теста == testid).ToList();

            var testnamef = db.Тест_.FirstOrDefault(x=>x.Номер == idtest);
            testname.Text = testnamef.Название;
            label4.Text = numvopr + " / " + neededvops.Count;
            label5.Text = itgballov + " / " + neededvops.Count;

            label1.Text = neededvops[numofquest].Вопрос;
            radioButton1.Text = neededvops[numofquest].Вариант1;
            radioButton2.Text = neededvops[numofquest].Вариант2;
            radioButton3.Text = neededvops[numofquest].Вариант3;

            timer1.Interval = 1000; // 1 second interval
            timer1.Enabled = true;
            fortimer.Text = "60:00";
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            List<Вопрос_> allvopr = db.Вопрос_.ToList();
            List<Вопрос_> neededvops = allvopr.Where(x => x.Номер_теста == testid).ToList();
            numvopr++;
            numofquest++;
            

            //Далее
            try
            {
                    if (radioButton1.Checked)
                    {
                        otvet = 1;
                    }
                    else if (radioButton2.Checked)
                    {
                        otvet = 2;
                    }
                    else if (radioButton3.Checked)
                    {
                        otvet = 3;
                    }


                    if (neededvops[numofquest - 1].Ответ == otvet)
                    {
                        itgballov += 1;
                        label5.Text = itgballov + " / " + neededvops.Count;
                    }
                    
                    label4.Text = numvopr + " / " + neededvops.Count;

                    label1.Text = neededvops[numofquest].Вопрос;
                    radioButton1.Text = neededvops[numofquest].Вариант1;
                    radioButton2.Text = neededvops[numofquest].Вариант2;
                    radioButton3.Text = neededvops[numofquest].Вариант3;

                }
                catch
                {
                    MessageBox.Show("Тест пройден! Поздравляю");

                //Записать как нибудь в базу 

                string itgres = "";

                //Подсчет оценки
                if (neededvops.Count == itgballov){
                    itgres = "5";
                }
                else if (neededvops.Count / 2 < itgballov){
                    itgres = "4";
                }
                else if (itgballov == 0){
                    itgres = "2";
                }
                else{
                    itgres = "3";
                }

                int schechminutes = neededmin;
                schechminutes -= 59;
                schechminutes *= -1;

                int schechseconds = neededsec;
                schechseconds -= 60;
                schechseconds *= -1;

                if (schechminutes > 0)
                {
                    schechseconds += (schechminutes * 60);
                }

                TimeSpan time = new TimeSpan(0, 0, schechseconds);

                try{
                    using (var context = new TistirovanieeEntities())
                    {
                        var newhist = new История_
                        {
                            Логин = userlog,
                            Номер_теста = testid,
                            Результат = itgres,
                            Кол__Баллов = itgballov,
                            Дата = DateTime.Now,
                            Время = time,
                        };
                        context.История_.Add(newhist);
                        context.SaveChanges();
                    }

                    Form5 form5 = new Form5(itgballov, neededvops.Count, userlog);
                    this.Hide();
                    form5.Show();
                }
                catch{
                    MessageBox.Show("Что-то пошло не так, упс");
                }
                }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int minutes = 60;
            int seconds = 0;
            string time = fortimer.Text;

            string[] parts = time.Split(':');
            minutes = int.Parse(parts[0]);
            seconds = int.Parse(parts[1]);

            seconds--;
            if (seconds < 0)
            {
                minutes--;
                seconds = 59;
            }

            neededmin = minutes;
            neededsec = seconds;
            fortimer.Text = $"{minutes}:{seconds:D2}";

            if (minutes == 0 && seconds == 0)
            {
                timer1.Stop();
            }
        }
    }
}
