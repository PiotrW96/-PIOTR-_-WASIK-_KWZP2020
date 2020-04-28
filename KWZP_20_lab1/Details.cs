using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KWZP_20_lab1
{
    public partial class Details : Form
    {
        public Details(SzwalniaEntities db, String employeeLastName)
        {
            InitializeComponent();
            Pracownicy employee = db.Pracownicy.Where(pracownik=> pracownik.Nazwisko == employeeLastName).First();

            lblTitle.Text = employee.Imie.TrimEnd() + " " + employee.Nazwisko;
            txtName.Text = employee.Imie;
            txtLastName.Text = employee.Nazwisko;
            txtPesel.Text = employee.Pesel;
            txtAddress.Text = employee.Adres;

            dgvRecordsList.DataSource = db.vZatrudnienie.Where(employment => employment.ID_Pracownika == employee.ID_Pracownika).ToList();
         
        }

        public Details(string text)
        {
            Text = text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Details_Load(object sender, EventArgs e)
        {

        }
    }
}
