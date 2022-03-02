using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_OOP
{


    public partial class Authorization : Form
    {



        // поля
        public string login1 = string.Empty;
        public string pin1 = string.Empty;
        private Accountadd user = new Accountadd(); //созданеи экземпляра класса Accountadd


        public Authorization()
        {
            InitializeComponent();
            LoadAccountadd(); // метод десериализации
        }


        // метод
        private void LoadAccountadd()
        {
            try
            {
                FileStream rhs = new FileStream("Accountadd.dat", FileMode.Open); //обьект класса FileStream  для чтения и записи
                BinaryFormatter form = new BinaryFormatter(); // объект класса BinaryFormatter для преобразования в  поток байтов
                user = (Accountadd)form.Deserialize(rhs); // обратный процесс BinaryFormatter - десериализация
                rhs.Close();

            }
            catch
            {
                return;
            }
        }

        private void SwitchForm() // метод авторизации с проверкой
        {
            for (int i = 0; i < user.login.Count; i++)
            {
                if (user.login[i] == textBox_login.Text && user.pin[i] == textBox_pin.Text)
                {
                    login1 = user.login[i];
                    pin1 = user.pin[i];
                    MessageBox.Show("Авторизация прошла успешно!");
                    if (user.login[i] == "1111" && user.pin[i] == "1111")
                    {
                        Form1 y = new Form1();
                        y.open_file(); // метод пустой, класс Form1
                    }
                    buttonOK.Enabled = true;

                }
                else if (user.login[i] == textBox_login.Text && user.pin[i] != textBox_pin.Text)
                {
                    login1 = user.login[i];
                    MessageBox.Show("Неверный пароль");
                }
            }
            if (login1 == "")
            {
                MessageBox.Show("Пользователь " + textBox_login.Text + " не найден!");
            }
        }


        private void UserAdd() //метод регистрации
        {
            if (textBox_login.Text == "" || textBox_pin.Text == "")
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }


            user.login.Add(textBox_login.Text);
            user.pin.Add(textBox_pin.Text);

            FileStream rhs = new FileStream("Accountadd.dat", FileMode.OpenOrCreate);

            BinaryFormatter form = new BinaryFormatter();
            form.Serialize(rhs, user);

            rhs.Close();
            login1 = textBox_login.Text;


        }



        
        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close(); // закрытие формы
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SwitchForm(); // при нажатии на кнопку вызываем метод авторизации 
        }

        private void button_close_Click_1(object sender, EventArgs e)
        {
            Application.Exit(); //закрытие программы
        }

        private void Authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (login1 == "" | pin1 == "") { Application.Exit(); }
        }

        private void button_reg_Click(object sender, EventArgs e)
        {
            UserAdd(); // при нажатии на кнопку вызываем метод регистрации и записываем логин и пароль в документ  Accountadd.dat
        }
    }
}
