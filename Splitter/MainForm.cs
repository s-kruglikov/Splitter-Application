using System;
using System.ComponentModel;
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

		public int ProgressMax
		{
			get { return progressBar1.Maximum; }
			set { progressBar1.Maximum = value; }
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
			backgroundWorker1.RunWorkerAsync();
		}

		private void btnAbout_Click(object sender, EventArgs e)
		{
			if (OnAboutInfo != null)
			{
				OnAboutInfo(sender, e);
			}
		}

		#region Public Methods
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

		public void BackgroundWorkerReport(int i)
		{
			backgroundWorker1.ReportProgress(i);
		}

		#endregion

		#region Internal Implementations
		/// <summary>
		/// Starts bacground split string operation
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			if (OnSplitString != null)
			{
				OnSplitString(sender, e);
			}
		}
		
		/// <summary>
		/// Sets progressbar values
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			// Change the value of the ProgressBar to the BackgroundWorker progress.
			progressBar1.Value = e.ProgressPercentage;
			// Set the text.
			//this.Text = e.ProgressPercentage.ToString();
		}
		#endregion
	}
}
