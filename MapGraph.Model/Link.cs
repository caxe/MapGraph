using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapGraph.Model
{
	public class Link
	{
		public double Length { get; set; }
		public int LinkType { get; set; }
		public Node RelatedNode { get; set; }

		public Link(double length, int linkType, Node relatedNode)
		{
			Length = length;
			LinkType = linkType;
			RelatedNode = relatedNode;
		}
	}
}
