using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Managers;
using System.Xml;


namespace WinForms
    {
    public partial class EmployeeForm : Form
        {
        public EmployeeForm ()
            {
            InitializeComponent ();
            }

        XmlManager xmlManager = new XmlManager ();

        private void Insert_Click (object sender, EventArgs e)
            {
            XmlDocument Xdoc = xmlManager.CreateXmlFile ();

            DataSet dataSet = new DataSet ();
            dataSet.ReadXml (@"C:\Users\i3\source\repos\WinForms\WinForms\Data\employee.xml");
            employeeDataGridView.DataSource = dataSet.Tables [0];
            }

        private void Update_Click (object sender, EventArgs e)
            {

            }

        private void Delete_Click (object sender, EventArgs e)
            {
            employeeDataGridView.Rows [0].Selected = true;
            DataSet dataSet = new DataSet ();
            dataSet.ReadXml (@"C:\Users\i3\source\repos\WinForms\WinForms\Data\employee.xml");
            xmlManager.DeleteChild ();
            foreach ( DataGridViewCell oneCell in employeeDataGridView.SelectedCells )
                {
                if ( oneCell.Selected )
                    employeeDataGridView.Rows.RemoveAt (oneCell.RowIndex);
                }
            }

        private void FirstName_TextChanged (object sender, EventArgs e)
            {

            }
        }
    }
