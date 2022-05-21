﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Ejercicio1
{
    public partial class Form1 : Form
    {
        private int rowIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            //n = indice del registro
            int n = dataGridViewUsers.Rows.Add();

            //agregar nombre, apellido y edad al gridView
            dataGridViewUsers.Rows[n].Cells[0].Value = textName.Text;
            dataGridViewUsers.Rows[n].Cells[1].Value = textLastName.Text;
            dataGridViewUsers.Rows[n].Cells[2].Value = textAge.Text;

            textName.Text = "";
            textLastName.Text = "";
            textAge.Text = "";
            //este comentario
    
        }

        private void delete_Click(object sender, EventArgs e)
        {
            dataGridViewUsers.Rows.RemoveAt(rowIndex);

        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
