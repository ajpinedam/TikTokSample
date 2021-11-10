using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace TikTokSample.Skia.Tizen
{
	class Program
{
	static void Main(string[] args)
	{
		var host = new TizenHost(() => new TikTokSample.App(), args);
		host.Run();
	}
}
}
