using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalISDB
{
   public class Context: DbContext
   {
       // <summary>
       // The constructor, we provide the connectionstring to be used to it's base class.
       // </summary>
      /*public Context() 
           : base("Data Source=SQL Server 11.0.3000;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False") 
       {
       
       }    
       */
        public DbSet<User> person { get; set; }
   }
      
}
