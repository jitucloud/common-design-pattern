using System;

namespace SOLIDLSP
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IReadableSqlFile readableSQLFile = new ReadOnlySqlFile();

            IReadableSqlFile xx = new ReadOnlySqlFile();

            SqlFileManager sfm = new SqlFileManager();
            sfm.GetTextFromFile(readableSQLFile);


            Console.WriteLine("Hello World!");
        }
    }
}
