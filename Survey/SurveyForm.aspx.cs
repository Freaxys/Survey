using System;
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
        /// <summary>
        /// Saves answers given by the user to the database using stored procedure.
        /// </summary>
        /// <param name="scale"></param>
        /// <param name="yesOrNo"></param>
        /// <param name="comment"></param>
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
<<<<<<< Updated upstream
=======

        /// <summary>
        /// Retrievs Questions from the Database using table-valued function
        /// and inserts them into the correct labels.
        /// </summary>
        public void GetQuestions()
        {
            var context = new SurveyAppEntities();

            const int OneAboveId = 4;

            var questions = from q in context.GetQuestions(OneAboveId)
                            select new
                            {
                                q
                            };
            List<string> ques = new List<string>();

            foreach (var result in questions)
            {
                ques.Add(result.q);
            }
            FQuestion.Text = ques.ElementAt(0);
            SQuestion.Text = ques.ElementAt(1);
            TQuestion.Text = ques.ElementAt(2);

            context.Dispose();
        }
>>>>>>> Stashed changes
        
        protected override void OnLoad(EventArgs e)
        {
<<<<<<< Updated upstream
            
=======
            GetQuestions();
            base.OnLoad(e);
>>>>>>> Stashed changes
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