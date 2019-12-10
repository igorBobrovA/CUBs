namespace cubs
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VertPB1 = new System.Windows.Forms.PictureBox();
            this.VertPB2 = new System.Windows.Forms.PictureBox();
            this.VertPB3 = new System.Windows.Forms.PictureBox();
            this.VertPB4 = new System.Windows.Forms.PictureBox();
            this.VertPB5 = new System.Windows.Forms.PictureBox();
            this.UserPB1 = new System.Windows.Forms.PictureBox();
            this.UserPB2 = new System.Windows.Forms.PictureBox();
            this.UserPB3 = new System.Windows.Forms.PictureBox();
            this.UserPB4 = new System.Windows.Forms.PictureBox();
            this.UserPB5 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gameCOM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VertPB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VertPB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VertPB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VertPB4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VertPB5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPB4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPB5)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Новая игра";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.Location = new System.Drawing.Point(12, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(304, 59);
            this.button2.TabIndex = 1;
            this.button2.Text = "Бросить кубик";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Игрок";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(233, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "комп";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 38);
            this.label4.TabIndex = 5;
            this.label4.Text = "осталось попыток: 5";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Teal;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(173, 120);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 145);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VertPB1);
            this.groupBox1.Controls.Add(this.VertPB2);
            this.groupBox1.Controls.Add(this.VertPB3);
            this.groupBox1.Controls.Add(this.VertPB4);
            this.groupBox1.Controls.Add(this.VertPB5);
            this.groupBox1.Controls.Add(this.UserPB1);
            this.groupBox1.Controls.Add(this.UserPB2);
            this.groupBox1.Controls.Add(this.UserPB3);
            this.groupBox1.Controls.Add(this.UserPB4);
            this.groupBox1.Controls.Add(this.UserPB5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(338, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 416);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Результаты";
            // 
            // VertPB1
            // 
            this.VertPB1.BackColor = System.Drawing.Color.Teal;
            this.VertPB1.ErrorImage = null;
            this.VertPB1.Location = new System.Drawing.Point(135, 341);
            this.VertPB1.Name = "VertPB1";
            this.VertPB1.Size = new System.Drawing.Size(67, 63);
            this.VertPB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VertPB1.TabIndex = 19;
            this.VertPB1.TabStop = false;
            // 
            // VertPB2
            // 
            this.VertPB2.BackColor = System.Drawing.Color.Teal;
            this.VertPB2.ErrorImage = null;
            this.VertPB2.Location = new System.Drawing.Point(135, 272);
            this.VertPB2.Name = "VertPB2";
            this.VertPB2.Size = new System.Drawing.Size(67, 63);
            this.VertPB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VertPB2.TabIndex = 18;
            this.VertPB2.TabStop = false;
            // 
            // VertPB3
            // 
            this.VertPB3.BackColor = System.Drawing.Color.Teal;
            this.VertPB3.ErrorImage = null;
            this.VertPB3.Location = new System.Drawing.Point(135, 203);
            this.VertPB3.Name = "VertPB3";
            this.VertPB3.Size = new System.Drawing.Size(67, 63);
            this.VertPB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VertPB3.TabIndex = 17;
            this.VertPB3.TabStop = false;
            // 
            // VertPB4
            // 
            this.VertPB4.BackColor = System.Drawing.Color.Teal;
            this.VertPB4.ErrorImage = null;
            this.VertPB4.Location = new System.Drawing.Point(135, 134);
            this.VertPB4.Name = "VertPB4";
            this.VertPB4.Size = new System.Drawing.Size(67, 63);
            this.VertPB4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VertPB4.TabIndex = 16;
            this.VertPB4.TabStop = false;
            // 
            // VertPB5
            // 
            this.VertPB5.BackColor = System.Drawing.Color.Teal;
            this.VertPB5.ErrorImage = null;
            this.VertPB5.Location = new System.Drawing.Point(135, 65);
            this.VertPB5.Name = "VertPB5";
            this.VertPB5.Size = new System.Drawing.Size(67, 63);
            this.VertPB5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VertPB5.TabIndex = 14;
            this.VertPB5.TabStop = false;
            // 
            // UserPB1
            // 
            this.UserPB1.BackColor = System.Drawing.Color.Teal;
            this.UserPB1.ErrorImage = null;
            this.UserPB1.Location = new System.Drawing.Point(11, 341);
            this.UserPB1.Name = "UserPB1";
            this.UserPB1.Size = new System.Drawing.Size(67, 63);
            this.UserPB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPB1.TabIndex = 13;
            this.UserPB1.TabStop = false;
            // 
            // UserPB2
            // 
            this.UserPB2.BackColor = System.Drawing.Color.Teal;
            this.UserPB2.ErrorImage = null;
            this.UserPB2.Location = new System.Drawing.Point(11, 272);
            this.UserPB2.Name = "UserPB2";
            this.UserPB2.Size = new System.Drawing.Size(67, 63);
            this.UserPB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPB2.TabIndex = 12;
            this.UserPB2.TabStop = false;
            // 
            // UserPB3
            // 
            this.UserPB3.BackColor = System.Drawing.Color.Teal;
            this.UserPB3.ErrorImage = null;
            this.UserPB3.Location = new System.Drawing.Point(11, 203);
            this.UserPB3.Name = "UserPB3";
            this.UserPB3.Size = new System.Drawing.Size(67, 63);
            this.UserPB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPB3.TabIndex = 11;
            this.UserPB3.TabStop = false;
            // 
            // UserPB4
            // 
            this.UserPB4.BackColor = System.Drawing.Color.Teal;
            this.UserPB4.ErrorImage = null;
            this.UserPB4.Location = new System.Drawing.Point(11, 134);
            this.UserPB4.Name = "UserPB4";
            this.UserPB4.Size = new System.Drawing.Size(67, 63);
            this.UserPB4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPB4.TabIndex = 10;
            this.UserPB4.TabStop = false;
            // 
            // UserPB5
            // 
            this.UserPB5.BackColor = System.Drawing.Color.Teal;
            this.UserPB5.ErrorImage = null;
            this.UserPB5.Location = new System.Drawing.Point(11, 65);
            this.UserPB5.Name = "UserPB5";
            this.UserPB5.Size = new System.Drawing.Size(67, 63);
            this.UserPB5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPB5.TabIndex = 9;
            this.UserPB5.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(130, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "комп: 0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(6, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Игрок: 0";
            // 
            // gameCOM
            // 
            this.gameCOM.AutoSize = true;
            this.gameCOM.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameCOM.ForeColor = System.Drawing.Color.Lime;
            this.gameCOM.Location = new System.Drawing.Point(183, 20);
            this.gameCOM.Name = "gameCOM";
            this.gameCOM.Size = new System.Drawing.Size(149, 38);
            this.gameCOM.TabIndex = 9;
            this.gameCOM.Text = "megaGame";
            this.gameCOM.Click += new System.EventHandler(this.gameCOM_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(592, 439);
            this.Controls.Add(this.gameCOM);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.Text = "Кубы";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VertPB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VertPB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VertPB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VertPB4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VertPB5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPB4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPB5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox VertPB1;
        private System.Windows.Forms.PictureBox VertPB2;
        private System.Windows.Forms.PictureBox VertPB3;
        private System.Windows.Forms.PictureBox VertPB4;
        private System.Windows.Forms.PictureBox VertPB5;
        private System.Windows.Forms.PictureBox UserPB1;
        private System.Windows.Forms.PictureBox UserPB2;
        private System.Windows.Forms.PictureBox UserPB3;
        private System.Windows.Forms.PictureBox UserPB4;
        private System.Windows.Forms.PictureBox UserPB5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label gameCOM;
    }
}

