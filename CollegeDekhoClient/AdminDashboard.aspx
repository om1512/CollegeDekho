<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDashboard.aspx.cs" Inherits="CollegeDekhoClient.AdminDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin />
    <link
      href="https://fonts.googleapis.com/css2?family=Gudea:ital,wght@0,400;0,700;1,400&family=Poppins:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;0,800;0,900;1,100;1,200;1,300;1,400;1,500;1,600;1,700;1,800;1,900&display=swap"
      rel="stylesheet"
    />
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin />
    <link
      href="https://fonts.googleapis.com/css2?family=Gudea:ital,wght@0,400;0,700;1,400&family=Londrina+Shadow&family=Poppins:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;0,800;0,900;1,100;1,200;1,300;1,400;1,500;1,600;1,700;1,800;1,900&display=swap"
      rel="stylesheet"
    />
    <link
      rel="stylesheet"
      href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.1/css/all.min.css"
      integrity="sha512-DTOQO9RWCH3ppGqcWaEA1BIZOC6xxalwEsw9c2QQeAIftl+Vegovlnee1c9QX4TctnWMn13TZye+giMm8e2LwA=="
      crossorigin="anonymous"
      referrerpolicy="no-referrer"
    />
    <link rel="stylesheet" href="resources/styles/admin_dashboard.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
        <div class="column">
            <div class="addCollege">
                <div class="title">Add College</div>
                <div class="input-fields">
                    <asp:TextBox runat="server" ID="name" CssClass="field" placeholder="Name"/>
                    <asp:TextBox runat="server" ID="university" CssClass="field" placeholder="University"/>
                    <asp:TextBox runat="server" ID="description" CssClass="desc field" placeholder="Description"/>
                    <asp:TextBox runat="server" ID="place" CssClass="field" placeholder="Place"/>
                    <asp:TextBox runat="server" ID="established" CssClass="field" placeholder="Established"/>
                    <asp:TextBox runat="server" ID="imageUrl" CssClass="field" placeholder="ImageURL"/>
                    <asp:TextBox runat="server" ID="phone" CssClass="field" placeholder="Phone"/>
                    <asp:TextBox runat="server" ID="email" CssClass="field" placeholder="Email"/>
                    <asp:TextBox runat="server" ID="website" CssClass="field" placeholder="Website"/>
                    <asp:TextBox runat="server" ID="type" CssClass="field" placeholder="Type"/>
                    <asp:TextBox runat="server" ID="campusSize" CssClass="field" placeholder="Campus Size"/>
                    <asp:TextBox runat="server" ID="gym" CssClass="field" placeholder="Gym"/>
                    <asp:TextBox runat="server" ID="canteen" CssClass="field" placeholder="Canteen"/>
                    <asp:TextBox runat="server" ID="library" CssClass="field" placeholder="Library"/>
                    <asp:TextBox runat="server" ID="sports" CssClass="field" placeholder="Sports"/>
                    <asp:TextBox runat="server" ID="NAAC" CssClass="field" placeholder="NAAC"/>
                    <asp:TextBox runat="server" ID="NIRF" CssClass="field" placeholder="NIRF"/>
                    <asp:Button runat="server" ID="save" CssClass="saveButton field" Text="Save" OnClick="save_Click"/>
                </div>
            </div>
        </div>
        <div class="column">
            <div class="addCourse">
                <div class="title">Add Course</div>
                <div class="input-fields-course">
                <asp:TextBox runat="server" ID="txtCollegeId" CssClass="field" placeholder="College ID"/>
                <asp:TextBox runat="server" ID="txtType" CssClass="field" placeholder="Type"/>
                <asp:TextBox runat="server" ID="txtDescription" CssClass="course-desc field" placeholder="Description"/>
                <asp:TextBox runat="server" ID="txtDegree" CssClass="field" placeholder="Degree"/>
                <asp:TextBox runat="server" ID="txtName" CssClass="field" placeholder="Name"/>
                <asp:TextBox runat="server" ID="txtDuration" CssClass="field" placeholder="Duration"/>
                <asp:TextBox runat="server" ID="txtFees" CssClass="field" placeholder="Fees"/>
                <asp:TextBox runat="server" ID="txtRating" CssClass="field" placeholder="Rating"/>
                <asp:TextBox runat="server" ID="txtPlacementRate" CssClass="field" placeholder="Placement Rate"/>
                <asp:TextBox runat="server" ID="txtMedianSalary" CssClass="field" placeholder="Median Salary"/>
                <asp:TextBox runat="server" ID="txtTotalAvailableSeats" CssClass="field" placeholder="Total Seats"/>
                <asp:TextBox runat="server" ID="txtGeneralSeat" CssClass="field" placeholder="General Seats"/>
                <asp:TextBox runat="server" ID="txtObcSeat" CssClass="field" placeholder="OBC Seats"/>
                <asp:TextBox runat="server" ID="txtScSeat" CssClass="field" placeholder="SC Seats"/>
                <asp:TextBox runat="server" ID="txtStSeat" CssClass="field" placeholder="ST Seats"/>
                <asp:TextBox runat="server" ID="txtOpeningHomeStateRank" CssClass="field" placeholder="Opening Rank"/>
                <asp:TextBox runat="server" ID="txtClosingHomeStateRank" CssClass="field" placeholder="Closing Rank"/>
                <asp:TextBox runat="server" ID="txtGeneralOpeningRankGujcat" CssClass="field" placeholder="General Opening Rank Gujcat"/>
                <asp:TextBox runat="server" ID="txtGeneralClosingRankGujcat" CssClass="field" placeholder="General Closing Rank Gujcat"/>
                <asp:TextBox runat="server" ID="txtGeneralOpeningRankJee" CssClass="field" placeholder="General Opening Rank JEE"/>
                <asp:TextBox runat="server" ID="txtGeneralClosingRankJee" CssClass="field" placeholder="General Closing Rank JEE"/>
                <asp:TextBox runat="server" ID="txtObcOpeningRankGujcat" CssClass="field" placeholder="OBC Opening Rank Gujcat"/>
                <asp:TextBox runat="server" ID="txtObcClosingRankGujcat" CssClass="field" placeholder="OBC Closing Rank Gujcat"/>
                <asp:TextBox runat="server" ID="txtObcOpeningRankJee" CssClass="field" placeholder="OBC Opening Rank JEE"/>
                <asp:TextBox runat="server" ID="txtObcClosingRankJee" CssClass="field" placeholder="OBC Closing Rank JEE"/>
                <asp:TextBox runat="server" ID="txtSCOpeningRankGujcat" CssClass="field" placeholder="SC Opening Rank Gujcat"/>
                <asp:TextBox runat="server" ID="txtSCClosingRankGujcat" CssClass="field" placeholder="SC Closing Rank Gujcat"/>
                <asp:TextBox runat="server" ID="txtSCOpeningRankJee" CssClass="field" placeholder="SC Opening Rank JEE"/>
                <asp:TextBox runat="server" ID="txtSCClosingRankJee" CssClass="field" placeholder="SC Closing Rank JEE"/>
                <asp:TextBox runat="server" ID="txtSTOpeningRankGujcat" CssClass="field" placeholder="ST Opening Rank Gujcat"/>
                <asp:TextBox runat="server" ID="txtSTClosingRankGujcat" CssClass="field" placeholder="ST Closing Rank Gujcat"/>
                <asp:TextBox runat="server" ID="txtSTOpeningRankJee" CssClass="field" placeholder="ST Opening Rank JEE"/>
                <asp:TextBox runat="server" ID="txtSTClosingRankJee" CssClass="field" placeholder="ST Closing Rank JEE"/>

                    
                    <asp:Button runat="server" CssClass="saveButton field" style="grid-column-start:1;
    grid-column-end:5;" Text="Save" OnClick="courseSave"/>
                </div>
            </div>
        </div>
    </div>
        <div class="list">
            <asp:Repeater ID="collegeRepeater" runat="server"> 
                <ItemTemplate>
<div ID="collegeCardLinkButton" runat="server" style="text-decoration: none" >
                            <div class="college-card">

                        <div class="fields" style="text-decoration: none;">
                            <div class="title"><%# Eval("Id") %>.    <%# Eval("Name") %></div>
                            <div class="line2">
                                <div class="col1">
                                    <div class="university">University : <span><%# Eval("University") %></span></div>
                                    <div class="loc">Place : <span><%# Eval("Place") %></span></div>
                                </div>
                                <div class="col2">
                                    <asp:LinkButton runat="server"  CssClass="update-button" OnClick="collegeCardPanel_Click" CommandArgument='<%# Eval("Id") %>' Text="Update"/>
                                    <asp:LinkButton runat="server"  CssClass="update-button" OnClick="deleteButton" CommandArgument='<%# Eval("Id") %>' Text="Delete"/>
                                </div>
                            </div>
                            
                        </div>
                                </div>
                    </div>

                </ItemTemplate>
            </asp:Repeater>
                </div>
</form>
    
</body>
</html>
