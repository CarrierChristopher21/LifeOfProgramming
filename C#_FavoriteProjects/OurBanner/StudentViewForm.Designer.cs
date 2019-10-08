namespace OurBanner
{
    partial class StudentConsoleViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.getStudentSubmission = new System.Windows.Forms.Button();
            this.GetInputDropList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.utilityXMLFileLoaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.utilityXMLFileLoaderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // getStudentSubmission
            // 
            this.getStudentSubmission.Location = new System.Drawing.Point(198, 64);
            this.getStudentSubmission.Name = "getStudentSubmission";
            this.getStudentSubmission.Size = new System.Drawing.Size(124, 34);
            this.getStudentSubmission.TabIndex = 0;
            this.getStudentSubmission.Text = "Submit";
            this.getStudentSubmission.UseVisualStyleBackColor = true;
            this.getStudentSubmission.Click += new System.EventHandler(this.submit_Click);
            // 
            // GetInputDropList
            // 
            this.GetInputDropList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GetInputDropList.FormattingEnabled = true;
            this.GetInputDropList.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104"});
            this.GetInputDropList.Location = new System.Drawing.Point(29, 64);
            this.GetInputDropList.MaxDropDownItems = 10;
            this.GetInputDropList.Name = "GetInputDropList";
            this.GetInputDropList.Size = new System.Drawing.Size(121, 21);
            this.GetInputDropList.TabIndex = 3;
            this.GetInputDropList.Tag = "Select Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Press a number 1 - 104 to choose a student \r\nOR Press 0 to recieve All of the Stu" +
    "dents on File: ";
            // 
            // utilityXMLFileLoaderBindingSource
            // 
            this.utilityXMLFileLoaderBindingSource.DataSource = typeof(OurBanner.UtilityXMLFileLoader);
            // 
            // StudentViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GetInputDropList);
            this.Controls.Add(this.getStudentSubmission);
            this.Name = "StudentViewForm";
            this.Text = "Student View Form";
            ((System.ComponentModel.ISupportInitialize)(this.utilityXMLFileLoaderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getStudentSubmission;
        private System.Windows.Forms.ComboBox GetInputDropList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource utilityXMLFileLoaderBindingSource;
    }
}