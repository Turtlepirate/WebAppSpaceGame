using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAppSpaceGame.Models
{
    public class Good
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FromDate { get; set; }
        public string Rarity { get; set; }
        public decimal Price { get; set; }
    }
}
