namespace Tesstrterrr
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chooseres = new System.Windows.Forms.ComboBox();
            this.showres = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.showneedres = new System.Windows.Forms.TextBox();
            this.exitbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.pictureBox1.Location = new System.Drawing.Point(12, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 405);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Мои результаты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PowderBlue;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выберите тест";
            // 
            // chooseres
            // 
            this.chooseres.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseres.FormattingEnabled = true;
            this.chooseres.Location = new System.Drawing.Point(36, 77);
            this.chooseres.Name = "chooseres";
            this.chooseres.Size = new System.Drawing.Size(729, 27);
            this.chooseres.TabIndex = 3;
            // 
            // showres
            // 
            this.showres.BackColor = System.Drawing.Color.White;
            this.showres.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showres.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.showres.Location = new System.Drawing.Point(334, 119);
            this.showres.Name = "showres";
            this.showres.Size = new System.Drawing.Size(252, 35);
            this.showres.TabIndex = 4;
            this.showres.Text = "Перейти к тестированию";
            this.showres.UseVisualStyleBackColor = false;
            this.showres.Click += new System.EventHandler(this.showres_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PowderBlue;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "История прохождения тестов";
            // 
            // showneedres
            // 
            this.showneedres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showneedres.Location = new System.Drawing.Point(36, 202);
            this.showneedres.Multiline = true;
            this.showneedres.Name = "showneedres";
            this.showneedres.Size = new System.Drawing.Size(729, 170);
            this.showneedres.TabIndex = 6;
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.White;
            this.exitbtn.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitbtn.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.exitbtn.Location = new System.Drawing.Point(614, 388);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(151, 35);
            this.exitbtn.TabIndex = 7;
            this.exitbtn.Text = "Выйти";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Location = new System.Drawing.Point(614, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Показать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.showneedres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.showres);
            this.Controls.Add(this.chooseres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Панель пользователя";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox chooseres;
        private System.Windows.Forms.Button showres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox showneedres;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button button1;
    }
}