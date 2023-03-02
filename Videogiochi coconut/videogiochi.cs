using System;
using System.Collections.Generic;
using System.Xml;

namespace Videogiochi_coconut
{
    public class Personaggio
    {
        public string nome { get; protected set; }
        public int vita { get; protected set; }
        protected Random rnd;

        public Personaggio(string nome)
        {
            this.nome = nome;
            vita = rnd.Next(1, 101);
        }
    }
    public class Guerriero : Personaggio
    {
        int Forza;
        public Guerriero(string nome) : base(nome)
        {
            Forza = rnd.Next(1, 101);
        }
        public string IL_METODO()
        {
            return $"{nome},{vita},{Forza};";
        }
    }
    public class Mago : Personaggio
    {
        int Mana;
        public Mago(string nome) : base(nome)
        {
            Mana = rnd.Next(1, 101);
        }
        public string IL_METODO()
        {
            return $"{nome},{vita},{Mana};";
        }
    }
    public class Curatore : Personaggio
    {
        int Cura;
        public Curatore(string nome) : base(nome)
        {
            Cura = rnd.Next(1, 101);
        }
        public string IL_METODO()
        {
            return $"{nome},{vita},{Cura};";
        }
    }
    public class Boss
    {
        public string nome { get; protected set; }
        public int vita { get; protected set; }
        public int Attacco { get; protected set; }
        protected Random rnd;
        public Boss(string nome)
        {
            this.nome = nome;
            vita = 200;
            Attacco = rnd.Next(1, 301);
        }

        public static Personaggio[] partY;
        private static int n_personaggi = 0;
        private static int ultimo_personaggio_aggiunto = 0;
        public static void Persone_che_giochano(int giochatori)
        {
            n_personaggi = giochatori;
            partY = new Personaggio[n_personaggi];
        }
        public void AgGiUgnGi_PersSoNAggI(int personaggio)
        {
            if (n_personaggi == 0)
            {
                Console.WriteLine("Numero di personaggi non settato");
                return;
            }
            switch (personaggio)
            {
                case 1:
                    Console.WriteLine($"Come vuole chiamare il carratere n°{ultimo_personaggio_aggiunto + 1}");
                    partY[ultimo_personaggio_aggiunto] = new Mago(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine($"Come vuole chiamare il carratere n°{ultimo_personaggio_aggiunto + 1}");
                    partY[ultimo_personaggio_aggiunto] = new Guerriero(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine($"Come vuole chiamare il carratere n°{ultimo_personaggio_aggiunto + 1}");
                    partY[ultimo_personaggio_aggiunto] = new Curatore(Console.ReadLine());
                    break;
                default:
                    return;
            }
            ultimo_personaggio_aggiunto++;
        }
        public string IL_METODO()
        {
            return $"{nome},{vita},{Attacco};";
        }
    }


    public class Round{
        public class Round1
        {
            
        }
        public class Round2
        {

        }
        public class Round3
        {

        }
    }
}
