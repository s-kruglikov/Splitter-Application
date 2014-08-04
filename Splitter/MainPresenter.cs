using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Splitter
{
	class MainPresenter
	{
		private readonly IMainView _mainView;

		private const string AboutInfoText = "Splitter v.{0}{1}Splits string onto multi lines by split symbol";
		private const string OpenFileExceptionText = @"Unable to open file. Please refer for exception details.";
		private const string SaveFileExceptionText = @"Unable to save file. Please feref for exception details.";

		public MainPresenter(IMainView mainView)
		{
			_mainView = mainView;
			_mainView.OnAboutInfo += _mainView_OnAboutInfo;
			_mainView.OnSplitString += _mainView_OnSplitString;
			_mainView.OnOpenFile += _mainView_OnOpenFile;
			_mainView.OnSaveFile += _mainView_OnSaveFile;
		}

		void _mainView_OnSaveFile(object sender, EventArgs e)
		{
			try
			{
				File.WriteAllText(_mainView.FileName, _mainView.EditorText);
			}
			catch (IOException exc)
			{
				_mainView.NotifyException(SaveFileExceptionText, exc);
			}
		}

		void _mainView_OnOpenFile(object sender, EventArgs e)
		{
			try
			{
				_mainView.EditorText = File.ReadAllText(_mainView.FileName);
			}
			catch (IOException exc)
			{
				_mainView.NotifyException(OpenFileExceptionText, exc);
			}
		}

		void _mainView_OnSplitString(object sender, EventArgs e)
		{
			var formatter = new TextFormatter();
			var splittedString = formatter.SplitString(_mainView.EditorText, _mainView.SplitCharsString);

			_mainView.EditorText = splittedString;
		}

		void _mainView_OnAboutInfo(object sender, EventArgs e)
		{
			var appVersion = Assembly.GetExecutingAssembly().GetName().Version;
			MessageBox.Show(string.Format(AboutInfoText, appVersion, Environment.NewLine));
		}
	}
}
