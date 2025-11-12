using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_MVC_App.Model
{
    public class MainModel // відповідає за логіку обчислення і обробку даних
    {
        public double Add(double a, double b) => a + b;   // арифметичні операції + - * /
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b) => a / b;
    
        public string GetAgeCategory(int age) // визначення вікової категорії 
        {
            if (age < 13)
                return "Дитина";
            else if (age < 18)
                return "Підліток";
            else if (age < 65)
                return "Дорослий";
            else
                return "Людина похилого віку";        
        }

        public string GetMultiplicationTable(int number) // генерація таблиці множення для заданого числа
        {
            string table = "";
            for (int i = 1; i <= 10; i++)
            {
                table += $"{number} * {i} = {number * i}\r\n";
            }
            return table;
    }    }
}
