using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GestionReservationHotel.ControlUtilisateur
{
    public partial class UC_Hotel : UserControl
    {
        DataClasseDataContext dc = new DataClasseDataContext();

        public static DateTime dateReservation { get; set; }
        public UC_Hotel()
        {
            InitializeComponent();
        }

        private void UC_Hotel_Load(object sender, EventArgs e)
        {
            dateReservation=dateTimePicker1.Value;
        }

        private void uC_Chambre1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uC_Chambre2_Load(object sender, EventArgs e)
        {

        }

        private void uC_Chambre9_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateReservation = dateTimePicker1.Value;
            foreach (UC_Chambre r in tableLayoutPanel1.Controls)
            {
                r.ChambreReservee(dateTimePicker1.Value);
            }
           
            /*
            foreach (Control r in this.Controls)
            {
                MessageBox.Show(r.ToString());
                if (r is UC_Chambre)
                {
                    
                    UC_Chambre chambre = (UC_Chambre)r;
                   
                    chambre.ChambreReservee(dateTimePicker1.Value);
                    
                }
            }*/
        }

        private void uC_Chambre1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
