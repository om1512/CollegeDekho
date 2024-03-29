<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CollegeDetail.aspx.cs" Inherits="CollegeDekhoClient.CollegeDetail" %>

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

    <link rel="stylesheet" href="resources/styles/detail_style.css" />
    </head>
<body>
        <form id="form1" runat="server">
      <asp:LinkButton runat="server" OnClick="button_back_Click" id="button_back" class="back" style="text-decoration: none">
        <i class="fa fa-arrow-left" aria-hidden="true"></i>
      </asp:LinkButton>
      <div class="content">
        <div class="item1">
          <div class="image">
            <asp:Image
                runat="server"
                ID="image"
              
            />
          </div>
          <div class="detail">
            <asp:Label runat="server" ID="name" class="name">Dharamsinh Desai University</asp:Label>
            <asp:Label runat="server" ID="desc" class="desc">
              Lorem ipsum dolor sit amet consectetur adipisicing elit. Similique
              molestias itaque accusamus suscipit animi rem aperiam sed, maxime
              autem sit quos optio sequi praesentium molestiae iure tempora.
              Perferendis, quod facilis.
            </asp:Label>
            <div class="row-block">
              <div class="university">
                <div class="label">Univesity</div>
                <asp:Label runat="server" ID="uniType" class="label-val">Autonomous</asp:Label>
              </div>
              <div class="place">
                <div class="label">Place</div>
                <asp:Label runat="server" ID="place" class="label-val">Nadiad, Guajarat.</asp:Label>
              </div>
              <div class="established">
                <div class="label">Established</div>
                <asp:Label runat="server" ID="established" class="label-val">Year 2000</asp:Label>
              </div>
            </div>
          </div>
        </div>
        <div class="item2">
          <div class="col1">
            <div class="activity">
              <div class="item">
                <div class="label">Gym</div>
                <asp:Label runat="server" ID="gym" class="label-val">Yes</asp:Label>
              </div>
              <div class="item">
                <div class="label">Canteen</div>
                <asp:Label runat="server" ID="canteen" class="label-val">Yes</asp:Label>
              </div>
              <div class="item">
                <div class="label">Campus size</div>
                <asp:Label runat="server" ID="acre" class="label-val">241 Acre</asp:Label>
              </div>
              <div class="item">
                <div class="label">Library</div>
                <asp:Label runat="server" ID="library" class="label-val">Yes</asp:Label>
              </div>
              <div class="sports-item">
                <div class="label">Sports</div>
                <asp:Label runat="server" ID="sports" class="label-val">Cricket, Tennis, Chess, Carrom.</asp:Label>
              </div>
            </div>
            <div class="contact">
              <div class="item">
                <div class="label" style="width: max-content">Phone</div>
                <asp:Label runat="server" ID="phone" class="label-val">+91 265 8895668</asp:Label>
              </div>
              <div class="item" style="margin-top: 10px">
                <div class="label" style="width: max-content">Email</div>
                <asp:Label runat="server" ID="email" class="label-val">registrar@ddu.ac.in</asp:Label>
              </div>
              <div class="item" style="margin-top: 10px">
                <div class="label" style="width: max-content">Website</div>
                <asp:Label runat="server" ID="website" class="label-val">https://www.ddu.ac.in</asp:Label>
              </div>
            </div>
            <div class="achivments">
              <div class="item">
                <div class="label" style="width: max-content">NAAC</div>
                <asp:Label runat="server" ID="naac" class="label-val">A+++</asp:Label>
              </div>
              <div class="item" style="margin-left: 20px">
                <div class="label" style="width: max-content">NIRF Rank</div>
                <asp:Label runat="server" ID="nirf" class="label-val">154</asp:Label>
              </div>
            </div>
            <div class="achivments">
              <div class="item">
                <div class="label">Type</div>
                <asp:Label runat="server" ID="type" class="label-val">Grant In Aid</asp:Label>
              </div>
            </div>
            <div class="achivments">
              <div class="item">
                <div class="label">Admission Through</div>
                <div class="label-val">Gujcat, JEE</div>
              </div>
            </div>
          </div>
          <div class="col2">
            <div class="branch-content">
             <asp:Repeater ID="courseRepeater" runat="server">
                 <ItemTemplate>
                      <div class="b">
                        <div class="line1">
                          <div class="cname">
                            <div class="courseName" style="margin-bottom: 5px">
                                    <%# Eval("name") %>
                            </div>
                            <div class="starts">
                                <%# GenerateStars(Eval("rating")) %>
                            </div>
                          </div>
                          <div class="courseDetail">
                            <div class="type"><%# Eval("type") %></div>
                            <div class="degree"><%# Eval("degree") %></div>
                          </div>
                        </div>
                        <div class="line2">
                          <%# Eval("description") %>
                        </div>
                        <div class="line3">
                          <div class="box">
                            <div class="subBox">
                              <div class="label">Duration</div>
                              <div class="label-val"><%# Eval("duration") %></div>
                            </div>
                            <div class="subBox">
                              <div class="label">Fees</div>
                              <div class="label-val"><%# Eval("fees") %> / Year</div>
                            </div>
                            <div class="subBox">
                              <div class="label">Placement Rate</div>
                              <div class="label-val"><%# Eval("placement_rate") %>%</div>
                            </div>
                            <div class="subBox">
                              <div class="label">Median Salary</div>
                              <div class="label-val"><%# Eval("median_salary") %></div>
                            </div>
                          </div>
                        </div>
                        <div class="line4">
                          <div
                            class="box"
                            style="grid-template-columns: 1fr 1fr 1fr 1fr 1fr"
                          >
                            <div class="subBox">
                              <div class="label">Total Seats</div>
                              <div class="label-val"><%# Eval("total_available_seats") %></div>
                            </div>
                            <div class="subBox">
                              <div class="label">Open</div>
                              <div class="label-val"><%# Eval("general_seat") %></div>
                            </div>
                            <div class="subBox">
                              <div class="label">OBC</div>
                              <div class="label-val"><%# Eval("obc_seat") %></div>
                            </div>
                            <div class="subBox">
                              <div class="label">SC</div>
                              <div class="label-val"><%# Eval("sc_seat") %></div>
                            </div>
                            <div class="subBox">
                              <div class="label">ST</div>
                              <div class="label-val"><%# Eval("st_seat") %></div>
                            </div>
                          </div>
                        </div>

                        <div class="line5">
                          <div class="rank-box">
                            <div class="ranktitle">Gujcat Opening Ranks</div>
                            <div class="boxContent">
                              <div class="subBox">
                                <div class="label">Open</div>
                                <div class="label-val"><%# Eval("general_opening_rank_Gujcat") %></div>
                              </div>
                              <div class="subBox">
                                <div class="label">OBC</div>
                                <div class="label-val"><%# Eval("obc_opening_rank_Gujcat") %></div>
                              </div>
                              <div class="subBox">
                                <div class="label">SC</div>
                                <div class="label-val"><%# Eval("SC_opening_rank_Gujcat") %></div>
                              </div>
                              <div class="subBox">
                                <div class="label">ST</div>
                                <div class="label-val"><%# Eval("ST_opening_rank_Gujcat") %></div>
                              </div>
                            </div>

                            <div class="ranktitle" style="margin-top: 10px">
                              Gujcat Closing Ranks
                            </div>
                            <div class="boxContent">
                              <div class="subBox">
                                <div class="label">Open</div>
                                <div class="label-val"><%# Eval("general_closing_rank_Gujcat") %></div>
                              </div>
                              <div class="subBox">
                                <div class="label">OBC</div>
                                <div class="label-val"><%# Eval("obc_closing_rank_Gujcat") %></div>
                              </div>
                              <div class="subBox">
                                <div class="label">SC</div>
                                <div class="label-val"><%# Eval("SC_closing_rank_Gujcat") %></div>
                              </div>
                              <div class="subBox">
                                <div class="label">ST</div>
                                <div class="label-val"><%# Eval("ST_closing_rank_Gujcat") %></div>
                              </div>
                            </div>

                            <div class="ranktitle" style="margin-top: 10px">
                              JEE Opening Ranks
                            </div>
                            <div class="boxContent">
                              <div class="subBox">
                                <div class="label">Open</div>
                                <div class="label-val"><%# Eval("general_opening_rank_Jee") %></div>
                              </div>
                              <div class="subBox">
                                <div class="label">OBC</div>
                                <div class="label-val"><%# Eval("obc_opening_rank_Jee") %></div>
                              </div>
                              <div class="subBox">
                                <div class="label">SC</div>
                                <div class="label-val"><%# Eval("SC_opening_rank_Jee") %></div>
                              </div>
                              <div class="subBox">
                                <div class="label">ST</div>
                                <div class="label-val"><%# Eval("ST_opening_rank_Jee") %></div>
                              </div>
                            </div>
                            <div class="ranktitle" style="margin-top: 10px">
                              JEE Closing Ranks
                            </div>
                            <div class="boxContent">
                              <div class="subBox">
                                <div class="label">Open</div>
                                <div class="label-val"><%# Eval("general_closing_rank_Jee") %></div>
                              </div>
                              <div class="subBox">
                                <div class="label">OBC</div>
                                <div class="label-val"><%# Eval("obc_closing_rank_Jee") %></div>
                              </div>
                              <div class="subBox">
                                <div class="label">SC</div>
                                <div class="label-val"><%# Eval("SC_closing_rank_Jee") %></div>
                              </div>
                              <div class="subBox">
                                <div class="label">ST</div>
                                <div class="label-val"><%# Eval("ST_closing_rank_Jee") %></div>
                              </div>
                            </div>
                          </div>
                        </div>
                      </div>
                </ItemTemplate>
             </asp:Repeater>
            </div>
          </div>
        </div>
      </div>
    </form>
    
</body>
</html>
