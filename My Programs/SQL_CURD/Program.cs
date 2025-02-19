using System.Data;
using System.Data.SqlClient;

namespace SQL_CURD
{
    class Program
    {
        static void Main(string[] args)
        {
            //string connectionString = @"Data Source=RAHUL\SQLEXPRESS;Initial Catalog=Rahul;Integrated Security=True";
            //SqlConnection sqlConnection= new SqlConnection(connectionString);
            //sqlConnection.Open();

            //try
            //{
            //    string ans;
            //    do
            //    {
            //        Console.WriteLine("Connect Successfully");

            //        Console.WriteLine("Database Operation..");
            //        Console.WriteLine("1. Insert Data");
            //        Console.WriteLine("2. Retrive Data");
            //        Console.WriteLine("3. Update Data");
            //        Console.WriteLine("4. DElete Data");
            //        Console.WriteLine("5. Exit");
            //        Console.WriteLine();
            //        Console.WriteLine("Enter Your Choice :");
            //        int choice = Convert.ToInt32(Console.ReadLine());
            //        switch (choice)
            //        {
            //            //create =>C
            //            case 1:
            //                Console.WriteLine("Enter Your Name:");
            //                string userName = Console.ReadLine();
            //                Console.WriteLine("Enter Your Age:");
            //                int userAge = Int32.Parse(Console.ReadLine());
            //                string insertQuery = "INSERT INTO USERDATA(User_Name,User_Age) VALUES('" + userName + "'," + userAge + ")";
            //                SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
            //                insertCommand.ExecuteNonQuery();
            //                Console.WriteLine("Data successfully Inserted in UserData Table...");
            //                break;

            //            //Retrive =>R
            //            case 2:
            //                string displayQuery = "SELECT*FROM USERDATA";
            //                SqlCommand displayCommand = new(displayQuery, sqlConnection);
            //                SqlDataReader dataReader = displayCommand.ExecuteReader();
            //                while (dataReader.Read())
            //                {
            //                    Console.WriteLine("ID:" + dataReader.GetValue(0).ToString());
            //                    Console.WriteLine("Name:" + dataReader.GetValue(1).ToString());
            //                    Console.WriteLine("Age:" + dataReader.GetValue(2).ToString());
            //                    Console.WriteLine();
            //                }
            //                Console.WriteLine("Data Retrive Successfully...");
            //                dataReader.Close();
            //                break;
            //            case 3:
            //                //Update=>U
            //                int U_id;
            //                int U_Age;
            //                Console.WriteLine("Enter User ID whre You want To Update :");
            //                U_id = Int32.Parse(Console.ReadLine());
            //                Console.WriteLine("Enter New Age For Update :");
            //                U_Age = Int32.Parse(Console.ReadLine());

            //                string updateQuery = "UPDATE USERDATA SET User_Age=" + U_Age + "WHERE User_Id=" + U_id + "";
            //                SqlCommand updateCommand = new(updateQuery, sqlConnection);
            //                updateCommand.ExecuteNonQuery();
            //                Console.WriteLine("Data Update Successfully...");
            //                break;
            //            case 4:
            //                //Delete=>D
            //                int d_Id;
            //                Console.WriteLine("Enter User ID for Delete Record From UserData Table :");
            //                d_Id = Convert.ToInt32(Console.ReadLine());
            //                string deleteQuery = "DELETE FROM USERDATA WHERE  User_Id=" + d_Id + "";
            //                SqlCommand deleteCommand = new(deleteQuery, sqlConnection);
            //                deleteCommand.ExecuteNonQuery();
            //                Console.WriteLine("Data Delete Successfully..");
            //                break;

            //            case 5:
            //                Console.WriteLine("Tata Byeee..Byaeee");
            //                break;
            //            default:
            //                Console.WriteLine("Invalid Choice");
            //                break;

            //        }
            //        Console.WriteLine("Do You Want To Continue?");
            //         ans = Console.ReadLine();
            //    } while (ans!="NO");




            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);

            //}
            //finally
            //{
            //    sqlConnection.Close();

            //}

            //annotation CURD with abstraction
            //int data;
            //do
            //{
            //    StudentImp student = new StudentImp();

            //    Console.WriteLine("Database Operation..");
            //    Console.WriteLine("1. Insert Data");
            //    Console.WriteLine("2. Retrive Data");
            //    Console.WriteLine("3. Update Data");
            //    Console.WriteLine("4. Delete Data");
            //    Console.WriteLine("5. Exit");
            //    Console.WriteLine();
            //    Console.WriteLine("Enter Your Choice :");
            //    data = Convert.ToInt32(Console.ReadLine());
            //    switch (data)
            //    {
            //        case 1:
            //            student.InsertData();
            //            break;
            //        case 2:
            //            student.DisplayData();
            //            break;
            //        case 3:
            //            student.UpdateData();
            //            break;
            //        case 4:
            //            student.DeleteData();
            //            break;
            //        case 5:
            //            Console.WriteLine("Tata Byeee..Byaeee");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid Choice");
            //            break;
            //    }
            //} while (data!=5 );


            //Disconnected Architecture
            string connectionString = @"Data Source=RAHUL\SQLEXPRESS;Initial Catalog=Rahul;Integrated Security=True";

            string query = "SELECT * FROM Student1";

            SqlDataAdapter adapter = new SqlDataAdapter(query,connectionString);

            DataSet dataset = new DataSet();

            adapter.Fill(dataset,"Student1");

            Console.WriteLine("Before Update");
            foreach(DataRow row in dataset.Tables["Student1"].Rows)
            {
                Console.WriteLine(row["Id"] + "   " + row["sName"] + "   " + row["sAge"]);
            }

            DataTable table = dataset.Tables["Student1"];
            if(table.Rows.Count > 0)
            {
                table.Rows[0]["sAge"] = Convert.ToInt32(table.Rows[0]["sAge"]= 50);
                Console.WriteLine("Age updated");
            }

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(dataset, "Student1");
            adapter.

            Console.WriteLine("after update");
            foreach (DataRow row in dataset.Tables["Student1"].Rows)
            {
                Console.WriteLine(row["Id"] + "   " + row["sName"] + "   " + row["sAge"]);
            }





        }
    }
}
