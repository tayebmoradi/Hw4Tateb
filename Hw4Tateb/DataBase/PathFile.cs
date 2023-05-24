using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4Tateb.DataBase
{

    public static class PathFile
    {
        private static string workingDirectory;
        private static string projectDirectory;
        public static string PathFileDataBase()
        {
            workingDirectory = Environment.CurrentDirectory;
            projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            return $"{projectDirectory}\\DataBase\\UsersCsvFile.csv";
        }
    }
}
