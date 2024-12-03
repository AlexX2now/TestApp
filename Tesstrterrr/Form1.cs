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
    public partial class Form1 : Form
    {
        TistirovanieeEntities db = new TistirovanieeEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void showpass_Click(object sender, EventArgs e)
        {
            if (password.PasswordChar == '*')
            {
                password.PasswordChar = '\0';
            }
            else{
                password.PasswordChar = '*';
            }
        }

        private void registbtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void regbtn_Click(object sender, EventArgs e)
        {
            //Регистрация
            if (string.IsNullOrEmpty(surname.Text) ||
            string.IsNullOrEmpty(name.Text) ||
            string.IsNullOrEmpty(trim.Text) ||
            string.IsNullOrEmpty(loginreg.Text) ||
            string.IsNullOrEmpty(passwordreg.Text) ||
            string.IsNullOrEmpty(checkrpass.Text)){
                MessageBox.Show("Не оставляйте поля пустыми");
            }
            else{
                if (passwordreg.Text != checkrpass.Text){
                    MessageBox.Show("Пароль не совпадает с повтором");
                }
                else{
                    var checklog = db.Пользователь_.FirstOrDefault(x=>x.Логин == loginreg.Text);

                    if (checklog != null){
                        MessageBox.Show("Пользователь с таким логином уже существует");
                    }
                    else{
                        using (var context = new TistirovanieeEntities()){
                            var NewUser = new Пользователь_{
                                Логин = loginreg.Text,
                                Пароль = passwordreg.Text,
                                Фамилия = surname.Text,
                                Имя = name.Text,
                                Отчество = trim.Text
                            };
                            context.Пользователь_.Add(NewUser);
                            context.SaveChanges();
                        }
                        MessageBox.Show("Пользователь успешно добавлен");
                        Form2 form2 = new Form2(loginreg.Text);
                        this.Hide();
                        form2.Show();
                    }
                }
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            //Очистка полей регистрации
            surname.Clear();
            name.Clear();
            trim.Clear();
            loginreg.Clear();
            passwordreg.Clear();
            checkrpass.Clear();
        }

        private void enterbtn_Click(object sender, EventArgs e)
        {
            //Войти
            if (string.IsNullOrEmpty(login.Text) || string.IsNullOrEmpty(password.Text)){
                MessageBox.Show("Не оставляйте поля пустыми");
            }
            else{
                var user = db.Пользователь_.FirstOrDefault(x=>x.Логин == login.Text && x.Пароль == password.Text);

                if (user == null){
                    MessageBox.Show("Такого пользователя нет");
                }
                else{

                    Form2 form2 = new Form2(user.Логин);
                    this.Hide();
                    form2.Show();
                }
            }
        }
    }
}
