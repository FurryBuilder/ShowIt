using Machine.Specifications;
using ShowIt.Common.Contracts;
using ShowIt.Common.Services;

namespace ShowIt.Common.Specs.Adapters
{
	[Subject("Adapters")]
	public class ConsoleAdapterSpecs
	{
		private static IConsoleAdapter _subject;
		private static 

		private Establish _context = () =>
		{
			_subject = new ConsoleAdapter();
		};


	}
}