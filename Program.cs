using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarAtmaOyunu
{
    class Program
    {
        static void Main(string[] args)
        {

            Random zar = new Random();
            int roll1 = zar.Next(1, 7);
            int roll2 = zar.Next(1, 7);
            int roll3 = zar.Next(1, 7);
            int toplam = roll1 + roll2 + roll3;

            Console.WriteLine("Roll 1 :" + roll1);
            Console.WriteLine("Roll 2 :" + roll2);
            Console.WriteLine("Roll 3 :" + roll3);

            if (roll1 == roll2 || roll2 == roll3 || roll1 == roll3)
            {
                if (roll1==roll2 && roll2==roll3)
                {
                    Console.WriteLine("Tebrikler Üç Roll Aynı +6 Puan Kazandınız!");
                    toplam += 6;
                }
                else
                {
                    Console.WriteLine("Tebrikler İki Roll Aynı +2 Puan Kazandınız!");
                    toplam += 2;
                }
            }
            if (toplam>=15)
            {
                Console.WriteLine("Tebrikler Kazandınız! Toplam Puan:"+toplam );
            }
            else
            {
                Console.WriteLine("Kaybettiniz Toplam Puan:"+toplam);
            }
            Console.ReadLine();


        }
    }
}
