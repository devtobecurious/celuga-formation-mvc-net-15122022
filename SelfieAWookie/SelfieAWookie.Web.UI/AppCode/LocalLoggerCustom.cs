namespace SelfieAWookie.Web.UI.AppCode
{
	public class LocalLoggerCustom : ILoggerCustom
	{
		public void Log(string message, Exception? ex = null)
		{
			Console.WriteLine(message, ex);	
		}
	}
}
