using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Haulagebiz.Core.Enums;
using Microsoft.AspNetCore.Identity;

namespace Haulagebiz.Core.Entities
{
	public class AppUser : IdentityUser<Guid>
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string OtherNames { get; set; }
		public GenderEnum Gender { get; set; }

		public DateTime DateCreated { get; set; }
		public DateTime? LastModified { get; set; }
		public DateTime? LastLogin { get; set; }

		[InverseProperty("AppUser")]
		public Driver Driver { get; set; }
	}
}
