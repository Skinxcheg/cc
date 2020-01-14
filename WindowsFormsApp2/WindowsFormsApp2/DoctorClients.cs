using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class DoctorClients : Form
    {
        public DoctorClients()
        {
            InitializeComponent();
        }

        private void doctorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doctorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.doctorsDataSet);

        }

        private void DoctorClients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "doctorsDataSet.clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.doctorsDataSet.clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "doctorsDataSet.doctors". При необходимости она может быть перемещена или удалена.
            this.doctorsTableAdapter.Fill(this.doctorsDataSet.doctors);

        }
    }
}
