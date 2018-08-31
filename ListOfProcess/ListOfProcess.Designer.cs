namespace ListOfProcess
{
	partial class ListOfProcess
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
			this.listView = new System.Windows.Forms.ListView();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnTaskList = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listView
			// 
			this.listView.Location = new System.Drawing.Point(12, 12);
			this.listView.Name = "listView";
			this.listView.Size = new System.Drawing.Size(776, 391);
			this.listView.TabIndex = 0;
			this.listView.UseCompatibleStateImageBehavior = false;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(13, 410);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "Add Process";
			this.btnAdd.UseVisualStyleBackColor = true;
			// 
			// btnTaskList
			// 
			this.btnTaskList.Location = new System.Drawing.Point(95, 410);
			this.btnTaskList.Name = "btnTaskList";
			this.btnTaskList.Size = new System.Drawing.Size(75, 23);
			this.btnTaskList.TabIndex = 2;
			this.btnTaskList.Text = "Task List";
			this.btnTaskList.UseVisualStyleBackColor = true;
			// 
			// ListOfProcess
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 441);
			this.Controls.Add(this.btnTaskList);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.listView);
			this.Name = "ListOfProcess";
			this.Text = "List of Process";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView listView;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnTaskList;
	}
}

