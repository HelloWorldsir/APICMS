<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyProject.aspx.cs" Inherits="Web.Admin.ProjectManagement.MyProject" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
  <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
  <meta charset="utf-8"/>
  <!-- Title and other stuffs -->
  <title>我的项目</title> 
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
        function makeProject()
        {   
            window.open('AddProject.aspx', 'newwindow', 'height=600,width=800,top=0,left=0,toolbar=no,menubar=no,scrollbars=yes, resizable=no,location=no, status=no')   
        }
    </script>
</head>

<body>
    <div class="mainbarLay">
        <div class="page-head">
        <h2 class="pull-left"><i class="icon-table"></i> 我的项目</h2>

        <!-- Breadcrumb -->
        <div class="bread-crumb pull-right">
          <a href="index.html"><i class="icon-home"></i> 我们项目</a> 
          <!-- Divider -->
          <span class="divider">/</span> 
          <a href="#" class="bread-current">Dashboard</a>
        </div>

        <div class="clearfix"></div>

      </div>
        <div class="well">
            
            <button type="button" class="btn btn-default btn-lg" onclick="makeProject()">
                 <li class="icon-plus icon-white"></li>创建项目
            </button>
        </div>
     </div>
    <span class="totop"><a href="#"><i class="icon-chevron-up"></i></a></span> 
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

<script src="js/sparklines.js"></script> <!-- Sparklines -->
<script src="js/jquery.cleditor.min.js"></script> <!-- CLEditor -->
<script src="js/bootstrap-datetimepicker.min.js"></script> <!-- Date picker -->
<script src="js/jquery.uniform.min.js"></script> <!-- jQuery Uniform -->
<script src="js/bootstrap-switch.min.js"></script> <!-- Bootstrap Toggle -->
<script src="js/filter.js"></script> <!-- Filter for support page -->
<script src="js/custom.js"></script> <!-- Custom codes -->
<script src="js/charts.js"></script> <!-- Charts & Graphs -->
</body>
</html>
