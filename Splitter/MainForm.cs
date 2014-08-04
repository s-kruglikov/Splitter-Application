using System;
using System.Windows.Forms;

namespace Splitter
{
	public partial class MainForm : Form, IMainView
	{
		private string _fileName;

		#region Public Properties

		public string EditorText
		{
			get { return txtEditor.Text; }
			set { txtEditor.Text = value; }
		}

		public string SplitCharsString
		{
			get { return txtSplitSymbol.Text; }
		}

		public string FileName
		{
			get { return _fileName; }
		}

		#endregion

		#region Events
		
		public event EventHandler OnOpenFile;
		public event EventHandler OnSplitString;
		public event EventHandler OnSaveFile;
		public event EventHandler OnAboutInfo;

		#endregion

		#region Constants

		private const string OpenFileFilterString = @"All files (*.*)|*.*|837 files (*.837)|*.837|Text files (*.txt)|*.txt";
		private const string SaveFileFilterString = @"Text files (*.txt)|*.txt|837 files (*.837)|*.837";

		#endregion

		public MainForm()
		{
			InitializeComponent();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			saveFileDialog1.Filter = SaveFileFilterString;
			saveFileDialog1.FileName = _fileName + "_splitted";

			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				_fileName = saveFileDialog1.FileName;
				if (OnSaveFile != null)
				{
					OnSaveFile(sender, e);
				}
			}
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			openFileDialog1.Title = @"Please select file to open";
			openFileDialog1.InitialDirectory = _fileName;
			openFileDialog1.FileName = "";
			openFileDialog1.Filter = OpenFileFilterString;

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				if (OnOpenFile != null)
				{
					_fileName = openFileDialog1.FileName;
					OnOpenFile(sender, e);
				}
			}
		}

		private void btnSplit_Click(object sender, EventArgs e)
		{
			if (OnSplitString != null)
			{
				OnSplitString(sender, e);
			}
		}

		private void btnAbout_Click(object sender, EventArgs e)
		{
			if (OnAboutInfo != null)
			{
				OnAboutInfo(sender, e);
			}
		}

		/// <summary>
		/// Shows messagebox with exception details
		/// </summary>
		/// <param name="exceptionUserText">General exception notification string</param>
		/// <param name="exc">Exception object</param>
		public void NotifyException(string exceptionUserText, Exception exc)
		{
			string exceptionMessage = exceptionUserText
				+ Environment.NewLine
				+ string.Format("{0}", exc.Message);

			MessageBox.Show(exceptionMessage);
		}
	}
}
