using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4Tateb.DataBase
{

    public class PathFile
    {
        private string workingDirectory;
        private string projectDirectory;
        public string PathFileDataBase()
        {
            workingDirectory = Environment.CurrentDirectory;
            projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            return $"{projectDirectory}\\DataBase\\UsersCsvFile.csv";
        }
    }
}
