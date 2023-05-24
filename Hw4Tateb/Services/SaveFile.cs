using CsvHelper;
using Hw4Tateb.DataBase;
using Hw4Tateb.Entity;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4Tateb.Services
{
    public class SaveFile
    {
       
        
        public static bool SaveOnCsv(List<User> users)
        {
           
            try
            {

                string filePatch = PathFile.PathFileDataBase();
                using (var writer = new StreamWriter(filePatch))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteHeader<User>();
                    csv.NextRecord();
                    foreach (var User in users)
                    {
                        csv.WriteRecord(User);
                        csv.NextRecord();
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
