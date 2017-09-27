<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChequeInput.aspx.cs" Inherits="AKQA.Web.ChequeInput" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="/assets/bootstrap.min.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="col-lg-4 col-md-6">
            <h1>Cheque</h1>
            <div class="form-group">
                <label class="control-label">Person's name</label>
                <input class="form-control" type="text" id="nameInput" runat="server" />
            </div>
            <div class="form-group">
                <label class="control-label">Amount</label>
                <input class="form-control" type="text" id="amountInput" runat="server" />
            </div>
            <div class="form-group">
                <button type="submit" class="btn btn-primary" id="btnSubmit" runat="server" onserverclick="btnSubmit_ServerClick">Submit</button>
            </div>
            <div id="divAlert" runat="server"></div>
        </div>
    </form>
</body>
</html>
