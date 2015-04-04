namespace Incubator_Downloader
{
    partial class ProgressForm
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
            this.pbDownload = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // pbDownload
            // 
            this.pbDownload.Location = new System.Drawing.Point(12, 25);
            this.pbDownload.Name = "pbDownload";
            this.pbDownload.Size = new System.Drawing.Size(335, 31);
            this.pbDownload.TabIndex = 0;
            // 
            // ProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 80);
            this.Controls.Add(this.pbDownload);
            this.Name = "ProgressForm";
            this.Text = "Descarc";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbDownload;
    }
}