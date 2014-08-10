using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Splitter
{
	public interface IMainView
	{
		#region Properties

		string EditorText { get; set; }
		string SplitCharsString { get; }

		string FileName { get; }

		int ProgressMax { get; set; }

		#endregion

		#region Events

		event EventHandler OnOpenFile;
		event EventHandler OnSplitString;
		event EventHandler OnSaveFile;
		event EventHandler OnAboutInfo;

		#endregion

		#region Methods

		void NotifyException(string exceptionUserText, Exception exc);

		void BackgroundWorkerReport(int i);

		#endregion
	}
}
