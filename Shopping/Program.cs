using System;

namespace Shopping
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            int crystalPrice = 12;
            int gold;
            int purchasedCrystals;

            Console.WriteLine("Приветствую вам в моем магазине Кристаллов!");
            Console.WriteLine("Один кристалл за 12 золотых. Хорошее предложение, верно?");
            Console.WriteLine("");

            Console.Write("Сколько у вас золота? " );
            gold = Convert.ToInt32(Console.ReadLine());

            Console.Write("Сколько хотите купить кристаллов? ");
            purchasedCrystals = Convert.ToInt32(Console.ReadLine());

            gold -= (purchasedCrystals * crystalPrice);

            Console.Write("У вас осталось золота: " + goldOfPlayer) ;
            Console.WriteLine(" ");
            Console.Write("Вы купили " + purchasedCrystals + " кристаллов.");
        }  
    }
}
