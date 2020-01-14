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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "doctorsDataSet.doctorFullName". При необходимости она может быть перемещена или удалена.
            this.doctorFullNameTableAdapter.Fill(this.doctorsDataSet.doctorFullName);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "doctorsDataSet.doctors". При необходимости она может быть перемещена или удалена.
            this.doctorsTableAdapter.Fill(this.doctorsDataSet.doctors);
            timePick.MinDate = DateTime.Now;
        }

        private void doctorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doctorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.doctorsDataSet);

        }

        private void AddClientToDB(object sender, EventArgs e)
        {

            //int sqr(int i) { return i * i; }

            //var vals = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var even = from i in vals where i % 2 == 0 select sqr(i);
            //var even2 = vals.Where(i => i % 2 == 0).Select(sqr);

            //clientsTA.Insert();
            var doctor = ((DataRowView) doctorFullNameBindingSource.Current).Row as doctorsDataSet.doctorFullNameRow;


            clientsTableAdapter.Insert(ClientName.Text, ClientPhone.Text, doctor.Id);
        }

        private void checkDoctorClients(object sender, EventArgs e)
        {
            var DoctorClients = new DoctorClients();
            Hide();
            DoctorClients.ShowDialog();
            Show();
        }

        private void BtnMouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.White;
        }
    }
}
