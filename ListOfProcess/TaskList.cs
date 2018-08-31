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
	public partial class TaskList : Form
	{
		public TaskList(List<ProcessItem> list)
		{
			InitializeComponent();
			listBox1.DataSource = list;

		}
	}
}
