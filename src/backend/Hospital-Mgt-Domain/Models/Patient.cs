﻿using Hospital_Mgt_Domain.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Mgt_Domain.Models
{
    public class Patient : AuditableEntity
    {
        [Required(ErrorMessage ="Patient First name is required.")]
        [StringLength(50, ErrorMessage ="Character length can not exceed 50.")]
        public string? FirstName { get; set; }

        [StringLength(50, ErrorMessage = "Character length can not exceed 50.")]
        public string? MiddleName { get; set; }

        [Required(ErrorMessage = "Patient Family name is required.")]
        [StringLength(50, ErrorMessage = "Character length can not exceed 50.")]
        public string? FamilyName { get; set; }

        //Contact Information(Address, Phone Number, Email)
        [StringLength(3, ErrorMessage ="Maximum character length is 3.")]
        [Display(Name ="HouseNumner")]
        [Required(ErrorMessage ="Hosue Number is a required field.")]
        public string? AddressLine1 { get; set; }

        [StringLength(50, ErrorMessage = "Maximum character length is 50.")]
        [Display(Name = "Street Name")]
        [Required(ErrorMessage = "Street Number is a required field.")]
        public string? AddressLine2 { get;set; }

        [StringLength(50, ErrorMessage = "Maximum character length is 50.")]
        [Required(ErrorMessage = "City is a required field.")]
        public string? City { get;set; }

        [StringLength(50, ErrorMessage = "Maximum character length is 50.")]        
        [Required(ErrorMessage = "State is a required field.")]
        public string? State { get; set; }

        [Range(4, 8, ErrorMessage = "Mini. value is 4 digit and max. value 8.")]
        [Display(Name = "Postal Code")]
        [Required(ErrorMessage = "Postal code is a required field.")]
        public int PostalCode { get; set;}

        [StringLength(50, ErrorMessage = "Maximum character length is 50.")]
        [Required(ErrorMessage = "Country is a required field.")]
        public string? Country { get; set; }

        [StringLength(11, ErrorMessage = "Maximum character length is 11.")]       
        [Required(ErrorMessage = "Phone number is a required field.")]
        public string? PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage ="Enter a valid email address.")]
        [StringLength(20, ErrorMessage ="Email character length is 20.")]
        public string? Email { get; set; }
        //Date of Birth
        [Range(1,31)]
        [Required(ErrorMessage ="Day of Birth is a required field.")]
        public int DayofBirth { get; set; }

        [StringLength(15, ErrorMessage = "Maximum character length is 15.")]
        [Display(Name = "Month")]
        [Required(ErrorMessage = "Month of Birth is a required field.")]
        public string? MonthofBirth { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage ="Year of Birth is a required field.")]
        [Display(Name ="Year")]
        public int YearofBirth { get; set; }
        //Gender
        [Required(ErrorMessage ="Gender is a required field.")]
        [StringLength(6, ErrorMessage ="Max. character length is 6")]
        public string? Gender { get; set; }
        //Insurance Information(Policy Number, Insurance Provider)
        [Range(8,16)]
        public int? PolicyNumber { get; set; }

        [StringLength(50, ErrorMessage ="Max. character length is 50.")]
        public string? HMOProvider { get; set; }

    }
}
