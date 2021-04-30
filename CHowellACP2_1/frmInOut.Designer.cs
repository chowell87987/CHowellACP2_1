namespace CHowellACP2_1
{
    partial class frmInOut
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
            if (disposing && (components != null))
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
            this.btnGrades = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbxDisplay = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGrades
            // 
            this.btnGrades.Location = new System.Drawing.Point(12, 353);
            this.btnGrades.Name = "btnGrades";
            this.btnGrades.Size = new System.Drawing.Size(140, 41);
            this.btnGrades.TabIndex = 0;
            this.btnGrades.Text = "&Grades";
            this.btnGrades.UseVisualStyleBackColor = true;
            this.btnGrades.Click += new System.EventHandler(this.btnGrades_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(334, 353);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 41);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbxDisplay
            // 
            this.lbxDisplay.FormattingEnabled = true;
            this.lbxDisplay.ItemHeight = 22;
            this.lbxDisplay.Location = new System.Drawing.Point(12, 12);
            this.lbxDisplay.Name = "lbxDisplay";
            this.lbxDisplay.Size = new System.Drawing.Size(462, 334);
            this.lbxDisplay.TabIndex = 4;
            // 
            // frmInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 406);
            this.Controls.Add(this.lbxDisplay);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGrades);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmInOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input and Output";
            this.Load += new System.EventHandler(this.frmInOut_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGrades;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lbxDisplay;
    }
}