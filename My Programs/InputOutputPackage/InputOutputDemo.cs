using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InputOutputPackage
{
    public  class InputOutputDemo
    {

        public static void FileHandling(string path)
        {


            if (File.Exists(path))
            {

                Console.WriteLine("File Exist");

            }
            else
            {
                File.Create(path);
                Console.WriteLine("File Created");
            }

            




        }
        public static void readFile(string path) 
        {
        
            //StreamReader sr = new StreamReader(path);
            //Console.WriteLine(sr);

            string line =File.ReadAllText(path);
            Console.WriteLine(line);
        }
        public static void writeFile(string path, string data) 
            
        {
            //StreamWriter sw = new StreamWriter(path);
            //sw.Write(data);
            File.WriteAllText(path, data);
            Console.WriteLine("New Data Added...");

            



        }
        public static void CopyFile(string source, string destination)
        {
            File.Copy(source, destination, true);
            Console.WriteLine("File copy successfully...");


        }

        public static void DeleteFile(string path) 
        {
            File.Delete(path);
            Console.WriteLine(path+"  Its Deleted successfully....  ");
        
        
        }
        public static void deleteSpecificdata(string path,string destination, string data)
        {

            //string[] line = File.ReadAllLines(path);
            //for (int i = 0; i < line.Length; i++)
            //{
            //    if (line[i].Equals(data))
            //    {
            //        File.WriteAllText(destination, line[i]);
            //    }

            //}

            //if (File.Exists(path))
            //{
            //    string[] lines = File.ReadAllLines(path);

            //    using (StreamWriter sw = new StreamWriter(destination))
            //    {
            //        for (int i = 0; i < lines.Length; i++)
            //        {
            //            if (lines[i].Equals(data))
            //            {
            //                sw.WriteLine(lines[i]);
            //            }
            //        }
            //    }
            //}

            string[] lines = File.ReadAllLines(path);
            HashSet<string> existingLines = new HashSet<string>(File.ReadAllLines(destination));

            using (var sw = new StreamWriter(destination, append: true))
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Contains(data) && !existingLines.Contains(lines[i]))
                    {
                        sw.WriteLine(lines[i]);
                        existingLines.Add(lines[i]);
                    }
                }
            }






        }
        public static void ConvertPToL(string path,string data) 
        {
            string[] splitedData = data.Split('.');

            if (File.Exists(path)) {

                File.WriteAllLines(path, splitedData);
            }


        }

       


    }
}
