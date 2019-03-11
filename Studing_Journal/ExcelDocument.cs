using System;
using System.Data;
using excel = Microsoft.Office.Interop.Excel;

namespace Studing_Journal
{
    class ExcelDocument
    {
        public string Group_name = "";
        public DataTable dtDiscipline = new DataTable();
        public DataTable dtStudents = new DataTable();
        public void GroupDisciplineCreate()
        {
            string name = Registry_Class.DirPath + Group_name
                + DateTime.Now.ToString("_hh_mm_ss_dd_MM_yyyy") + ".xlsx";
            excel.Application application = new excel.Application();
            excel.Workbook workbook = application.Workbooks.Add();
            excel.Worksheet worksheet = 
                (excel.Worksheet)workbook.ActiveSheet;
            try
            {
                worksheet.Name = Group_name;
                worksheet.Cells[4, 1] = "№ПП";
                worksheet.Cells[4, 2] = "Студент";
                for (int i = 0; i < dtStudents.Rows.Count; i++)
                {
                    worksheet.Cells[i + 5, 1] = Convert.ToInt32(i + 1);
                    worksheet.Cells[i + 5, 2] = dtStudents.Rows[i][0].ToString();
                    worksheet.Columns[2].AutoFit();
                }
                for (int i = 0; i < dtDiscipline.Rows.Count; i++)
                {
                    worksheet.Cells[4, i + 3] = dtDiscipline.Rows[i][0].ToString();
                    excel.Range range = worksheet.Cells[4, i + 3];
                    range.HorizontalAlignment = excel.XlHAlign.xlHAlignCenter;
                    range.Font.Size = 10;
                    range.Orientation = excel.XlOrientation.xlUpward;
                    range.WrapText = true;
                }
                worksheet.Range[worksheet.Cells[3, 3],
                    worksheet.Cells[3, 2 + dtDiscipline.Rows.Count]].Merge();
                worksheet.Cells[3, 3] = "Дисциплины";
                excel.Range conf_cell = worksheet.Cells[3, 3];
                conf_cell.HorizontalAlignment = excel.XlHAlign.xlHAlignCenter;
                conf_cell.VerticalAlignment = excel.XlHAlign.xlHAlignCenter;
                conf_cell.WrapText = true;
                conf_cell = worksheet.Cells[4, 1];
                conf_cell.RowHeight = 150;
                worksheet.Cells[4, 
                    dtDiscipline.Rows.Count + 3] 
                    = "Кол-во часов по уважительной причине";
                worksheet.Cells[4, 
                    dtDiscipline.Rows.Count + 4] = "Кол-во часов по не уважительной причине";
                worksheet.Cells[4, dtDiscipline.Rows.Count + 5] = "Итого";
                conf_cell = worksheet.Cells[4, dtDiscipline.Rows.Count + 3];
                conf_cell.Cells.Orientation = excel.XlOrientation.xlUpward;
                conf_cell.HorizontalAlignment = excel.XlHAlign.xlHAlignCenter;
                conf_cell.WrapText = true;
                conf_cell = worksheet.Cells[4, dtDiscipline.Rows.Count + 4];
                conf_cell.Cells.Orientation = excel.XlOrientation.xlUpward;
                conf_cell.HorizontalAlignment = excel.XlHAlign.xlHAlignCenter;
                conf_cell.WrapText = true;
                conf_cell = worksheet.Cells[4, dtDiscipline.Rows.Count + 5];
                conf_cell.Cells.Orientation = excel.XlOrientation.xlUpward;
                conf_cell.HorizontalAlignment = excel.XlHAlign.xlHAlignCenter;
                conf_cell.WrapText = true;
                worksheet.Range[worksheet.Cells[3, 3 + dtDiscipline.Rows.Count], 
                    worksheet.Cells[3, 5 + dtDiscipline.Rows.Count]].Merge();
                worksheet.Cells[3, 3 + dtDiscipline.Rows.Count] = "Пропуски";
                conf_cell = worksheet.Cells[3, 3 + dtDiscipline.Rows.Count];
                conf_cell.HorizontalAlignment = excel.XlHAlign.xlHAlignCenter;
                conf_cell.VerticalAlignment = excel.XlHAlign.xlHAlignCenter;
                worksheet.Range[worksheet.Cells[2, 1], 
                    worksheet.Cells[2, 5 + dtDiscipline.Rows.Count]].Merge();
                worksheet.Cells[2, 1] = "Сводная ведомомть группы " + Group_name;
                conf_cell = worksheet.Cells[2, 1];
                conf_cell.HorizontalAlignment = excel.XlHAlign.xlHAlignCenter;
                conf_cell.VerticalAlignment = excel.XlHAlign.xlHAlignCenter;
                conf_cell.WrapText = true;
                worksheet.Range[worksheet.Cells[1, 1],
                    worksheet.Cells[1, 5 + dtDiscipline.Rows.Count]].Merge();
                worksheet.Cells[1, 1] = Registry_Class.OrganizationName;
                conf_cell = worksheet.Cells[1, 1];
                conf_cell.HorizontalAlignment = excel.XlHAlign.xlHAlignCenter;
                conf_cell.VerticalAlignment = excel.XlHAlign.xlHAlignCenter;
                conf_cell.WrapText = true;
                conf_cell.RowHeight = 150;
                worksheet.Range[worksheet.Cells[dtStudents.Rows.Count + 5, 1], 
                    worksheet.Cells[dtStudents.Rows.Count + 5, 2]].Merge();
                worksheet.Range[worksheet.Cells[dtStudents.Rows.Count + 6, 1],
                    worksheet.Cells[dtStudents.Rows.Count + 6, 2]].Merge();
                worksheet.Range[worksheet.Cells[dtStudents.Rows.Count + 7, 1], 
                    worksheet.Cells[dtStudents.Rows.Count + 7, 2]].Merge();
                worksheet.Range[worksheet.Cells[dtStudents.Rows.Count + 8, 1], 
                    worksheet.Cells[dtStudents.Rows.Count + 8, 2]].Merge();
                worksheet.Cells[dtStudents.Rows.Count + 5, 1] = "Ср. балл";
                worksheet.Cells[dtStudents.Rows.Count + 6, 1] = "% качества";
                worksheet.Cells[dtStudents.Rows.Count + 7, 1] = "% успеваемости";
                worksheet.Cells[dtStudents.Rows.Count + 8, 1] = "Подпись";
                conf_cell = worksheet.Cells[dtStudents.Rows.Count + 5, 1];
                conf_cell.HorizontalAlignment = excel.XlHAlign.xlHAlignCenter;
                conf_cell.VerticalAlignment = excel.XlHAlign.xlHAlignCenter;
                conf_cell.WrapText = true;
                conf_cell = worksheet.Cells[dtStudents.Rows.Count + 6, 1];
                conf_cell.HorizontalAlignment = excel.XlHAlign.xlHAlignCenter;
                conf_cell.VerticalAlignment = excel.XlHAlign.xlHAlignCenter;
                conf_cell.WrapText = true;
                conf_cell = worksheet.Cells[dtStudents.Rows.Count + 7, 1];
                conf_cell.HorizontalAlignment = excel.XlHAlign.xlHAlignCenter;
                conf_cell.VerticalAlignment = excel.XlHAlign.xlHAlignCenter;
                conf_cell.WrapText = true;
                conf_cell = worksheet.Cells[dtStudents.Rows.Count + 8, 1];
                conf_cell.HorizontalAlignment = excel.XlHAlign.xlHAlignCenter;
                conf_cell.VerticalAlignment = excel.XlHAlign.xlHAlignCenter;
                conf_cell.WrapText = true;
                worksheet.Cells[dtStudents.Rows.Count + 10, 2] 
                    = "Заместитель директора по УМР __________________";
                worksheet.Cells[dtStudents.Rows.Count + 11, 2] 
                    = "Педагог организатор          __________________";
                worksheet.Cells[dtStudents.Rows.Count + 12, 2]
                    = DateTime.Now.ToLongDateString();
                excel.Range brdRange = worksheet.Range[worksheet.Cells[1, 1], 
                    worksheet.Cells[dtStudents.Rows.Count + 8, dtDiscipline.Rows.Count + 5]];
                brdRange.Borders.LineStyle = excel.XlLineStyle.xlContinuous;
                application.ActiveWindow.View = excel.XlWindowView.xlPageBreakPreview;
            }
            catch (Exception ex)
            {
                Registry_Class.error_message += "\n" 
                    + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                workbook.SaveAs(name, application.DefaultSaveFormat);
                workbook.Close();
                application.Quit();
            }
        }
    }
}
