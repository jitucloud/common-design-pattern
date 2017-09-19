using System;
namespace SOLIDLSP
{
    public class ReadOnlySqlFile : IReadableSqlFile
    {
		public string FilePath { get; set; }
		public string FileText { get; set; }

		public string LoadText()
		{
            String text = String.Empty;

            Console.WriteLine("Read Only SQL File Load File");

            return text;
		}
	}
}
