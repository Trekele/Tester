namespace Test
{
    partial class frmTester
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
            System.Windows.Forms.TrackBar tbRadius;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.btnGo = new System.Windows.Forms.Button();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.lblRadius = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.txtAlertDescription = new System.Windows.Forms.TextBox();
            this.txtAlertTitle = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            tbRadius = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(tbRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbRadius
            // 
            tbRadius.Location = new System.Drawing.Point(60, 346);
            tbRadius.Minimum = 1;
            tbRadius.Name = "tbRadius";
            tbRadius.Size = new System.Drawing.Size(246, 45);
            tbRadius.TabIndex = 9;
            tbRadius.Value = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gmap);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnGo);
            this.splitContainer1.Panel2.Controls.Add(this.rb5);
            this.splitContainer1.Panel2.Controls.Add(this.rb4);
            this.splitContainer1.Panel2.Controls.Add(this.rb3);
            this.splitContainer1.Panel2.Controls.Add(this.rb2);
            this.splitContainer1.Panel2.Controls.Add(tbRadius);
            this.splitContainer1.Panel2.Controls.Add(this.rb1);
            this.splitContainer1.Panel2.Controls.Add(this.lblRadius);
            this.splitContainer1.Panel2.Controls.Add(this.lblPriority);
            this.splitContainer1.Panel2.Controls.Add(this.txtAlertDescription);
            this.splitContainer1.Panel2.Controls.Add(this.txtAlertTitle);
            this.splitContainer1.Panel2.Controls.Add(this.lblDescription);
            this.splitContainer1.Panel2.Controls.Add(this.lblTitle);
            this.splitContainer1.Panel2.Controls.Add(this.lblDashboard);
            this.splitContainer1.Size = new System.Drawing.Size(905, 424);
            this.splitContainer1.SplitterDistance = 560;
            this.splitContainer1.TabIndex = 0;
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(0, 0);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 2;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(557, 424);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 0D;
            this.gmap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gmap_MouseClick);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(145, 389);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 14;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rb5.Location = new System.Drawing.Point(280, 265);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(17, 30);
            this.rb5.TabIndex = 13;
            this.rb5.TabStop = true;
            this.rb5.Text = "5";
            this.rb5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rb4.Location = new System.Drawing.Point(225, 265);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(17, 30);
            this.rb4.TabIndex = 12;
            this.rb4.TabStop = true;
            this.rb4.Text = "4";
            this.rb4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rb3.Location = new System.Drawing.Point(170, 265);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(17, 30);
            this.rb3.TabIndex = 11;
            this.rb3.TabStop = true;
            this.rb3.Text = "3";
            this.rb3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rb2.Location = new System.Drawing.Point(115, 265);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(17, 30);
            this.rb2.TabIndex = 10;
            this.rb2.TabStop = true;
            this.rb2.Text = "2";
            this.rb2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rb1.Location = new System.Drawing.Point(60, 265);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(17, 30);
            this.rb1.TabIndex = 8;
            this.rb1.TabStop = true;
            this.rb1.Text = "1";
            this.rb1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(-1, 328);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(40, 13);
            this.lblRadius.TabIndex = 7;
            this.lblRadius.Text = "Radius";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(-1, 267);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(38, 13);
            this.lblPriority.TabIndex = 6;
            this.lblPriority.Text = "Priority";
            // 
            // txtAlertDescription
            // 
            this.txtAlertDescription.Location = new System.Drawing.Point(60, 89);
            this.txtAlertDescription.Multiline = true;
            this.txtAlertDescription.Name = "txtAlertDescription";
            this.txtAlertDescription.Size = new System.Drawing.Size(246, 151);
            this.txtAlertDescription.TabIndex = 5;
            // 
            // txtAlertTitle
            // 
            this.txtAlertTitle.Location = new System.Drawing.Point(60, 41);
            this.txtAlertTitle.Name = "txtAlertTitle";
            this.txtAlertTitle.Size = new System.Drawing.Size(246, 20);
            this.txtAlertTitle.TabIndex = 4;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(-1, 89);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(-1, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Location = new System.Drawing.Point(129, 9);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(91, 13);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "AlertU Dashboard";
            // 
            // frmTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 424);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmTester";
            this.Text = "AlertU Testing";
            this.Load += new System.EventHandler(this.frmTester_Load);
            ((System.ComponentModel.ISupportInitialize)(tbRadius)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.TextBox txtAlertDescription;
        private System.Windows.Forms.TextBox txtAlertTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Button btnGo;

    }
}

