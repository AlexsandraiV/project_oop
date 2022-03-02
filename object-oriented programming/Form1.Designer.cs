
namespace project_OOP
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
            this.textBox_case = new System.Windows.Forms.TextBox();
            this.textBox_player = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_process = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dateTime_1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_open = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_case
            // 
            this.textBox_case.Location = new System.Drawing.Point(12, 51);
            this.textBox_case.Multiline = true;
            this.textBox_case.Name = "textBox_case";
            this.textBox_case.Size = new System.Drawing.Size(246, 51);
            this.textBox_case.TabIndex = 1;
            // 
            // textBox_player
            // 
            this.textBox_player.Location = new System.Drawing.Point(12, 140);
            this.textBox_player.Multiline = true;
            this.textBox_player.Name = "textBox_player";
            this.textBox_player.Size = new System.Drawing.Size(246, 51);
            this.textBox_player.TabIndex = 8;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(264, 51);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 51);
            this.button_add.TabIndex = 9;
            this.button_add.Text = "Создать";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click_1);
            // 
            // button_process
            // 
            this.button_process.Location = new System.Drawing.Point(264, 140);
            this.button_process.Name = "button_process";
            this.button_process.Size = new System.Drawing.Size(75, 51);
            this.button_process.TabIndex = 10;
            this.button_process.Text = "В процессе";
            this.button_process.UseVisualStyleBackColor = true;
            this.button_process.Click += new System.EventHandler(this.button_process_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(357, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(259, 277);
            this.listBox1.TabIndex = 11;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(622, 51);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(259, 277);
            this.listBox2.TabIndex = 18;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(887, 51);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(259, 277);
            this.listBox3.TabIndex = 19;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(980, 334);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(76, 84);
            this.button_delete.TabIndex = 20;
            this.button_delete.Text = "Удалить  дело";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(595, 334);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 84);
            this.button4.TabIndex = 21;
            this.button4.Text = ">";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(860, 334);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(53, 84);
            this.button5.TabIndex = 22;
            this.button5.Text = ">";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // dateTime_1
            // 
            this.dateTime_1.Location = new System.Drawing.Point(34, 197);
            this.dateTime_1.Name = "dateTime_1";
            this.dateTime_1.Size = new System.Drawing.Size(200, 20);
            this.dateTime_1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Дело";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Пользователь";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Дата";
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(183, 334);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(75, 84);
            this.button_open.TabIndex = 27;
            this.button_open.Text = "Открыть";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click_1);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(264, 334);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 84);
            this.button_save.TabIndex = 28;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 523);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTime_1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_process);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_player);
            this.Controls.Add(this.textBox_case);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_case;
        private System.Windows.Forms.TextBox textBox_player;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_process;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker dateTime_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button button_save;
    }
}

