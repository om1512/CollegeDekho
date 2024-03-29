<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="CollegeDekhoClient.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link rel="stylesheet" href="resources/styles/home_style.css" />
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin />
    <link
      href="https://fonts.googleapis.com/css2?family=Gudea:ital,wght@0,400;0,700;1,400&family=Poppins:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;0,800;0,900;1,100;1,200;1,300;1,400;1,500;1,600;1,700;1,800;1,900&display=swap"
      rel="stylesheet"
    />
</head>
<body>
    <form id="form1" runat="server">
        <div class="content">
            <div class="place">
                <div class="fixed">
                        <div class="header">
                        <asp:LinkButton runat="server" style="text-decoration:none;" OnClick="AdminLoginClick" CssClass="menu">Admin</asp:LinkButton>
                        <asp:LinkButton runat="server" style="text-decoration:none;" OnClick="AdminLoginClick" CssClass="menu">About Me</asp:LinkButton>
                    </div>
                    <div class="head">
                        <div class="logo">
                            <img src="resources/images/logo.svg" alt="" srcset="" />
                        </div>
                        <div class="input">
                            <input
                                type="text"
                                name="search"
                                id=""
                                placeholder="Search College, University, City "
                            />
                        </div>
                    </div>
                </div>
                <div class="list">
                    <div>
            <asp:Repeater ID="collegeRepeater" runat="server"> 
                <ItemTemplate>
                    <asp:LinkButton ID="collegeCardLinkButton" runat="server" style="text-decoration: none"  OnClick="collegeCardPanel_Click" CommandArgument='<%# Eval("Id") %>'>
                                                <div class="college-card">

                                            <div class="field" style="text-decoration: none;">
                                                <div class="title"><%# Eval("Name") %></div>
                                                <div class="university">University : <span><%# Eval("University") %></span></div>
                                                <div class="loc">Place : <span><%# Eval("Place") %></span></div>
                                            </div>
                                                    </div>
                                        </asp:LinkButton>

                                    </ItemTemplate>
                                </asp:Repeater>
                            </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
