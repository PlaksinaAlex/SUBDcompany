using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Database.Tables
{
	public class Post
	{
		public int Id { get; set; }
		[Required]
		public string PostName { get; set; }
		[Required]
		public int PostRate { get; set; }
	
		[ForeignKey("PostId")]
		public virtual List<Staff> Staffs { get; set; }
	}
}
