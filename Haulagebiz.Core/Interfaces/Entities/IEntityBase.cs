using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haulagebiz.Core.Interfaces.Entities
{
	public interface IEntityBase<TKey>
	{
		TKey Id { get; set; }
	}
}
