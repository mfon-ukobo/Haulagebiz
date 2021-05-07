using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haulagebiz.Core.Entities
{
	[Table("Drivers")]
	public class Driver : DatedEntity<long>
	{
		public Guid AppUserId { get; set; }

		[ForeignKey(nameof(AppUserId))]
		[InverseProperty("Driver")]
		public AppUser AppUser { get; set; }

		[InverseProperty("Driver")]
		public ICollection<VehicleDriver> DriverVehicles { get; set; }
	}
}
