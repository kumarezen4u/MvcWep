﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebMvc.BAL
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int Id { get; set; } 
        public string Username { get; set; }
        public string Password { get; set; }
    }
}