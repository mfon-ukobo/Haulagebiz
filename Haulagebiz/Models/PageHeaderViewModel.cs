using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Haulagebiz.Models
{
	public class PageHeaderViewModel
	{
		public string Title { get; set; }
		public string Caption { get; set; }
		public string ImageUrl { get; set; }
		public IEnumerable<string> BreadCrumb { get; set; }
	}
}
