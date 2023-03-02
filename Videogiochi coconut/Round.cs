using System;
using System.Collections.Generic;
using System.Text;

namespace Videogiochi_coconut
{
    public class Round
    {
        static int vita = 0;
        private static bool attaco(Personaggio[] partY, Boss Boss_epico)
        {
            int danno = 0;
            for (int i = 0; i < partY.Length; i++)
                switch (partY[i])
                {
                    case Mago mago:
                        danno += mago.Mana;
                        break;
                    case Guerriero guerriero:
                        danno += guerriero.Forza;
                        break;
                }
            Boss_epico.vita -= danno;
            if (Boss_epico.vita < 0)
                return false;
            return true;
        }
        private static bool attaco_boss(Personaggio[] partY, Boss Boss_epico)
        {
            vita -= Boss_epico.Attacco;

            
            if (Boss_epico.vita < 0)
            {
                Console.WriteLine("THE GHE PERZHOO !!!11!1!1!!!!!!!!11111");
                return true;
            }

            if (Boss_epico.vita < 50)
                for (int i = 0; i < partY.Length; i++)
                    switch (partY[i])
                    {
                        case Curatore curatore:
                            vita += curatore.Cura;
                            return false;
                    }
            Console.WriteLine("IHL PARTHI ZHEEEHE SOPPRAHVISHUO GG FOR NHOW GHWOOD LHUCK FOHR NEHXT HONE!11!!!11!!!!!!!1111!!1!!!!!1!11!");
            return false;

        }
        public static void Round1(Personaggio[] partY, Boss Boss_epico)
        {
            for (int i = 0; i < partY.Length; i++)
                vita += partY[i].vita;
            if (attaco(partY, Boss_epico))
                Console.WriteLine("!!11!!1!!!!!!!11!EBBIGGO THE GHE VINTHOOOHO!1!11!!!!11!");
            else
            {
                Console.WriteLine("NON THE GHE ANCORAH VINTHOO \nNHEXT RoUHND \nINICZIO ROUNHD DDOHS !!111!1!!!1!1!!!1!1!");
                Round2(partY, Boss_epico);
            }
        }
        public static void Round2(Personaggio[] partY, Boss Boss_epico)
        {
            if(attaco_boss(partY, Boss_epico))
                Console.WriteLine("BJETTER LHUCK NHEXT TYHME :)");
            else
            {
                Console.WriteLine("NHEXT RHOUND1!!11!1!!11!");
                Round3(partY, Boss_epico);
            }
        }
        public static void Round3(Personaggio[] partY, Boss Boss_epico)
        {
            while (true)
            {
                if (attaco(partY, Boss_epico))
                {
                    Console.WriteLine("!!11!!1!!!!!!!11!EBBIGGO THE GHE VINTHOOOHO!1!11!!!!11!");
                    return;
                }
                if (attaco_boss(partY, Boss_epico))
                {
                    Console.WriteLine("!!11!!1!!!!!!!11!EBBIGGO THE GHE PERZOHHOOOO!1!11!!!!11!");
                    return;
                }
            }
        }
    }
}
