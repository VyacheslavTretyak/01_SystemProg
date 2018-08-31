namespace ListOfProcess
{
	partial class AddProcess
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
			this.dtpStart = new System.Windows.Forms.DateTimePicker();
			this.dtpStop = new System.Windows.Forms.DateTimePicker();
			this.tbParams = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lFimeName = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// dtpStart
			// 
			this.dtpStart.CustomFormat = "dd MMMM yyyy | HH:mm:ss";
			this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpStart.Location = new System.Drawing.Point(145, 89);
			this.dtpStart.Name = "dtpStart";
			this.dtpStart.ShowCheckBox = true;
			this.dtpStart.Size = new System.Drawing.Size(200, 20);
			this.dtpStart.TabIndex = 0;
			// 
			// dtpStop
			// 
			this.dtpStop.CustomFormat = "dd MMMM yyyy | HH:mm:ss";
			this.dtpStop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpStop.Location = new System.Drawing.Point(145, 127);
			this.dtpStop.Name = "dtpStop";
			this.dtpStop.ShowCheckBox = true;
			this.dtpStop.Size = new System.Drawing.Size(200, 20);
			this.dtpStop.TabIndex = 1;
			// 
			// tbParams
			// 
			this.tbParams.Location = new System.Drawing.Point(145, 175);
			this.tbParams.Name = "tbParams";
			this.tbParams.Size = new System.Drawing.Size(200, 20);
			this.tbParams.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 95);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Start Time";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 133);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Stop Time";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 178);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Params Cmd";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(13, 13);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 6;
			this.btnAdd.Text = "Choose App";
			this.btnAdd.UseVisualStyleBackColor = true;
			// 
			// lFimeName
			// 
			this.lFimeName.AutoSize = true;
			this.lFimeName.Location = new System.Drawing.Point(15, 54);
			this.lFimeName.Name = "lFimeName";
			this.lFimeName.Size = new System.Drawing.Size(62, 13);
			this.lFimeName.TabIndex = 7;
			this.lFimeName.Text = "Choose File";
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(12, 218);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(294, 218);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 9;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			// 
			// AddProcess
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(391, 253);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.lFimeName);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbParams);
			this.Controls.Add(this.dtpStop);
			this.Controls.Add(this.dtpStart);
			this.Name = "AddProcess";
			this.Text = "AddProcess";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dtpStart;
		private System.Windows.Forms.DateTimePicker dtpStop;
		private System.Windows.Forms.TextBox tbParams;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label lFimeName;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnStart;
	}
}