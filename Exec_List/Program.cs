using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_List
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<string> products = new List<string>() {"eggs", "bacon", "toast" };
			foreach (var item in products)
			{
				Console.WriteLine(item);
			} // print eggs bacon toast
		}
	}
}
