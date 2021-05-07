using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haulagebiz.Core.Entities
{
	[Table("VehiclesDrivers")]
	public class VehicleDriver : DatedEntity<long>
	{
		public long VehicleId { get; set; }
		public long DriverId { get; set; }

		[ForeignKey(nameof(VehicleId))]
		[InverseProperty("VehicleDrivers")]
		public Vehicle Vehicle { get; set; }

		[ForeignKey(nameof(DriverId))]
		[InverseProperty("DriverVehicles")]
		public Driver Driver { get; set; }
	}
}
