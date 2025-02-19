using System.Globalization;
using System.Text.Json.Serialization;
using CsvHelper;
using Newtonsoft.Json;

namespace InputOutputPackage
{
    internal class Program
    {
        public static void Main(string[] args)
        {
         //string source = @"D:\.Net Practice 2025\My Programs\InputOutputPackage\FirstFile.txt";
        //string source1= @"D:\.Net Practice 2025\My Programs\InputOutputPackage\source.txt";
        //    string destination = @"D:\.Net Practice 2025\My Programs\InputOutputPackage\DestinationFile.txt";
        //    var InputData = "File I/O in C# is a fundamental skill for manipulating files.Reading files involves using classes like File or StreamReader to extract data from existing files.Writing files entails employing classes like File or StreamWriter to create or modify files.";
        //    var DeleteFromFile = "Writing files entails employing classes like File or StreamWriter to create or modify files";
        //    var addToDest = "File I/O in C# is a fundamental skill for manipulating files";

        //    Console.WriteLine( "\t----Sourcce File----");
        //    //InputOutputDemo.FileHandling(source);
        //    //InputOutputDemo.readFile(source);
        //    //InputOutputDemo.writeFile(source, InputData);
        //    InputOutputDemo.ConvertPToL(source1, InputData);
        //    InputOutputDemo.readFile(source1);
        //    InputOutputDemo.deleteSpecificdata(source1,destination, DeleteFromFile);
        //    InputOutputDemo.deleteSpecificdata(source1, destination, addToDest);

            





        //    Console.WriteLine("\t----Destination File----");
        //    //InputOutputDemo.CopyFile(source, destination);
        //    //InputOutputDemo.readFile(destination);
        //    //InputOutputDemo.DeleteFile(destination);
          





               

            //csv and Json File Read Wrute
            //var data = new List<Employee>()
            //{
            //    new Employee{ Id=101,Name="Rahul",Email="rahul@gmail.com"},
            //    new Employee{Id=102,Name="Pratik",Email="pratik@gmail.com" },
            //    new Employee{Id=103,Name="Pranav",Email="pranav@gmail.com"},
            //    new Employee{Id=104,Name="Vishal",Email="vishal@gmail.com"},
            //    new Employee{Id=105,Name="krishna",Email="krishna@gmail.com"},

            //};

            //string path = @"D:\.Net Practice 2025\My Programs\InputOutputPackage\CsvFile.csv";
            ////File.Create(path);
            ////write Data In CSV
            //using (var writer = new StreamWriter(path)) 
            //    using(var csv=new CsvWriter(writer,CultureInfo.InvariantCulture))
            //    { 

            //        csv.WriteRecords(data);



            //    }
            //Read Data from CSV
            //using (var reader = new StreamReader(path))
            //using (var csvdata = new CsvReader(reader, CultureInfo.InvariantCulture))
            //{

            // var records=csvdata.GetRecords<Employee>();
            //    foreach (var value in records)
            //    {
            //        Console.WriteLine(value.ToString());

            //    }

            //}


            //string jsonPath = @"D:\.Net Practice 2025\My Programs\InputOutputPackage\JsonFile.json";
            ////File.Create(jsonPath);

            //string json=JsonConvert.SerializeObject(data,Formatting.Indented);
            //File.WriteAllText(jsonPath, json);

            //string jsonData=File.ReadAllText(jsonPath);
            //var deserializedData=JsonConvert.DeserializeObject<List<Employee>>(jsonData);
            //foreach (var value in deserializedData)
            //{
            //    Console.WriteLine(value.ToString());
            //}


            string path = @"D:\.Net Practice 2025\My Programs\InputOutputPackage\product.json";
            var data1 = new List<Product>()
            {
                new Product(1001, "Hp Laptop", DateTime.Now, "Electronic"),
                new Product(1002, "Linovo Laptop", DateTime.Now, "Electronic"),
                new Product(1003, "Asus Laptop", DateTime.Now, "Electronic"),
                new Product(1004, "Apple Laptop", DateTime.Now, "Electronic"),
                new Product(1005, "Acer Laptop", DateTime.Now, "Electronic"),

            };

            Program.AddDataInJson(path, data1);
            Program.PrintDataFromJson(path, data1);









        }
        public static void AddDataInJson(string path,List<Product> data)
        {

            string  json=JsonConvert.SerializeObject(data,Formatting.Indented);
            File.WriteAllText(path,json);



        }

        public static void PrintDataFromJson(string path,List<Product> data)
        {
            string json=File.ReadAllText(path);

            var retrive=JsonConvert.DeserializeObject<List<Product>>(json);
            foreach (var item in retrive) 
            {
                Console.WriteLine(item.ToString());
            }


        }

    }
}
