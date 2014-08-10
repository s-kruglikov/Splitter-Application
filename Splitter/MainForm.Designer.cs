namespace Splitter
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnAbout = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnSplit = new System.Windows.Forms.Button();
			this.btnOpen = new System.Windows.Forms.Button();
			this.txtSplitSymbol = new System.Windows.Forms.TextBox();
			this.lblSplitSymbol = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.txtEditor = new System.Windows.Forms.TextBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.txtEditor, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(587, 512);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.flowLayoutPanel1.Controls.Add(this.btnAbout);
			this.flowLayoutPanel1.Controls.Add(this.btnSave);
			this.flowLayoutPanel1.Controls.Add(this.btnSplit);
			this.flowLayoutPanel1.Controls.Add(this.btnOpen);
			this.flowLayoutPanel1.Controls.Add(this.txtSplitSymbol);
			this.flowLayoutPanel1.Controls.Add(this.lblSplitSymbol);
			this.flowLayoutPanel1.Controls.Add(this.progressBar1);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 480);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(581, 29);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// btnAbout
			// 
			this.btnAbout.Location = new System.Drawing.Point(501, 3);
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.Size = new System.Drawing.Size(75, 23);
			this.btnAbout.TabIndex = 5;
			this.btnAbout.Text = "About";
			this.btnAbout.UseVisualStyleBackColor = true;
			this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(420, 3);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnSplit
			// 
			this.btnSplit.Location = new System.Drawing.Point(339, 3);
			this.btnSplit.Name = "btnSplit";
			this.btnSplit.Size = new System.Drawing.Size(75, 23);
			this.btnSplit.TabIndex = 2;
			this.btnSplit.Text = "Split";
			this.btnSplit.UseVisualStyleBackColor = true;
			this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(258, 3);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(75, 23);
			this.btnOpen.TabIndex = 1;
			this.btnOpen.Text = "Open";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// txtSplitSymbol
			// 
			this.txtSplitSymbol.Location = new System.Drawing.Point(191, 3);
			this.txtSplitSymbol.Name = "txtSplitSymbol";
			this.txtSplitSymbol.Size = new System.Drawing.Size(61, 20);
			this.txtSplitSymbol.TabIndex = 4;
			this.txtSplitSymbol.Text = "~";
			// 
			// lblSplitSymbol
			// 
			this.lblSplitSymbol.AutoSize = true;
			this.lblSplitSymbol.Location = new System.Drawing.Point(123, 0);
			this.lblSplitSymbol.Name = "lblSplitSymbol";
			this.lblSplitSymbol.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
			this.lblSplitSymbol.Size = new System.Drawing.Size(62, 19);
			this.lblSplitSymbol.TabIndex = 3;
			this.lblSplitSymbol.Text = "Split symbol";
			this.lblSplitSymbol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// progressBar1
			// 
			this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.progressBar1.Location = new System.Drawing.Point(4, 3);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(113, 23);
			this.progressBar1.TabIndex = 6;
			// 
			// txtEditor
			// 
			this.txtEditor.AllowDrop = true;
			this.txtEditor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtEditor.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEditor.Location = new System.Drawing.Point(3, 3);
			this.txtEditor.Multiline = true;
			this.txtEditor.Name = "txtEditor";
			this.txtEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtEditor.Size = new System.Drawing.Size(581, 471);
			this.txtEditor.TabIndex = 2;
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.WorkerReportsProgress = true;
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(587, 512);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(200, 100);
			this.Name = "MainForm";
			this.Text = "Splitter";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtEditor;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtSplitSymbol;
        private System.Windows.Forms.Label lblSplitSymbol;
        private System.Windows.Forms.Button btnAbout;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

