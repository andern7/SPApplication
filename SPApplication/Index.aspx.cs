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
                string sqlquery = "exec sp-insert @first_Name, @last_Name, @_address, @_city, @_state, @_tel, @_email, @college_Name, @college_City, @_major, @c_GPA, @c_Graduate, @hs_Name, @hs_City, @hs_State, @hs_GradYear, @hs_Graduate, @c_Name, @c_Address, @c_City, @c_State, @c_ZIP, @supervisor_Name, @supervisor_Phone, @supervisor_Email, @_okToContact, @r_Name, @r_Phone, @r_Email, @_relationship";

                SqlCommand command = new SqlCommand(sqlquery, conn);



                //open the connection to the database.
                conn.Open();
                
                //First Name
                string FirstName = firstNameTextBox.Text;
                command.Parameters.AddWithValue("@first_Name", FirstName);
                //Last Name
                string LastName = lastNameTextBox.Text;
                command.Parameters.AddWithValue("@last_Name", LastName);
                //Address
                string StreetAddress = streetAddressTextBox.Text;
                command.Parameters.AddWithValue("@street_Address", StreetAddress);
                //City
                string City = CityTextBox.Text;
                command.Parameters.AddWithValue("@_city", City);
                //ZIP
                string zip = ZIPTextBox.Text;
                command.Parameters.AddWithValue("@_zip", zip);
                //Phone Number
                string PhoneNumber = telTextBox.Text;
                command.Parameters.AddWithValue("@_phone", PhoneNumber);
                //Email
                string Email = emailTextBox.Text;
                command.Parameters.AddWithValue("@_email", Email);


                //*************************************************************************************************
                //Add information to the College table
                //College Name
                string CollegeName = CollegeNameTextBox.Text;
                command.Parameters.AddWithValue("@college_Name", CollegeName);
                //College City
                string CollegeCity = CollegeCityTextBox.Text;
                command.Parameters.AddWithValue("@college_City", CollegeCity);
                //College State
                string CollegeState = CollegeStateTextBox.Text;
                command.Parameters.AddWithValue("@college_State", CollegeState);
                //College Grad Year
                string CollegeGradYear = CollegeGradYearTextBox.Text;
                command.Parameters.AddWithValue("@college_GradYear", CollegeGradYear);
                //College Graduate    
                string Graduate;
                if (CollegeGradCheckBox.Checked)
                {
                    Graduate = "Yes";
                }
                else
                {
                    Graduate = "No";
                }
                command.Parameters.AddWithValue("@c_Graduate", Graduate);

                //******************************************************************************************************
                //Insert information into the HS table. 
                //High School Name
                string HSName = HSNameTextBox.Text;
                command.Parameters.AddWithValue("@hs_Name", HSName);
                //High School City
                string HSCity = HSCityTextBox.Text;
                command.Parameters.AddWithValue("@hs_City", HSCity);
                //High School State
                string HSState = HSStateTextBox.Text;
                command.Parameters.AddWithValue("@hs_State", HSState);
                //High School Graduation Year
                string HSGradYear = HSGradYearTextBox.Text;
                command.Parameters.AddWithValue("@hs_GradYear", HSGradYear);
                //High School Graduate? 
                string HSGraduate;
                if (HSGradCheckBox.Checked)
                {
                    HSGraduate = "Yes";
                }
                else
                {
                    HSGraduate = "No";
                }
                command.Parameters.AddWithValue("@hs_Graduate", HSGraduate);

                //***************************************************************************************
                //Insert information into the Employers table
                //Employer 1 Name
                string CName1 = CNameTextBox.Text;
                command.Parameters.AddWithValue("@_Company", CName1);
                //Employer 1 Address
                string CAddress1 = CAddressTextBox.Text;
                command.Parameters.AddWithValue("@c_Address", CAddress1);
                //Employer 1 City
                string CCity1 = CCityTextBox.Text;
                command.Parameters.AddWithValue("@c_City", CCity1);
                //Employer 1 State
                string CState1 = CStateTextBox.Text;
                command.Parameters.AddWithValue("@c_State", CState1);
                //Employer 1 ZIP
                string CZIP1 = CZIPTextBox.Text;
                command.Parameters.AddWithValue("@c_ZIP", CZIP1);
                //Employer 1 Supervisor Name
                string SupervisorName = SupNameTextBox.Text;
                command.Parameters.AddWithValue("@supervisor_Name", SupervisorName);
                //Employer 1 Supervisor Phone Number
                string SupervisorPhone = SupPhoneTextBox.Text;
                command.Parameters.AddWithValue("@supervisor_Phone", SupervisorPhone);
                //Employer 1 Supervisor Email Address
                string SupervisorEmail = SupEmailTextBox.Text;
                command.Parameters.AddWithValue("@supervisor_Email", SupervisorEmail);
                //Ok to Contact?
                string OkToContact1;
                if (OkToContactCheckBox.Checked)
                {
                    OkToContact1 = "Yes";
                }
                else
                {
                    OkToContact1 = "No";
                }
                command.Parameters.AddWithValue("@_okToContact", OkToContact1);
                //**************************************************************************************************
                //Employer 2 Name
                string CName2 = CName2TextBox.Text;
                command.Parameters.AddWithValue("@_Company", CName2);
                //Employer 2 Address
                string CAddress2 = CAddress2TextBox.Text;
                command.Parameters.AddWithValue("@c_Address", CAddress2);
                //Employer 2 City
                string CCity2 = CCity2TextBox.Text;
                command.Parameters.AddWithValue("@c_City", CCity2);
                //Employer 2 State
                string CState2 = CState2TextBox.Text;
                command.Parameters.AddWithValue("@c_State", CState2);
                //Employer 2 ZIP
                string CZIP2 = CZIP2TextBox.Text;
                command.Parameters.AddWithValue("@c_ZIP", CZIP2);
                //Employer 2 Supervisor Name
                string SupervisorName2 = SupName2TextBox.Text;
                command.Parameters.AddWithValue("@supervisor_Name", SupervisorName2);
                //Employer 2 Supervisor Phone Number
                string SupervisorPhone2 = SupPhone2TextBox.Text;
                command.Parameters.AddWithValue("@supervisor_Phone", SupervisorPhone2);
                //Employer 2 Supervisor Email Address
                string SupervisorEmail2 = SupEmail2TextBox.Text;
                command.Parameters.AddWithValue("@supervisor_Email", SupervisorEmail2);
                //Ok to Contact?
                string OkToContact2;
                if (OkToContact2CheckBox.Checked)
                {
                    OkToContact2 = "Yes";
                }
                else
                {
                    OkToContact2 = "No";
                }
                command.Parameters.AddWithValue("@_okToContact", OkToContact2);

                //********************************************************************************************
                //Employer 3 Name
                string CName3 = CName3TextBox.Text;
                command.Parameters.AddWithValue("@_Company", CName3);
                //Employer 3 Address
                string CAddress3 = CAddress3TextBox.Text;
                command.Parameters.AddWithValue("@c_Address", CAddress3);
                //Employer 3 City
                string CCity3 = CCity3TextBox.Text;
                command.Parameters.AddWithValue("@c_City", CCity3);
                //Employer 3 State
                string CState3 = CState3TextBox.Text;
                command.Parameters.AddWithValue("@c_State", CState3);
                //Employer 3 ZIP
                string CZIP3 = CZIP3TextBox.Text;
                command.Parameters.AddWithValue("@c_ZIP", CZIP3);
                //Employer 3 Supervisor Name
                string SupervisorName3 = SupName3TextBox.Text;
                command.Parameters.AddWithValue("@supervisor_Name", SupervisorName3);
                //Employer 3 Supervisor Phone Number
                string SupervisorPhone3 = SupPhone3TextBox.Text;
                command.Parameters.AddWithValue("@supervisor_Phone", SupervisorPhone3);
                //Employer 3 Supervisor Email Address
                string SupervisorEmail3 = SupEmail3TextBox.Text;
                command.Parameters.AddWithValue("@supervisor_Email", SupervisorEmail3);
                //Ok to contact? 
                string OkToContact3;
                if (OkToContact3CheckBox.Checked)
                {
                    OkToContact3 = "Yes";
                }
                else
                {
                    OkToContact3 = "No";
                }
                command.Parameters.AddWithValue("@_okToContact", OkToContact3);

                //*****************************************************************************************************
                //Insert information into the References database
                //Reference 1 Name
                string RName1 = RName1TextBox.Text;
                command.Parameters.AddWithValue("@r_Name", RName1);
                //Reference 1 Phone
                string RPhone1 = RPhone1TextBox.Text;
                command.Parameters.AddWithValue("@r_Phone", RPhone1);
                //Reference 1 Email
                string REmail1 = REmail1TextBox.Text;
                command.Parameters.AddWithValue("@r_Email", REmail1);
                //Reference 1 Relationship
                string Relationship1 = Relationship1TextBox.Text;
                command.Parameters.AddWithValue("@_relationship", Relationship1);
                //
                //
                //
                //Reference 2 Name
                string RName2 = RName2TextBox.Text;
                command.Parameters.AddWithValue("@r_Name", RName2);
                //Reference 2 Phone
                string RPhone2 = RPhone2TextBox.Text;
                command.Parameters.AddWithValue("@r_Phone", RPhone2);
                //Reference 2 Phone Number
                string REmail2 = REmail2TextBox.Text;
                command.Parameters.AddWithValue("@r_Email", REmail2);
                //Reference 2 Email
                string Relationship2 = Relationship2TextBox.Text;
                command.Parameters.AddWithValue("@_relationship", Relationship2);
                //Reference 2 Relationship
                //
                //Reference 2 Name
                string RName3 = RName3TextBox.Text;
                command.Parameters.AddWithValue("@r_Name", RName3);
                //Reference 2 Phone
                string RPhone3 = RPhone3TextBox.Text;
                command.Parameters.AddWithValue("@r_Phone", RPhone3);
                //Reference 3 Email
                string REmail3 = REmail3TextBox.Text;
                command.Parameters.AddWithValue("@r_Email", REmail3);
                //Reference 3 Relationship
                string Relationship3 = Relationship3TextBox.Text;
                command.Parameters.AddWithValue("@_relationship", Relationship3);




                //Execute the command.
                command.ExecuteNonQuery();
                //Close the connection.
                
                conn.Close();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Read from database. 

        }
    }
}

    


