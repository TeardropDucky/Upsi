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
			var list = new LetterList();
			var history = new List<Tuple<char,string>>();

			string menu = @"
********************
*       Menu       *
********************
*    1: Tilføj     *
*    2: Fjern      *
*    3: Print      *
*    4: Undo       *
*    5: Luk        *
********************
";
			while (!end)
			{
				Console.WriteLine(menu);
				string input = Console.ReadLine().ToLower();
				history.Add(new Tuple<char, string>('m',input));

				switch (input)
				{
					case "1":
					case "tilføj":
					case "tilfoj":
						Console.WriteLine("Input tilføjelser og tryk enter:");
						input = Console.ReadLine();
						if(input == "tilbage")
						{
							history.Add(new Tuple<char, string>('m', input));
						}
						else
						{
							foreach(var item in input)
							{
								list.AddLetter(item);
							}
						}
						break;
					case "2":
					case "fjern":
						break;
					case "3":
					case "print":
						break;
					case "4":
					case "undo":
						break;
					case "5":
					case "luk":
						if(list.Save())
						{
							end = true;
						}
						else
						{

						}
							
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
