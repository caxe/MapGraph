using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MapGraph.Model;

namespace MapGraph.Control
{
	public class Util
	{
		public double? LinkPrice(Link link, double price)
		{
			switch (link.LinkType)
			{
				case 2:
					return 0;
				case 1:
					if (link.Length <= 5) { return 0; } else
					{
						var linkTypeOneCount = (int) ((link.Length - 5) / 10);
						return linkTypeOneCount * 2;
					}
				case 0:
					if (link.Length <= 10) { return 3; } else
					{
						var linkTypeTwoCount = (int) ((link.Length - 10));
						return linkTypeTwoCount * 0.5 + 3;
					}
				default: return null;
			}
		}
	}
}