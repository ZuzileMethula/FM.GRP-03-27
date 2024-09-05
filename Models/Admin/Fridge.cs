using System.ComponentModel.DataAnnotations;

namespace FM.GRP_03_27.Models.Admin
{
	public class FridgeModel
	{
		[Required]
		public string FridgeType { get; set; }

		[Required]
		public string QuantityInStock { get; set; }

		[Required]
		public string Price { get; set; }

		[Required]
		public string Condition { get; set; }
	}


}
