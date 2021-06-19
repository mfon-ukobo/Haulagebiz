using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class EntityBase<T>
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public T Id { get; set; }
	}

	public class DatedEntity<T> : EntityBase<T>
	{
		public DateTime _dateCreated { get; set; }
		public DateTime _lastModified { get; set; }

		public DateTime DateCreated
		{
			get => _dateCreated;
			set
			{
				if (value == DateTime.MinValue)
				{
					_dateCreated = DateTime.Now;
				}
			}
		}

		public DateTime LastModified
		{
			get => _lastModified;
			set
			{
				_lastModified = DateTime.Now;
			}
		}
	}
}
