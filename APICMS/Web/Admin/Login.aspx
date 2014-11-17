<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web.Admin.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
 
  <!-- Title and other stuffs -->
  <title>后台登陆页面</title> 
  <meta name="keywords" content="后台管理系统" />
  <meta name="description" content="" />
  <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
  <meta name="author" content=""/>
  <!-- Stylesheets -->
  <link href="style/bootstrap.css" rel="stylesheet"/>
  <link rel="stylesheet" href="style/font-awesome.css"/>
  <link href="style/style.css" rel="stylesheet"/>
  <link href="style/bootstrap-responsive.css" rel="stylesheet"/>
  
  <!-- HTML5 Support for IE -->
  <!--[if lt IE 9]>
  <script src="js/html5shim.js"></script>
  <![endif]-->

  <!-- Favicon -->
  <link rel="shortcut icon" href="img/favicon/favicon.png"/>
</head>
<body>
    <!-- Form area -->
<div class="admin-form">
  <div class="container">

    <div class="row">
      <div class="col-md-12">
        <!-- Widget starts -->
            <div class="widget worange">
              <!-- Widget head -->
              <div class="widget-head">
                <i class="icon-lock"></i> 登录 
              </div>

              <div class="widget-content">
                <div class="padd">
                  <!-- Login form -->
                  <form class="form-horizontal" action="Login.aspx" method="post">
                    <!-- Email -->
                    <div class="form-group">
                      <label class="control-label col-lg-3" for="inputEmail">用户名</label>
                      <div class="col-lg-9">
                        <input type="text" class="form-control" id="inputEmail" placeholder="Email" name="username"/>
                      </div>
                    </div>
                    <!-- Password -->
                    <div class="form-group">
                      <label class="control-label col-lg-3" for="inputPassword">密   码</label>
                      <div class="col-lg-9">
                        <input type="password" class="form-control" id="inputPassword" name="password" placeholder="Password"/>
                      </div>
                    </div>
                    <!-- Remember me checkbox and sign in button -->
                    <div class="form-group">
					<div class="col-lg-9 col-lg-offset-3">
                      <div class="checkbox">
                        <label>
                          <input type="checkbox" checked="checked"/> 记住密码
                        </label>
						</div>
					</div>
					</div>
                        <div class="col-lg-9 col-lg-offset-2">
							<button type="submit" class="btn btn-danger">登录</button>
							<button type="reset" class="btn btn-default">重置</button>
						</div>
                    <br />
                  </form>
				  
				</div>
                </div>
               
                <div class="widget-foot">
                  未注册? <a href="register.aspx">点击注册</a>
                </div>
            </div>  
      </div>
    </div>
  </div> 
</div>
	
		

<!-- JS -->
<script src="js/jquery.js"></script>
<script src="js/bootstrap.js"></script>
</body>
</html>
