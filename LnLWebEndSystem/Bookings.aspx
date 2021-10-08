<!--E Coetzee - 34374469-->

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

    <section class="section-reg">
		<h2 style="padding: 0 5rem"> Schedule a booking by filling out the fields below.</h2>      
        <p  style="padding: 0 5rem"> Feel free to email us at lodgebythelake@gmail.com for direct confirmation/queries</p>

		<div class="reg-container">
			<form class="reg-form"  id="form1" runat="server">
				<div>
					<label for="txtID">ID</label>
		            <asp:TextBox class="inputText" runat="server" ID="txtID" placeholder="01" required="true"></asp:TextBox>
				</div>

				<div>
					<label for="txtTime">What time is your event</label>
		            <asp:TextBox class="inputText" runat="server" ID="txtTime" placeholder="14:00" required="true"></asp:TextBox>
				</div>

		        <div>
			        <label for="eventList">Choose the type of event you are hosting.</label>
                    <asp:DropDownList class="inputText" ID="eventList" runat="server">
                        <asp:ListItem>Birthday party</asp:ListItem>
                        <asp:ListItem>Stag party</asp:ListItem>
                        <asp:ListItem>Wedding</asp:ListItem>
                        <asp:ListItem>Reunion</asp:ListItem>
                        <asp:ListItem>Music show</asp:ListItem>
                        <asp:ListItem>Party</asp:ListItem>
                        <asp:ListItem>Conference</asp:ListItem>
                    </asp:DropDownList>
		        </div>

    		    <div>
	    	    	<label for="locationList">What location would you like to make use of</label>
		        	<asp:DropDownList class="inputText" ID="locationList" runat="server">
                        <asp:ListItem>Main hall</asp:ListItem>
                        <asp:ListItem>Outdoor chapel</asp:ListItem>
                        <asp:ListItem>Lakeside</asp:ListItem>
                        <asp:ListItem>Garden hall</asp:ListItem>
                        <asp:ListItem>Railway photoshoot</asp:ListItem>
                        <asp:ListItem>Large field</asp:ListItem>
                        <asp:ListItem>Old hall</asp:ListItem>
                        <asp:ListItem>Tree-Forest</asp:ListItem>
                    </asp:DropDownList>
    		    </div>

	    	    <div>
		    	   <label>Use the calander below to select a date for the event </label>
                   <asp:Calendar ID="cldDate" runat="server" Height="300px" Width="700px" BackColor="White" BorderColor="Black" DayNameFormat="Shortest" Font-Names="Times New Roman" Font-Size="10pt" ForeColor="Black" NextPrevFormat="FullMonth" TitleFormat="Month">
                       <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" ForeColor="#333333" Height="14pt" />
                       <DayStyle Width="16%" />
                       <NextPrevStyle Font-Size="9pt" ForeColor="White" />
                       <OtherMonthDayStyle ForeColor="#999999" />
                       <SelectedDayStyle BackColor="#CC3333" ForeColor="White" />
                       <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#333333" Width="1%" />
                       <TitleStyle BackColor="Black" Font-Bold="True" Font-Size="13pt" ForeColor="White" Height="14pt" />
                       <TodayDayStyle BackColor="#CCCC99" />
                    </asp:Calendar> 
	            </div>
				<div></div>
			    <asp:Button class="btn btn--form" runat="server" ID="btnBook" Text="Book" OnClick="btnBook_Click" />
                <asp:Label ID="lblMessage" runat="server" Text="Label" Visible="False"></asp:Label>
	        </form>
		</div>		
    </section>

</body>
</html>
