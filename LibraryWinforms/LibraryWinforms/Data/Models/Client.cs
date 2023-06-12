﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWinforms.Data.Models
{
    public class Client
    {
        public Client(int id, string firstName, string lastName, string email, int age,int phoneNumber , int password )
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Age = age;
            PhoneNumber = phoneNumber;
            Password = password;
            
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public int Age { get; set; }
        public int Password { get; set; }
        public virtual ICollection<BorrowedBooks> BorrowedBooks { get; set; }
    }
}
