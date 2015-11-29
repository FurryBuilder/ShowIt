using System.Collections.Generic;
using ShowIt.Common.Models.Glyphs;

namespace ShowIt.Common.Models.Shapes
{
	public class LineShape : Shape
	{
		public static class Constants
		{
			public const string StartPinGlyph = "StartPin";
			public const string TraitGlyph = "Trait";
			public const string EndPinGlyph = "EndPin";

			public const string Priority = "TraitPriority";
		}

		public enum TraitPriority
		{
			Default = End,

			Start = 0,
			Trait = 1,
			End = 2
		}

		public LineShape(
			Point source,
			Size size,
			Glyph trait,
			Glyph startPin = null,
			Glyph endPin = null,
			TraitPriority traitPriority = TraitPriority.Default
		) : base(
			new Zone(source, size),
			new Dictionary<string, Glyph>
			{
				{ Constants.StartPinGlyph, startPin ?? trait },
				{ Constants.TraitGlyph, trait },
				{ Constants.EndPinGlyph, endPin ?? trait }
			},
			new Dictionary<string, object>
			{
				{ Constants.Priority, traitPriority }
			}
		)
		{ }
	}
}