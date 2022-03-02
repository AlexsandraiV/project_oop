
namespace project_OOP
{
    partial class Authorization
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_pin = new System.Windows.Forms.TextBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.button_reg = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "пароль";
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(73, 44);
            this.textBox_login.Multiline = true;
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(143, 36);
            this.textBox_login.TabIndex = 2;
            // 
            // textBox_pin
            // 
            this.textBox_pin.Location = new System.Drawing.Point(73, 99);
            this.textBox_pin.Multiline = true;
            this.textBox_pin.Name = "textBox_pin";
            this.textBox_pin.Size = new System.Drawing.Size(143, 36);
            this.textBox_pin.TabIndex = 3;
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(73, 141);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(90, 39);
            this.button_ok.TabIndex = 4;
            this.button_ok.Text = "Авторизация";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Enabled = false;
            this.buttonOK.Location = new System.Drawing.Point(169, 141);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(47, 39);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // button_reg
            // 
            this.button_reg.Location = new System.Drawing.Point(73, 186);
            this.button_reg.Name = "button_reg";
            this.button_reg.Size = new System.Drawing.Size(143, 38);
            this.button_reg.TabIndex = 6;
            this.button_reg.Text = "Регистрация";
            this.button_reg.UseVisualStyleBackColor = true;
            this.button_reg.Click += new System.EventHandler(this.button_reg_Click);
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_close.Location = new System.Drawing.Point(222, 230);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(47, 39);
            this.button_close.TabIndex = 7;
            this.button_close.Text = "Х";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click_1);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 296);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_reg);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.textBox_pin);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Authorization";
            this.Text = "Authorization";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Authorization_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_pin;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button button_reg;
        private System.Windows.Forms.Button button_close;
    }
}