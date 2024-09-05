using System.ComponentModel.DataAnnotations;

namespace FM.GRP_03_27.Models.Admin
{
	public class Supplier
	{
		[Required]
		public string CompanyName { get; set; }

		[Required]
		public string ContactPerson { get; set; }

		[Required]
		public int AccountNumber { get; set; }

		[Required]
		[EmailAddress]
		public string Email { get; set; }

		[Required]
		[Phone]
		public string PhoneNumber { get; set; }

		[Required]
		public string PhysicalAddress { get; set; }
	}
}
