using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeCourseworkHostel
{
    public partial class JournalClient : DevExpress.XtraEditors.XtraForm
    {
        public JournalClient()
        {
            InitializeComponent();
        }

        private void btnClientEdit_Click(object sender, EventArgs e)
        {
            // Cоздаем экземпляр класса Reservation.
            ClientEdit clientedit = new ClientEdit();

            // Показывает окно.
            clientedit.Show();
        }

        private void btnClientAdd_Click(object sender, EventArgs e)
        {
            // Cоздаем экземпляр класса Reservation.
            ClientEdit clientadd = new ClientEdit();

            // Показывает окно.
            clientadd.Show();
        }
    }
}
