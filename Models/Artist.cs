using System;
using System.ComponentModel.DataAnnotations;

namespace artist_api.Models
{
    public class Artist
    {
         public string Id {get; set;}
        [Required]
        public string Name {get; set;}
        [Required]
        public string Medium {get; set;}
        public Artist (string name, string medium)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Medium = medium;
           
        }
    }
}