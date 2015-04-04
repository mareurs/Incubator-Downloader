namespace Incubator_Downloader
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnViewGraph = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(13, 190);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(112, 35);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Descarca";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.downloadButtonClicked);
            // 
            // btnViewGraph
            // 
            this.btnViewGraph.Location = new System.Drawing.Point(133, 190);
            this.btnViewGraph.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewGraph.Name = "btnViewGraph";
            this.btnViewGraph.Size = new System.Drawing.Size(112, 35);
            this.btnViewGraph.TabIndex = 1;
            this.btnViewGraph.Text = "Afiseaza";
            this.btnViewGraph.UseVisualStyleBackColor = true;
            this.btnViewGraph.Click += new System.EventHandler(this.viewPlotFormClicked);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(385, 190);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 35);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Iesire";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.ExitClicked);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 20);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.MaximumSize = new System.Drawing.Size(340, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(187, 20);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Here lies the status label ";
            // 
            // serialPort
            // 
            this.serialPort.PortName = "COM999";
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialDataReceived);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 73);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.refreshButtonClicked);
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(377, 20);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(121, 28);
            this.cbPorts.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 239);
            this.Controls.Add(this.cbPorts);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnViewGraph);
            this.Controls.Add(this.btnDownload);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Incubator Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnViewGraph;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblStatus;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbPorts;
    }
}

