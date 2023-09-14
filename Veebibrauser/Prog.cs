using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veebibrauser
{
    public class Program
    {
        public static void Main()
        {
            // Loome brauseri eksemplari.
            Browser site = new Browser();

            // Toome välja kasutajajuhised.
            Console.WriteLine("näidata ajalugu   history\n" +
                              "edasi             forward\n" +
                              "tagasi            back\n" +
                              "praegune          current");
            Console.WriteLine("");

            while (true)
            {
                Console.Write("G:\\Web Browser> ");
                string link = Console.ReadLine();

                // Kui kasutaja sisestab "history", näidatakse külastatud saitide ajalugu.
                if (link == "history" || link == "h")
                {
                    Console.WriteLine("");
                    for (int i = 0; i < site.History().Count; i++)
                    {
                        Console.WriteLine(site.History()[i]);
                    }
                    Console.WriteLine("");
                }

                // Kui kasutaja sisestab "forward", liigume edasi järgmisele lehele ajaloos.
                else if (link == "forward" || link == "f")
                {
                    site.Forward();
                    Console.WriteLine(site.Current());
                }

                // Kui kasutaja sisestab "back", naaseme ajaloo eelmisele lehele.

                else if (link == "back" || link == "b")
                {
                    site.Back();
                    Console.WriteLine(site.Current());
                }

                // Kui kasutaja sisestab "current", kuvatakse konsoolil tõeline leht.
                else if (link == "current" || link == "c")
                {
                    Console.WriteLine(site.Current());
                }

                // Vastasel juhul liigume kasutaja sisestatud lingile.
                else { site.GoTo(link); }
            }
        }
    }

}