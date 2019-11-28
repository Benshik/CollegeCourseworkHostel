﻿using System;
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
    public partial class ClientEdit : DevExpress.XtraEditors.XtraForm
    {

        public ClientEdit(bool isNewClient)
        {
            InitializeComponent();
            PaintName(isNewClient);
        }

        private void PaintName (bool isNewClient)
        {
            if (isNewClient)
            {
                this.Text = "Добавление клиента";
            }
            else
            {
                this.Text = "Редактирование клиента";
            }
        }

        private void btnClientEditOk_Click(object sender, EventArgs e)
        {
            string secondName = textEditSecondName.Text;
            string firstName = textEditFirstName.Text;
            string middleName = textEditMiddleName.Text;
            var birthday = dateEditBirthday.Text;
            //var gender = lookUpEditGender.Text;

        }
    }
}
