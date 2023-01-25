
namespace CustomDataGRid
{
    partial class CustDataGridView
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
            this.Usertxtbx1 = new System.Windows.Forms.TextBox();
            this.Passtxtbx1 = new System.Windows.Forms.TextBox();
            this.Roletxtbx1 = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnSelect1 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtbxSearchBar = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Usertxtbx1
            // 
            this.Usertxtbx1.Location = new System.Drawing.Point(28, 134);
            this.Usertxtbx1.Name = "Usertxtbx1";
            this.Usertxtbx1.ReadOnly = true;
            this.Usertxtbx1.Size = new System.Drawing.Size(100, 20);
            this.Usertxtbx1.TabIndex = 0;
            // 
            // Passtxtbx1
            // 
            this.Passtxtbx1.Location = new System.Drawing.Point(125, 134);
            this.Passtxtbx1.Name = "Passtxtbx1";
            this.Passtxtbx1.ReadOnly = true;
            this.Passtxtbx1.Size = new System.Drawing.Size(100, 20);
            this.Passtxtbx1.TabIndex = 1;
            this.Passtxtbx1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Roletxtbx1
            // 
            this.Roletxtbx1.Location = new System.Drawing.Point(222, 134);
            this.Roletxtbx1.Name = "Roletxtbx1";
            this.Roletxtbx1.ReadOnly = true;
            this.Roletxtbx1.Size = new System.Drawing.Size(100, 20);
            this.Roletxtbx1.TabIndex = 2;
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(34, 108);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(94, 23);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(131, 108);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(94, 23);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // lblRole
            // 
            this.lblRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(228, 108);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(94, 23);
            this.lblRole.TabIndex = 5;
            this.lblRole.Text = "Role";
            // 
            // btnSelect1
            // 
            this.btnSelect1.BackColor = System.Drawing.Color.LightBlue;
            this.btnSelect1.Location = new System.Drawing.Point(0, 134);
            this.btnSelect1.Name = "btnSelect1";
            this.btnSelect1.Size = new System.Drawing.Size(28, 20);
            this.btnSelect1.TabIndex = 6;
            this.btnSelect1.Text = "*";
            this.btnSelect1.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(309, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtbxSearchBar
            // 
            this.txtbxSearchBar.Location = new System.Drawing.Point(28, 28);
            this.txtbxSearchBar.Name = "txtbxSearchBar";
            this.txtbxSearchBar.Size = new System.Drawing.Size(245, 20);
            this.txtbxSearchBar.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(309, 57);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // CustDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtbxSearchBar);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSelect1);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.Roletxtbx1);
            this.Controls.Add(this.Passtxtbx1);
            this.Controls.Add(this.Usertxtbx1);
            this.Name = "CustDataGridView";
            this.Size = new System.Drawing.Size(394, 313);
            this.Load += new System.EventHandler(this.CustDataGridView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Usertxtbx1;
        private System.Windows.Forms.TextBox Passtxtbx1;
        private System.Windows.Forms.TextBox Roletxtbx1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnSelect1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtbxSearchBar;
        private System.Windows.Forms.Button btnDelete;
    }
}
