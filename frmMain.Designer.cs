namespace ComboBugRepro
{
    partial class frmMain
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
            this.tableHeadings = new System.Windows.Forms.TableLayoutPanel();
            this.lblApp = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblTrackingParam = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tableDirs = new System.Windows.Forms.TableLayoutPanel();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.tableHeadings.SuspendLayout();
            this.flowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableHeadings
            // 
            this.tableHeadings.AutoSize = true;
            this.tableHeadings.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableHeadings.ColumnCount = 4;
            this.tableHeadings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableHeadings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableHeadings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableHeadings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableHeadings.Controls.Add(this.lblApp, 0, 0);
            this.tableHeadings.Controls.Add(this.lblArea, 1, 0);
            this.tableHeadings.Controls.Add(this.lblSource, 2, 0);
            this.tableHeadings.Controls.Add(this.lblTrackingParam, 3, 0);
            this.tableHeadings.Location = new System.Drawing.Point(6, 64);
            this.tableHeadings.Name = "tableHeadings";
            this.tableHeadings.RowCount = 1;
            this.tableHeadings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableHeadings.Size = new System.Drawing.Size(435, 41);
            this.tableHeadings.TabIndex = 0;
            // 
            // lblApp
            // 
            this.lblApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApp.AutoSize = true;
            this.lblApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApp.Location = new System.Drawing.Point(6, 14);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(94, 13);
            this.lblApp.TabIndex = 0;
            this.lblApp.Text = "Application";
            this.lblApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArea
            // 
            this.lblArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(109, 14);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(94, 13);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "Area";
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSource
            // 
            this.lblSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSource.Location = new System.Drawing.Point(212, 14);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(74, 13);
            this.lblSource.TabIndex = 2;
            this.lblSource.Text = "Source";
            // 
            // lblTrackingParam
            // 
            this.lblTrackingParam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrackingParam.AutoSize = true;
            this.lblTrackingParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackingParam.Location = new System.Drawing.Point(295, 14);
            this.lblTrackingParam.Name = "lblTrackingParam";
            this.lblTrackingParam.Size = new System.Drawing.Size(134, 13);
            this.lblTrackingParam.TabIndex = 16;
            this.lblTrackingParam.Text = "Tracking Param";
            this.lblTrackingParam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(12, 48);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(95, 13);
            this.lblHeader.TabIndex = 11;
            this.lblHeader.Text = "Dataset Slot(s):";
            // 
            // flowPanel
            // 
            this.flowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowPanel.AutoScroll = true;
            this.flowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowPanel.Controls.Add(this.tableDirs);
            this.flowPanel.Location = new System.Drawing.Point(3, 106);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(444, 97);
            this.flowPanel.TabIndex = 18;
            // 
            // tableDirs
            // 
            this.tableDirs.AutoSize = true;
            this.tableDirs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableDirs.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableDirs.ColumnCount = 4;
            this.tableDirs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableDirs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableDirs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableDirs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableDirs.Location = new System.Drawing.Point(3, 3);
            this.tableDirs.Name = "tableDirs";
            this.tableDirs.RowCount = 1;
            this.tableDirs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableDirs.Size = new System.Drawing.Size(435, 36);
            this.tableDirs.TabIndex = 1;
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(13, 13);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(75, 23);
            this.cmdUpdate.TabIndex = 19;
            this.cmdUpdate.Text = "Update";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(455, 204);
            this.Controls.Add(this.cmdUpdate);
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.tableHeadings);
            this.Controls.Add(this.lblHeader);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(790, 800);
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Event Setup";
            this.Load += new System.EventHandler(this.frmDirSetup_Load);
            this.tableHeadings.ResumeLayout(false);
            this.tableHeadings.PerformLayout();
            this.flowPanel.ResumeLayout(false);
            this.flowPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableHeadings;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblTrackingParam;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.TableLayoutPanel tableDirs;
        private System.Windows.Forms.Button cmdUpdate;
    }
}