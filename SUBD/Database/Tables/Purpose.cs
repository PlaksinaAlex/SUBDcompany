using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Database.Tables
{
	public class Purpose
	{
		public int Id { get; set; }
		public int StaffId { get; set; }
		[Required]
		public DateTime workday { get; set; }
		public int HoursCount { get; set; }
		public virtual Staff Staff { get; set; }

	}
}
