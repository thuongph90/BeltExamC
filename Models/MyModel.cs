using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace BeltExam.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "First Name must be at least 2 characters.")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Last Name must be 2 characters.")]
        public string LastName { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [DataType(DataType.Password)]

        [Required]
        [MinLength(8, ErrorMessage = "Password must be 8 characters or longer!")]
        public string Password { get; set; }
        // Will not be mapped to your user's table!
        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string Confirm { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public List<Attendance> ActForUser{get;set;}
        public List<Activity> CreatedActivities{get; set;} 
    }

    public class LoginUser
    {
        // No other fields!
        [Required]
        public string LoginEmail { get; set; }
        [Required]
        public string LoginPassword { get; set; }

    }
    public class Activity
    {
        [Key]
        public int ActivityId { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Title must be at least 2 characters.")]
        public string Title { get; set; }
        public int CreatorId { get; set; }
        [Required]
        public string Time { get; set; }
        [Required]
        public DateTime Date{ get; set; }
        [Required]
        public int DurationNum{get; set;}
        [Required]
        public string DurationStr{get; set;}
        [Required]
        [MinLength(2, ErrorMessage = "Title must be at least 10 characters.")]
        public string Description{ get; set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public List<Attendance> UserToAct{ get; set;}
        public User Creator{get; set;}
    }
    public class Attendance
    {
        [Key]
        public int AttendanceId{get; set;}

        public int UserId{get; set;}
        public int ActivityId{get; set;}
        public User Users{get; set;}
        public Activity Activities{get; set;}
    }
}