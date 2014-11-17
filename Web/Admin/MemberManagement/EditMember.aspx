<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditMember.aspx.cs" Inherits="Web.Admin.MemberManagement.EditMember" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
  <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
  <meta charset="utf-8"/>
  <!-- Title and other stuffs -->
  <title>添加会员</title> 
  <meta name="keywords" content="" />
  <meta name="description" content="" />
  <meta name="viewport" content="width=device-width, initial-scale=1.0"/> 
  <meta name="author" content=""/>
  <!-- Stylesheets -->
  <link href="../style/bootstrap.css" rel="stylesheet"/>
  <!-- Font awesome icon -->
  <link rel="stylesheet" href="../style/font-awesome.css"/> 
  <!-- jQuery UI -->
   <link href="../style/jquery-ui.css" rel="stylesheet" />
  <!-- Calendar -->
  <link rel="stylesheet" href="../style/fullcalendar.css"/>
  <!-- prettyPhoto -->
  <link rel="stylesheet" href="../style/prettyPhoto.css"/>  
  <!-- Star rating -->
  <link rel="stylesheet" href="../style/rateit.css"/>
  <!-- Date picker -->
  <link rel="stylesheet" href="../style/bootstrap-datetimepicker.min.css"/>
  <!-- CLEditor -->
  <link rel="stylesheet" href="../style/jquery.cleditor.css"/> 
  <!-- Uniform -->
  <link rel="stylesheet" href="../style/uniform.default.css"/> 
  <!-- Bootstrap toggle -->
  <link rel="stylesheet" href="../style/bootstrap-switch.css"/>
  <!-- Main stylesheet -->
  <link href="../style/style.css" rel="stylesheet"/>
  <!-- Widgets ../stylesheet -->
  <link href="style/widgets.css" rel="stylesheet"/>   
  
  <!-- HTML5 Support for IE -->
  <!--[if lt IE 9]>
  <script src="../js/html5shim.js"></script>
  <![endif]-->

  <!-- Favicon -->
  <link rel="shortcut icon" href="../img/favicon/favicon.png"/>
    <script type="text/javascript">
        function callFrame() {
            parent.editUrl("MemberManagement/MemberList.aspx");
        }

    </script>
