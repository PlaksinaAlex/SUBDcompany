using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Tables
{
	public class ProjectType
	{
		public int Id { get; set; }
		[Required]
		public string ProjectTypeName { get; set; }

		public int ProjectTypeRate { get; set; }

		[ForeignKey("ProjectTypeId")]
		public virtual List<ProjectNumber> ProjectNumbers { get; set; }
	}
}
