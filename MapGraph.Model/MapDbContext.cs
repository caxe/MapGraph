using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapGraph.Model
{
	internal class MapDbContext : DbContext
	{
		public MapDbContext() : base("name = MapGraphConnection") { }
		public IDbSet<Node> Nodes { get; set; }
		public IDbSet<Link> Links { get; set; }
		public IDbSet<Graph> Graphs { get; set; }
	}
}
