﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_ECA
{
    public partial class Ventana7 : Form
    {
        Grafo g;
        Principal p;
        public Ventana7(Principal p)
        {
            this.p = p;
            g = p.g;
            InitializeComponent();
            LlenarTabla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            p.Show();
        }

        private void LlenarTabla()
        {
            Dictionary<string, string> pares = g.PareoNormal();

            foreach (String aux in pares.Keys)
            {
                pareo.Rows.Add(aux, pares[aux]);
            }
        }

        private void Ventana7_FormClosing(object sender, FormClosingEventArgs e)
        {
            p.Show();
        }
    }
}
