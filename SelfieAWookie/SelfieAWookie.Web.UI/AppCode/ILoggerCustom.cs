namespace SelfieAWookie.Web.UI.AppCode
{
	public interface ILoggerCustom
	{
		void Log(string message, Exception? ex = null);
	}
}
