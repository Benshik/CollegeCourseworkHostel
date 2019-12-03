﻿using CollegeCourseworkHostel.Сouchette;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CollegeCourseworkHostel
{
    public partial class Hostel : DevExpress.XtraEditors.XtraForm
    {
        public Hostel()
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

        // при нажатие на кнопку "Гостевой учет"
        private void btnReservedPlaces_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            СouchetteJournal сouchetteJournal = new СouchetteJournal();
            сouchetteJournal.MdiParent = this;
            сouchetteJournal.Show();
        }

        // при нажатие на кнопку "Клиенты"
        private void btnClients_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ClientJournal clientJournal = new ClientJournal();
            clientJournal.MdiParent = this;
            clientJournal.Show();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Report report = new Report();
            report.MdiParent = this;
            report.Show();
        }
    }
}
