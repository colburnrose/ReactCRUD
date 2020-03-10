using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReactCRUD.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string EmpNumber { get; set; }
        [Required, MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string MiddleName { get; set; }
        [Required, MaxLength(50)]
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string ImageUrl { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreateDate { get; set; }
        public string Role { get; set; }
        public string EmailAddress { get; set; }
        [Required, MaxLength(50)]
        public string SSN { get; set; }
        public string Phone { get; set; }
        [Required, MaxLength(150)]
        public string Address { get; set; }
        [Required, MaxLength(50)]
        public string City { get; set; }
        [Required, MaxLength(50)]
        public string PostalCode { get; set; }
        public IEnumerable<PaymentRecord> PaymentRecords { get; set; }
    }
}
