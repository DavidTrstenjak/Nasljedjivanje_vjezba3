/*Definirajte klasu Biljka, te definirajte od nje izvedenu klasu Stablo sa sljedećim članicama:
• varijabla tipa bool
opadajuListovi
• svojstvo
OpadajuListovi
• konstruktor
Stablo(bool) koji će dodijeliti vrijednost proslijeñenog argumenta varijabli
opadajuListovi
Definirajte klasu Cvijet izvedenu iz klase Biljka.
Definirajte klase Bijelogoricno i Crnogoricno izvedene iz klase Stablo. Klasama definirajte
odgovarajuće konstruktore.
Definirajte dva objekta Hrast i Bor tipova Bijelogoricno i Crnogoricno, te ispišite vrijednosti
njihovih članica opadajuListovi.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje_vjezba3
{
    internal class Program
    {
        class Biljka
        {
            
        }

        class Stablo : Biljka
        {
            bool otpadajuListovi;

            public Stablo(bool otpadajuListovi)
            {
                OtpadajuListovi = otpadajuListovi;
            }

            public bool OtpadajuListovi { get => otpadajuListovi; set => otpadajuListovi = value; }

            public virtual string Ispis()
            {
                return " " + OtpadajuListovi;
            }
        }

        class Cvijet : Biljka
        {

        }

        class Bjelogoricno : Stablo
        {
            public Bjelogoricno(bool otpadajuListovi) : base(otpadajuListovi)
            {
            }

            public override string Ispis()
            {
                return "Za hrast, otpadanje listova : " + OtpadajuListovi;
            }
        }

        class Crnogoricno : Stablo
        {
            public Crnogoricno(bool otpadajuListovi) : base(otpadajuListovi)
            {
            }

            public override string Ispis()
            {
                return "Za bor, otpadanje listova :  " + OtpadajuListovi;
            }
            

            
        }

        static void Main(string[] args)
        {
            Bjelogoricno hrast = new Bjelogoricno(true);
            Crnogoricno bor = new Crnogoricno(false);

            Console.WriteLine(hrast.Ispis());
            Console.WriteLine(bor.Ispis());


            Console.ReadKey();
        }
    }
}
