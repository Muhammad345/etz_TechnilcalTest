using System;
using System.ComponentModel.DataAnnotations;
using ETZ.Common;

namespace ETZ.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public Geneder Sex { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Position_Id { get; set; }

        public string Location { get; set; }
    }
}
