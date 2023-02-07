namespace ex_cours2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_lire_excel = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.colPatineur2 = new System.Windows.Forms.ColumnHeader();
            this.colCourse = new System.Windows.Forms.ColumnHeader();
            this.colDist = new System.Windows.Forms.ColumnHeader();
            this.colNomCourse = new System.Windows.Forms.ColumnHeader();
            this.coPos = new System.Windows.Forms.ColumnHeader();
            this.coTemps = new System.Windows.Forms.ColumnHeader();
            this.colPoints = new System.Windows.Forms.ColumnHeader();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colPatineur = new System.Windows.Forms.ColumnHeader();
            this.colNom = new System.Windows.Forms.ColumnHeader();
            this.coPrenom = new System.Windows.Forms.ColumnHeader();
            this.colAge = new System.Windows.Forms.ColumnHeader();
            this.colVille = new System.Windows.Forms.ColumnHeader();
            this.colPointsT = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // btn_lire_excel
            // 
            this.btn_lire_excel.Location = new System.Drawing.Point(14, 14);
            this.btn_lire_excel.Margin = new System.Windows.Forms.Padding(5);
            this.btn_lire_excel.Name = "btn_lire_excel";
            this.btn_lire_excel.Size = new System.Drawing.Size(198, 98);
            this.btn_lire_excel.TabIndex = 0;
            this.btn_lire_excel.Text = "Lire ficher excel";
            this.btn_lire_excel.UseVisualStyleBackColor = true;
            this.btn_lire_excel.Click += new System.EventHandler(this.btn_lire_excel_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPatineur2,
            this.colCourse,
            this.colDist,
            this.colNomCourse,
            this.coPos,
            this.coTemps,
            this.colPoints});
            this.listView2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView2.Location = new System.Drawing.Point(640, 120);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(679, 600);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // colPatineur2
            // 
            this.colPatineur2.Text = "No Patineur";
            this.colPatineur2.Width = 100;
            // 
            // colCourse
            // 
            this.colCourse.Text = "No Course";
            this.colCourse.Width = 100;
            // 
            // colDist
            // 
            this.colDist.Text = "Distance";
            this.colDist.Width = 80;
            // 
            // colNomCourse
            // 
            this.colNomCourse.Text = "Nom Course";
            this.colNomCourse.Width = 100;
            // 
            // coPos
            // 
            this.coPos.Text = "Position";
            this.coPos.Width = 80;
            // 
            // coTemps
            // 
            this.coTemps.Text = "Temps";
            this.coTemps.Width = 80;
            // 
            // colPoints
            // 
            this.colPoints.Text = "Points";
            this.colPoints.Width = 100;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPatineur,
            this.colNom,
            this.coPrenom,
            this.colAge,
            this.colVille,
            this.colPointsT});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView1.Location = new System.Drawing.Point(28, 120);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(594, 600);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colPatineur
            // 
            this.colPatineur.Text = "No Patineur";
            this.colPatineur.Width = 100;
            // 
            // colNom
            // 
            this.colNom.Text = "Nom";
            this.colNom.Width = 100;
            // 
            // coPrenom
            // 
            this.coPrenom.Text = "Prénom";
            this.coPrenom.Width = 100;
            // 
            // colAge
            // 
            this.colAge.Text = "Age";
            this.colAge.Width = 50;
            // 
            // colVille
            // 
            this.colVille.Text = "Club";
            this.colVille.Width = 130;
            // 
            // colPointsT
            // 
            this.colPointsT.Text = "Points Total";
            this.colPointsT.Width = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 732);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.btn_lire_excel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_lire_excel;
        private ListView listView2;
        private ListView listView1;
        private ColumnHeader colPatineur2;
        private ColumnHeader colCourse;
        private ColumnHeader colDist;
        private ColumnHeader colPos;
        private ColumnHeader coTemps;
        private ColumnHeader colNomC;
        private ColumnHeader colPatineur;
        private ColumnHeader colNom;
        private ColumnHeader coPrenom;
        private ColumnHeader colAge;
        private ColumnHeader colVille;
        private ColumnHeader colPointsT;
        private ColumnHeader colPoints;
        private ColumnHeader colNomCourse;
        private ColumnHeader coPos;
    }
}