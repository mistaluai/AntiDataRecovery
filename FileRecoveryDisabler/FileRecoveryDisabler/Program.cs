using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileRecoveryDisabler
{
    class Program
    {
       
         static void Main(string[] args)
        {
            //Variables
            int SizeInteger = int.Parse(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ADRtemp\SizeInteger.temp"));
            string LogicalDrive = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ADRtemp\LogicalDrive.temp");
            int ProgressInteger = 0;
            int ProgressIntegerMax;

            //---------------------------------------

            Directory.CreateDirectory(LogicalDrive + @"\Antidatarecoverytemp");
            DirectoryInfo Hider = new DirectoryInfo(LogicalDrive + @"\Antidatarecoverytemp");
            Hider.Attributes = FileAttributes.Hidden;
            Random rnd = new Random();
            using (StreamWriter sw = new StreamWriter(LogicalDrive + @"\Antidatarecoverytemp\DataKiller.HDS", false, Encoding.Default))
            {
                //create large test file
                for (int j = 0; j < 130; j++)
                {

                    sw.WriteLine("\r\n--====" + j + "=====--\r\n");
                    for (int i = 0; i < 10000; i++)
                        sw.WriteLine(string.Format("N{0:0000} X{1} Y{2} Z{3}", i, rnd.Next(), rnd.Next(), rnd.Next()));
                }
            }
            ProgressIntegerMax = (SizeInteger*1024) / 50;
            File.WriteAllText((Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ADRtemp\ProgressIntegerMax.temp"), ProgressIntegerMax.ToString());
            for (int x = 0; x < ProgressIntegerMax; x++)
            {
                File.Copy(LogicalDrive + @"\Antidatarecoverytemp\DataKiller.HDS", LogicalDrive + @"\Antidatarecoverytemp\DataKiller" + x + ".HDS");
                if (ProgressInteger != ProgressIntegerMax)
                {
                    ProgressInteger++;
                    File.WriteAllText((Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ADRtemp\ProgressInteger.temp"), ProgressInteger.ToString());
                }
            }
            foreach (string FileElement in Directory.GetFiles(LogicalDrive + @"\Antidatarecoverytemp\"))
            {
                File.Delete(FileElement);
            }
            Directory.Delete(LogicalDrive + @"\Antidatarecoverytemp\");
        }
    }
}
