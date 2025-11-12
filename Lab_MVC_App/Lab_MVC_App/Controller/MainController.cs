using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_MVC_App.Model;

namespace Lab_MVC_App.Controller
{
    public class MainController // викликає методи з моделі та повертає результати у вигляді, зручному для відображення. 
    {
        private MainModel model = new MainModel(); // створення еземпляра моделі

        public double Calculate(string operation, double a, double b) // метод для виконання арифметичних операцій
        {
            switch (operation)
            {
                case "+":
                    return model.Add(a, b);
                case "-":
                    return model.Subtract(a, b);
                case "*":
                    return model.Multiply(a, b);
                case "/":
                    return model.Divide(a, b);
                default:
                    return 0;
            }
        }

        public string CheckAgeCategory(int age) // метод для визначення категорії віку
        {
            return model.GetAgeCategory(age);
        }

        public string GenerateTable(int number) // метод для генерації таблиці множення
        {
            return model.GetMultiplicationTable(number);
        }
    }
}
