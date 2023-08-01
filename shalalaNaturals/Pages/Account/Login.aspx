<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="shalalaNaturals.Pages.Account.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
                                .everything{color:#9dc15b; padding-bottom:100px;}
        h2{color:#9dc15b}
            </style>
</asp:Content>
<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder3" runat="server" >LOGIN</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="everything">
    <asp:Literal runat="server" ID="litErrorMsg" Text="Invalid username or password." Visible="false" />
        





	  <div class="modal-dialog modal-dialog-centered modal-lg" role="document">
		<div class="modal-content">
			
			<div class="modal-body customer-box">
				<!-- Nav tabs -->
				<ul class="nav nav-tabs">
					<li><a class="active" href="#Login" data-toggle="tab">Login</a></li>
				</ul>
				<!-- Tab panes -->
				<div class="tab-content">
					<div class="tab-pane active" id="Login">
						<form role="form" class="form-horizontal">
							<div class="form-group">
								<div class="col-sm-12">
									<asp:TextBox runat="server" ID="txtUserName" CssClass="form-control"  placeholder="Username" />
								</div>
							</div>
							<div class="form-group">
								<div class="col-sm-12">
									<asp:TextBox runat="server"  ID="txtPassword" TextMode="Password" CssClass="form-control" />
								</div>
							</div>
							<div class="row">
								<div class="col-sm-10">
									
									<asp:Button ID="btnSignIn" runat="server" Text="Submit" OnClick="btnSignIn_OnClick" CssClass="btn btn-light btn-radius btn-brd grd1" />
									<asp:Literal runat="server" ID="litStatus" Visible="false" />
								</div>
							</div>
						</form>
					</div>
					
				</div>
			</div>
		</div>
	  </div>
	</div>
</asp:Content>
