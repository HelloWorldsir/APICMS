<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Log.aspx.cs" Inherits="Web.Admin.Log" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
 <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
  <meta charset="utf-8"/>
  <!-- Title and other stuffs -->
  <title>用户日志</title> 
  <meta name="keywords" content="" />
  <meta name="description" content="" />
  <meta name="viewport" content="width=device-width, initial-scale=1.0"/> 
  <meta name="author" content=""/>
  <!-- Stylesheets -->
  <link href="style/bootstrap.css" rel="stylesheet"/>
  <!-- Font awesome icon -->
  <link rel="stylesheet" href="style/font-awesome.css"/> 
  <!-- jQuery UI -->
  <link rel="stylesheet" href="style/jquery-ui.css"/> 
  <!-- Calendar -->
  <link rel="stylesheet" href="style/fullcalendar.css"/>
  <!-- prettyPhoto -->
  <link rel="stylesheet" href="style/prettyPhoto.css"/>  
  <!-- Star rating -->
  <link rel="stylesheet" href="style/rateit.css"/>
  <!-- Date picker -->
  <link rel="stylesheet" href="style/bootstrap-datetimepicker.min.css"/>
  <!-- CLEditor -->
  <link rel="stylesheet" href="style/jquery.cleditor.css"/> 
  <!-- Uniform -->
  <link rel="stylesheet" href="style/uniform.default.css"/> 
  <!-- Bootstrap toggle -->
  <link rel="stylesheet" href="style/bootstrap-switch.css"/>
  <!-- Main stylesheet -->
  <link href="style/style.css" rel="stylesheet"/>
  <!-- Widgets stylesheet -->
  <link href="style/widgets.css" rel="stylesheet"/>   
  
  <!-- HTML5 Support for IE -->
  <!--[if lt IE 9]>
  <script src="js/html5shim.js"></script>
  <![endif]-->

  <!-- Favicon -->
  <link rel="shortcut icon" href="img/favicon/favicon.png"/>
    <script type="text/javascript">
        $(function () {
            $("#starttime").datetimepicker({ format: 'yyyy-mm-dd hh:ii' });
            $("#endtimes").datetimepicker({ format: 'yyyy-mm-dd hh:ii' });
        });
    </script>
</head>
<body>
  	<div class="mainbarLay">

      <!-- Page heading -->
      <div class="page-head">
        <h2 class="pull-left"><i class="icon-table"></i> 日志</h2>

        <!-- Breadcrumb -->
        <div class="bread-crumb pull-right">
          <a href="index.html"><i class="icon-home"></i> Home</a> 
          <!-- Divider -->
          <span class="divider">/</span> 
          <a href="#" class="bread-current">Dashboard</a>
        </div>

        <div class="clearfix"></div>
          

      </div>
      <!-- Page heading ends -->
           <div class="well">
                 用户名&nbsp;&nbsp;&nbsp;&nbsp;:<input type="text"  placeholder="用户名"/>
                 开始时间:<input type="text" id="starttime" data-date-format="yyyy-mm-dd hh:ii" placeholder="开始时间"/>
                 结束时间:<input type="text" id="endtimes"data-date-format="yyyy-mm-dd hh:ii" placeholder="结束时间"/>
               <br/>
               <br/>
               操作模块:<input type="text"  placeholder="操作模块"/>
               子模块&nbsp;&nbsp;&nbsp;&nbsp;:<input type="text"  placeholder="操作子模块"/>
               用户IP&nbsp;&nbsp;&nbsp;&nbsp;:<input type="text"  placeholder="用户IP"/>
                 <i class="icon-search"></i><input type="submit" value="搜索" />
               
            </div>
	    <!-- Matter -->

	    <div class="matter">
        <div class="container">

          <!-- Table -->

            <div class="row">

              <div class="col-md-12">

                <div class="widget">

                <div class="widget-head">
                  <div class="pull-left">接口列表</div>
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
                          <th>ID</th>
                          <th>用户名</th>
                          <th>操作模块</th>
                          <th>操作子模块</th>
                          <th>用户IP</th>
                          <th>操作结果</th>
                          <th>操作时间</th>
                            <th>操作</th>
                        </tr>
                      </thead>
                      <tbody>
                          <%
                              if (list != null)
                              {
                                  foreach (Model.Accounts_Log accounts_log in list)
                                  { 
                                
                            %>
                          <tr>
                          <td><%=accounts_log.ID %></td>
                          <td><%=accounts_log.UserName %></td>
                          <td><%=accounts_log.OperModuel %></td>
                          <td><%=accounts_log.ChildModuel %></td>
                          <td><%=accounts_log.IP %></td>
                          <td><%=(accounts_log.OperResult=="true"?"成功":"失败") %></td>
                          <td><%=accounts_log.OperTime %></td>
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
<script src="js/jquery.js"></script> <!-- jQuery -->
<script src="js/bootstrap.js"></script> <!-- Bootstrap -->
<script src="js/jquery-ui-1.9.2.custom.min.js"></script> <!-- jQuery UI -->
<script src="js/fullcalendar.min.js"></script> <!-- Full Google Calendar - Calendar -->
<script src="js/jquery.rateit.min.js"></script> <!-- RateIt - Star rating -->
<script src="js/jquery.prettyPhoto.js"></script> <!-- prettyPhoto -->

<!-- jQuery Flot -->
<script src="js/excanvas.min.js"></script>
<script src="js/jquery.flot.js"></script>
<script src="js/jquery.flot.resize.js"></script>
<script src="js/jquery.flot.pie.js"></script>
<script src="js/jquery.flot.stack.js"></script>

<!-- jQuery Notification - Noty -->
<script src="js/jquery.noty.js"></script> <!-- jQuery Notify -->
<script src="js/themes/default.js"></script> <!-- jQuery Notify -->
<script src="js/layouts/bottom.js"></script> <!-- jQuery Notify -->
<script src="js/layouts/topRight.js"></script> <!-- jQuery Notify -->
<script src="js/layouts/top.js"></script> <!-- jQuery Notify -->
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
