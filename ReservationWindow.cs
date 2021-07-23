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
    public partial class ReservationWindow : Form
    {
        DataClasseDataContext dc = new DataClasseDataContext();
        public int NumChambre { get; set; }

        public ReservationWindow()
        {
            InitializeComponent();
        }

        private void ReservationWindow_Load(object sender, EventArgs e)
        {
            this.textBoxDateReservation.Text = UC_Hotel.dateReservation.Date.ToString();
            this.textBoxDateReservation.ReadOnly = true;

            this.textBoxNumChambre.Text = this.NumChambre.ToString();
            this.textBoxNumChambre.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            Reservation r = new Reservation();
            r.DateReservation = UC_Hotel.dateReservation.Date;
            r.numChambre = NumChambre;
            r.NomClient = textBoxNom.Text;
            r.PrenomClient = textBoxPrenom.Text;
            r.CINClient = textBoxCIN.Text;
            dc.Reservations.InsertOnSubmit(r);
            dc.SubmitChanges();
            MessageBox.Show("Chambre " + this.NumChambre.ToString() + " est reservée le " + r.DateReservation.ToString());
            this.Close();
        }
    }
}
