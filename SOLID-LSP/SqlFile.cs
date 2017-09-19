using System;
namespace SOLIDLSP
{
    public class SqlFile :IReadableSqlFile, IWritableSqlFile
    {
		public string FilePath { get; set; }
		public string FileText { get; set; }

		public string LoadText()
		{
			String text = String.Empty;

			Console.WriteLine("SQL File Load File");

			return text;
        }

		public void SaveText()
		{
			Console.WriteLine("SQL File Save File");
		}
    }
}
