namespace MetroThing.Controls
{
    partial class DeviceQrTile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceQrTile));
            this.qrPicture = new Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl();
            ((System.ComponentModel.ISupportInitialize)(this.qrPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // qrPicture
            // 
            this.qrPicture.BackColor = System.Drawing.Color.Transparent;
            this.qrPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qrPicture.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M;
            this.qrPicture.Image = ((System.Drawing.Image)(resources.GetObject("qrPicture.Image")));
            this.qrPicture.Location = new System.Drawing.Point(0, 0);
            this.qrPicture.Name = "qrPicture";
            this.qrPicture.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Four;
            this.qrPicture.Size = new System.Drawing.Size(150, 150);
            this.qrPicture.TabIndex = 1;
            this.qrPicture.TabStop = false;
            this.qrPicture.Visible = false;
            // 
            // DeviceQrTile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.qrPicture);
            this.Name = "DeviceQrTile";
            ((System.ComponentModel.ISupportInitialize)(this.qrPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl qrPicture;

    }
}
