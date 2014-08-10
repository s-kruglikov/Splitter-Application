using System;
using System.Text;

namespace Splitter
{

    class TextFormatter
    {
		/// <summary>
		/// Splits received string according each split string characters
		/// </summary>
		/// <param name="inputString">Source string</param>
		/// <param name="splitChars">Split characters string</param>
		/// <returns></returns>
        public string SplitString(string inputString, string splitChars)
	    {
		    var outputString = new StringBuilder();
			var splittedStringsCollection = inputString.Split(splitChars.ToCharArray());

			if (OnRowsCalculated != null)
			{
				OnRowsCalculated(this, new OnRowsCalculatedEventArgs {RowsCount = splittedStringsCollection.Length - 2});
			}

			for(int i = 0; i < splittedStringsCollection.Length - 1; i++)
		    {
				outputString.AppendLine(splittedStringsCollection[i] + splitChars);
			    if (OnRowAdded != null)
			    {
				    OnRowAdded(this, new OnRowAddedEventArgs { RowsProcessed = i});
			    }
		    }

		    return outputString.ToString();
	    }

		public event EventHandler OnRowsCalculated;
		public event EventHandler OnRowAdded;
    }

	internal class OnRowAddedEventArgs : EventArgs
	{
		public int RowsProcessed { get; set; }
	}

	internal class OnRowsCalculatedEventArgs : EventArgs
	{
		public int RowsCount { get; set; }
	}
}
