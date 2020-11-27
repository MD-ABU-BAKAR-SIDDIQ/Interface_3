using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface3
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone m1 = new Phone("Sound of Silence ", "Ayub Bachchu", 2007, 402);
            m1.ShowInfo();

            Console.WriteLine("\n    Swich On Call");
            m1.switchs(true);
            

            Console.WriteLine("\n    Music Play");
            m1.play(true);
            

            Console.WriteLine("\n    Set Volume Call ");
            m1.setVolume(4); 

            


            Phone m2 = new Phone("Dukhini Dukkho Koro Na", "James", 1997, 350);
            Phone m3 = new Phone("Thik Ache Bondhu ", "James", 1999, 500);
            Phone list = new Phone();

            list.AddMusicFile(m2, m1, m3);
            Console.WriteLine("\n  Next play");
            list.playNext();
            Console.WriteLine("\n  Previous Music play");
            list.playPrevious();
            Console.WriteLine("\n  Music List");
            list.ShowAllMusicFile();

        }
    }
}
