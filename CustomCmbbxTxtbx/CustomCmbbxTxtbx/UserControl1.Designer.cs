namespace CustomCmbbxTxtbx
{
    partial class UserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.custCmbbxTxtbx1 = new CustomCmbbxTxtbx.CustCmbbxTxtbx();
            this.SuspendLayout();
            // 
            // custCmbbxTxtbx1
            // 
            this.custCmbbxTxtbx1.DataList = ((System.Collections.Generic.List<string>)(resources.GetObject("custCmbbxTxtbx1.DataList")));
            this.custCmbbxTxtbx1.Location = new System.Drawing.Point(284, 62);
            this.custCmbbxTxtbx1.Name = "custCmbbxTxtbx1";
            this.custCmbbxTxtbx1.Size = new System.Drawing.Size(285, 63);
            this.custCmbbxTxtbx1.TabIndex = 0;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.custCmbbxTxtbx1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CustCmbbxTxtbx custCmbbxTxtbx1;
    }
}
