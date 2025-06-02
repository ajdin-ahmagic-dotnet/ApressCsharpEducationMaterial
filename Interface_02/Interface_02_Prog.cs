using System;
using System.Collections.Generic;
using System.Linq;

namespace Interface_02
{
    class Interface_02_Prog
    {
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║                   --- DOBRODOŠLI U: INTERFACES PRIMJER 1 ---                   ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);


            Hexagon hex = new Hexagon("Aydin");
            hex.DrawAbstract();
            Console.WriteLine("Tačaka: {0}", hex.Points);

            // U gornjem primjeru sve radi kako treba jer znamo da dani tip implementira interface.
            // Ali kako da znamo da li odreni tip ne implementira interfejs a nismo u mogućnosti to saznati?
            // To možemo uraditi kroz explicitni cast da vidimo da li određeni tip podržava taj interface:

            #region DELIMITER
            Console.WriteLine();
            #endregion


            Circle cir = new Circle("Edin");
            cir.DrawAbstract();


            IPointy itfPt = null;
            try
            {
                itfPt = (IPointy)cir;
                Console.WriteLine(itfPt.Points);
            }
            catch(InvalidCastException ex)
            {
                // I kao što smo očeikavali ovaj catch se aktivira.
                Console.WriteLine(ex.Message);
            }

            // Iako mi možemo ovako provjeriti da li određena klasa podržava interface, ima boljih načina da se to sazna.
            // to možemo saznati koristeći "as" ključnu riječ.

            #region DELIMITER
            Console.WriteLine();
            #endregion

            // Ako objekt može biti tretiran kao "as" specificirani interface, vraća nam se referenca od interface-a u pitanju.
            // Ako ne, dobićemo null reference! Tako da trebamo paziti da provjerimo null vrijednosti prije nego što krenemo...
            Hexagon hex2 = new Hexagon("Marlena");
            hex2.DrawAbstract();

            // Provjera interface-a:
            IPointy itfPt2 = hex2 as IPointy;

            // Provjera null reference:
            if(itfPt2 != null)
            {
                Console.WriteLine("Tačke: {0}.", itfPt2.Points);
            }
            else
            {
                Console.WriteLine("UUPS! Nije IPointy...");
            }

            // Možemo primjetiti da sada nismo koristili try-catch, dano da referenca nije nula, 
            //i znamo da pozivamo validnu interface referencu.


            #region DELIMITER
            Console.WriteLine();
            #endregion

            // Isto tako možemo provjeriti da li određena klasa podržava interface sa "is" ključnom riječju.
            // U ovom slučaju ako objekt nije kompatibilan sa određenim nam interface-om vratit će nam 
            // vrijednost "false". A ako znamo da provjeravamo interface na mjestu, onda nam ne treba try-catch blok.

            // Pretpostavimo da imamo kolekciju Shape objekata koje implementiraju IPointy interface, pa ćemo 
            // kroz "is" ključnu riječ provjeriti koji su to članovi koji podržavaju IPointy:

            // Napravićemo array od Shape-a:
            Shape[] oblici = { new Hexagon(), new Circle(),
                                 new Triangle("Edo"), new Circle("Ajdo")}; 

            // Sada nam treba petlja da prođemo kroz objekte:
            for(int i = 0; i < oblici.Length; i++)
            {
                // Podjestimo se da Shape bazna klasa definira abstraktnu metodu DrawAbstract()
                // tako da svi oblici "Shapes" znaju da se sami nacrtaju.
                oblici[i].DrawAbstract();

                // Tko je od njih tačkast? tj. Pointy
                if(oblici[i] is IPointy)
                {
                    Console.WriteLine("-> Tačke: {0}.", ((IPointy)oblici[i]).Points);
                }
                else
                {
                    Console.WriteLine("-> {0}\'s nisu Pointy!", oblici[i].Name);
                }

            }


            #region DELIMITER
            Console.WriteLine();
            #endregion

