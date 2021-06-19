using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Site
{
	public class QuoteRequest : EntityBase<long>
	{
		public string Name { get; set; }
		public string Email { get; set; }
	}
}
