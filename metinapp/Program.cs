using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metinapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StreamWriter sw = new StreamWriter("C:\\Users\\Cetin\\Desktop\\Yeni Metin Belgesi.txt");
            //------------------------------------
            //sw.Write("Bu bir denemedir ");
            //sw.Close();
            //------------------------------------
            //string  metin;
            //Console.WriteLine("Metin giriniz : ");
            //metin = Console.ReadLine();
            //sw.Write(metin);
            //sw.Close();
            //------------------------------------

            FileStream fs=new FileStream("C:\\Users\\Cetin\\Desktop\\metin belgesi okutma.txt ", FileMode.Open,FileAccess.Read);//metin belgesinden dosya okuma
            StreamReader sr=new StreamReader(fs);
            string metin = sr.ReadLine();
            while ( metin != null ) 
            {
                Console.WriteLine( metin );
                metin = sr.ReadLine();
            }
             sr.Close();
             fs.Close();
             






            Console.Read();
        }
    }
}
