using System;
using Videogiochi_coconut;
using System.Collections.Generic;
using System.Text;

namespace mainino
{
    class Program
    {
        static void Main(string[] args)
        {
            Personaggio[] partY = new Personaggio[4];
            Console.WriteLine("Inserire il nome del boss");
            Boss Boos_epico = new Boss(Console.ReadLine());
            Console.Clear();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Che personaggio vuole n°{i + 1}");
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            Console.WriteLine($"Come vuole chiamare il carratere n°{i + 1}");
                            partY[i] = new Mago(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine($"Come vuole chiamare il carratere n°{i + 1}");
                            partY[i] = new Guerriero(Console.ReadLine());
                            break;
                        case 3:
                            Console.WriteLine($"Come vuole chiamare il carratere n°{i + 1}");
                            partY[i] = new Curatore(Console.ReadLine());
                            break;
                        default:
                            Console.WriteLine("He, He, He, Haw");
                            i--;
                            break;
                    }
            }


        }
    }
}
