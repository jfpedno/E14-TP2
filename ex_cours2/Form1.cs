using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace ex_cours2
{
    public partial class Form1 : Form

    {
        // Connection string for the Excel file
        string excelConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\MultiHexa_cours\\Session4\\E14\\ListePatineurs.xlsx;Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1'";

        // Connection string for the Access database
        string accessConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\MultiHexa_cours\\Session4\\E14\\database2.accdb";


        static Excel.Application? excelApp;
        static Excel.Workbook? excelBook;
        static Excel.Worksheet? excelSheet;
        static Excel.Range? excelRange;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_lire_excel_Click(object sender, EventArgs e)
        {
            long lastRow = excelRange.Rows.Count;
            long lastCol = excelRange.Columns.Count;

            //MessageBox.Show("LastRow: " + lastRow + "LastCol: " + lastCol);
            // 1. Clear the list view
            listView1.Items.Clear();
            listView2.Items.Clear();
            ListViewItem row;
            ListViewItem row2;

            string patineur = "";

            for (int i = 1; i <= lastRow; i++)
            {

                //ListViewItem row;
                //ListViewItem row2;

                //char[] aTrimmer = { ' ', ',' };

                if (String.IsNullOrEmpty(excelSheet.Cells[i, 1].Value2) == false)
                {



                    if ((i - 1) % 4 == 0)
                    {
                        string tempRow = excelSheet.Cells[i, 1].Value2;


                        //char firstChar = tempRow[0];

                        //string patineur = firstChar.ToString();
                        int r = 0;
                        while (r < tempRow.Length && tempRow[r] != ' ')
                        {
                            r++;
                        }
                        patineur = tempRow.Substring(0, r);

                        row = new ListViewItem(patineur);
                        //row.SubItems.Add(patineur.ToString());

                        //char firstCharNom = tempRow[3];
                        int n = 3;  // Start at index 3
                        while (n < tempRow.Length && tempRow[n] != ',' )
                        {
                            n++;
                        }

                        string nom = tempRow.Substring(3, n - 3);
                        row.SubItems.Add(nom.ToString());

                        //char firstCharPreNom
                        int indexVirgule = tempRow.IndexOf(',');
                        int p = indexVirgule + 2;

                        while (p < tempRow.Length && tempRow[p] != ' ')
                        {
                            p++;
                        }

                        //char firstCharAge
                        int a = p + 1;
                        while (a < tempRow.Length && tempRow[a] != ' ')
                        {
                            a++;
                        }

                        //char cmptEspeaces1
                        int x = a;
                        while (x < tempRow.Length && tempRow[x] == ' ')
                        {
                            x++;
                        }

                        //char firstCharVille
                        int v = x + 1;
                        while (v < tempRow.Length && tempRow[v] != ' ')
                        {
                            v++;
                        }

                        //char cmptEspeaces2
                        int y = v;
                        while (y < tempRow.Length && tempRow[y] == ' ')
                        {
                            y++;
                        }

                        //char firstCharPoints
                        int t = y + 1;
                        while (t < tempRow.Length && tempRow[t] != ' ')
                        {
                            t++;
                        }

                        string preNom = tempRow.Substring(indexVirgule + 2, p - (indexVirgule + 2));
                        row.SubItems.Add(preNom.ToString());

                        string age = tempRow.Substring(a - 2, a - p + 1);
                        row.SubItems.Add(age.ToString());


                        string ville = tempRow.Substring(x, v - x);
                        row.SubItems.Add(ville.ToString());

                        string points = tempRow.Substring(y, t - y);
                        row.SubItems.Add(points.ToString());

                        listView1.Items.Add(row);

                    }

                    else
                    {

                        row2 = new ListViewItem(patineur);


                        for (int j = 1; j <= lastCol; j++)
                        {


                            //MessageBox.Show(patineur2);

                            switch (j)
                            {
                                case 1:
                                    //MessageBox.Show(excelSheet.Cells[i, j].Value2);
                                    string noCourse = excelSheet.Cells[i, j].Value2;
                                    row2.SubItems.Add(noCourse.ToString());
                                    break;
                                case 2:
                                    //MessageBox.Show(excelSheet.Cells[i, j].Value2);
                                    string distance = excelSheet.Cells[i, j].Value2;
                                    row2.SubItems.Add(distance.ToString());
                                    break;
                                case 3:
                                    //MessageBox.Show(excelSheet.Cells[i, j].Value2);
                                    string nomCourse = excelSheet.Cells[i, j].Value2;
                                    row2.SubItems.Add(nomCourse.ToString());
                                    break;

                                case 4:
                                    string pos = "";
                                    //MessageBox.Show(pos += excelSheet.Cells[i, j].Value2);
                                    pos += excelSheet.Cells[i, j].Value2;
                                    row2.SubItems.Add(pos.ToString());
                                    break;
                                case 5:
                                    //MessageBox.Show(excelSheet.Cells[i, j].Value2);
                                    string temps = excelSheet.Cells[i, j].Value2;
                                    row2.SubItems.Add(temps.ToString());
                                    break;
                                case 6:
                                    //MessageBox.Show(excelSheet.Cells[i, j].Value2);
                                    string pointsCourse = excelSheet.Cells[i, j].Value2;
                                    row2.SubItems.Add(pointsCourse.ToString());
                                    break;
                            }
                        }

                        listView2.Items.Add(row2);
                        //row2.
                    }
                }
                else
                {
                    i = Convert.ToInt32(lastRow);
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            excelApp = new Excel.Application();
            if(excelApp == null)
            {
                MessageBox.Show("Excel doit être installé pour utiliser cette application");
                Application.Exit();
            }

            try
            {
                excelBook = excelApp?.Workbooks.Open(AppContext.BaseDirectory + "ListePatineurs.xlsx");
                excelSheet = excelBook.Worksheets[1];
                excelRange = excelSheet.UsedRange;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Une erreur est survenue: " + ex.Message);
                CloseExcel();
                Application.Exit();
            }

        }

        private void CloseExcel()
        {
            excelBook.Close();
            excelApp.Quit();

            GC.Collect();
            GC.WaitForPendingFinalizers();

            if(excelRange != null) Marshal.ReleaseComObject(excelRange);
            if(excelSheet != null) Marshal.ReleaseComObject(excelSheet);
            if(excelBook != null) Marshal.ReleaseComObject(excelBook);
            if (excelApp != null) Marshal.ReleaseComObject(excelApp);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseExcel();
        }
    }
}