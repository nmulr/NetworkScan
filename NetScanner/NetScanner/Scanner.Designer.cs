namespace NetScanner
{
    partial class Scanner
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
            this.txtIp = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lbl_ipname = new System.Windows.Forms.Label();
            this.btn_Scan = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lstView = new System.Windows.Forms.ListView();
            this.IP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hostname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(12, 295);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(242, 20);
            this.txtIp.TabIndex = 14;
            this.txtIp.TextChanged += new System.EventHandler(this.TxtIp_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(545, 342);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(242, 61);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save to Excel";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(280, 342);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(242, 61);
            this.btnStop.TabIndex = 12;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // lbl_ipname
            // 
            this.lbl_ipname.AutoSize = true;
            this.lbl_ipname.Location = new System.Drawing.Point(277, 374);
            this.lbl_ipname.Name = "lbl_ipname";
            this.lbl_ipname.Size = new System.Drawing.Size(0, 13);
            this.lbl_ipname.TabIndex = 11;
            // 
            // btn_Scan
            // 
            this.btn_Scan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Scan.Location = new System.Drawing.Point(12, 342);
            this.btn_Scan.Name = "btn_Scan";
            this.btn_Scan.Size = new System.Drawing.Size(242, 61);
            this.btn_Scan.TabIndex = 10;
            this.btn_Scan.Text = "Start";
            this.btn_Scan.UseVisualStyleBackColor = true;
            this.btn_Scan.Click += new System.EventHandler(this.Btn_Scan_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 415);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(775, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // lstView
            // 
            this.lstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IP,
            this.Hostname});
            this.lstView.HideSelection = false;
            this.lstView.Location = new System.Drawing.Point(12, 12);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(776, 262);
            this.lstView.TabIndex = 9;
            this.lstView.UseCompatibleStateImageBehavior = false;
            this.lstView.View = System.Windows.Forms.View.Details;
            this.lstView.SelectedIndexChanged += new System.EventHandler(this.LstView_SelectedIndexChanged);
            // 
            // IP
            // 
            this.IP.Text = "IP";
            this.IP.Width = 200;
            // 
            // Hostname
            // 
            this.Hostname.Text = "Hostname";
            this.Hostname.Width = 500;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Please enter starting IP Address";
            // 
            // Scanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lbl_ipname);
            this.Controls.Add(this.btn_Scan);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lstView);
            this.Name = "Scanner";
            this.Text = "Scanner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lbl_ipname;
        private System.Windows.Forms.Button btn_Scan;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListView lstView;
        private System.Windows.Forms.ColumnHeader IP;
        private System.Windows.Forms.ColumnHeader Hostname;
        private System.Windows.Forms.Label label1;
    }
}