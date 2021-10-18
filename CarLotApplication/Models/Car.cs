using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarLotApplication.Models
{
    public class Car
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public int Mileage { get; set; }

        public int Price { get; set; }

        [NotMapped]
        [Display(Name = "Image")]
        [DataType(DataType.Upload)]
        public IFormFile ImageFile { get; set; }

        //These properties hold the converted information from the uploaded file - security against malicious uploads
        public byte[] ImageData { get; set; }
        public string ImageType { get; set; }

        public bool IsUsed { get; set; }

        public DateTime Created { get; set; }

        public virtual IdentityUser User { get; set; }

    }
}
