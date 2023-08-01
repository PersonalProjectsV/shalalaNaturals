<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="shalalaNaturals.Pages.Account.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <style>
                .everything{color:#9dc15b;padding-bottom:100px;}
        h2{color:#9dc15b}
    </style>
</asp:Content>
<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder3" runat="server" >REGISTER</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="everything">
    <p>
        <asp:Literal runat="server" ID="litStatusMessage" />

    </p>
        </div>

    <div class="modal-dialog modal-dialog-centered modal-lg" role="document">
		<div class="modal-content">

			<div class="modal-body customer-box">
				<!-- Nav tabs -->
				<ul class="nav nav-tabs">
					<li><a  data-toggle="tab">Registration</a></li>
				</ul>
				<!-- Tab panes -->
				<div class="tab-content">
					<div class="tab-pane active" id="Registration">
						<form role="form" class="form-horizontal">
							<div class="form-group">
								<div class="col-sm-12">

									  User name:<br />
    <asp:TextBox runat="server" ID="txtUserName" placeholder="Username" CssClass="form-control" /><br />

									    First Name:<br />
    <asp:TextBox runat="server"  ID="txtFirstName" CssClass="form-control" placeholder="First Name" /><br />

    Last Name:<br />
    <asp:TextBox runat="server" ID="txtLastName" placeholder="Last Name" CssClass="form-control" /><br />





    Email Address:<br />
    <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control"  AutoCompleteType="Email" TextMode="Email"/><br />
								</div>
							</div>					
							<div class="form-group">
								<div class="col-sm-12">
									    Password:
    <br />
    <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" CssClass="form-control" /><br />

									    Confirm password:
    <br />
    <asp:TextBox runat="server" ID="txtConfirmPassword" TextMode="Password" CssClass="form-control" /><br />
								</div>
							</div>
														<div class="form-group">
								<div class="col-sm-12">

    Mobile Number:<br />
    <asp:TextBox runat="server" ID="number" TextMode="Number" AutoCompleteType="Cellular"  placeholder="0842567831" CssClass="form-control" /><br />
								</div>
							</div>

														<div class="form-group">
								<div class="col-sm-12">

    Address Line 1:<br />
    <asp:TextBox runat="server" ID="address1" CssClass="form-control" AutoCompleteType="HomeStreetAddress" Text="Street address, P.O. box, company name"/><br />
								</div>
							</div>

														<div class="form-group">
								<div class="col-sm-12">

    Address Line 2:<br />
    <asp:TextBox runat="server" ID="address2" CssClass="form-control" Text="Apartment, suite, unit, building, floor, etc." AutoCompleteType="HomeStreetAddress"  /><br />
								</div>
							</div>

														<div class="form-group">
								<div class="col-sm-12">

    City:<br />
    <asp:TextBox runat="server" ID="city" placeholder="Johannesburg" CssClass="form-control" /><br />
								</div>
							</div>

														<div class="form-group">
								<div class="col-sm-12">

    Province:<br />
	<asp:DropDownList runat="server" CssClass="form-control" ID="province">
		<asp:ListItem Text="Eastern Cape" Value="Eastern Cape"></asp:ListItem>
		<asp:ListItem Text="Free State" Value="Free State"></asp:ListItem>
		<asp:ListItem Text="Gauteng" Value="Gauteng"></asp:ListItem>
		<asp:ListItem Text="KwaZulu-Natal" Value="KwaZulu-Natal"></asp:ListItem>
        <asp:ListItem Text="Limpopo" Value="Limpopo"></asp:ListItem>
		<asp:ListItem Text="Mpumalanga" Value="Mpumalanga"></asp:ListItem>
		<asp:ListItem Text="Northern Cape" Value="Northern Cape"></asp:ListItem>
		<asp:ListItem Text="North West" Value="North West"></asp:ListItem>
		<asp:ListItem Text="Western Cape" Value="Western Cape"></asp:ListItem>
	</asp:DropDownList>

									<br />
								</div>
							</div>

														<div class="form-group">
								<div class="col-sm-12">

    Zip Code:<br />
    <asp:TextBox runat="server" TextMode="Number" ID="zipCode" placeholder="####" CssClass="form-control" /><br />
								</div>
							</div>

							<div class="row">							
								<div class="col-sm-10">
									<asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" CssClass="btn btn-light btn-radius btn-brd grd1" />
								</div>
							</div>
						</form>
					</div>
				</div>
			</div>
		</div>
	  </div>
</asp:Content>
