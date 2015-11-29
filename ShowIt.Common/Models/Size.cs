namespace ShowIt.Common.Models
{
	public class Size
	{
		public int Height { get; private set; }

		public int Width { get; private set; }

		public Size(int height, int width)
		{
			Width = width;
			Height = height;
		}
	}
}