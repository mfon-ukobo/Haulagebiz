using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Haulagebiz.Core.Interfaces.Entities;

namespace Haulagebiz.Core.Entities
{
	public class AuditEntity<TKey> : EntityBase<TKey>, IAuditEntity
	{
		public string CreatedBy { get; set; }
		public string ModifiedBy { get; set; }
	}
}
