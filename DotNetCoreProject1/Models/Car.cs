using System;
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreProject1.Models
{
    //model class is attribute(elements) and servies are the datas of this instance.
    public class Car  
    {
        //properties data. Can be CarId as well for database default primary key. Or for other non default names [key] needs to be mentions on top.
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Display(Name = "Car Model")]
        [Required(ErrorMessage = "This field cannot be empty!!")]
        [MinLength(2, ErrorMessage = "This field cannot be less than 2 characters!!")]
        public string CarModel { get; set; }

        [Display(Name = "Car Type")]
        [Required(ErrorMessage = "This field cannot be empty!!")]
        [MinLength(2, ErrorMessage = "This field cannot be less than 2 characters!!")]
        public string CarType { get; set; }

        [Display(Name = "Review Score")]
        [Range(0,10)] //score between 0 and 10
        [Required(ErrorMessage = "This field cannot be empty!!")]
        public double ReviewScore { get; set; } 

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "This field cannot be empty!!")]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name ="Is available on the market?")]
        [Required(ErrorMessage = "This field cannot be empty!!")]
        public bool AvailableInMarket { get; set; }


        [Display(Name = "Car Description")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "This field cannot be empty!!")]
        public string Description { get; set; }
    }
}
