using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfProcess
{
	public class ProcessItem
	{
		public int Id { get; set; }
		public string FileName { get; set; }
		public DateTime? StartTime { get; set; }
		public DateTime? StopTime { get; set; }
		public string Params { get; set; }
		public override string ToString()
		{
			return $"{Id} {FileName} {StartTime?.ToString() ?? "null"} {StopTime?.ToString() ?? "null"} {Params}";

		}
	}
}
