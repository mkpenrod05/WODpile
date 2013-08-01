using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace WODpile.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
    }

    [Table("***Table Name***")]
    public class UserData : DbContext 
    {
        public DbSet<User> UserData { get; set; }    
    }
}