</head>
<body>

    <div class="mainbarLay">
         <div class="page-head">
            <h2 class="pull-left"><i class="icon-table"></i>添加用户</h2>

            <!-- Breadcrumb -->
            <div class="bread-crumb pull-right">
                <a href="javascript:void(0)" onclick="callFrame()"><i class="icon-home"></i>用户列表</a>
                <!-- Divider -->
                <span class="divider">/</span>
                <a href="#" class="bread-current">Dashboard</a>
            </div>

            <div class="clearfix"></div>

        </div>
     <div class="matter">
        <div class="container">

          <div class="row">

            <div class="col-md-12">


              <div class="widget wgreen">
                
                <div class="widget-head">
                  <div class="pull-left">添加会员</div>
                  <div class="widget-icons pull-right">
                    <a href="#" class="wminimize"><i class="icon-chevron-up"></i></a> 
                    <a href="#" class="wclose"><i class="icon-remove"></i></a>
                  </div>
                  <div class="clearfix"></div>
                </div>

                <div class="widget-content">
                  <div class="padd">

                    <h6>会员信息</h6>
                    <hr />
                    <!-- Form starts.  -->
                     <form class="form-horizontal" role="form" method="post" action="AddMember.aspx">
                              
                                <div class="form-group">
                                  <label class="col-lg-4 control-label">用户名</label>
                                  <div class="col-lg-8">
                                    <input type="text" class="form-control" name="username" placeholder="用户名"/>
                                  </div>
                                </div>
                                
                                <div class="form-group">
                                  <label class="col-lg-4 control-label">初始密码</label>
                                  <div class="col-lg-8">
                                    <input type="password" class="form-control" name="password" placeholder="初始密码"/>
                                  </div>
                                </div>
                                
                                <div class="form-group">
                                  <label class="col-lg-4 control-label">姓名</label>
                                  <div class="col-lg-8">
                                    <input type="text" class="form-control" name="truename" placeholder="姓名"/>
                                  </div>
                                </div>    
                                <div class="form-group">
                                    <label class="col-lg-4 control-label">电子邮件</label>
                                     <div class="col-lg-8">
                                        <input type="text" class="form-control" name="email" placeholder="电子邮件"/>
                                     </div>
                                </div>
                                <div class="form-group">
                                  <label class="col-lg-4 control-label">性别</label>
                                  <div class="col-lg-8">
                                    <div class="radio">
                                      <label>
                                        <input type="radio" name="sex" id="optionsRadios1" value="男" checked="checked"/>
                                       男
                                      </label>
                                    </div>
                                    <div class="radio">
                                      <label>
                                        <input type="radio" name="sex" id="optionsRadios2" value="女"/>
                                        女
                                      </label>
                                    </div>
                                  </div>
                                </div>
                                
                                <div class="form-group">
                                  <label class="col-lg-4 control-label">职位</label>
                                  <div class="col-lg-8">
                                    <select class="form-control" name="EmployeeName">
                                        <% if (list != null) {
                                               foreach (Model.Employee employ in list)
                                               {%>
                                                 <option><%=employ.EmployeeName %></option>   
                                              <% }
                                           }%>
                                    </select>
                                  </div>
                                </div>                                                           
                                    <hr />
                                <div class="form-group">
                                  <div class="col-lg-offset-1 col-lg-9">
                                    <button type="submit" class="btn btn-danger">发送</button>
                                  </div>
                                </div>
                              </form>
                  </div>
                </div>
                  <div class="widget-foot">
                    <!-- Footer goes here -->
                  </div>
              </div>  

            </div>

          </div>

        </div>
		  </div>

		<!-- Matter ends -->
        </div>

   <!-- JS -->
<script src="../js/jquery.js"></script> <!-- jQuery -->
<script src="../js/bootstrap.js"></script> <!-- Bootstrap -->
<script src="../js/jquery-ui-1.9.2.custom.min.js"></script> <!-- jQuery UI -->
<script src="../js/fullcalendar.min.js"></script> <!-- Full Google Calendar - Calendar -->
<script src="../js/jquery.rateit.min.js"></script> <!-- RateIt - Star rating -->
<script src="../js/jquery.prettyPhoto.js"></script> <!-- prettyPhoto -->

<!-- jQuery Flot -->
<script src="../js/excanvas.min.js"></script>
<script src="../js/jquery.flot.js"></script>
<script src="../js/jquery.flot.resize.js"></script>
<script src="../js/jquery.flot.pie.js"></script>
<script src="../js/jquery.flot.stack.js"></script>

<!-- jQuery Notification - Noty -->
<script src="../js/jquery.noty.js"></script> <!-- jQuery Notify -->
<script src="../js/themes/default.js"></script> <!-- jQuery Notify -->
<script src="../js/layouts/bottom.js"></script> <!-- jQuery Notify -->
<script src="../js/layouts/topRight.js"></script> <!-- jQuery Notify -->
<script src="../js/layouts/top.js"></script> <!-- jQuery Notify -->
<!-- jQuery Notification ends -->

<script src="../js/sparklines.js"></script> <!-- Sparklines -->
<script src="../js/jquery.cleditor.min.js"></script> <!-- CLEditor -->
<script src="../js/bootstrap-datetimepicker.min.js"></script> <!-- Date picker -->
<script src="../js/jquery.uniform.min.js"></script> <!-- jQuery Uniform -->
<script src="../js/bootstrap-switch.min.js"></script> <!-- Bootstrap Toggle -->
<script src="../js/filter.js"></script> <!-- Filter for support page -->
<script src="../js/custom.js"></script> <!-- Custom codes -->
<script src="../js/charts.js"></script> <!-- Charts & Graphs -->
</body>
</html>
