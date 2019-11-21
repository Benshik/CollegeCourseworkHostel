using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CollegeCourseworkHostel
{
    public partial class Reservation : DevExpress.XtraEditors.XtraForm
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            {
                // Cоздаем экземпляр класса Reservation.
                ClientEdit newclientadd = new ClientEdit();

                // Показывает окно.
                newclientadd.Show();
            }
        }
    }
}