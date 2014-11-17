<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogList.aspx.cs" Inherits="Web.Admin.System_Log.LogList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
  <meta charset="utf-8">
  <!-- Title and other stuffs -->
  <title>表格页面 Bootstrap响应式后台管理系统模版Mac - 代码家园-www.daimajiayuan.com</title> 
  <meta name="keywords" content="Bootstrap模版,Bootstrap模版下载,Bootstrap教程,Bootstrap中文,后台管理系统模版,后台模版下载,后台管理系统,后台管理模版" />
  <meta name="description" content="代码家园-www.daimajiayuan.com提供Bootstrap模版,后台管理系统模版,后台管理界面,Bootstrap教程,Bootstrap中文翻译等相关Bootstrap插件下载" />
  <meta name="viewport" content="width=device-width, initial-scale=1.0"/> 
  <meta name="author" content=""/>
  <!-- Stylesheets -->
  <link href="../style/bootstrap.css" rel="stylesheet">
  <!-- Font awesome icon -->
  <link rel="stylesheet" href="../style/font-awesome.css"> 
  <!-- jQuery UI -->
  <link rel="stylesheet" href="../style/jquery-ui.css"> 
  <!-- Calendar -->
  <link rel="stylesheet" href="../style/fullcalendar.css">
  <!-- prettyPhoto -->
  <link rel="stylesheet" href="../style/prettyPhoto.css">  
  <!-- Star rating -->
  <link rel="stylesheet" href="../style/rateit.css">
  <!-- Date picker -->
  <link rel="stylesheet" href="../style/bootstrap-datetimepicker.min.css">
  <!-- CLEditor -->
  <link rel="stylesheet" href="../style/jquery.cleditor.css"> 
  <!-- Uniform -->
  <link rel="stylesheet" href="../style/uniform.default.css"> 
  <!-- Bootstrap toggle -->
  <link rel="stylesheet" href="../style/bootstrap-switch.css">
  <!-- Main stylesheet -->
  <link href="../style/style.css" rel="stylesheet">
  <!-- Widgets stylesheet -->
  <link href="../style/widgets.css" rel="stylesheet">   
  
  <!-- HTML5 Support for IE -->
  <!--[if lt IE 9]>
  <script src="js/html5shim.js"></script>
  <![endif]-->

  <!-- Favicon -->
  <link rel="shortcut icon" href="img/favicon/favicon.png">
</head>

