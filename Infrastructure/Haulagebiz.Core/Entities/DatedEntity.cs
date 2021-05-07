using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Haulagebiz.Core.Interfaces.Entities;

namespace Haulagebiz.Core.Entities
{
	public class DatedEntity<TKey> : EntityBase<TKey>, IDatedEntity
	{
		public DateTime DateCreated { get; set; }
		public DateTime? DateModified { get; set; }
	}
}
