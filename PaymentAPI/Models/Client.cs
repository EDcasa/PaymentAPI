using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaymentAPI.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string fullName { get; set; }

        public int age { get; set; }

        [Column(TypeName = "Date")]
        public DateTime birthDate { get; set; }

        [Column(TypeName = "Date")]
        public DateTime dateInscription { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal cost { get; set; }
    }
}
