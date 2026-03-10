using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolucao
{
    public class ImportarExcel
    {
        public DataSet importarXLS(string caminho)
        {
            DataSet dataSet = new DataSet();
            using (var stream = File.Open(caminho, FileMode.Open, FileAccess.Read))
            {
                IExcelDataReader reader;
                reader = ExcelDataReader.ExcelReaderFactory.CreateReader(stream);

                var conf = new ExcelDataSetConfiguration
                {
                    ConfigureDataTable = _ => new ExcelDataTableConfiguration
                    {
                        UseHeaderRow = true
                    }
                };

                dataSet = reader.AsDataSet(conf);
            }
            return dataSet;
        }
    }
}
