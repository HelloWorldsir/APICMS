<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberList.aspx.cs" Inherits="Web.Admin.MemberManagement.MemberList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
    <meta charset="utf-8" />
    <!-- Title and other stuffs -->
    <title>我的项目</title>
    <meta name="keywords" content="" />
    <meta name="description" content="" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="author" content="" />
    <!-- Stylesheets -->
    <link href="../style/bootstrap.css" rel="stylesheet" />
    <!-- Font awesome icon -->
    <link rel="stylesheet" href="../style/font-awesome.css" />
    <!-- jQuery UI -->
    <link href="../style/jquery-ui.css" rel="stylesheet" />
    <!-- Calendar -->
    <link rel="stylesheet" href="../style/fullcalendar.css" />
    <!-- prettyPhoto -->
    <link rel="stylesheet" href="../style/prettyPhoto.css" />
    <!-- Star rating -->
    <link rel="stylesheet" href="../style/rateit.css" />
    <!-- Date picker -->
    <link rel="stylesheet" href="../style/bootstrap-datetimepicker.min.css" />
    <!-- CLEditor -->
    <link rel="stylesheet" href="../style/jquery.cleditor.css" />
    <!-- Uniform -->
    <link rel="stylesheet" href="../style/uniform.default.css" />
    <!-- Bootstrap toggle -->
    <link rel="stylesheet" href="../style/bootstrap-switch.css" />
    <!-- Main stylesheet -->
    <link href="../style/style.css" rel="stylesheet" />
    <!-- Widgets ../stylesheet -->
    <link href="../style/widgets.css" rel="stylesheet" />

    <!-- HTML5 Support for IE -->
    <!--[if lt IE 9]>
  <script src="../js/html5shim.js"></script>
  <![endif]-->

    <!-- Favicon -->
    <link rel="shortcut icon" href="../img/favicon/favicon.png" />
    
</head>

