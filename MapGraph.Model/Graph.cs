using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapGraph.Model
{
	public class Graph
	{
		public Dictionary<string, Node> Map = new Dictionary<string, Node>();

		public void AddNode(Node node)
		{
			Map.Add(node.Name, node);
		}

		public void OneWayLink(string start, string end, double length, int linkType)
		{
			if (Map.ContainsKey(start) && Map.ContainsKey(end))
			{
				Link link = new Link(length, linkType, new Node(end));
				Map[start].LinksList.Add(link);
			} else { Console.WriteLine(@"Missing Nodes"); }
		}

		public void TwoWayLink(string start, string end, double legnth, int linkType)
		{
			OneWayLink(start, end, legnth, linkType);
			OneWayLink(end, start, legnth, linkType);
		}
	}
}
