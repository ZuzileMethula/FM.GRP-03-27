using System.ComponentModel.DataAnnotations;

namespace FM.GRP_03_27.Models.FaultTech
{
    public class Repair
    {
        [Key]
        public int RequestId { get; set; }
        [Required, StringLength(50), Display(Name = "Repair Date")]
        public DateTime RepairDate { get; set; }

        [Required, StringLength(50), Display(Name = "Repair Status")]
        public string RepairStatus { get; set; }

        [Required, StringLength(50), Display(Name = "Repair Description")]
        public string RepairDescription { get; set; }
    }
}
