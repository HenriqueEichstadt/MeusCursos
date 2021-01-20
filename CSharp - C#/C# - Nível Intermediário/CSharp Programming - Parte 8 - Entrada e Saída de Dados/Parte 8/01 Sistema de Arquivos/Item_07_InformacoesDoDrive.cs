using System;
using System.IO;

namespace Listings
{
    class Item_07_InformacoesDoDrive
    {
        private const int Kilobyte = 1024;
        
        static void XMain(string[] args)
        {
            //TAREFA:
            //=======
            //Nome do drive
            //Verificar se o drive está pronto
            //Tipo do drive
            //Formato do drive
            //Espaço livre, em bytes, MB, GB e TB

            var drives = DriveInfo.GetDrives();

            foreach (var drive in drives)
            {
                Console.WriteLine($"Nome: {drive.Name}");
                Console.WriteLine();
                if (!drive.IsReady)
                {
                    Console.WriteLine("O drive não está pronto");
                    continue;
                }

                Console.WriteLine($"Tipo: {drive.DriveType}");
                Console.WriteLine($"Formato: {drive.DriveFormat}");

                Console.WriteLine($"Espaço livre:");

                long bytes = drive.TotalFreeSpace;
                Console.WriteLine("{0} bytes", bytes);

                double kb = bytes / Kilobyte;
                Console.WriteLine("{0:N2} KB", kb);
                
                double mb = kb / Kilobyte;
                Console.WriteLine("{0:N2} MB", mb);

                double gb = mb / Kilobyte;
                Console.WriteLine("{0:N2} GB", gb);

                double tb = gb / Kilobyte;
                Console.WriteLine("{0:N2} TB", tb);

            }
        }
    }
}
