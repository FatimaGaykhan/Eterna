using System;
using System.ComponentModel.DataAnnotations;
namespace Eterna.Models
{
	public class Pricing
	{
		public int Id { get; set; }
		[StringLength(100),Required]
		public string Name { get; set; }
		public double Price { get; set; }
		public bool IsFeatured { get; set; }


	}
}

