using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Tables;

namespace Database.Implements
{
	public class StaffStorage
	{
		public List<Staff> GetFullList()
		{
			using var context = new CompanyDatabase();
			return context.Staffs
				.ToList();
		}
		public List<Staff> GetFilteredList(int rate)
		{
			
			using var context = new CompanyDatabase();
			return context.Staffs
			.Where(rec => rec.StaffRate == rate)
			.ToList();
		}
	}
}
