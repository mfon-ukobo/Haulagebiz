using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haulagebiz.Core.Entities
{
	[Table("Vehicles")]
	public class Vehicle : DatedEntity<long>
	{
		public string Color { get; set; }
		public double? Height { get; set; }
		public double? Width { get; set; }
		public double? Length { get; set; }
		public string PlateNumber { get; set; }

		[InverseProperty("Vehicle")]
		public ICollection<VehicleDriver> VehicleDrivers { get; set; }
	}
}
