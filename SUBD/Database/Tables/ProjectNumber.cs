using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Database.Tables
{
	public class ProjectNumber
	{
		public int Id { get; set; }

		public int ProjectTypeId { get; set; }

		[Required]
		public string ProjectNumberName { get; set; }	

		[ForeignKey("ProjectNumberId")]
		public virtual List<Staff> Staffs { get; set; }

		public virtual ProjectType ProjectType { get; set; }

	}
}
