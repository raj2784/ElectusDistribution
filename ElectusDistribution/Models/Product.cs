using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ElectusDistribution.Models
{
	public class Product
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[Column(TypeName = "nvarchar(50)")]
		public string ModelNumber { get; set; }
		[Required]
		[Column(TypeName = "nvarchar(50)")]
		public string ProductName { get; set; }
		public string PhotoPath { get; set; }

	}
}
