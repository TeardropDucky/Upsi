using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letters
{
    class Program
    {

        static void Main(string[] args)
        {
			bool end = false;
			string menu = @"
********************
*       Menu       *
********************
*    1: Tilføj     *
*    2: Fjern      *
*    3: Print      *
*    4: Luk        *
********************
";
			while (!end)
			{
				Console.WriteLine(menu);
				string input = Console.ReadLine().ToLower();
				switch (input)
				{
					case "1":
					case "tilføj":
					case "tilfoj":
						Console.Clear();
						break;
					case "2":
					case "fjern":
						Console.Clear();
						break;
					case "3":
					case "print":
						Console.Clear();
						break;
					case "4":
					case "luk":
						end = true;
						break;
					default:
						Console.WriteLine("Input ikke forstået");
						break;
				}
				//Make list with Letters. Add new letter if not already in the list.
			}
        }
    }
}