<body>
    <div class="widget">

                <div class="widget-head">
                  <div class="pull-left">用户日志</div>
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
                          <th>编号</th>
                          <th>用户名</th>
                          <th>操作模块</th>
                          <th>子模块</th>
                          <th>IP地址</th>
                          <th>结果</th>
                          <th>操作时间</th>
                        </tr>
                      </thead>
                      <tbody>

                        <tr>
                          <td>1</td>
                          <td>Ravi Kumar</td>
                          <td>India</td>
                          <td>23/12/2012</td>
                          <td>Paid</td>
                          <td><span class="label label-success">Active</span></td>
                          <td>

                              <button class="btn btn-xs btn-success"><i class="icon-ok"></i> </button>
                              <button class="btn btn-xs btn-warning"><i class="icon-pencil"></i> </button>
                              <button class="btn btn-xs btn-danger"><i class="icon-remove"></i> </button>
                          
                          </td>
                        </tr>


                        <tr>
                          <td>2</td>
                          <td>Parneethi Chopra</td>
                          <td>USA</td>
                          <td>13/02/2012</td>
                          <td>Free</td>
                          <td><span class="label label-danger">Banned</span></td>
                          <td>

                              <button class="btn btn-xs btn-default"><i class="icon-ok"></i> </button>
                              <button class="btn btn-xs btn-default"><i class="icon-pencil"></i> </button>
                              <button class="btn btn-xs btn-default"><i class="icon-remove"></i> </button>

                          </td>
                        </tr>

                        <tr>
                          <td>3</td>
                          <td>Kumar Ragu</td>
                          <td>Japan</td>
                          <td>12/03/2012</td>
                          <td>Paid</td>
                          <td><span class="label label-success">Active</span></td>
                          <td>

                            <div class="btn-group">
                              <button class="btn btn-xs btn-default"><i class="icon-ok"></i> </button>
                              <button class="btn btn-xs btn-default"><i class="icon-pencil"></i> </button>
                              <button class="btn btn-xs btn-default"><i class="icon-remove"></i> </button>
                            </div>

                          </td>
                        </tr>

                        <tr>
                          <td>4</td>
                          <td>Vishnu Vardan</td>
                          <td>Bangkok</td>
                          <td>03/11/2012</td>
                          <td>Paid</td>
                          <td><span class="label label-success">Active</span></td>
                          <td>

                            <div class="btn-group">
                              <button class="btn btn-xs btn-success"><i class="icon-ok"></i> </button>
                              <button class="btn btn-xs btn-warning"><i class="icon-pencil"></i> </button>
                              <button class="btn btn-xs btn-danger"><i class="icon-remove"></i> </button>
                            </div>

                          </td>
                        </tr>

                        <tr>
                          <td>5</td>
                          <td>Anuksha Sharma</td>
                          <td>Singapore</td>
                          <td>13/32/2012</td>
                          <td>Free</td>
                          <td><span class="label label-danger">Banned</span></td>
                          <td>

                            <div class="btn-group1">
                              <button class="btn btn-xs btn-success"><i class="icon-ok"></i> </button>
                              <button class="btn btn-xs btn-warning"><i class="icon-pencil"></i> </button>
                              <button class="btn btn-xs btn-danger"><i class="icon-remove"></i> </button>
                            </div>

                          </td>
                        </tr>                                                            
                         <tr>
                          <td>5</td>
                          <td>Anuksha Sharma</td>
                          <td>Singapore</td>
                          <td>13/32/2012</td>
                          <td>Free</td>
                          <td><span class="label label-danger">Banned</span></td>
                          <td>

                            <div class="btn-group1">
                              <button class="btn btn-xs btn-success"><i class="icon-ok"></i> </button>
                              <button class="btn btn-xs btn-warning"><i class="icon-pencil"></i> </button>
                              <button class="btn btn-xs btn-danger"><i class="icon-remove"></i> </button>
                            </div>

                          </td>
                        </tr>           
                           <tr>
                          <td>5</td>
                          <td>Anuksha Sharma</td>
                          <td>Singapore</td>
                          <td>13/32/2012</td>
                          <td>Free</td>
                          <td><span class="label label-danger">Banned</span></td>
                          <td>

                            <div class="btn-group1">
                              <button class="btn btn-xs btn-success"><i class="icon-ok"></i> </button>
                              <button class="btn btn-xs btn-warning"><i class="icon-pencil"></i> </button>
                              <button class="btn btn-xs btn-danger"><i class="icon-remove"></i> </button>
                            </div>

                          </td>
                        </tr>           
                           <tr>
                          <td>5</td>
                          <td>Anuksha Sharma</td>
                          <td>Singapore</td>
                          <td>13/32/2012</td>
                          <td>Free</td>
                          <td><span class="label label-danger">Banned</span></td>
                          <td>

                            <div class="btn-group1">
                              <button class="btn btn-xs btn-success"><i class="icon-ok"></i> </button>
                              <button class="btn btn-xs btn-warning"><i class="icon-pencil"></i> </button>
                              <button class="btn btn-xs btn-danger"><i class="icon-remove"></i> </button>
                            </div>

                          </td>
                        </tr>           
                           <tr>
                          <td>5</td>
                          <td>Anuksha Sharma</td>
                          <td>Singapore</td>
                          <td>13/32/2012</td>
                          <td>Free</td>
                          <td><span class="label label-danger">Banned</span></td>
                          <td>

                            <div class="btn-group1">
                              <button class="btn btn-xs btn-success"><i class="icon-ok"></i> </button>
                              <button class="btn btn-xs btn-warning"><i class="icon-pencil"></i> </button>
                              <button class="btn btn-xs btn-danger"><i class="icon-remove"></i> </button>
                            </div>

                          </td>
                        </tr>           
                           <tr>
                          <td>5</td>
                          <td>Anuksha Sharma</td>
                          <td>Singapore</td>
                          <td>13/32/2012</td>
                          <td>Free</td>
                          <td><span class="label label-danger">Banned</span></td>
                          <td>

                            <div class="btn-group1">
                              <button class="btn btn-xs btn-success"><i class="icon-ok"></i> </button>
                              <button class="btn btn-xs btn-warning"><i class="icon-pencil"></i> </button>
                              <button class="btn btn-xs btn-danger"><i class="icon-remove"></i> </button>
                            </div>

                          </td>
                        </tr>           
                           <tr>
                          <td>5</td>
                          <td>Anuksha Sharma</td>
                          <td>Singapore</td>
                          <td>13/32/2012</td>
                          <td>Free</td>
                          <td><span class="label label-danger">Banned</span></td>
                          <td>

                            <div class="btn-group1">
                              <button class="btn btn-xs btn-success"><i class="icon-ok"></i> </button>
                              <button class="btn btn-xs btn-warning"><i class="icon-pencil"></i> </button>
                              <button class="btn btn-xs btn-danger"><i class="icon-remove"></i> </button>
                            </div>

                          </td>
                        </tr>           
                           <tr>
                          <td>5</td>
                          <td>Anuksha Sharma</td>
                          <td>Singapore</td>
                          <td>13/32/2012</td>
                          <td>Free</td>
                          <td><span class="label label-danger">Banned</span></td>
                          <td>

                            <div class="btn-group1">
                              <button class="btn btn-xs btn-success"><i class="icon-ok"></i> </button>
                              <button class="btn btn-xs btn-warning"><i class="icon-pencil"></i> </button>
                              <button class="btn btn-xs btn-danger"><i class="icon-remove"></i> </button>
                            </div>

                          </td>
                        </tr>           
                           <tr>
                          <td>5</td>
                          <td>Anuksha Sharma</td>
                          <td>Singapore</td>
                          <td>13/32/2012</td>
                          <td>Free</td>
                          <td><span class="label label-danger">Banned</span></td>
                          <td>

                            <div class="btn-group1">
                              <button class="btn btn-xs btn-success"><i class="icon-ok"></i> </button>
                              <button class="btn btn-xs btn-warning"><i class="icon-pencil"></i> </button>
                              <button class="btn btn-xs btn-danger"><i class="icon-remove"></i> </button>
                            </div>

                          </td>
                        </tr>           
                           <tr>
                          <td>5</td>
                          <td>Anuksha Sharma</td>
                          <td>Singapore</td>
                          <td>13/32/2012</td>
                          <td>Free</td>
                          <td><span class="label label-danger">Banned</span></td>
                          <td>

                            <div class="btn-group1">
                              <button class="btn btn-xs btn-success"><i class="icon-ok"></i> </button>
                              <button class="btn btn-xs btn-warning"><i class="icon-pencil"></i> </button>
                              <button class="btn btn-xs btn-danger"><i class="icon-remove"></i> </button>
                            </div>

                          </td>
                        </tr>           
                           <tr>
                          <td>5</td>
                          <td>Anuksha Sharma</td>
                          <td>Singapore</td>
                          <td>13/32/2012</td>
                          <td>Free</td>
                          <td><span class="label label-danger">Banned</span></td>
                          <td>

                            <div class="btn-group1">
                              <button class="btn btn-xs btn-success"><i class="icon-ok"></i> </button>
                              <button class="btn btn-xs btn-warning"><i class="icon-pencil"></i> </button>
                              <button class="btn btn-xs btn-danger"><i class="icon-remove"></i> </button>
                            </div>

                          </td>
                        </tr>           
                           <tr>
                          <td>5</td>
                          <td>Anuksha Sharma</td>
                          <td>Singapore</td>
                          <td>13/32/2012</td>
                          <td>Free</td>
                          <td><span class="label label-danger">Banned</span></td>
                          <td>

                            <div class="btn-group1">
                              <button class="btn btn-xs btn-success"><i class="icon-ok"></i> </button>
                              <button class="btn btn-xs btn-warning"><i class="icon-pencil"></i> </button>
                              <button class="btn btn-xs btn-danger"><i class="icon-remove"></i> </button>
                            </div>

                          </td>
                        </tr>           
                           <tr>
                          <td>5</td>
                          <td>Anuksha Sharma</td>
                          <td>Singapore</td>
                          <td>13/32/2012</td>
                          <td>Free</td>
                          <td><span class="label label-danger">Banned</span></td>
                          <td>

                            <div class="btn-group1">
                              <button class="btn btn-xs btn-success"><i class="icon-ok"></i> </button>
                              <button class="btn btn-xs btn-warning"><i class="icon-pencil"></i> </button>
                              <button class="btn btn-xs btn-danger"><i class="icon-remove"></i> </button>
                            </div>

                          </td>
                        </tr>           
                           <tr>
                          <td>5</td>
                          <td>Anuksha Sharma</td>
                          <td>Singapore</td>
                          <td>13/32/2012</td>
                          <td>Free</td>
                          <td><span class="label label-danger">Banned</span></td>
                          <td>

                            <div class="btn-group1">
                              <button class="btn btn-xs btn-success"><i class="icon-ok"></i> </button>
                              <button class="btn btn-xs btn-warning"><i class="icon-pencil"></i> </button>
                              <button class="btn btn-xs btn-danger"><i class="icon-remove"></i> </button>
                            </div>

                          </td>
                        </tr>           
                           <tr>
                          <td>5</td>
                          <td>Anuksha Sharma</td>
                          <td>Singapore</td>
                          <td>13/32/2012</td>
                          <td>Free</td>
                          <td><span class="label label-danger">Banned</span></td>
                          <td>

                            <div class="btn-group1">
                              <button class="btn btn-xs btn-success"><i class="icon-ok"></i> </button>
                              <button class="btn btn-xs btn-warning"><i class="icon-pencil"></i> </button>
                              <button class="btn btn-xs btn-danger"><i class="icon-remove"></i> </button>
                            </div>

                          </td>
                        </tr>           
                           <tr>
                          <td>5</td>
                          <td>Anuksha Sharma</td>
                          <td>Singapore</td>
                          <td>13/32/2012</td>
                          <td>Free</td>
                          <td><span class="label label-danger">Banned</span></td>
                          <td>

                            <div class="btn-group1">
                              <button class="btn btn-xs btn-success"><i class="icon-ok"></i> </button>
                              <button class="btn btn-xs btn-warning"><i class="icon-pencil"></i> </button>
                              <button class="btn btn-xs btn-danger"><i class="icon-remove"></i> </button>
                            </div>

                          </td>
                        </tr>           
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
