using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_CURD
{
    
    public class StudentImp : Student
    {
        private string connectionString = @"Data Source=RAHUL\SQLEXPRESS;Initial Catalog=Rahul;Integrated Security=True";

        public override void DeleteData()
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    Console.WriteLine("Enter Student ID for Delete Record :");
                    Stu_ID= Convert.ToInt32(Console.ReadLine());
                    string deleteQuery = "DELETE FROM STUDENT WHERE Stu_ID=" + Stu_ID;
                    SqlCommand deleteCommand = new(deleteQuery, connection);
                    deleteCommand.ExecuteNonQuery();
                    Console.WriteLine("Data Successfully Deleted from Student Table...");
                    connection.Close();

                }
            } 
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }


        }

        public override void DisplayData()
        {
            try {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    string displayQuery = "SELECT*FROM STUDENT";
                    SqlCommand displayCommand = new(displayQuery,sqlConnection);

                    SqlDataReader dataReader= displayCommand.ExecuteReader();
                    
                    while (dataReader.Read())
                    {
                       
                        Console.WriteLine("ID: "+ dataReader.GetValue(0).ToString());
                        Console.WriteLine("Name: " + dataReader.GetValue(1).ToString());
                        Console.WriteLine("Age: " + dataReader.GetValue(2).ToString());
                        Console.WriteLine("Email: " + dataReader.GetValue(3).ToString());

                    }
                    Console.WriteLine("Data Read Successfully");
                    Console.WriteLine();
                    dataReader.Close();
                    sqlConnection.Close();

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public override void InsertData()
        {
            try
            {
                using (SqlConnection sqlconnection = new SqlConnection(connectionString))
                {
                    sqlconnection.Open();

                    Console.WriteLine("Enter Your ID : ");
                    Stu_ID = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Your Name : ");
                    Stu_Name = Console.ReadLine();
                    Console.WriteLine("Enter Your Age : ");
                    Stu_Age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Your Email : ");
                    Email = Console.ReadLine();

                    var contex=new ValidationContext(this);
                    var result=new List<ValidationResult>();
                    var isValid= Validator.TryValidateObject(this, contex, result, true);
                    if (isValid)
                    {
                        //string insertQuery = "INSERT INTO STUDENT (Stu_ID, Stu_Name, Stu_Age, Email) VALUES (@Stu_ID, @Stu_Name, @Stu_Age, @Email)";
                        //SqlCommand insertCommand = new SqlCommand(insertQuery, sqlconnection);
                        //insertCommand.Parameters.AddWithValue("@Stu_ID", Stu_ID);
                        //insertCommand.Parameters.AddWithValue("@Stu_Name", Stu_Name);  
                        //insertCommand.Parameters.AddWithValue("@Stu_Age", Stu_Age);
                        //insertCommand.Parameters.AddWithValue("@Email", Email);

                        string insertQuery = "INSERT INTO STUDENT VALUES(" + Stu_ID + ",'" + Stu_Name + "'," + Stu_Age + ",'" + Email + "')";
                        SqlCommand insertCommand = new SqlCommand(insertQuery, sqlconnection);
                        insertCommand.ExecuteNonQuery();
                        Console.WriteLine("Data Successfully Inserted in Student Table...");
                    }
                    else { 

                        foreach (var item in result)
                        {
                            Console.WriteLine("Validation Errors...");

                            Console.WriteLine("--> "+item.ErrorMessage);
                        }
                    }                    
                    sqlconnection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public override void UpdateData()
        {
            try {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Enter Student ID for Update Record :");
                    Stu_ID = Convert.ToInt32(Console.ReadLine());
                    string ans;

                    do
                    {
                        Console.WriteLine("Select what you want to update :");
                        Console.WriteLine("1. Name");
                        Console.WriteLine("2. Age");
                        Console.WriteLine("3. Email");
                        Console.WriteLine("0. Exit");

                        Console.WriteLine("Enter Your Choice :");
                        int choice = Convert.ToInt32(Console.ReadLine());

                        

                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter Student Name :");
                                Stu_Name = Console.ReadLine();
                                var nameContex = new ValidationContext(this) { MemberName = nameof(Stu_Name) };
                                var nameResult = new List<ValidationResult>();
                                var isNameValid = Validator.TryValidateProperty(Stu_Name, nameContex, nameResult);
                                if (isNameValid)
                                {
                                    string updateName = "UPDATE STUDENT SET Stu_Name='"+ Stu_Name + "' WHERE Stu_ID=" + Stu_ID;
                                    SqlCommand updateCommandName = new SqlCommand(updateName, connection);
                                    updateCommandName.ExecuteNonQuery();
                                    Console.WriteLine("Student Name Updated....");
                                }
                                else
                                {
                                    foreach (var item in nameResult)
                                    {
                                        Console.WriteLine("Validation Errors...");
                                        Console.WriteLine("--> " + item.ErrorMessage);
                                    }
                                }
                                
                                break;
                            case 2:

                                Console.WriteLine("Enter Student Age :");
                                Stu_Age = Convert.ToInt32(Console.ReadLine());
                                var ageContex = new ValidationContext(this) { MemberName = nameof(Stu_Age) };
                                var ageResult = new List<ValidationResult>();
                                var isAgeValid = Validator.TryValidateProperty(Stu_Age, ageContex, ageResult);
                                if (isAgeValid) {
                                   string updateAge = "UPDATE STUDENT SET Stu_Age=" + Stu_Age + "WHERE Stu_ID=" + Stu_ID;
                                    SqlCommand updateCommandAge = new SqlCommand(updateAge, connection);
                                    updateCommandAge.ExecuteNonQuery();
                                    Console.WriteLine("Student Age Updated....");
                                }
                                else
                                {
                                    foreach (var item in ageResult)
                                    {
                                        Console.WriteLine("Validation Errors...");
                                        Console.WriteLine("--> " + item.ErrorMessage);
                                    }
                                }
                                    break;
                            case 3:
                                Console.WriteLine("Enter Student Email :");
                                Email = Console.ReadLine();
                                var emailContex = new ValidationContext(this) { MemberName = nameof(Email) };
                                var emailResult = new List<ValidationResult>();
                                var isEmailValid = Validator.TryValidateProperty(Email, emailContex, emailResult);

                                if (isEmailValid)
                                {
                                    string updateEmail = "UPDATE STUDENT SET Email='" + Email + "' WHERE Stu_ID=" + Stu_ID;
                                    SqlCommand updateCommandEmail = new SqlCommand(updateEmail, connection);
                                    updateCommandEmail.ExecuteNonQuery();
                                    Console.WriteLine("Student Email Updated....");
                                }
                                else
                                {
                                    foreach (var item in emailResult)
                                    {
                                        Console.WriteLine("Validation Errors...");
                                        Console.WriteLine("--> " + item.ErrorMessage);
                                    }
                                }
                                    break;
                            case 0:
                                Console.WriteLine("Exit...");
                                break;
                            default:
                                Console.WriteLine("Invalid Choice...");
                                break;
                        }
                        Console.WriteLine("Do you Want Update Enything Else.. ??");
                        ans = Console.ReadLine();



                    } while (ans!="N");

                    connection.Close();

                }            
            
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }
    }
}
