using System.Collections.Generic;
using ShowIt.Common.Models.Glyphs;

namespace ShowIt.Common.Models.Shapes
{
	public abstract class Shape
	{
		public Zone Zone { get; private set; }

		public IDictionary<string, Glyph> Data { get; private set; }

		public IDictionary<string, object> Configs { get; private set; }

		public Shape(Zone zone, IDictionary<string, Glyph> data, IDictionary<string, object> configs)
		{
			Zone = zone;
			Data = data;
			Configs = configs;
		}
	}
}