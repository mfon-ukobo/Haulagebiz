using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haulagebiz.Core.Entities
{
	public class Vehicle : DatedEntity<Guid>
	{
		public string PlateNumber { get; set; }
	}
}
