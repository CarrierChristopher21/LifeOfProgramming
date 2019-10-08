namespace OurBanner
{
    partial class StudentFileForm
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
            this.studentFileSubmit = new System.Windows.Forms.Button();
            this.studentFileBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.studentFileOuputBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // studentFileSubmit
            // 
            this.studentFileSubmit.Location = new System.Drawing.Point(241, 85);
            this.studentFileSubmit.Name = "studentFileSubmit";
            this.studentFileSubmit.Size = new System.Drawing.Size(75, 23);
            this.studentFileSubmit.TabIndex = 0;
            this.studentFileSubmit.Text = "Submit";
            this.studentFileSubmit.UseVisualStyleBackColor = true;
            this.studentFileSubmit.Click += new System.EventHandler(this.studentFileSubmit_Click);
            // 
            // studentFileBox
            // 
            this.studentFileBox.FormattingEnabled = true;
            this.studentFileBox.Items.AddRange(new object[] {
            "Select Item",
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
            this.studentFileBox.Location = new System.Drawing.Point(38, 85);
            this.studentFileBox.Name = "studentFileBox";
            this.studentFileBox.Size = new System.Drawing.Size(121, 21);
            this.studentFileBox.TabIndex = 1;
            this.studentFileBox.Text = "Select Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // studentFileOuputBox
            // 
            this.studentFileOuputBox.FormattingEnabled = true;
            this.studentFileOuputBox.Location = new System.Drawing.Point(38, 147);
            this.studentFileOuputBox.Name = "studentFileOuputBox";
            this.studentFileOuputBox.Size = new System.Drawing.Size(288, 95);
            this.studentFileOuputBox.TabIndex = 3;
            // 
            // StudentFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 261);
            this.Controls.Add(this.studentFileOuputBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentFileBox);
            this.Controls.Add(this.studentFileSubmit);
            this.Name = "StudentFileForm";
            this.Text = "Student File Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button studentFileSubmit;
        private System.Windows.Forms.ComboBox studentFileBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox studentFileOuputBox;
    }
}