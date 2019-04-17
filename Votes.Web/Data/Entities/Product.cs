

namespace Votes.Web.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Occupation { get; set; }

        public string Gender { get; set; }

        public string City { get; set; }

        public int Stratum { get; set; }


        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        

        [Display(Name = "Birthdate")]
        public DateTime Birthdate { get; set; }

        [Display(Name = "Is Availabe?")]
        public bool IsAvailabe { get; set; }

       
    }

}
