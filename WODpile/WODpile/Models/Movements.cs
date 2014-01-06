using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WODpile.Models
{
    public class Movements : CustomClasses
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool MeasuredByReps { get; set; }
        public bool MeasuredByWeight { get; set; }
        public bool MeasuredByCalories { get; set; }
        public bool MeasuredByVerticle { get; set; }
        public bool MeasuredByHorizontal { get; set; }
        public int AddedByUserID { get; set; }
        public string AddedDate { get; set; }
        public int ReviewedByAdminID { get; set; }
        public string ReviewedDate { get; set; }
        public bool Approved { get; set; }
        public int ApprovedByAdminID { get; set; }
        public string ApprovedDate { get; set; }

        public ErrorCheck errorCheck = new ErrorCheck();

        //Empty constructor to call this class with empty values.
        public Movements() { }

        //Overide constructor to call this class with values for a specific movement ID.
        public Movements(int MovementID) 
        {
            SqlConnection sqlConnection = new SqlConnection(SqlConnWODPile);
            SqlCommand sqlCommand = new SqlCommand("SelectMovementByID", sqlConnection);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@ID", MovementID);

            try 
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);

                if (sqlDataReader.HasRows)
                {
                    errorCheck.IsError = false;
                    errorCheck.Message = "";
                    while (sqlDataReader.Read()) 
                    {
                        ID = (int)sqlDataReader["ID"];
                        Title = (string)sqlDataReader["Title"];
                        Description = (string)sqlDataReader["Description"];
                        MeasuredByReps = (bool)sqlDataReader["MeasuredByReps"];
                        MeasuredByWeight = (bool)sqlDataReader["MeasuredByWeight"];
                        MeasuredByCalories = (bool)sqlDataReader["MeasuredByCalories"];
                        MeasuredByVerticle = (bool)sqlDataReader["MeasuredByVerticle"];
                        MeasuredByHorizontal = (bool)sqlDataReader["MeasuredByHorizontal"];
                        AddedByUserID = (int)sqlDataReader["AddedByUserID"];
                        AddedDate = ((DateTime)sqlDataReader["AddedDate"]).ToShortDateString();
                        ReviewedByAdminID = (int)sqlDataReader["ReviewedByAdminID"];
                        ReviewedDate = ((DateTime)sqlDataReader["ReviewedDate"]).ToShortDateString();
                        Approved = (bool)sqlDataReader["Approved"];
                        ApprovedByAdminID = (int)sqlDataReader["ApprovedByAdminID"];
                        ApprovedDate = ((DateTime)sqlDataReader["ApprovedDate"]).ToShortDateString();
                    }
                }
                else 
                {
                    errorCheck.IsError = true;
                    errorCheck.Message = "";
                }
            }
            catch (Exception ex)
            {
                errorCheck.IsError = true;
                errorCheck.Message = "Error: " + ex.Message;
            }
            finally 
            {
                sqlConnection.Close();
            }
        }
    }
}