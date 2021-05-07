﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haulagebiz.Core.Interfaces.Entities
{
	public interface IDatedEntity
	{
		DateTime DateCreated { get; set; }
		DateTime? DateModified { get; set; }
	}
}
