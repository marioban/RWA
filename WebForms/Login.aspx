<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebForms.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/login.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container login-container">
            <div class="row">

                <div class="col-md-6 lijevaStrana text-center">
                    <h3>Prijava</h3>

                    <div class="form-group">
                        <input id="txtEmail" type="email" class="form-control" placeholder="Vaša Email Adresa" value="" runat="server" />
                    </div>

                    <div class="form-group">
                        <input id="txtPw" type="password" class="form-control" placeholder="Vaša Lozinka" value="" runat="server" />
                    </div>

                    <div class="form-group">
                        <input type="submit" class="btnPrijava" value="Prijava" />
                    </div>


                    <div class="form-group">
                        <p id="lblUspjeh" class="ForgetPwd" runat="server"></p>
                    </div>


                </div>


                <div class="col-md-6 desnaStrana">

                    <h3>RWA Projekt</h3>
                    <h5>Prijavite se</h5>

                </div>

            </div>

        </div>
    </form>
</body>
</html>
