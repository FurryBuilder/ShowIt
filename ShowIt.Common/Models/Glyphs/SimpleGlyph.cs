using System;

namespace ShowIt.Common.Models.Glyphs
{
	public class SimpleGlyph : Glyph
	{
		public SimpleGlyph(ConsoleColor backgroundColor, ConsoleColor foregroundColor, char value)
			: base(backgroundColor, foregroundColor, new [] { value })
		{
		}

		public override char GetValue(Orientation orientation)
		{
			return base.GetValue(Orientation.LeftToRight);
		}
	}
}