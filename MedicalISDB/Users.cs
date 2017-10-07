using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MedicalISDB
{

    public class User
    {
       [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
       [Required(ErrorMessage = "Username is required")]
       public string Username { get; set; }
        [Required(ErrorMessage = "Passcode is required")]
        public int Userpasscode { get; set; }
      

    }
    

}
