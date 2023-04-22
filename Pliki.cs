using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piwo
{
    public class Pliki
    {
        public String fileName = "wyniki.csv";
        public String separator = ";";
        public String firstRow = "Data";

        public Pliki()
        {
            firstRow = "Date" + separator + "Beer" + separator
                + "Wine" + separator + "Vodka" + separator
                + "Promile" + separator + "TimeDetox";
        
        }

        public void SaveRowToFile(String rowData)
        {
            bool isFile = File.Exists(fileName);
            StreamWriter streamWriter = File.AppendText(fileName);

            if (!isFile)
            {
                streamWriter.WriteLine(firstRow);
                streamWriter.WriteLine(rowData);
                streamWriter.Close();
            }
            else
            {
                streamWriter.WriteLine(rowData);
                streamWriter.Close();
            }

        }

    }

}
