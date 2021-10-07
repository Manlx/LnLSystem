<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="LnLWebEndSystem.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
	<head runat="server">
		<meta http-equiv="Cache-Control" content="no-cache, no-store, must-revalidate">
        <meta http-equiv="Pragma" content="no-cache">
        <meta http-equiv="Expires" content="0">
		<title>Luke & Liam's lodge by the lake</title>

		<link rel="preconnect" href="https://fonts.gstatic.com" />
			<link
				href="https://fonts.googleapis.com/css2?family=Rubik:wght@400;600;700&display=swap"
				rel="stylesheet"
			/>
		 <link href="Styles/general.css" rel="stylesheet" />
        <link href="Styles/style.css" rel="stylesheet" />
	</head>
	<body runat="server">
		<header class="header">
			<div>
				<img class="logo" alt="logo" src="Styles/images/Logo-removebg-preview_1.png" />
			</div>

			<nav class="main-nav">
				<ul class="main-nav-list">
					<li><a href="login.aspx" class="main-nav-link">Login</a></li>
					<li><a href="#" class="main-nav-link">Book</a></li>
					<li><a href="#" class="main-nav-link">Help</a></li>
				</ul>
			</nav>
		</header>

		<main>
			<section class="hero">
				<div class="header-container-inner">
					<h1>Enjoy the slower moments in a fast and busy life</h1>
					<p>
						Have a relaxing breakaway from the hustle and bustle of everyday
						life. Take in the breathtaking nature while enjoying luxurious
						five-star service.
					</p>
					<a href="#regForm" class="btn">Sign up for free</a>
				</div>
			</section>

			<section class="section-food">
				<div class="container grid grid--2-cols food-grid">
					<div class="food-img-container">
						<img class="food-img" src="Styles/images/food.jpg" alt="chef holding food" />
					</div>

					<div class="food-description food-grid">
						<h2 class="header-secondary food-grid">
							5-star meals at an affordable price
						</h2>
						<p class="section-text">
							Whether it be local favourites, healthy alternatives or the guilty
							pleasures of comfort food, our chefs craft every meal with the
							care and respect it deserves.
						</p>
					</div>
				</div>
			</section>

			<section class="section-locations">
				<div class="container grid grid--2-cols location-grid">
					<div class="location-description food-grid">
						<h2 class="header-secondary food-grid">The perfect location</h2>
						<p class="section-text">
							Our lodge is in a magical setting, surrounded by lush greens and a
							peaceful atmosphere, always only a few steps away from the
							beautiful le Roux lake.
						</p>
					</div>

					<div class="food-img-container">
						<img
							class="location-img"
							src="Styles/images/xavier-souty-G2GfUWZgMS0-unsplash.jpg"
							alt="chef holding food"
						/>
					</div>
				</div>
			</section>

			<section class="section-reg">
				<div class="reg-container cta">
					<div class="reg-text">
						<h2>Sign up now for free!</h2>
						<p class="reg-p-text">
							Register here for hassle-free bookings to your next getaway.
						</p>

						<a id="regForm"></a>
						
						<form class="reg-form" id="form1" runat="server">
						

							<div>
								<label for="txtName">Name</label>
								<asp:TextBox class="inputText" runat="server" ID="txtName" placeholder="Eugene" required="true"></asp:TextBox>
							</div>

							<div>
								<label for="txtSurname">Surname</label>
								<asp:TextBox class="inputText" runat="server" ID="txtSurname" placeholder="Coetzee" required="true"></asp:TextBox>
							</div>

							<div>
								<label for="txtCell">Cellphone number</label>
								<asp:TextBox class="inputText" runat="server" ID="txtCell" placeholder="0875554444" required="true"></asp:TextBox>
							</div>

							<div>
								<label for="txtEmailAddress">Email</label>
								<asp:TextBox class="inputText" runat="server" ID="txtEmailAddress" type="Email" placeholder="example@gmail.com" required="true"></asp:TextBox>
							</div>

							<div>
								<label for="txtPassword">Password</label>
								<asp:TextBox class="inputText" runat="server" ID="txtPassword" required="true" TextMode="Password"></asp:TextBox>
							</div>

							<asp:Button class="btn btn--form" runat="server" ID="btnRegister" Text="Sign up now" OnClick="btnRegister_Click"/>
						    <br />
                            <asp:Label ID="lblMessage" runat="server" Text="Label" Visible="False"></asp:Label>
						</form>
					</div>
					<div class="reg-img" role="img" aria-label="Woman eating"></div>
				</div>
			</section>
		</main>
	</body>
</html>
