
namespace YazilimMimarisi
{
    partial class adminEkran
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
            this.transListView = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // transListView
            // 
            this.transListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.urunAd});
            this.transListView.HideSelection = false;
            this.transListView.Location = new System.Drawing.Point(12, 12);
            this.transListView.Name = "transListView";
            this.transListView.Size = new System.Drawing.Size(625, 476);
            this.transListView.TabIndex = 2;
            this.transListView.UseCompatibleStateImageBehavior = false;
            this.transListView.View = System.Windows.Forms.View.Details;
            this.transListView.DoubleClick += new System.EventHandler(this.transListView_DoubleClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // urunAd
            // 
            this.urunAd.Text = "Diyetisyen Adı";
            this.urunAd.Width = 130;
            // 
            // adminEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 655);
            this.Controls.Add(this.transListView);
            this.Name = "adminEkran";
            this.Text = "adminEkran";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.adminEkran_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView transListView;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader urunAd;
    }
}