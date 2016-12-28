using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SuperPuzzle
{
    
    class SuperPuzzle
    {
        static void Main(string[] args)
        {
            LoadLogo loadLogo = new LoadLogo();
            loadLogo.LoadLogoNow();
            LoadControlButtonInfo loadControlButtons = new LoadControlButtonInfo();
            loadControlButtons.LoadInfo();

            Console.ReadKey();
            Console.Clear();
            DifficutlyLevel difficutlyLevel = new DifficutlyLevel();
            difficutlyLevel.SelectLevel();
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
