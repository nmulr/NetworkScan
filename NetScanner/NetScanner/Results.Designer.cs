﻿namespace NetScanner
{
    partial class Results
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
            this.lstFile = new System.Windows.Forms.ListView();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstFile
            // 
            this.lstFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName});
            this.lstFile.HideSelection = false;
            this.lstFile.Location = new System.Drawing.Point(12, 12);
            this.lstFile.Name = "lstFile";
            this.lstFile.Size = new System.Drawing.Size(776, 347);
            this.lstFile.TabIndex = 7;
            this.lstFile.UseCompatibleStateImageBehavior = false;
            this.lstFile.View = System.Windows.Forms.View.Details;
            this.lstFile.SelectedIndexChanged += new System.EventHandler(this.LstFile_SelectedIndexChanged);
            // 
            // FileName
            // 
            this.FileName.Text = "File Name";
            this.FileName.Width = 500;
            // 
            // btn_Open
            // 
            this.btn_Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Open.Location = new System.Drawing.Point(12, 377);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(242, 61);
            this.btn_Open.TabIndex = 6;
            this.btn_Open.Text = "Open";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.Btn_Open_Click);
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstFile);
            this.Controls.Add(this.btn_Open);
            this.Name = "Results";
            this.Text = "Results";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstFile;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.Button btn_Open;
    }
}