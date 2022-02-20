using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesHistoricalFiguresAC.Models
{
    public class HistoricalFiguresAC
    {
        public int ID { get; set; }
        public string Name { get; set; }
        
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        
        [Display(Name = "Date of Death")]
        [DataType(DataType.Date)]
        public DateTime DateOfDeath { get; set; }
        public string Profession { get; set; }
        
        [Display(Name = "Seen In")]
        public string SeenIn { get; set; }
        public string Affiliation { get; set; }
    }
}