using CollegeCourseworkHostel.Service;
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
    public partial class Evenue : DevExpress.XtraEditors.XtraForm
    {
        public Evenue()
        {
            InitializeComponent();
        }

        private void btnCalcMoney_Click(object sender, EventArgs e)
        {
            try
            {
                CheckCorrectDateInput();
                DateTime with = Convert.ToDateTime(dateEditwith.Text);
                DateTime until = Convert.ToDateTime(dateEditUntil.Text);
                SQLAdapter sqdapter = new SQLAdapter();

                int countNum = 0;

                while (with.Date != until.Date)
                {
                    var query = string.Format($"select count(*) as count from VGuestBedsAccounting where \"{with.Date}\" BETWEEN  \"Дата заезда\"  and  \"Дата отъезда\"");
                    var row = sqdapter.SelectActiveRow(query);
                    countNum += int.Parse(row["count"].ToString());
                    with = with.AddDays(1);
                }
                MessageBox.Show(
                    $"Выручка хоcтела с период {dateEditwith.Text} по {dateEditUntil.Text} " +
                    $"составила {countNum * 500} рублей!",
                    "Внимание, конфиденциальная информация!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла внутрення ошибка при рассчете выручки !  {ex.Message}!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckCorrectDateInput()
        {
            DateTime with = Convert.ToDateTime(dateEditwith.Text);
            DateTime until = Convert.ToDateTime(dateEditUntil.Text);
            if (until > with)
            {
                //tbCost.Text = ((departure.Day - arrival.Day) * 500).ToString();
            }
            else
            {
                MessageBox.Show("Дата начала отсчета  не может быть больше даты завершения!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateEditUntil.EditValue = Convert.ToDateTime(dateEditwith.Text).Date.AddDays(1);
            }
        }

        private void dateEditUntil_EditValueChanged(object sender, EventArgs e)
        {
            CheckCorrectDateInput();
        }
    }
}
