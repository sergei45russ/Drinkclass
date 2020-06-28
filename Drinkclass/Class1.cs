using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksClass
{
    class Alcoholic
    {
        public int price { get; set; }
        public double percent { get; set; }
        public string ingredients { get; set; }
        public string name { get; set; }

        public void GetAlcoholicInfo()
        {
            Console.WriteLine($"Имя: {name}| |Цена (в руб): {price}| |Процент алкоголя (В % об): {percent}| |Состав: {ingredients}|");
        }
    }

    
    class NonAlcoholic : Alcoholic
    {
        public string type { get; set; }

        public virtual void GetNonAlcoholicInfo()
        {
            Console.WriteLine($"Имя: {name}| |Цена (в руб): {price}| |Тип: {type}|  |Процент алкоголя (В % об): {percent}| |Состев: {ingredients}|");
        }
    }
}