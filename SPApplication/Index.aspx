<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="SPApplication.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/SPStylesheet.css" rel="stylesheet" />
    <title>Applicant Information</title>
</head>
<body>
    <h1>Employment Application</h1>
    <h2>Personal Information</h2>
    <form id="form" runat="server">
    <div id="Contact">
        <label>First Name: </label>
        <asp:TextBox ID="firstName" runat="server"></asp:TextBox>
        <label>Last Name: </label>
        <asp:TextBox ID="lastName" runat="server"></asp:TextBox>
&nbsp;<p>
            <label>Street Address: </label>
            <asp:TextBox ID="Address" runat="server"></asp:TextBox>
        </p>
        <p>
            <label>City: </label>
            <asp:TextBox ID="City" runat="server"></asp:TextBox>
            <label> State: </label>
            <asp:TextBox ID="State" runat="server"></asp:TextBox>
            <label>ZIP Code: </label>
            <asp:TextBox ID="ZIP" runat="server"></asp:TextBox>
        </p>
        <p>
            <label>Phone Number: </label>
            <asp:TextBox ID="tel" runat="server"></asp:TextBox>
            <label>Email: </label>
            <asp:TextBox ID="email" runat="server"></asp:TextBox>
        </p>
    </div>
    <hr />
    <h2>Past Employment</h2>
        <div id="Employer1">
            <label>Company Name: </label>
            <asp:TextBox ID="CName" runat="server"></asp:TextBox>
            <p>
            <label>Street Address: </label>
            <asp:TextBox ID="CAddress" runat="server"></asp:TextBox>
        </p>
        <p>
            <label>City: </label>
            <asp:TextBox ID="CCity" runat="server"></asp:TextBox>
            <label> State: </label>
            <asp:TextBox ID="CState" runat="server"></asp:TextBox>
            <label>ZIP Code: </label>
            <asp:TextBox ID="CZIP" runat="server"></asp:TextBox>
        </p>
        <p>
            <label>Supervisor Name: </label>
            <asp:TextBox ID="SupName" runat="server"></asp:TextBox>
            <label>Supervisor Phone Number: </label>
            <asp:TextBox ID="SupPhone" runat="server"></asp:TextBox>
            <label>Supervisor Email: </label>
            <asp:TextBox ID="SupEmail" runat="server"></asp:TextBox>
            </p>
            <p>
                <label>Ok to contact?</label>
                <asp:CheckBox ID="OkToContact" runat="server" />
                
            </p>
        </div>
    <br /><br /><br />
        <div id="Employer2">
            <label>Company Name: </label>
            <asp:TextBox ID="CName2" runat="server"></asp:TextBox>
            <p>
            <label>Street Address: </label>
            <asp:TextBox ID="CAddress2" runat="server"></asp:TextBox>
        </p>
        <p>
            <label>City: </label>
            <asp:TextBox ID="CCity2" runat="server"></asp:TextBox>
            <label> State: </label>
            <asp:TextBox ID="CState2" runat="server"></asp:TextBox>
            <label>ZIP Code: </label>
            <asp:TextBox ID="CZIP2" runat="server"></asp:TextBox>
        </p>
        <p>
            <label>Supervisor Name: </label>
            <asp:TextBox ID="SupName2" runat="server"></asp:TextBox>
            <label>Supervisor Phone Number: </label>
            <asp:TextBox ID="SupPhone2" runat="server"></asp:TextBox>
            <label>Supervisor Email: </label>
            <asp:TextBox ID="SupEmail2" runat="server"></asp:TextBox>
            </p>
            <p>
                <label>Ok to contact?</label>
                <asp:CheckBox ID="OkToContact2" runat="server" />
                
            </p>
        </div>
    <br /><br /><br />
        <div id="Employer">
            <label>Company Name: </label>
            <asp:TextBox ID="CName3" runat="server"></asp:TextBox>
            <p>
            <label>Street Address: </label>
            <asp:TextBox ID="CAddress3" runat="server"></asp:TextBox>
        </p>
        <p>
            <label>City: </label>
            <asp:TextBox ID="CCity3" runat="server"></asp:TextBox>
            <label> State: </label>
            <asp:TextBox ID="CState3" runat="server"></asp:TextBox>
            <label>ZIP Code: </label>
            <asp:TextBox ID="CZIP3" runat="server"></asp:TextBox>
        </p>
        <p>
            <label>Supervisor Name: </label>
            <asp:TextBox ID="SupName3" runat="server"></asp:TextBox>
            <label>Supervisor Phone Number: </label>
            <asp:TextBox ID="SupPhone3" runat="server"></asp:TextBox>
            <label>Supervisor Email: </label>
            <asp:TextBox ID="SupEmail3" runat="server"></asp:TextBox>
            </p>
            <p>
                <label>Ok to contact?</label>
                <asp:CheckBox ID="OkToContact3" runat="server" />
                
            </p>
        </div>
    <hr />
    <h2>Education</h2>
    <div id="Education">
            <label>High School Name: </label>
            <asp:TextBox ID="HSName" runat="server"></asp:TextBox>
            <label>City: </label>
            <asp:TextBox ID="HSCity" runat="server"></asp:TextBox>
            <label>State:</label>
            <asp:TextBox ID="HSState" runat="server"></asp:TextBox>
            <p>
                <label>Graduation Year: </label>
                <asp:TextBox ID="HSGradYear" runat="server"></asp:TextBox>
            <label>GPA: </label>
                <asp:TextBox ID="HSGPA" runat="server"></asp:TextBox>
            
                <label>Did you graduate?</label>
                <asp:CheckBox ID="HSGradCheckBox" runat="server" />
            </p>
            <hr />
            <p>
            <label>Undergraduate Institution Name:</label>
            <asp:TextBox ID="CollegeName" runat="server"></asp:TextBox>
            </p>
            <p>
            <label>City: </label>
            <asp:TextBox ID="CollegeCity" runat="server"></asp:TextBox>
            <label> State:</label>
            <asp:TextBox ID="CollegeState" runat="server"></asp:TextBox>
            </p>
            <label>Major:</label>
           <p>
             <asp:TextBox ID="Major" runat="server"></asp:TextBox>
            
               <label>Did you graduate?</label>
               <asp:CheckBox ID="CollegeGradCheckBox" runat="server" />
            <label>Graduation Year: </label>
                <asp:TextBox ID="CollegeGradYear" runat="server"></asp:TextBox>
            <label>GPA: </label>
            <asp:TextBox ID="CollegeGPA" runat="server"></asp:TextBox>
            </p>

    </div>
    
    <h2>References</h2>
    <div id="References">
            <label>Name: </label>
            <asp:TextBox ID="RName1" runat="server"></asp:TextBox>
            <label>Relationship: </label>
            <asp:TextBox ID="Relationship1" runat="server"></asp:TextBox>
            <label>Phone Number: </label>
            <asp:TextBox ID="RPhone1" runat="server"></asp:TextBox>
            <label>Email: </label>
            <asp:TextBox ID="REmail1" runat="server"></asp:TextBox>
            <p>
                <label>Name: </label>
            <asp:TextBox ID="RName2" runat="server"></asp:TextBox>
            <label>Relationship: </label>
            <asp:TextBox ID="Relationship2" runat="server"></asp:TextBox>
            <label>Phone Number: </label>
            <asp:TextBox ID="RPhone2" runat="server"></asp:TextBox>
            <label>Email: </label>
            <asp:TextBox ID="REmail2" runat="server"></asp:TextBox>
            </p>
            <p>
                <label>Name: </label>
            <asp:TextBox ID="RName3" runat="server"></asp:TextBox>
            <label>Relationship: </label>
            <asp:TextBox ID="Relationship3" runat="server"></asp:TextBox>
            <label>Phone Number: </label>
            <asp:TextBox ID="RPhone3" runat="server"></asp:TextBox>
            <label>Email: </label>
            <asp:TextBox ID="REmail3" runat="server"></asp:TextBox>
            </p>
    </div>
    <
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Submit Application" />
        </p>
    </form>
    </body>
</html>
