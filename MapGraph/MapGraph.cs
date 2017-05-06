using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapGraph
{
	public partial class MapGraph : Form
	{
		public MapGraph()
		{
			InitializeComponent();
		}

		private void ExitMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void MapGraph_Load(object sender, EventArgs e)
		{

		}

		private void NewMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void NewNode_Click(object sender, EventArgs e)
		{
			var newNode = new NewNode();
			newNode.Show();
		}

	}
}
