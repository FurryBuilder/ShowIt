namespace ShowIt.Common.Models
{
	public class Zone
	{
		public Point Source { get; private set; }

		public Size Size { get; private set; }

		public Zone(Point source, Size size)
		{
			Source = source;
			Size = size;
		}
	}
}