            // Sve isto kao u gornjem primjeru samo malo promjena radi prosljeđivanja interface-a
            // kao parametra metodi i sada uzetog kao argumenta...
            Shape[] nOblici = { new Hexagon("Hex"), new Circle("Krug"), new Triangle("Trokut"), new Circle("Krug") };

            // Sada nam treba petlja da prođemo kroz objekte:
            for(int i = 0; i < nOblici.Length; i++)
            {
                // Podjestimo se da Shape bazna klasa definira abstraktnu metodu DrawAbstract()
                // tako da svi oblici "Shapes" znaju da se sami nacrtaju.
                nOblici[i].DrawAbstract();

                // Mogu li te nacrtati u 3D-u?
                if(nOblici[i] is IDraw3D)
                {
                    DrawIn3D((IDraw3D)nOblici[i]);
                }
                else
                {
                    Console.WriteLine("-> {0}\'ovi nisu Pointy!", nOblici[i].Name);
                }

            }

            #region DELIMITER
            Console.WriteLine();
            #endregion


            // Interface-i isto tako mogu vrati vrijednosti. Mogu se koristiti kao metodno vraćanje vrijdnosti.
            // Npr. Možemo napisti metodu koju uzima array od Shape objekta i vraća referencu od prvog koji 
            // podržava IPointy interface.

            Shape[] n2Oblici = { new Circle("Pek"), new Circle("Dek"), new Triangle("Đek"), new Hexagon("Tek") };
            
            // Dobavi prvu pointy stavku.
            // Zbog sigurnosti, trebali bi provjeriti prvuPointyStavku za "null reference"!
            IPointy prvaPointyStavka = NadjiPrviIPointyShape(n2Oblici);
            Console.WriteLine("Stavka ima {0} tačaka.", prvaPointyStavka.Points);

            #region DELIMITER
            Console.WriteLine();
            #endregion

            // Sada kada smo kreirali još tri klase "Fork", "Pitchfork" i "Knife", a sve klase implementiraju 
            // IPointy Interface, možemo napraviti array svih tih objekata koji podržavaju taj interface, tre-
            // tirajući svaki od njih kao kompatibilan bez obzira na razlike u klasnoj hijerarhiji.
            Console.WriteLine("=> Array klasa koje imaju zajednički interface IPointy:");
            Console.WriteLine();
            IPointy[] mojiPointObjekti = { new Hexagon(), new Knife(), new Triangle(), new Fork(), new PitchFork() };

            foreach(IPointy i in mojiPointObjekti)
            {
                Console.WriteLine("Objekt ima {0} tačaka. {1}.", i.Points, i.GetType().Name);
            }

            #region DELIMITER
            Console.WriteLine();
            #endregion

            // Ekstraktovani interface u klasi HexExtract:
            Console.WriteLine("=> ETRAKTOVANI INTERFACE NA NOVU KLASU KOJA GA IMPLEMENTIRA:");
            Console.WriteLine();
                
            HexExtract hExt = new HexExtract("NoviHex");
            hExt.DrawAbstract();
            hExt.Draw3D();

            Console.WriteLine("Ovaj novi Objekt '{0}' je proizvod naljeđene klase 'Shape' i Extraktovanog interface-a. Ima {1} tačaka!", hExt.Name, hExt.Points);


            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();
        }
        private static void NapisiPunuCrtu40(string ulaz)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(ulaz);
        }

        // Prosljeđivanje interface-a kao parametra metodi, je moguće 
        // s obzirom da su interface-i validni .net tipovi.
        static void DrawIn3D(IDraw3D itf3d)
        {
            Console.WriteLine("-> Crtanje IDraw3D kompatiblinog tipa.");
            itf3d.Draw3D();
        }

        // Evo metode koja vraća vrijednost:
        static IPointy NadjiPrviIPointyShape(Shape[] shapes)
        {
            // Ovdje kombiniramo "is" i "as" ključne riječi!
            foreach(Shape s in shapes)
            {
                // Ako je Shape "s" stvarno "IPointy" interface, onda vrati "s" "kao-as" IPointy interface.
                if(s is IPointy)
                    return s as IPointy;
            }
            // Ako nije tako vrati nulu...
            return null;
        }
    }
}
