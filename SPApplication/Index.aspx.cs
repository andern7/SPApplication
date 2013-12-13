using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace SPApplication
{
    public partial class Index : System.Web.UI.Page
    {

        protected void SubmitButton_Click1(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conn2"].ConnectionString;

                int ApplicantId = 0;
                //Applicant Table Insert
                //
                string applicant_insert = "INSERT INTO [ApplicantDatabase].[dbo].[Applicant] (firstName,lastName,streetAddress,city,state,zip,phone,email)";
                applicant_insert += "VALUES (@firstName,@lastName,@streetAddress,@city,@state,@zip,@phone,@email);";
               
                //Employer Table Insert
                //
                string employer_insert = "INSERT INTO [ApplicantDatabase].[dbo].[Company] (Company, CAddress, CCity, CState, CZIP, SupervisorName, SupervisorPhone, SupervisorEmail, OkToContact, ApplicantId)";
                employer_insert += "VALUES(@Company, @CAddress, @CCity, @CState, @CZIP, @SupervisorName, @SupervisorPhone, @SupervisorEmail, @OkToContact, @ApplicantId)";
               
                //High School Table Insert
                //
                string education_insert = "INSERT INTO [ApplicantDatabase].[dbo].[HS] (HSName, HSCity, HSState, HSGradYear, HSGPA, HSGraduate, ApplicantId)";
                education_insert += "VALUES(@HSName, @HSCity, @HSState, @HSGradYear, @HSGPA, @HSGraduate, @ApplicantId)";
               
                //College Table Insert
                //
                string college_insert = "INSERT INTO [ApplicantDatabase].[dbo].[College] (CollegeName, CollegeCity, CollegeState, Major, CGPA, CGraduate, CollegeGradYear, ApplicantId)";
                college_insert += "VALUES(@CollegeName, @CollegeCity, @CollegeState, @Major, @CGPA, @CGraduate, @CollegeGradYear,  @ApplicantId)";
                
                //Reference Table Insert
                string reference_insert = "INSERT INTO [ApplicantDatabase].[dbo].[References] (RName, RPhone, REmail, Relationship, ApplicantId)";
                reference_insert += "VALUES(@RName, @RPhone, @REmail, @Relationship, @ApplicantId)";










                conn.Open();
                try
                {
                    SqlCommand cmdIns = new SqlCommand(applicant_insert, conn);

                    cmdIns.Parameters.AddWithValue("@firstName", firstNameTextBox.Text);
                    cmdIns.Parameters.AddWithValue("@lastName", lastNameTextBox.Text);
                    cmdIns.Parameters.AddWithValue("@streetAddress", streetAddressTextBox.Text);
                    cmdIns.Parameters.AddWithValue("@city", CityTextBox.Text);
                    cmdIns.Parameters.AddWithValue("@state", "WI");
                    cmdIns.Parameters.AddWithValue("@zip", ZIPTextBox.Text);
                    cmdIns.Parameters.AddWithValue("@phone", telTextBox.Text);
                    cmdIns.Parameters.AddWithValue("@email", emailTextBox.Text);

                    cmdIns.ExecuteNonQuery();
                    cmdIns.Parameters.Clear();

                    cmdIns.CommandText = "SELECT @@IDENTITY";

                    // Get the last inserted id.
                    ApplicantId = Convert.ToInt32(cmdIns.ExecuteScalar());

                    //
                    //Insert into the Employers Table
                    //Employer 1
                    SqlCommand cmdIns1 = new SqlCommand(employer_insert, conn);
                    cmdIns1.Parameters.AddWithValue("@Company", CNameTextBox.Text);
                    cmdIns1.Parameters.AddWithValue("@CAddress", CAddressTextBox.Text);
                    cmdIns1.Parameters.AddWithValue("@CCity", CCityTextBox.Text);
                    cmdIns1.Parameters.AddWithValue("@CState", CStateTextBox.Text);
                    cmdIns1.Parameters.AddWithValue("@CZIP", CZIPTextBox.Text);
                    cmdIns1.Parameters.AddWithValue("@SupervisorName", SupNameTextBox.Text);
                    cmdIns1.Parameters.AddWithValue("@SupervisorPhone", SupPhoneTextBox.Text);
                    cmdIns1.Parameters.AddWithValue("@SupervisorEmail", SupEmailTextBox.Text);
                    cmdIns1.Parameters.AddWithValue("@OkToContact", OkToContactCheckBox.Checked);
                    cmdIns1.Parameters.AddWithValue("@ApplicantId", ApplicantId);
           
                    cmdIns1.ExecuteNonQuery();
                    cmdIns1.Parameters.Clear();
                    //Employer 2
                    //add ApplicantId to all tables to serve as foreign key
                    SqlCommand cmdIns2 = new SqlCommand(employer_insert, conn);
                    cmdIns2.Parameters.AddWithValue("@Company", CName2TextBox.Text);
                    cmdIns2.Parameters.AddWithValue("@CAddress", CAddress2TextBox.Text);
                    cmdIns2.Parameters.AddWithValue("@CCity", CCity2TextBox.Text);
                    cmdIns2.Parameters.AddWithValue("@CState", CState2TextBox.Text);
                    cmdIns2.Parameters.AddWithValue("@CZIP", CZIP2TextBox.Text);
                    cmdIns2.Parameters.AddWithValue("@SupervisorName", SupName2TextBox.Text);
                    cmdIns2.Parameters.AddWithValue("@SupervisorPhone", SupPhone2TextBox.Text);
                    cmdIns2.Parameters.AddWithValue("@SupervisorEmail", SupEmail2TextBox.Text);
                    cmdIns2.Parameters.AddWithValue("@OkToContact", OkToContact2CheckBox.Checked);
                    cmdIns2.Parameters.AddWithValue("@ApplicantId", ApplicantId);
                    cmdIns2.ExecuteNonQuery();
                    cmdIns2.Parameters.Clear();
                    ////Employer 3
                    SqlCommand cmdIns3 = new SqlCommand(employer_insert, conn);
                    cmdIns3.Parameters.AddWithValue("@Company", CName3TextBox.Text);
                    cmdIns3.Parameters.AddWithValue("@CAddress", CAddress3TextBox.Text);
                    cmdIns3.Parameters.AddWithValue("@CCity", CCity3TextBox.Text);
                    cmdIns3.Parameters.AddWithValue("@CState", CState3TextBox.Text);
                    cmdIns3.Parameters.AddWithValue("@CZIP", CZIP3TextBox.Text);
                    cmdIns3.Parameters.AddWithValue("@SupervisorName", SupName3TextBox.Text);
                    cmdIns3.Parameters.AddWithValue("@SupervisorPhone", SupPhone3TextBox.Text);
                    cmdIns3.Parameters.AddWithValue("@SupervisorEmail", SupEmail3TextBox.Text);
                    cmdIns3.Parameters.AddWithValue("@OkToContact", OkToContact3CheckBox.Checked);
                    cmdIns3.Parameters.AddWithValue("@ApplicantId", ApplicantId);
                    cmdIns3.ExecuteNonQuery();
                    cmdIns3.Parameters.Clear();
                    //
                    //Insert into the High School Table
                    //
                    SqlCommand cmdIns4 = new SqlCommand(education_insert, conn);
                    cmdIns4.Parameters.AddWithValue("@HSName", HSNameTextBox.Text);
                    cmdIns4.Parameters.AddWithValue("@HSCity", HSCityTextBox.Text);
                    cmdIns4.Parameters.AddWithValue("@HSState", HSStateTextBox.Text);
                    cmdIns4.Parameters.AddWithValue("@HSGradYear", HSGradYearTextBox.Text);
                    cmdIns4.Parameters.AddWithValue("@HSGPA", HSGPATextBox.Text);
                    cmdIns4.Parameters.AddWithValue("@HSGraduate", HSGradCheckBox.Checked);
                    cmdIns4.Parameters.AddWithValue("@ApplicantId", ApplicantId);

                    cmdIns4.ExecuteNonQuery();
                    cmdIns4.Parameters.Clear();
                    
                    //
                    //Insert into the College Table
                    //
                    SqlCommand cmdIns5 = new SqlCommand(college_insert, conn);
                    cmdIns5.Parameters.AddWithValue("@CollegeName", CollegeNameTextBox.Text);
                    cmdIns5.Parameters.AddWithValue("@CollegeCity", CollegeCityTextBox.Text);
                    cmdIns5.Parameters.AddWithValue("@CollegeState", CollegeStateTextBox.Text);
                    cmdIns5.Parameters.AddWithValue("@Major", MajorTextBox.Text);
                    cmdIns5.Parameters.AddWithValue("@CGPA", CollegeGPATextBox.Text);
                    cmdIns5.Parameters.AddWithValue("@CGraduate", CollegeGradCheckBox.Checked);
                    cmdIns5.Parameters.AddWithValue("@CollegeGradYear", CollegeGradYearTextBox.Text);
                    cmdIns5.Parameters.AddWithValue("@ApplicantId", ApplicantId);
                    
                    cmdIns5.ExecuteNonQuery();
                    cmdIns5.Parameters.Clear();
                    //
                    //Add to the References Table
                    //
                    SqlCommand cmdIns6 = new SqlCommand(reference_insert, conn);
                    cmdIns6.Parameters.AddWithValue("@RName", RName1TextBox.Text);
                    cmdIns6.Parameters.AddWithValue("@RPhone", RPhone1TextBox.Text);
                    cmdIns6.Parameters.AddWithValue("@REmail", REmail1TextBox.Text);
                    cmdIns6.Parameters.AddWithValue("@Relationship", Relationship1TextBox.Text);
                    cmdIns6.Parameters.AddWithValue("@ApplicantId", ApplicantId);
                    
                    cmdIns6.ExecuteNonQuery();
                    cmdIns6.Parameters.Clear();
                    //
                    SqlCommand cmdIns7 = new SqlCommand(reference_insert, conn);
                    cmdIns7.Parameters.AddWithValue("@RName", RName2TextBox.Text);
                    cmdIns7.Parameters.AddWithValue("@RPhone", RPhone2TextBox.Text);
                    cmdIns7.Parameters.AddWithValue("@REmail", REmail2TextBox.Text);
                    cmdIns7.Parameters.AddWithValue("@Relationship", Relationship2TextBox.Text);
                    cmdIns7.Parameters.AddWithValue("@ApplicantId", ApplicantId);
                    
                    cmdIns7.ExecuteNonQuery();
                    cmdIns7.Parameters.Clear();
                    ////
                    SqlCommand cmdIns8 = new SqlCommand(reference_insert, conn);
                    cmdIns8.Parameters.AddWithValue("@RName", RName3TextBox.Text);
                    cmdIns8.Parameters.AddWithValue("@RPhone", RPhone3TextBox.Text);
                    cmdIns8.Parameters.AddWithValue("@REmail", REmail3TextBox.Text);
                    cmdIns8.Parameters.AddWithValue("@Relationship", Relationship3TextBox.Text);
                    cmdIns8.Parameters.AddWithValue("@ApplicantId", ApplicantId);
                    

                    cmdIns8.ExecuteNonQuery();
                    cmdIns8.Parameters.Clear();
                    
                   //Dispose method to free up memory used by the application.

                    cmdIns.Dispose();
                    cmdIns = null;
                    cmdIns1.Dispose();
                    cmdIns1 = null;
                    cmdIns2.Dispose();
                    cmdIns2 = null;
                    cmdIns3.Dispose();
                    cmdIns3 = null;
                    cmdIns4.Dispose();
                    cmdIns4 = null;
                    cmdIns5.Dispose();
                    cmdIns5 = null;
                    cmdIns6.Dispose();
                    cmdIns6 = null;
                    cmdIns7.Dispose();
                    cmdIns7 = null;
                    cmdIns8.Dispose();
                    cmdIns8 = null; 
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString(), ex);
                }
                finally
                {
                    
                    conn.Close();
                }

                conn.Close();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Application Submission Successful')", true);


                
                
                }
            }
        }
    }


    


