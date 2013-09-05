using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Office.Interop.Excel;
using Startup;

namespace Chapter2.Objective2
{
    [Description("Listing 2-28 Exporting some data to Excel.")]
    internal class ExportingSomeDataToExcel : ISample
    {
        public void Run()
        {
            var entities = new List<dynamic>
            {
                new
                {
                    ColumnA = 1,
                    ColumnB = "Foo"
                },
                new
                {
                    ColumnA = 2,
                    ColumnB = "Bar"
                }
            };

            DisplayInExcel(entities);
        }

        private static void DisplayInExcel(IEnumerable<dynamic> entities)
        {
            var excelApp = new Application();

            excelApp.Visible = true;
            excelApp.Workbooks.Add();

            dynamic workSheet = excelApp.ActiveSheet;

            workSheet.Cells[1, "A"] = "Header A";
            workSheet.Cells[1, "B"] = "Header B";

            int row = 1;
            foreach (dynamic entity in entities)
            {
                row++;
                workSheet.Cells[row, "A"] = entity.ColumnA;
                workSheet.Cells[row, "B"] = entity.ColumnB;
            }

            workSheet.Columns[1].AutoFit();
            workSheet.Columns[2].AutoFit();
        }
    }
}