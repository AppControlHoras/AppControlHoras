﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppControlHoras.Clientes
{
    public partial class EliminarCliente : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source = BATTISTA\\DAVIDSERVER; Initial Catalog = BBDD_HORAS; Integrated Security = True");

        public EliminarCliente()
        {
            InitializeComponent();
        }

        private void EliminarCliente_Load(object sender, EventArgs e)
        {
            connection.Open();
            string query = "select idCliente, descripcion from Clientes ";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbClientes.Items.Add(reader["descripcion"].ToString());
            }
            connection.Close();
        }

        
        private void btEliminar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string descripcion = cbClientes.Text;
            string query = "delete from Clientes where descripcion='" + descripcion + "'";
            try
            {
                if (string.IsNullOrEmpty(descripcion))
                {
                    MessageBox.Show("Selecciona un id", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Eliminado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Source);
            }
            
            connection.Close();
        }
    }
}
