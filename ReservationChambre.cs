using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionReservationHotel
{
    public partial class ReservationChambre : Form
    {
        DataClasseDataContext dc = new DataClasseDataContext();
        public ReservationChambre()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = dc.Reservation; 
        }

        private void uC_Hotel1_Load(object sender, EventArgs e)
        {

        }

        private void ReservationChambre_Load(object sender, EventArgs e)
        {

        }
    }
}
