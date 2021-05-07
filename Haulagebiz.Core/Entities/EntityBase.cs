using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Haulagebiz.Core.Interfaces.Entities;

namespace Haulagebiz.Core.Entities
{
	public class EntityBase<TKey> : IEntityBase<TKey>
	{
		public TKey Id { get; set; }
	}
}
