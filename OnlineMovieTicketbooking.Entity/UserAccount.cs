﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMovieTicketBooking.Entity
{
    [Table("UserInfo")]
    public class UserAccount
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }
        [Required]
        [Index(IsUnique = true)]
        public long MobileNumber { get; set; }
        [Required]
        [Index(IsUnique = true)]
        [MaxLength(50)]
        public string MailId { get; set; }
        [Required]
        [MaxLength(20)]
        public string Password { get; set; }
        [Required]
        [MaxLength(15)]
        public string Role { get; set; }
        public ICollection<Theatre> Theatre { get; set; }
    }
}
