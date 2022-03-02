using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Каждое дело задается:
//текстовой описание, дата, исполнитель, статус (сделать, в процессе, готово).

//После запука приложения на форме отображаются три списка: 
//сделать,
//в процессе,
//готово.
//(данные хранятся в файле)

//Пользователь может:
//добавить новое дело в список "сделать";
//перемещать дело между списками (при этом меняется статус);
//удалить дело из списка "готово".

//Приложение могут использовать несколько пользователей. Для работы
//с приложением необходимо зарегистрироваться. После авторизации пользователю отображается его список дел.


namespace project_OOP // я скопировала данные из проекта, который не смогла загрузить на github namespace из него
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }



        Case_process emp, emp1; // экземпляры класса создания дел

       
        // метод удаления значения из листбокс1 и добавления этого значения в листбокс 2
        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                listBox2.Items.Add(listBox1.SelectedItems[i]);
                listBox1.Items.Remove(listBox1.Items[i]);

            }
        }


        // метод удаления значения из листбокс2 и добавления этого значения в листбокс 3
        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.SelectedItems.Count; i++)
            {
                listBox3.Items.Add(listBox2.SelectedItems[i]);
                listBox2.Items.Remove(listBox2.Items[i]);

            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            Authorization program = new Authorization();
            program.ShowDialog();

        }


        

        public void open_file()
        {
            //открытие файлов в лист боксы, реализовать не получилось, то что получилось идет дальше в button_open_Click 
            //хотела сделать условие в методе SwitchForm класса Authorization , чтобы проверяло определенного пользователя 
            // и открывало все файлы,
            // лист боксы так и оставались пустыми
        }

        private void button_open_Click_1(object sender, EventArgs e)//открытые файлов в лист бокс 
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            string[] gin1 = File.ReadAllLines(@"D:\\1111.txt");
            listBox1.Items.AddRange(gin1);

            string[] gin2 = File.ReadAllLines(@"D:\\1112.txt");
            listBox2.Items.AddRange(gin2);

            string[] gin3 = File.ReadAllLines(@"D:\\1113.txt");
            listBox3.Items.AddRange(gin3);
        }

        private void button_save_Click_1(object sender, EventArgs e) // сохранение данных из трех лист боксов
                                                                     // хотела сделать сохранение в общий файл .cvs не поняла как соединить 3 лист бокса,возможно не поняла задание и нужно было и
                                                                     //использовать не листбоксы
        {
            using (System.IO.StreamWriter rhw = new System.IO.StreamWriter("D:\\1111.txt"))
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                    rhw.WriteLine(listBox1.Items[i].ToString());
                using (System.IO.StreamWriter rhw2 = new System.IO.StreamWriter("D:\\1112.txt"))
                {
                    for (int i = 0; i < listBox2.Items.Count; i++)
                        rhw2.WriteLine(listBox2.Items[i].ToString());
                }
                using (System.IO.StreamWriter rhw3 = new System.IO.StreamWriter("D:\\1113.txt"))
                {
                    for (int i = 0; i < listBox3.Items.Count; i++)
                        rhw3.WriteLine(listBox3.Items[i].ToString());
                }
            }
        }

        private void button_add_Click_1(object sender, EventArgs e)
        {
            // добавление значений из текстбоксов в листбокс "сделать"
            if (textBox_case.Text != "" && textBox_player.Text != "")
            {
                emp = new Case_process(textBox_case.Text, textBox_player.Text, dateTime_1.Text);
                listBox1.Items.Add(emp);
            }
            else if (textBox_case.Text == "" && textBox_player.Text != "")
            {
                emp = new Case_process(textBox_case.Text, textBox_player.Text, dateTime_1.Text);
                listBox1.Items.Add(emp);
            }
            else if (textBox_case.Text == "" && textBox_player.Text == "")
            {
                emp = new Case_process(textBox_case.Text, textBox_player.Text, dateTime_1.Text);
                listBox1.Items.Add(emp);
            }
            else if (textBox_case.Text != "" && textBox_player.Text == "")
            {
                emp = new Case_process(textBox_case.Text, textBox_player.Text, dateTime_1.Text);
                listBox1.Items.Add(emp);
            }
            else
            {
                emp = new Case_process(textBox_case.Text, textBox_player.Text);
                listBox1.Items.Add(emp);
            }
            
        }

        private void button_process_Click(object sender, EventArgs e)
        {
            // добавление значений из текстбоксов в листбокс "в процессе"

            if (textBox_case.Text != "" && textBox_player.Text != "")
            {
                emp1 = new Case_process(textBox_case.Text, textBox_player.Text, dateTime_1.Text);
                listBox2.Items.Add(emp1);
            }
            else if (textBox_case.Text == "" && textBox_player.Text != "")
            {
                emp1 = new Case_process(textBox_case.Text, textBox_player.Text, dateTime_1.Text);
                listBox2.Items.Add(emp1);
            }
            else if (textBox_case.Text == "" && textBox_player.Text == "")
            {
                emp1 = new Case_process(textBox_case.Text, textBox_player.Text, dateTime_1.Text);
                listBox2.Items.Add(emp1);
            }
            else if (textBox_case.Text != "" && textBox_player.Text == "")
            {
                emp1 = new Case_process(textBox_case.Text, textBox_player.Text, dateTime_1.Text);
                listBox2.Items.Add(emp1);
            }
            else
            {
                emp1 = new Case_process(textBox_case.Text, textBox_player.Text, dateTime_1.Text);
                listBox2.Items.Add(emp1);
            }
        }

        private void button4_Click_1(object sender, EventArgs e) 
            // метод удаления значения из листбокс1 и добавления этого значения в листбокс 2
        {
            
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                listBox2.Items.Add(listBox1.SelectedItems[i]);
                listBox1.Items.Remove(listBox1.Items[i]);

            }
        }
        // метод удаления значения из листбокс2 и добавления этого значения в листбокс 3
        private void button5_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.SelectedItems.Count; i++)
            {
                listBox3.Items.Add(listBox2.SelectedItems[i]);
                listBox2.Items.Remove(listBox2.Items[i]);

            }
        }

        private void button_delete_Click(object sender, EventArgs e)    // метод удаления значения из листбокс3
        {

            listBox3.Items.Remove(listBox3.SelectedItem);
            // selectesitem удаляет выбранную строчку из лист бокса


        }


    }
    
}

