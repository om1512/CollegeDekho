<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateCollege.aspx.cs" Inherits="CollegeDekhoClient.UpdateCollege" %>

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
    <link rel="stylesheet" href="resources/styles/update_college.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="column">
            <div class="addCollege">
                <div class="title">Update College</div>
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
        </div>
    </form>
</body>
</html>
