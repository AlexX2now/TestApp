namespace Tesstrterrr
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.registbtn = new System.Windows.Forms.Button();
            this.enterbtn = new System.Windows.Forms.Button();
            this.showpass = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.clearbtn = new System.Windows.Forms.Button();
            this.regbtn = new System.Windows.Forms.Button();
            this.checkrpass = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.passwordreg = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.loginreg = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.trim = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(41, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "EasyTest";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 97);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.label2.Size = new System.Drawing.Size(242, 344);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пусть школьные годы давно прошли. Наши тесты помогут проверить, насколько хорошо " +
    "вы помните то, чему вас учили терпеливые учителя";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(271, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(493, 403);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage1.Controls.Add(this.registbtn);
            this.tabPage1.Controls.Add(this.enterbtn);
            this.tabPage1.Controls.Add(this.showpass);
            this.tabPage1.Controls.Add(this.password);
            this.tabPage1.Controls.Add(this.login);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(485, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Авторизцаия";
            // 
            // registbtn
            // 
            this.registbtn.BackColor = System.Drawing.Color.White;
            this.registbtn.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registbtn.ForeColor = System.Drawing.Color.Cyan;
            this.registbtn.Location = new System.Drawing.Point(223, 238);
            this.registbtn.Name = "registbtn";
            this.registbtn.Size = new System.Drawing.Size(150, 42);
            this.registbtn.TabIndex = 6;
            this.registbtn.Text = "Регистрация";
            this.registbtn.UseVisualStyleBackColor = false;
            this.registbtn.Click += new System.EventHandler(this.registbtn_Click);
            // 
            // enterbtn
            // 
            this.enterbtn.BackColor = System.Drawing.Color.White;
            this.enterbtn.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterbtn.ForeColor = System.Drawing.Color.Cyan;
            this.enterbtn.Location = new System.Drawing.Point(41, 238);
            this.enterbtn.Name = "enterbtn";
            this.enterbtn.Size = new System.Drawing.Size(139, 42);
            this.enterbtn.TabIndex = 5;
            this.enterbtn.Text = "Вход";
            this.enterbtn.UseVisualStyleBackColor = false;
            this.enterbtn.Click += new System.EventHandler(this.enterbtn_Click);
            // 
            // showpass
            // 
            this.showpass.BackColor = System.Drawing.Color.Azure;
            this.showpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showpass.ForeColor = System.Drawing.Color.Cyan;
            this.showpass.Location = new System.Drawing.Point(390, 172);
            this.showpass.Name = "showpass";
            this.showpass.Size = new System.Drawing.Size(44, 30);
            this.showpass.TabIndex = 4;
            this.showpass.Text = "*";
            this.showpass.UseVisualStyleBackColor = false;
            this.showpass.Click += new System.EventHandler(this.showpass_Click);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(41, 172);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(332, 31);
            this.password.TabIndex = 3;
            this.password.Text = "Password123";
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(41, 84);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(332, 31);
            this.login.TabIndex = 2;
            this.login.Text = "Tykyass";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(37, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Логин";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage2.Controls.Add(this.clearbtn);
            this.tabPage2.Controls.Add(this.regbtn);
            this.tabPage2.Controls.Add(this.checkrpass);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.passwordreg);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.loginreg);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.trim);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.name);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.surname);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(485, 377);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Регистрация";
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.White;
            this.clearbtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearbtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.clearbtn.Location = new System.Drawing.Point(250, 292);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(147, 39);
            this.clearbtn.TabIndex = 13;
            this.clearbtn.Text = "Очистить";
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // regbtn
            // 
            this.regbtn.BackColor = System.Drawing.Color.White;
            this.regbtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regbtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.regbtn.Location = new System.Drawing.Point(48, 292);
            this.regbtn.Name = "regbtn";
            this.regbtn.Size = new System.Drawing.Size(147, 39);
            this.regbtn.TabIndex = 12;
            this.regbtn.Text = "Регистрация";
            this.regbtn.UseVisualStyleBackColor = false;
            this.regbtn.Click += new System.EventHandler(this.regbtn_Click);
            // 
            // checkrpass
            // 
            this.checkrpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkrpass.Location = new System.Drawing.Point(265, 206);
            this.checkrpass.Name = "checkrpass";
            this.checkrpass.Size = new System.Drawing.Size(187, 24);
            this.checkrpass.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Azure;
            this.label10.Location = new System.Drawing.Point(295, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Повтор пароля";
            // 
            // passwordreg
            // 
            this.passwordreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordreg.Location = new System.Drawing.Point(265, 147);
            this.passwordreg.Name = "passwordreg";
            this.passwordreg.Size = new System.Drawing.Size(187, 24);
            this.passwordreg.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Azure;
            this.label9.Location = new System.Drawing.Point(330, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Пароль";
            // 
            // loginreg
            // 
            this.loginreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginreg.Location = new System.Drawing.Point(265, 77);
            this.loginreg.Name = "loginreg";
            this.loginreg.Size = new System.Drawing.Size(187, 24);
            this.loginreg.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Azure;
            this.label8.Location = new System.Drawing.Point(330, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Логин";
            // 
            // trim
            // 
            this.trim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trim.Location = new System.Drawing.Point(15, 206);
            this.trim.Name = "trim";
            this.trim.Size = new System.Drawing.Size(196, 24);
            this.trim.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Azure;
            this.label7.Location = new System.Drawing.Point(64, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Отчество";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(15, 147);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(196, 24);
            this.name.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Azure;
            this.label6.Location = new System.Drawing.Point(80, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Имя";
            // 
            // surname
            // 
            this.surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname.Location = new System.Drawing.Point(15, 83);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(196, 24);
            this.surname.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Azure;
            this.label5.Location = new System.Drawing.Point(66, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Фамилия";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Домашнаяя страница";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button showpass;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registbtn;
        private System.Windows.Forms.Button enterbtn;
        private System.Windows.Forms.TextBox checkrpass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox passwordreg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox loginreg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox trim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button regbtn;
    }
}

