using System.Collections.Generic;
using ShowIt.Common.Models.Glyphs;

namespace ShowIt.Common.Models.Shapes
{
	public class RectangleShape : Shape
	{
		public static class Constants
		{
			public const string TopLeftGlyph = "TopLeft";
			public const string TopRightGlyph = "TopRight";
			public const string BottomLeftGlyph = "BottomLeft";
			public const string BottomRightGlyph = "BottomRight";
			public const string HorizontalGlyph = "Horizontal";
			public const string VerticalGlyph = "Vertical";

			public const string Priority = "TraitPriority";
		}

		public enum TraitPriority
		{
			Default = TopLeft,

			TopLeft = 0,
			TopRight = 1,
			BottomLeft = 2,
			BottomRight = 3,
			Horizontal = 4,
			Vertical = 5
		}

		public RectangleShape(
			Point source,
			Size size,
			Glyph horizontal,
			Glyph vertical,
			Glyph topLeft = null,
			Glyph topRight = null,
			Glyph bottomLeft = null,
			Glyph bottomRight = null,
			TraitPriority traitPriority = TraitPriority.Default
		) : base(
			new Zone(source, size),
			new Dictionary<string, Glyph>
			{
				{ Constants.TopLeftGlyph, topLeft },
				{ Constants.TopRightGlyph, topRight },
				{ Constants.BottomLeftGlyph, bottomLeft },
				{ Constants.BottomRightGlyph, bottomRight },
				{ Constants.HorizontalGlyph, horizontal },
				{ Constants.VerticalGlyph, vertical }
			},
			new Dictionary<string, object>
			{
				{ Constants.Priority, traitPriority}
			}
		)
		{ }
	}
}