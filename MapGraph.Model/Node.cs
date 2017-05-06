using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapGraph.Model
{
	public class Node
	{
		public string Name { get; set; }
		public int X { get; set; }
		public int Y { get;set; }
		public ArrayList NodeLinksList = new ArrayList();
		public ArrayList LinksList = new ArrayList();

		public Node(string name)
		{
			Name = name;
		}

		public Node(string name, int x, int y)
		{
			Name = name;
			X = x;
			Y = y;
		}
	}
}
