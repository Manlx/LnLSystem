<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bookings.aspx.cs" Inherits="LnLWebEndSystem.Bookings" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Cache-Control" content="no-cache, no-store, must-revalidate">
        <meta http-equiv="Pragma" content="no-cache">
        <meta http-equiv="Expires" content="0">
		<title>Bookings</title>

		<link rel="preconnect" href="https://fonts.gstatic.com" />
			<link
				href="https://fonts.googleapis.com/css2?family=Rubik:wght@400;600;700&display=swap"
				rel="stylesheet"
			/>
		 <link href="Styles/general.css" rel="stylesheet" />
        <link href="Styles/style.css" rel="stylesheet" />
</head>
<body>
    <header>
        <h1> Schedule a booking by filling out the fields below.</h1>      
        <p> Feel free to email us at lodgebythelake@gmail.com for direct confirmation/queries</p>
    </header>
    <form class="reg-form" id="form1" runat="server">
		<div>
			<label for="fullName">Full name</label>
			<asp:TextBox class="inputText" runat="server" ID="e" placeholder="Eugene Coetzee" required="true"></asp:TextBox>
		</div>

		<div>
			<label for="email">Email adress</label>
			<asp:TextBox class="inputText" runat="server" ID="email" placeholder="example@gmail.com" type="email" required="true"></asp:TextBox>
		</div>

			<asp:Button class="btn btn--form" runat="server" ID="btnLogin" Text="Login" OnClick="btnLogin_Click"/>
	</form>
</body>
</html>
