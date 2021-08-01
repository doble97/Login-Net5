using System;
using System.ComponentModel.DataAnnotations;
namespace CoreApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}