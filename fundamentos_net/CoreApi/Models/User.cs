using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace CoreApi.Models
{
    public class User: BaseEntity
    {
        public User()
        {
            this.Words = new HashSet<Word>();
        }

        public string Name { get; set; }
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public virtual ICollection<Word> Words{get;set;}
    }
}