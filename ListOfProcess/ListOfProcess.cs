using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListOfProcess
{
	public partial class ListOfProcess : Form
	{
		private System.Threading.Timer updateTimer;
		private System.Threading.Timer taskTimer;
		public ProcessItem addedProcess;
		private List<ProcessItem> listProccess = new List<ProcessItem>();
		
		public ListOfProcess()
		{
			InitializeComponent();
			listView.View = View.Details;
			btnAdd.Click += BtnAdd_Click;
			btnTaskList.Click += BtnTaskList_Click;
			InitListView();
			TimerCallback timerCallback = new TimerCallback(UpdateProcess);
			updateTimer = new System.Threading.Timer(timerCallback);
			updateTimer.Change(1000, 30000);
			TimerCallback callbackTask = new TimerCallback(Task);
			taskTimer = new System.Threading.Timer(callbackTask);
			taskTimer.Change(500, 1000);

		}

		private void BtnTaskList_Click(object sender, EventArgs e)
		{
			TaskList wnd = new TaskList(listProccess);
			wnd.Show();
		}

		private void Task(object timer)
		{
			List<ProcessItem> remove = new List<ProcessItem>();
			foreach(var task in listProccess)
			{
				if (task.StartTime != null)
				{
					
					if (task.StartTime < DateTime.Now)
					{						
						task.StartTime = null;
						Process proc = new Process();
						proc.StartInfo.FileName = task.FileName;
						proc.StartInfo.Arguments = task.Params;
						proc.Start();
						task.Id = proc.Id;
						if(task.StopTime == null)
						{
							remove.Add(task);
						}
					}
				}
				if(task.StopTime != null)
				{
					if (task.StopTime < DateTime.Now)
					{
						task.StopTime = null;
						Process[] processes = Process.GetProcesses();
						foreach(var process in processes)
						{
							if(process.Id == task.Id)
							{
								process.CloseMainWindow();
								process.Close();
							}
						}					
						if (task.StartTime == null)
						{
							remove.Add(task);
						}
					}
				}
			}
			foreach(var item in remove)
			{
				listProccess.Remove(item);
			}
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			AddProcess wnd = new AddProcess(this);
			wnd.ShowDialog();
			if(addedProcess == null)
			{				
				return;
			}
			listProccess.Add(addedProcess);
			if (addedProcess.StartTime == null)
			{
				Process proc = new Process();
				proc.StartInfo.FileName = addedProcess.FileName;
				proc.StartInfo.Arguments = addedProcess.Params;
				proc.Start();
				addedProcess.Id = proc.Id;
			}
		}

		private void InitListView()
		{			
			listView.Columns.Add("Id");
			listView.Columns.Add("ProcessName");
			listView.Columns.Add("Threads count");
			listView.Columns.Add("BasePriority");			
		}
		private void UpdateProcess(object timer)
		{
			Process[] processes = Process.GetProcesses();
			listView.Items.Clear();
			foreach (Process process in processes)
			{
				listView.Items.Add(new ListViewItem(new string[] { process.Id.ToString(), process.ProcessName, process.Threads.Count.ToString(), process.BasePriority.ToString() }));
			}
		}
	}
}
