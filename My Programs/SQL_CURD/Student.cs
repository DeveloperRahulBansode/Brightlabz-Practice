using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SQL_CURD
{
     public abstract class  Student
    {
        [Required(ErrorMessage ="Student Id is Required")]
        [Key]
        public int Stu_ID { get; set; }

        [Required(ErrorMessage ="Student Name is required")]
        [Length(5,maximumLength:50,ErrorMessage ="Student Name Shuld Be min 5 to 50 Charactors")]
        public string Stu_Name { get; set; }


        [Required(ErrorMessage ="Student Age Is Required ")]
        [Range(16,100,ErrorMessage ="Student Age Shuld Be between 16 to 100")]

        public int Stu_Age { get; set; }

        [Required(ErrorMessage ="Student Email Is Required")]
        [RegularExpression(@"[a-z0-9\.]+@[a-z]+\.[a-z]+")]
        public string Email { get; set; }

        

        public abstract void InsertData();
        public abstract void DisplayData();
        public abstract void UpdateData();
        public abstract void DeleteData();

        //public override string ToString()
        //{
        //    return $"Student [ ID: {stu_ID} , NAME: {stu_Name} , AGE: {stu_Age} , EMAIL: {Email} ] ";
        //}

    }
   


}
