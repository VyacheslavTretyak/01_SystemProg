using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListOfProcess
{
	public partial class AddProcess : Form
	{
		private ListOfProcess parent;
		public AddProcess(ListOfProcess parent)
		{
			InitializeComponent();
			this.parent = parent;
			btnAdd.Click += BtnAdd_Click;
			btnCancel.Click += BtnCancel_Click;
			btnStart.Click += BtnStart_Click;
		}

		private void BtnStart_Click(object sender, EventArgs e)
		{
			Start();
		}

		private void Start()
		{			
			if (openFileDialog1.FileName == "openFileDialog1")
			{
				return;
			}
			parent.addedProcess = new ProcessItem();					
			parent.addedProcess.FileName = lFimeName.Text;
			if (dtpStart.Checked)
			{
				parent.addedProcess.StartTime = dtpStart.Value;
			}
			else
			{
				parent.addedProcess.StartTime = null;
			}
			if (dtpStop.Checked)
			{
				parent.addedProcess.StopTime = dtpStop.Value;
			}
			else
			{
				parent.addedProcess.StopTime = null;
			}
			parent.addedProcess.Params = tbParams.Text;
			DialogResult = DialogResult.OK;
		}
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			parent.addedProcess = null;
			DialogResult = DialogResult.Cancel;
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			var result = openFileDialog1.ShowDialog();
			lFimeName.Text = openFileDialog1.FileName;
		}
	}
}
