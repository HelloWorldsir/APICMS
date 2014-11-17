<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddProject.aspx.cs" Inherits="Web.Admin.ProjectManagement.AddProject" %>

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
</head>
<body>

    <div class="mainbarLay">
     <div class="matter">
        <div class="container">

          <div class="row">

            <div class="col-md-12">


              <div class="widget wgreen">
                
                <div class="widget-head">
                  <div class="pull-left">Forms</div>
                  <div class="widget-icons pull-right">
                    <a href="#" class="wminimize"><i class="icon-chevron-up"></i></a> 
                    <a href="#" class="wclose"><i class="icon-remove"></i></a>
                  </div>
                  <div class="clearfix"></div>
                </div>

                <div class="widget-content">
                  <div class="padd">

                    <h6>Input Boxs</h6>
                    <hr />
                    <!-- Form starts.  -->
                     <form class="form-horizontal" role="form">
                              
                                <div class="form-group">
                                  <label class="col-lg-4 control-label">Input Box</label>
                                  <div class="col-lg-8">
                                    <input type="text" class="form-control" placeholder="Input Box"/>
                                  </div>
                                </div>
                                
                                <div class="form-group">
                                  <label class="col-lg-4 control-label">Password</label>
                                  <div class="col-lg-8">
                                    <input type="password" class="form-control" placeholder="Password Box"/>
                                  </div>
                                </div>
                                
                                <div class="form-group">
                                  <label class="col-lg-4 control-label">Textarea</label>
                                  <div class="col-lg-8">
                                    <textarea class="form-control" rows="3" placeholder="Textarea"></textarea>
                                  </div>
                                </div>    
                                
                                <div class="form-group">
                                  <label class="col-lg-4 control-label">Checkbox</label>
                                  <div class="col-lg-8">
                                    <label class="checkbox-inline">
                                      <input type="checkbox" id="inlineCheckbox1" value="option1"/> 1
                                    </label>
                                    <label class="checkbox-inline">
                                      <input type="checkbox" id="inlineCheckbox2" value="option2"/> 2
                                    </label>
                                    <label class="checkbox-inline">
                                      <input type="checkbox" id="inlineCheckbox3" value="option3"/> 3
                                    </label>
                                  </div>
                                </div>

                                <div class="form-group">
                                  <label class="col-lg-4 control-label">Radio Box</label>
                                  <div class="col-lg-8">
                                    <div class="radio">
                                      <label>
                                        <input type="radio" name="optionsRadios" id="optionsRadios1" value="option1" checked>
                                        Option one is this and that&mdash;be sure to include why it's great
                                      </label>
                                    </div>
                                    <div class="radio">
                                      <label>
                                        <input type="radio" name="optionsRadios" id="optionsRadios2" value="option2">
                                        Option two can be something else and selecting it will deselect option one
                                      </label>
                                    </div>
                                  </div>
                                </div>
                                
                                <div class="form-group">
                                  <label class="col-lg-4 control-label">Select Box</label>
                                  <div class="col-lg-8">
                                    <select class="form-control">
                                      <option>1</option>
                                      <option>2</option>
                                      <option>3</option>
                                      <option>4</option>
                                      <option>5</option>
                                    </select>
                                  </div>
                                </div>     

                                <div class="form-group">
                                  <label class="col-lg-4 control-label">Select Box</label>
                                  <div class="col-lg-8">
                                    <select multiple class="form-control">
                                      <option>1</option>
                                      <option>2</option>
                                      <option>3</option>
                                      <option>4</option>
                                      <option>5</option>
                                    </select>
                                  </div>
                                </div>   

                                <div class="form-group">
                                  <label class="col-lg-4 control-label">CLEditor</label>
                                  <div class="col-lg-8">
                                    <textarea class="cleditor" name="input"></textarea>
                                  </div>
                                </div>                                 
                                
                                    <hr />
                                <div class="form-group">
                                  <div class="col-lg-offset-1 col-lg-9">
                                    <button type="button" class="btn btn-default">Default</button>
                                    <button type="button" class="btn btn-primary">Primary</button>
                                    <button type="button" class="btn btn-success">Success</button>
                                    <button type="button" class="btn btn-info">Info</button>
                                    <button type="button" class="btn btn-warning">Warning</button>
                                    <button type="button" class="btn btn-danger">Danger</button>
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
