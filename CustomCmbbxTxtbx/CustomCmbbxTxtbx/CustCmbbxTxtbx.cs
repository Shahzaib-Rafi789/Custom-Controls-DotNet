using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomCmbbxTxtbx
{
    public partial class CustCmbbxTxtbx : UserControl
    {
        private List<string> dataList = new List<string>();

        public List<string> DataList { get => dataList; set => dataList = value; }

        public CustCmbbxTxtbx()
        {
            InitializeComponent();
        }

        

        private void CustCmbbxTxtbx_Load(object sender, EventArgs e)
        {            
            
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            this.textBox1.Text = comboBox1.SelectedItem.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void SetItemCollection(List<string> s)
        {
            comboBox1.Items.AddRange(s.ToArray());
        }
    }
}
