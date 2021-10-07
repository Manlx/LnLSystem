<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LnLWebEndSystem.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<meta http-equiv="Cache-Control" content="no-cache, no-store, must-revalidate">
        <meta http-equiv="Pragma" content="no-cache">
        <meta http-equiv="Expires" content="0">
    <title>Login</title>
    <link rel="preconnect" href="https://fonts.gstatic.com" />
		<link
			href="https://fonts.googleapis.com/css2?family=Rubik:wght@400;600;700&display=swap"
			rel="stylesheet"
		/>
    <link href="Styles/general.css" rel="stylesheet" />
    <link href="Styles/style.css" rel="stylesheet" />
</head>
<body>
	<header class="header">
			<div>
				<img class="logo" alt="logo" src="Styles/images/Logo-removebg-preview_1.png" />
			</div>

			<nav class="main-nav">
				<ul class="main-nav-list">
					<li>
						<a href="index.aspx" class="main-nav-link">Go back to homepage</a>
					</li>
				</ul>
			</nav>
		</header>

		<main>
			<section class="section-reg">
				<div class="reg-container cta">
					<div class="reg-text">
						<h2>Welcome back!</h2>

						<form class="reg-form" id="form1" runat="server">
							<div>
								<label for="txtID">ID</label>
								<asp:TextBox class="inputText" runat="server" ID="txtID" placeholder="Eugene Coetzee" required="true"></asp:TextBox>
							</div>

							<div>
								<label for="txtPass">Password</label>
								<asp:TextBox class="inputText" runat="server" ID="txtPass" placeholder="ID here" type="email" required="true"></asp:TextBox>
							</div>	
							
						    <asp:Button class="btn btn--form" runat="server" ID="btnLogin" Text="Login" OnClick="btnLogin_Click"/>
							
							<div>
								<asp:CheckBox style="width: 2rem; height: 2rem;" ID="chkRememberMe" runat="server" />
								<label style="display: inline-block; padding-left: 1rem;" for="chkRememberMe">Remember me </label>
							</div>
						        

						</form>
					</div>
					<div class="login-img" role="img" aria-label="cocktails"></div>
				</div>
			</section>
		</main>
</body>
</html>
