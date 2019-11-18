using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class fHostel : DevExpress.XtraEditors.XtraForm
    {
        public fHostel()
        {
            InitializeComponent();
        }

        private void btnBronirovanie_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Cоздаем экземпляр класса Reservation.
            Reservation reservation = new Reservation(); 

            // Задаем мултидокументную систему.
            reservation.MdiParent = this;

            // Показывает окно.
            reservation.Show();
        }
    }
}
