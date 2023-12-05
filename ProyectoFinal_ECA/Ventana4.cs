﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoFinal_ECA
{
    public partial class Ventana4 : Form
    {
        Grafo g;
        Principal p;
        public Ventana4(Principal p)
        {
            InitializeComponent();
            this.p = p;
            g = p.g;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            p.Show();
        }

        private void Ventana4_FormClosing(object sender, FormClosingEventArgs e)
        {
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            if (nodo.Text != String.Empty)
            {
                if (g.listaAdyacencia.ContainsKey(nodo.Text))
                {
                    foreach (String aux in g.BusquedaProfundidad(nodo.Text))
                    {
                        textBox1.Text += (textBox1.Text == String.Empty) ? aux : "-" + aux;
                    }
                }
                else
                {
                    MessageBox.Show("Nodo no encontrado.", "Búsqueda en Anchura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingresa un nodo.", "Búsqueda en Anchura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
