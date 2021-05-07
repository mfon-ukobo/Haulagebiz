using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haulagebiz.Core.Entities
{
	public abstract class Haulage : DatedEntity<long>
	{
		public HaulageLoading Loading { get; set; }
	}
}
