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
        public int Forza;
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
        public int Mana;
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
        public int Cura;
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
        public int vita;
        public int Attacco { get; protected set; }
        protected Random rnd;
        public Boss(string nome)
        {
            this.nome = nome;
            vita = 200;
            Attacco = rnd.Next(1, 301);
        }
        public string IL_METODO()
        {
            return $"{nome},{vita},{Attacco};";
        }
    }
}
