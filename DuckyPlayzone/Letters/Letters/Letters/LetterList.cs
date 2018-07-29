using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letters
{
	public class LetterList
	{
		private List<Letter> _letters;

		public LetterList()
		{
			//Check some file/database for saved info
		}

		public bool IncreaseLetterCount(char letter)
		{
			return false;
		}

		public bool DeceaseLetterCount(char letter)
		{
			//Update file/database before returning
			return false;
		}

		public bool AddLetter(char letter)
		{
			return false;
		}

		public bool RemoveLetter(char letter)
		{
			return false;
		}

		public void PrintSortedAfterLetter()
		{

		}

		public void PrintSortedAfterValue()
		{
			
		}

		public bool Save()
		{
			return true;
		}
	}
}
