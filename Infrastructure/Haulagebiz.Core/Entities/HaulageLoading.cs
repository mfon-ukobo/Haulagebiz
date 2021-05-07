using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Haulagebiz.Core.Entities
{
	[Owned]
	public class HaulageLoading
	{
		public DateTime Date { get; set; }
	}
}
