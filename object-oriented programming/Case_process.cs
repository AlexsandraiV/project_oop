using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_OOP
{
    class Case_process
    // класс создания дел 
    {
        public List<Case_process> dolist = new List<Case_process>();

        // три поля
        private string project; // поле для реализации дела
        private string player;  // поле для пользователя 
        private string data; // поле для заполнения даты

        // конструкторы 
        public Case_process(string project, string player, string data) //коструктор с тремя параметрами
        {
            this.project = project;
            this.player = player;
            this.data = data;
        }
        public Case_process(string project, string player) // конструктор с двумя параметрами
        {
            this.project = project;
            this.player = player;
            this.data = "";
        }
        public Case_process(string project) // конструктор с одним параметром
        {
            this.project = project;
            this.player = "";
            this.data = "";
        }

        override
        public String ToString() // метод для вывода данных (в дальнейшем в лист бокс)
        {
            return $" Дело {this.project}  Пользователь  {this.player}  Дата {this.data}";
        }
    }
}