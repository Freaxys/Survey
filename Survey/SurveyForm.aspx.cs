﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Survey
{
    public partial class SurveyForm : System.Web.UI.Page
    {
        public void Save(string scale, string yesOrNo, string comment) 
        {
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-DEI5CV63\SQLEXPRESS;Initial Catalog=SurveyApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Execute SaveForm @scale, @yesOrNo, @comment";

            cmd.Parameters.Add(@"scale", System.Data.SqlDbType.VarChar, 10).Value = scale;
            cmd.Parameters.Add(@"yesOrNo", System.Data.SqlDbType.VarChar, 10).Value = yesOrNo;
            cmd.Parameters.Add(@"comment", System.Data.SqlDbType.VarChar, 500).Value = comment;

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string scaleValue = radioScale.SelectedItem.Text;
            string booleanValue = radioBool.SelectedItem.Text;
            string commentValue = txtOpen.Text;

            Save(scaleValue, booleanValue, commentValue);
        }
    }
}