using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDLSP
{
    public class SqlFileManager
    {
		public string GetTextFromFiles(List<IReadableSqlFile> aLstReadableFiles)
		{
			StringBuilder objStrBuilder = new StringBuilder();

			foreach (var objFile in aLstReadableFiles)
			{
				objStrBuilder.Append(objFile.LoadText());
			}
			return objStrBuilder.ToString();
		}

		public string GetTextFromFile(IReadableSqlFile aReadableFile)
		{
			return aReadableFile.LoadText();
		}

        public void SaveTextIntoFiles(List<IWritableSqlFile> aLstWritableFiles)
		{
			foreach (var objFile in aLstWritableFiles)
			{
				objFile.SaveText();
			}
		}
	}
}
