using System.Text;

namespace Splitter
{

    class TextFormatter
    {
		/// <summary>
		/// Splits received string according each cplit string characters
		/// </summary>
		/// <param name="inputString">Source string</param>
		/// <param name="splitChars">Split characters string</param>
		/// <returns></returns>
        public string SplitString(string inputString, string splitChars)
	    {
		    var outputString = new StringBuilder();
			var splittedStringsCollection = inputString.Split(splitChars.ToCharArray());

			for(int i = 0; i < splittedStringsCollection.Length - 1; i++)
		    {
				outputString.AppendLine(splittedStringsCollection[i] + splitChars);
		    }

		    return outputString.ToString();
	    }
    }
}
