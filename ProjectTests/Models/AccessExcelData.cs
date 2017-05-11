namespace ProjectTests.Models
{
    using Dapper;
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data.OleDb;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AccessExcelData
    {
        public static string TestDataFileConnection()
        {

            var path = AppDomain.CurrentDomain.BaseDirectory + "ExcelFilesData\\";
            var filename = "RegisterPageData.xlsx";
            var con = string.Format("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = {0}; Extended Properties='Excel 12.0 Xml; HDR=YES; IMEX=1,';", path + filename);
            return con;

        }

        public static RegistrationUserModel GetTestData(string keyName)
        {
            using (var connection = new
                OleDbConnection(TestDataFileConnection()))
            {
                connection.Open();
                var query = string.Format("select * from [DataSet$]where key = '{0}'", keyName);
                var value = connection.Query<RegistrationUserModel>(query).FirstOrDefault();
                connection.Close();
                return value;
            }
        }

    }
}
