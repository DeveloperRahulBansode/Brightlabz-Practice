using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PracticeConcept
{
    
    public  class UserRegistration
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [Required(ErrorMessage = "The Username is Required to Fill")]
        [StringLength(15, MinimumLength = 8, ErrorMessage = "The Username should be between 8 to 15 characters only")]
        public String UserName { get; set; }

        [Required(ErrorMessage = "The Password is Required to Fill")]
        [StringLength(8, ErrorMessage = "The Password should be a maximum of 8 characters")]
        public String Password { get; set; }

        [Required(ErrorMessage = "The Email is Required to Fill")]
        [RegularExpression(@"^[a-z 0-9]+[^@\s]@[a-z]+[^@\s]\.[a-z]+", ErrorMessage ="Plz Enter Valid Email")]
        public String Email { get; set; }


        public UserRegistration(int id, string name, string userName, string password, string email)

        {
            this.ID = id;
            this.Name = name;
            this.UserName = userName;
            this.Password = password;
            this.Email = email;

        }

        public override string ToString()
        {
            return $"Employee [ ID : {ID}, Name : {Name}, UserName : {UserName}, Password : {Password}, Email : {Email} ]";
        }



    }

    
        
    }






