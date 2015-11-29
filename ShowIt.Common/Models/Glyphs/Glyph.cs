using System;

namespace ShowIt.Common.Models.Glyphs
{
	public class Glyph
	{
		public ConsoleColor BackgroundColor { get; private set; }

		public ConsoleColor ForegroundColor { get; private set; }

		private readonly char[] _values;

		public Glyph(ConsoleColor backgroundColor, ConsoleColor foregroundColor, char[] values)
		{
			BackgroundColor = backgroundColor;
			ForegroundColor = foregroundColor;

			_values = values;
		}

		public virtual char GetValue(Orientation orientation)
		{
			return _values[(short)orientation];
		}
	}
}