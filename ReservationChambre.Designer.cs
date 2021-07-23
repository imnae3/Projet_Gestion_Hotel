
namespace GestionReservationHotel
{
    partial class ReservationChambre
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.uC_Hotel1 = new GestionReservationHotel.ControlUtilisateur.UC_Hotel();
            this.SuspendLayout();
            // 
            // uC_Hotel1
            // 
            this.uC_Hotel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_Hotel1.Location = new System.Drawing.Point(-5, 0);
            this.uC_Hotel1.Margin = new System.Windows.Forms.Padding(1);
            this.uC_Hotel1.Name = "uC_Hotel1";
            this.uC_Hotel1.Size = new System.Drawing.Size(716, 457);
            this.uC_Hotel1.TabIndex = 0;
            this.uC_Hotel1.Load += new System.EventHandler(this.uC_Hotel1_Load);
            // 
            // ReservationChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 458);
            this.Controls.Add(this.uC_Hotel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReservationChambre";
            this.Text = "Reservation Hotel";
            this.Load += new System.EventHandler(this.ReservationChambre_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlUtilisateur.UC_Hotel uC_Hotel1;
    }
}