<body>
    <div class="mainbarLay">


        <div class="page-head">
            <h2 class="pull-left"><i class="icon-table"></i>添加用户</h2>

            <!-- Breadcrumb -->
            <div class="bread-crumb pull-right">
                <a href="index.html"><i class="icon-home"></i>添加用户</a>
                <!-- Divider -->
                <span class="divider">/</span>
                <a href="#" class="bread-current">Dashboard</a>
            </div>

            <div class="clearfix"></div>

        </div>
        <div class="well">
            <button type="button" class="btn btn-default btn-lg" onclick="callFrame()">
                 <li class="icon-plus icon-white"></li>添加用户
            </button>
             <button type="button" class="btn btn-default btn-lg" onclick="BatchDel()">
                 <li class="icon-remove icon-white"></li>批量删除
            </button>
            
        </div>
        <!-- Matter -->
        <div class="matter">
            <div class="container">

                <!-- Table -->

                <div class="row">

                    <div class="col-md-12">

                        <div class="widget">

                            <div class="widget-head">
                                <div class="pull-left">用户列表</div>
                                <div class="widget-icons pull-right">
                                    <a href="#" class="wminimize"><i class="icon-chevron-up"></i></a>
                                    <a href="#" class="wclose"><i class="icon-remove"></i></a>
                                </div>
                                <div class="clearfix"></div>

                            </div>

                            <div class="widget-content">

                                <table class="table table-striped table-bordered table-hover">
                                    <thead>
                                        <tr>
                                            <th>
                                                <span class="uni">
                                                    <input type='checkbox' id="checkall" name="checkall" onClick="checkAll(this.checked)" value='' />
                                                </span>
                                            </th>
                                            <th>ID</th>
                                            <th>用户名</th>
                                            <th>真实姓名</th>
                                            <th>性别</th>
                                            <th>电话</th>
                                            <th>电子邮件</th>
                                            <th>职位</th>
                                            <th>操作</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                       
                                           <%
                              if (list != null)
                              {
                                  foreach (Model.Accounts_Users accounts_log in list)
                                  { 
                                
                            %>
                          <tr>
                              <td>
                                   <span class="uni">
                                                    <input type='checkbox' name="chk_list" value='<%=accounts_log.UserID %>' />
                                   </span>
                              </td>
                          <td><%=accounts_log.UserID %></td>
                          <td><%=accounts_log.UserName %></td>
                          <td><%=accounts_log.TrueName %></td>
                          <td><%=accounts_log.Sex %></td>
                          <td><%=accounts_log.Phone%></td>
                          <td><%=accounts_log.Email %></td>
                          <td><%=accounts_log.EmployeeName %></td>
                          <td><a href="#"><span class="label label-success">详情</span> </a>
                             </td>
                        </tr>
                            <%
                            
                                  }
                              } %>

                                       
                                    </tbody>
                                </table>
                                <div class="widget-foot">

                                    <ul class="pagination pull-right">
                                        <li><a href="#">Prev</a></li>
                                        <li><a href="#">1</a></li>
                                        <li><a href="#">2</a></li>
                                        <li><a href="#">3</a></li>
                                        <li><a href="#">4</a></li>
                                        <li><a href="#">Next</a></li>
                                    </ul>

                                    <div class="clearfix"></div>

                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Matter ends -->

    </div>

    <!-- Mainbar ends -->
  
    <span class="totop"><a href="#"><i class="icon-chevron-up"></i></a></span>
    <!-- JS -->
    <script src="../js/jquery.js"></script>
    <!-- jQuery -->
    <script src="../js/bootstrap.js"></script>
    <!-- Bootstrap -->
    <script src="../js/jquery-ui-1.9.2.custom.min.js"></script>
    <!-- jQuery UI -->
    <script src="../js/fullcalendar.min.js"></script>
    <!-- Full Google Calendar - Calendar -->
    <script src="../js/jquery.rateit.min.js"></script>
    <!-- RateIt - Star rating -->
    <script src="../js/jquery.prettyPhoto.js"></script>
    <!-- prettyPhoto -->

    <!-- jQuery Flot -->
    <script src="../js/excanvas.min.js"></script>
    <script src="../js/jquery.flot.js"></script>
    <script src="../js/jquery.flot.resize.js"></script>
    <script src="../js/jquery.flot.pie.js"></script>
    <script src="../js/jquery.flot.stack.js"></script>

    <!-- jQuery Notification - Noty -->
    <script src="../js/jquery.noty.js"></script>
    <!-- jQuery Notify -->
    <script src="../js/themes/default.js"></script>
    <!-- jQuery Notify -->
    <script src="../js/layouts/bottom.js"></script>
    <!-- jQuery Notify -->
    <script src="../js/layouts/topRight.js"></script>
    <!-- jQuery Notify -->
    <script src="../js/layouts/top.js"></script>
    <!-- jQuery Notify -->
    <!-- jQuery Notification ends -->

    <script src="../js/sparklines.js"></script>
    <!-- Sparklines -->
    <script src="../js/jquery.cleditor.min.js"></script>
    <!-- CLEditor -->
    <script src="../js/bootstrap-datetimepicker.min.js"></script>
    <!-- Date picker -->
    <script src="../js/jquery.uniform.min.js"></script>
    <!-- jQuery Uniform -->
    <script src="../js/bootstrap-switch.min.js"></script>
    <!-- Bootstrap Toggle -->
    <script src="../js/filter.js"></script>
    <!-- Filter for support page -->
    <script src="../js/custom.js"></script>
    <!-- Custom codes -->
    <script src="../js/charts.js"></script>
    <!-- Charts & Graphs -->
    <script type="text/javascript">
        
        function makeProject() {
            var iWidth = 400; //弹出窗口的宽度;
            var iHeight = 600; //弹出窗口的高度;
            var iTop = (window.screen.availHeight - 30 - iHeight) / 2; //获得窗口的垂直位置;
            var iLeft = (window.screen.availWidth - 10 - iWidth) / 2; //获得窗口的水平位置;
            window.open('AddMember.aspx', 'newwindow', "height=" + iHeight + ", width=" + iWidth + ", top=" + iTop + ", left=" + iLeft + ", toolbar = no, menubar = no, scrollbars = yes, resizable = no, location = no, status = no");
            //window.open(openUrl,"","height="+iHeight+", width="+iWidth+", top="+iTop+", left="+iLeft); 
        }
        function callFrame() {
            parent.editUrl("MemberManagement/AddMember.aspx");
        }
        function checkAll(checked) {
            var allCheckBoxs = document.getElementsByName("chk_list");
            for (var i = 0; i < allCheckBoxs.length ; i++) {
                if (allCheckBoxs[i].type == "checkbox") {
                    allCheckBoxs[i].checked = checked;
                }
            }
        }
        function BatchDel()
        {
            var checkid = "";
            var allCheckBoxs = document.getElementsByName("chk_list");
            for (var i = 0; i < allCheckBoxs.length ; i++) {
                if (allCheckBoxs[i].checked)
                {
                    if (i < allCheckBoxs.length - 1) {
                        checkid = checkid + allCheckBoxs[i].value + ",";
                    }
                    else {
                        checkid = checkid + allCheckBoxs[i].value ;
                    }
                }
            }

            window.location = "MemberList.aspx?id=" + checkid;

        }
    </script>
</body>
</html>
