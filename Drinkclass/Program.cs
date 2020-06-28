using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Alcoholic alcoholic = new Alcoholic();
            alcoholic.name = "Пиво";
            alcoholic.price = 56;
            alcoholic.percent = 3.5;
            alcoholic.ingredients = "Вода, солод, дрожжи, хмель";

            alcoholic.GetAlcoholicInfo();

            NonAlcoholic nonAlcoholic = new NonAlcoholic();
            nonAlcoholic.type = "Без алкогольное";
            nonAlcoholic.name = "Лимонад";
            nonAlcoholic.ingredients = "Вода, сахар, сок лимона или лимонная кислота";
            nonAlcoholic.price = 42;
            nonAlcoholic.percent = 0;

            nonAlcoholic.GetNonAlcoholicInfo();

            Console.ReadLine();
        }
    }
}
