using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomDataGRid
{
    public partial class CustDataGridView : UserControl
    {
        private int RowCount = 1;
        private string btnPrevSelected = null;
        private List<string> LatestControlsName = new List<string>() { "btnSelect1", "Usertxtbx1", "Passtxtbx1", "Roletxtbx1" };
        private List<MUser> dataList = new List<MUser>() { new MUser("ALi","123","Admin"), new MUser("Hamza","123","Customer"), new MUser("Naeem","123","Admin")};
        public CustDataGridView()
        {
            InitializeComponent();
            btnSelect1.Click += new EventHandler(ChangeBtnColor);
        }


        private void ChangeBtnColor(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if(btnPrevSelected != null)
            {
                if (btnPrevSelected != button.Name)
                {
                    this.Controls[btnPrevSelected].BackColor = Color.LightBlue;
                    this.Controls[button.Name].BackColor = Color.DarkBlue;
                    btnPrevSelected = button.Name;
                }
                else
                {
                    this.Controls[button.Name].BackColor = Color.LightBlue;
                    btnPrevSelected = null;
                }
            }
            else
            {
                this.Controls[button.Name].BackColor = Color.DarkBlue;
                btnPrevSelected = button.Name;
            }
        }

        private void CustDataGridView_Load(object sender, EventArgs e)
        {
            if (dataList != null)
            {
                fillRowWithRecord();
                for(int i=1; i<dataList.Count; i++)
                {
                    AddRow();
                    fillRowWithRecord();                    
                }

            }
        }
        public List<MUser> DataList
        {
            
            set
            {
                dataList = value;
            }
        }
        private void AddRow()
        {
            RowCount++;

            Button b = new Button(), PrevBtn = (Button)this.Controls["btnSelect" + (RowCount - 1).ToString()];
            b.Name = "btnSelect" + RowCount.ToString();
            b.Location = new Point(PrevBtn.Location.X, PrevBtn.Location.Y + PrevBtn.Size.Height);
            b.Size = PrevBtn.Size;
            b.Text = PrevBtn.Text;
            b.BackColor = Color.LightBlue;
            b.Click += new EventHandler(ChangeBtnColor);

            TextBox b1 = new TextBox(), b2 = new TextBox(), b3 = new TextBox();
            TextBox Prevb1 = (TextBox)this.Controls["Usertxtbx" + (RowCount - 1).ToString()], Prevb2 = (TextBox)this.Controls["Passtxtbx" + (RowCount - 1).ToString()], Prevb3 = (TextBox)this.Controls["Roletxtbx" + (RowCount - 1).ToString()];
            b1.Name = "Usertxtbx" + RowCount.ToString();
            b1.Location = new Point(Prevb1.Location.X, Prevb1.Location.Y + Prevb1.Size.Height);
            b1.Size = Prevb1.Size;
            b1.ReadOnly = true;

            b2.Name = "Passtxtbx" + RowCount.ToString();
            b2.Location = new Point(Prevb2.Location.X, Prevb2.Location.Y + Prevb2.Size.Height);
            b2.Size = Prevb2.Size;
            b2.ReadOnly = true;

            b3.Name = "Roletxtbx" + RowCount.ToString();
            b3.Location = new Point(Prevb3.Location.X, Prevb3.Location.Y + Prevb3.Size.Height);
            b3.Size = Prevb3.Size;
            b3.ReadOnly = true;

            LatestControlsName = new List<string>() { b.Name, b1.Name, b2.Name, b3.Name};
            this.Controls.AddRange(new Control[] { b,b1,b2,b3});
        }

        private void fillRowWithRecord()
        {
            this.Controls[LatestControlsName[0]].Text = "*";
            this.Controls[LatestControlsName[1]].Text = dataList[RowCount - 1].Username;
            this.Controls[LatestControlsName[2]].Text = dataList[RowCount - 1].Password;
            this.Controls[LatestControlsName[3]].Text = dataList[RowCount - 1].Role;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtbxSearchBar.Text != "" && IsUserPresent(txtbxSearchBar.Text))
            {
                MessageBox.Show("User Present");
            }
            else
            {
                MessageBox.Show("Incorrect Username");
            }
        }

        private bool IsUserPresent(string name)
        {
            for(int i=1; i<=RowCount; i++)
            {
                if(this.Controls["Usertxtbx" + i.ToString()].Text == name )
                {
                    return true;
                }
            }
            return false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(btnPrevSelected != null)
            {
                int index = int.Parse(btnPrevSelected[9].ToString());
                this.Controls[btnPrevSelected].BackColor = Color.LightBlue;
                RemoveRow(index);
                
                btnPrevSelected = null;
                RowCount--;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void RemoveRow(int index)
        {
            if(index != RowCount)
            {
                for(int i = index; i<RowCount; i++)
                {
                    this.Controls["Usertxtbx" + i.ToString()].Text = this.Controls["Usertxtbx" + (i + 1).ToString()].Text;
                    this.Controls["Passtxtbx" + i.ToString()].Text = this.Controls["Passtxtbx" + (i + 1).ToString()].Text;
                    this.Controls["Roletxtbx" + i.ToString()].Text = this.Controls["Roletxtbx" + (i + 1).ToString()].Text;
                }

                this.Controls.Remove(this.Controls["btnSelect" + RowCount.ToString()]);
                this.Controls.Remove(this.Controls["Usertxtbx" + RowCount.ToString()]);
                this.Controls.Remove(this.Controls["Passtxtbx" + RowCount.ToString()]);
                this.Controls.Remove(this.Controls["Roletxtbx" + RowCount.ToString()]);
                
            }
            else
            {
                this.Controls.Remove(this.Controls["btnSelect" + index.ToString()]);
                this.Controls.Remove(this.Controls["Usertxtbx" + index.ToString()]);
                this.Controls.Remove(this.Controls["Passtxtbx" + index.ToString()]);
                this.Controls.Remove(this.Controls["Roletxtbx" + index.ToString()]);                
            }
        }
    }
}
