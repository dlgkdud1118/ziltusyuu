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

namespace _2024._06._11._01
{
    public partial class Form2 : Form
    {
        private SqlConnection cn = new SqlConnection();
        private SqlCommand cmd = new SqlCommand();
        private SqlDataReader rd;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.ConnectionString =
                 @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                 @"AttachDbFilename=|DataDirectory|\Database1.mdf;" +
                 "Integrated Security=True;Connect Timeout=30";
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO [dbo].[Table] VALUES(" +
                              "'" + textBox1.Text + "'," +
                              "N'" + textBox2.Text + "'," +
                              "N'" + textBox3.Text + "'," +
                              "N'" + textBox4.Text + "'," +
                              "'" + textBox5.Text + "')";
            rd = cmd.ExecuteReader();
            rd.Close();
            cn.Close();
            this.Close();
        }
    }
}