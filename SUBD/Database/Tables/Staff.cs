﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Tables
{
	public class Staff
	{
		public int Id { get; set; }
		public int PostId { get; set; }
		public int ProjectNumberId { get; set; }
		[Required]
		public string StaffName { get; set; }
		public decimal StaffRate { get; set; }
		public virtual Post Post { get; set; }
		public virtual ProjectNumber ProjectNumber { get; set; }

		[ForeignKey("StaffId")]
		public virtual List<Purpose> Purposes { get; set; }
	}
}
