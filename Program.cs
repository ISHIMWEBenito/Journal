//Write a text file - Version 2
using System;
using System.IO;
using System.Text;
namespace readwriteapp
{
    class Class1
    {
        [STAThread]
        static void Main(string[] args)
        {
            Int64 x;
            try
            {
                //Open the File
                StreamWriter sw = new StreamWriter("C:/Users/Full Stack Developer/Downloads/Phito/journal/Journal.txt", true, Encoding.ASCII);
               
               ////////////////////////////////////////////////////////////
                DateTime dateTime = DateTime.UtcNow.Date;
                string stopWriting="stop";
                string journal="";
                StringComparison comp = StringComparison.OrdinalIgnoreCase;
                Boolean check = journal.Contains(stopWriting, comp);
                Console.WriteLine("To start to write in Captain's journal type start and stop to end writing");
                string startWriting= Console.ReadLine();

                if (startWriting == "start") 
                {
                sw.WriteLine("Captain's log");
                sw.WriteLine("Stardate " + dateTime.ToString("dd/MM/yyyy"));
                journal = Console.ReadLine();


                if(check){
                sw.WriteLine("Jean-Luc Picard");
                sw.Close();
                }else {
                for(x=1; x > 0; x++)
                {
                sw.WriteLine("Line" + x + journal);
                }
                }

                sw.WriteLine("Jean-Luc Picard");
                sw.Close();
                } else if(startWriting == "stop"){
                    sw.Close();
                }

                ////////////////////////////////////////////////////
            
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}