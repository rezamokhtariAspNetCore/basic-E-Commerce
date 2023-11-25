using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BG.Model
{
	public class Category
	{
		[Key]
		public int Id { get; set; } 
		[Required]
		public string Name { get; set; }
		[Display(Name = "نام دارنده")]
		public string Author { get; set; }
	}

}
