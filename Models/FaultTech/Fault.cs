using System.ComponentModel.DataAnnotations;

namespace FM.GRP_03_27.Models.Fault
{
    public class Fault
    {
        [Key]
        public int FaultId { get; set; }

        [Required, StringLength(100)]
        public string FaultDescription { get; set; }

        [Required]
        public DateTime ViewDate { get; set; }

        [Required, StringLength(50), Display(Name = "Fault Status")]
        public int FaultStatus { get; set; }

        [Required, StringLength(50), Display(Name = "Fault Type")]
        public int FaultType { get; set; }
    }
}
