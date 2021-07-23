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
    public partial class UC_Chambre : UserControl
    {
        public int NumChambre { get; set; }
        DataClasseDataContext dc = new DataClasseDataContext();
        public UC_Chambre()
        {
            InitializeComponent();
        }

        public void ChambreReservee(DateTime d)
        {
           // dc.SubmitChanges();// pour refreshire la base de donnée
            List<Reservation> list = dc.Reservations.ToList();

            foreach (Reservation r in list)
            {
                if (r.DateReservation == d.Date && NumChambre == r.numChambre)
                { this.label1.BackColor = Color.Red; 
                    break; 
                }
                else
                { this.label1.BackColor = Color.DarkTurquoise;
                    //MessageBox.Show("en vert: ",label1.ToString());
                }
            }
        }

        private void UC_Chambre_Load(object sender, EventArgs e)
        {
            label1.Text = NumChambre.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void reserverToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ReservationWindow h = new ReservationWindow();
            h.NumChambre = this.NumChambre;
            h.ShowDialog();
            ChambreReservee(UC_Hotel.dateReservation.Date);

            
        }

        private void libererToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Reservation r = dc.Reservations.FirstOrDefault(res => res.numChambre.Equals(this.NumChambre) && res.DateReservation.Equals(UC_Hotel.dateReservation.Date));
            dc.Reservations.DeleteOnSubmit(r);
            dc.SubmitChanges();
            MessageBox.Show("Chambre " + this.NumChambre.ToString() + " est libérée pour le " + r.DateReservation.ToString());

            ChambreReservee(UC_Hotel.dateReservation.Date);

        }
    }
}
