﻿using System;
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

    public class UserData : DbContext 
    {
        public DbSet<User> UserDataSet { get; set; }    
    }
}