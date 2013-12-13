<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="SPApplication.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/SPStylesheet.css" rel="stylesheet" />
    <title>Applicant Information</title>
</head>
<body>
    
    <h1>Employment Application</h1>
    <form id="form" runat="server">
    <h2>Personal Information</h2>
    <div id="Contact">
        <label>First Name: </label>
        <asp:TextBox ID="firstNameTextBox" runat="server" Width="158px"></asp:TextBox>
        <label>Last Name: </label>
        <asp:TextBox ID="lastNameTextBox" runat="server" Width="193px"></asp:TextBox>

        <p>
            <label>Street Address: </label>
            <asp:TextBox ID="streetAddressTextBox" runat="server" Width="415px"></asp:TextBox>
        </p>
        <p>
            <label>City: </label>
            <asp:TextBox ID="CityTextBox" runat="server"></asp:TextBox>
            <label> State: </label>
            <asp:TextBox ID="StateTextBox" runat="server"></asp:TextBox>
            <label>ZIP Code: </label>
            <asp:TextBox ID="ZIPTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <label>Phone Number: </label>
            <asp:TextBox ID="telTextBox" runat="server" TextMode="Phone"></asp:TextBox>
            <label>Email: </label>
            <asp:TextBox ID="emailTextBox" runat="server" TextMode="Email" Width="242px"></asp:TextBox>
        </p>
    </div>
    <h2>Past Employment</h2>
        <div id="Employer1">
            <label>Company Name: </label>
            <asp:TextBox ID="CNameTextBox" runat="server" Width="405px"></asp:TextBox>
            <p>
            <label>Street Address: 
            <asp:TextBox ID="CAddressTextBox" runat="server" style="margin-left: 10px" Width="401px"></asp:TextBox>
                </label>
        </p>
        <p>
            <label>City: </label>
            <asp:TextBox ID="CCityTextBox" runat="server"></asp:TextBox>
            <label> State: </label>
            <asp:TextBox ID="CStateTextBox" runat="server"></asp:TextBox>
            <label>ZIP Code: </label>
            <asp:TextBox ID="CZIPTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <label>Supervisor Name: </label>
            <asp:TextBox ID="SupNameTextBox" runat="server"></asp:TextBox>
            <label>Supervisor Phone Number: </label>
            <asp:TextBox ID="SupPhoneTextBox" runat="server"></asp:TextBox>
            <label>Supervisor Email: </label>
            <asp:TextBox ID="SupEmailTextBox" runat="server" Width="343px"></asp:TextBox>
            </p>
            <p>
                <label>Ok to contact?</label>
                <asp:CheckBox ID="OkToContactCheckBox" runat="server" />
                
            </p>
        </div>
    <br /><br /><br />
        <div id="Employer2">
            <label>Company Name: </label>
            <asp:TextBox ID="CName2TextBox" runat="server" Width="407px"></asp:TextBox>
            <p>
            <label>Street Address: </label>
            <asp:TextBox ID="CAddress2TextBox" runat="server" Width="414px"></asp:TextBox>
        </p>
        <p>
            <label>City: </label>
            <asp:TextBox ID="CCity2TextBox" runat="server"></asp:TextBox>
            <label> State: </label>
            <asp:TextBox ID="CState2TextBox" runat="server"></asp:TextBox>
            <label>ZIP Code: </label>
            <asp:TextBox ID="CZIP2TextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <label>Supervisor Name: </label>
            <asp:TextBox ID="SupName2TextBox" runat="server"></asp:TextBox>
            <label>Supervisor Phone Number: </label>
            <asp:TextBox ID="SupPhone2TextBox" runat="server"></asp:TextBox>
            <label>Supervisor Email: </label>
            <asp:TextBox ID="SupEmail2TextBox" runat="server" Width="348px"></asp:TextBox>
            </p>
            <p>
                <label>Ok to contact?</label>
                <asp:CheckBox ID="OkToContact2CheckBox" runat="server" />
                
            </p>
        </div>
    <br /><br /><br />
        <div id="Employer">
            <label>Company Name: </label>
            <asp:TextBox ID="CName3TextBox" runat="server" Width="403px"></asp:TextBox>
            <p>
            <label>Street Address: </label>
            <asp:TextBox ID="CAddress3TextBox" runat="server" Width="413px"></asp:TextBox>
        </p>
        <p>
            <label>City: </label>
            <asp:TextBox ID="CCity3TextBox" runat="server"></asp:TextBox>
            <label> State: </label>
            <asp:TextBox ID="CState3TextBox" runat="server"></asp:TextBox>
            <label>ZIP Code: </label>
            <asp:TextBox ID="CZIP3TextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <label>Supervisor Name: </label>
            <asp:TextBox ID="SupName3TextBox" runat="server"></asp:TextBox>
            <label>Supervisor Phone Number: </label>
            <asp:TextBox ID="SupPhone3TextBox" runat="server"></asp:TextBox>
            <label>Supervisor Email: </label>
            <asp:TextBox ID="SupEmail3TextBox" runat="server" Width="344px"></asp:TextBox>
            </p>
            <p>
                <label>Ok to contact?</label>
                <asp:CheckBox ID="OkToContact3CheckBox" runat="server" />
                
            </p>
        </div>
    <hr />
   <h2>Education</h2>
    <div id="Education">
            <label>High School Name: </label>
            <asp:TextBox ID="HSNameTextBox" runat="server" Width="275px"></asp:TextBox>
            <label>City: </label>
            <asp:TextBox ID="HSCityTextBox" runat="server"></asp:TextBox>
            <label>State:</label>
            <asp:TextBox ID="HSStateTextBox" runat="server"></asp:TextBox>
            <p>
                <label>Graduation Year: </label>
                <asp:TextBox ID="HSGradYearTextBox" runat="server"></asp:TextBox>
            <label>GPA: </label>
                <asp:TextBox ID="HSGPATextBox" runat="server"></asp:TextBox>
            
                <label>Did you graduate?</label>
                <asp:CheckBox ID="HSGradCheckBox" runat="server" />
            </p>
        <p>
        </p>
            <hr />
            <p>
            <label>Undergraduate Institution Name:</label>
                    <asp:TextBox ID="CollegeNameTextBox" runat="server" Width="376px"></asp:TextBox>
            </p>
            <p>
            <label>City: </label>
                    <asp:TextBox ID="CollegeCityTextBox" runat="server"></asp:TextBox>
            <label> State:</label>
                    <asp:TextBox ID="CollegeStateTextBox" runat="server"></asp:TextBox>
       
            <label>Major:</label>
                    <asp:TextBox ID="MajorTextBox" runat="server" Width="219px"></asp:TextBox>
            </p>
        <label>GPA: </label>
                    <asp:TextBox ID="CollegeGPATextBox" runat="server" Width="61px"></asp:TextBox>
        <label>Did you graduate?</label>
                    <asp:CheckBox ID="CollegeGradCheckBox" runat="server" />   
         <label>Graduation Year: </label>
                    <asp:TextBox ID="CollegeGradYearTextBox" runat="server" Width="53px"></asp:TextBox>
            
            
            

    </div>
    
    <h2>References</h2>
    <div id="References">
            <label>Name: </label>
            <asp:TextBox ID="RName1TextBox" runat="server" Width="207px"></asp:TextBox>
            <label>Relationship: </label>
            <asp:TextBox ID="Relationship1TextBox" runat="server"></asp:TextBox>
            <label>Phone Number: </label>
            <asp:TextBox ID="RPhone1TextBox" runat="server"></asp:TextBox>
            <label>Email: </label>
            <asp:TextBox ID="REmail1TextBox" runat="server"></asp:TextBox>
            <p>
                <label>Name: </label>
            <asp:TextBox ID="RName2TextBox" runat="server" Width="205px"></asp:TextBox>
            <label>Relationship: </label>
            <asp:TextBox ID="Relationship2TextBox" runat="server"></asp:TextBox>
            <label>Phone Number: </label>
            <asp:TextBox ID="RPhone2TextBox" runat="server"></asp:TextBox>
            <label>Email: </label>
            <asp:TextBox ID="REmail2TextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <label>Name: </label>
            <asp:TextBox ID="RName3TextBox" runat="server" Width="202px"></asp:TextBox>
            <label>Relationship: </label>
            <asp:TextBox ID="Relationship3TextBox" runat="server"></asp:TextBox>
            <label>Phone Number: </label>
            <asp:TextBox ID="RPhone3TextBox" runat="server"></asp:TextBox>
            <label>Email: </label>
            <asp:TextBox ID="REmail3TextBox" runat="server"></asp:TextBox>
            </p>
    </div>
    
   
    

    
        <p>
            <asp:Button ID="SubmitButton" runat="server" OnClick="SubmitButton_Click1" Text="Submit Application" />
        </p>
    </form>
    </body>
</html>
