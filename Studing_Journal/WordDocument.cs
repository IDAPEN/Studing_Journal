using System;
using System.Data;
using word = Microsoft.Office.Interop.Word;

namespace Studing_Journal
{
    class WordDocument
    {
        public DataTable table = new DataTable();
        public string Group_name = "";
        public string AVG = "", QC = "", PC = "";
        public void student_list()
        {
            word.Application application = new word.Application();
            word.Document document = application.Documents.Add(Visible: true);
            word.Range range = document.Range(0, 0);
            string file_name = Registry_Class.DirPath+"\\СГ_"+Group_name
                +DateTime.Now.ToString("_hh_mm_ss_dd_MM_yyyy")+".docx";
            try
            {
                document.Sections.PageSetup.LeftMargin 
                    = application.CentimetersToPoints(Convert.ToSingle(Registry_Class.DocLM));
                document.Sections.PageSetup.RightMargin 
                    = application.CentimetersToPoints(Convert.ToSingle(Registry_Class.DocRM));
                document.Sections.PageSetup.TopMargin 
                    = application.CentimetersToPoints(Convert.ToSingle(Registry_Class.DocTM));
                document.Sections.PageSetup.BottomMargin 
                    = application.CentimetersToPoints(Convert.ToSingle(Registry_Class.DocBM));
                range.Text = Registry_Class.OrganizationName;
                range.ParagraphFormat.Alignment 
                    = word.WdParagraphAlignment.wdAlignParagraphCenter;
                range.ParagraphFormat.SpaceAfter = 1;
                range.ParagraphFormat.SpaceBefore = 1;
                range.ParagraphFormat.LineSpacingRule = word.WdLineSpacing.wdLineSpaceSingle;
                range.Font.Name = "Times New Roman";
                range.Font.Size = 12;
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                word.Paragraph Name_Doc = document.Paragraphs.Add();
                Name_Doc.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
                Name_Doc.Range.Font.Name = "Times New Roman";
                Name_Doc.Range.Font.Size = 16;
                Name_Doc.Range.Text = "СПИСОК ГРУППЫ " + Group_name;
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                word.Paragraph pTable = document.Paragraphs.Add();
                word.Table tbStudents = document.Tables.Add(pTable.Range, table.Rows.Count+1, 
                    table.Columns.Count);
                tbStudents.Borders.InsideLineStyle = word.WdLineStyle.wdLineStyleSingle;
                tbStudents.Borders.OutsideLineStyle = word.WdLineStyle.wdLineStyleSingle;
                tbStudents.Cell(1, 1).Range.Text = "№ПП";
                tbStudents.Cell(1, 2).Range.Text = "Фамилия имя отчество студента";
                tbStudents.Range.Font.Size = 11;
                tbStudents.Range.Font.Name = "Times New Roman";
                tbStudents.Columns[1].AutoFit();
                for (int i = 2; i<=tbStudents.Rows.Count;i++)
                    for (int j = 1; j<=tbStudents.Columns.Count;j++)
                    {
                        tbStudents.Cell(i, j).Range.Text 
                            = table.Rows[i - 2][j - 1].ToString();
                    }
            }
            catch(Exception ex)
            {
                Registry_Class.error_message += "\n" 
                    + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                document.SaveAs2(file_name, word.WdSaveFormat.wdFormatDocumentDefault);
                document.Close();
                application.Quit();
            }
        }

        public void quality_Group()
        {
            word.Application application = new word.Application();
            word.Document document = application.Documents.Add(Visible: true);
            word.Range range = document.Range(0, 0);
            string file_name = Registry_Class.DirPath + "\\УС_" + Group_name
                + DateTime.Now.ToString("_hh_mm_ss_dd_MM_yyyy") + ".docx";
            try
            {
                document.Sections.PageSetup.LeftMargin 
                    = application.CentimetersToPoints(Convert.ToSingle(Registry_Class.DocLM));
                document.Sections.PageSetup.RightMargin 
                    = application.CentimetersToPoints(Convert.ToSingle(Registry_Class.DocRM));
                document.Sections.PageSetup.TopMargin 
                    = application.CentimetersToPoints(Convert.ToSingle(Registry_Class.DocTM));
                document.Sections.PageSetup.BottomMargin 
                    = application.CentimetersToPoints(Convert.ToSingle(Registry_Class.DocBM));
                range.Text = Registry_Class.OrganizationName;
                range.ParagraphFormat.Alignment 
                    = word.WdParagraphAlignment.wdAlignParagraphCenter;
                range.ParagraphFormat.SpaceAfter = 1;
                range.ParagraphFormat.SpaceBefore = 1;
                range.ParagraphFormat.LineSpacingRule 
                    = word.WdLineSpacing.wdLineSpaceSingle;
                range.Font.Name = "Times New Roman";
                range.Font.Size = 12;
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                word.Paragraph Name_Doc = document.Paragraphs.Add();
                Name_Doc.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
                Name_Doc.Range.Font.Name = "Times New Roman";
                Name_Doc.Range.Font.Size = 16;
                Name_Doc.Range.Text = "УСПЕВАЕМОСТЬ ГРУППЫ " + Group_name;
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                word.Paragraph pTable = document.Paragraphs.Add();
                word.Table tbQuality = document.Tables.Add(pTable.Range, 3, 2);
                tbQuality.Borders.InsideLineStyle = word.WdLineStyle.wdLineStyleSingle;
                tbQuality.Borders.OutsideLineStyle = word.WdLineStyle.wdLineStyleSingle;
                tbQuality.Cell(1, 1).Range.Text = "Средний балл";
                tbQuality.Cell(2, 1).Range.Text = "% качества";
                tbQuality.Cell(3, 1).Range.Text = "% успеваемости";
                tbQuality.Cell(1, 2).Range.Text = AVG;
                tbQuality.Cell(2, 2).Range.Text = QC;
                tbQuality.Cell(3, 2).Range.Text = PC;
                tbQuality.Range.Font.Size = 11;
                tbQuality.Range.Font.Name = "Times New Roman";
                tbQuality.Columns[1].AutoFit();
                tbQuality.Range.Paragraphs.Alignment = 
                    word.WdParagraphAlignment.wdAlignParagraphCenter;
            }
            catch(Exception ex)
            {
                Registry_Class.error_message += "\n" 
                    + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                document.SaveAs2(file_name, word.WdSaveFormat.wdFormatDocumentDefault);
                document.Close();
                application.Quit();
            }
        }
    }
}
