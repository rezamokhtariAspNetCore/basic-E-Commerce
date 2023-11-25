using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BG.Model
{
	public class MenuItem
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		public string Description { get; set; }
		public string Image { get; set; }
		public double Price { get; set; }
		[Display(Name = "کدام بازی")]
		public int GameTypeId { get; set; }
		[ForeignKey("GameTypeId")]
		public GameType GameType { get; set; }
		[Display(Name = "کدام دسته بندی")]
		public int CategoryId { get; set; }
		public Category Category { get; set; }

	}
}