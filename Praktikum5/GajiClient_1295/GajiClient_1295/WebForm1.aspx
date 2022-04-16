<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="GajiClient_1295.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="1">
                <tr>
                    <th colspan="2">Use of Web Service</th>
                </tr>
                <tr>
                    <th align="left">NIK : </th>
                    <td>
                        <asp:TextBox ID="txtNik" runat="server" />
                    </td>
                </tr>
                <tr>
                    <th align="left">Nama : </th>
                    <td>
                        <asp:TextBox ID="txtNama" runat="server" />
                    </td>
                </tr>
                <tr>
                    <th align="left">Jabatan : </th>
                    <td>
                        <asp:TextBox ID="txtJabatan" runat="server" />
                    </td>
                </tr>
                <tr>
                    <th align="left">Gaji Pokok : </th>
                    <td>
                        <asp:TextBox ID="txtGapok" runat="server" />
                    </td>
                </tr>
                <tr>
                    <th align="left">Tunjangan : </th>
                    <td>
                        <asp:TextBox ID="txtTunjangan" runat="server" />
                    </td>
                </tr>
                <tr>
                    <th align="left">Potongan : </th>
                    <td>
                        <asp:TextBox ID="txtPotongan" runat="server" />
                    </td>
                </tr>
                <tr>
                    <th align="left">Pph (%): </th>
                    <td>
                        <asp:TextBox ID="txtPph" runat="server" />
                    </td>
                </tr>
                <tr>
                    <th colspan="2">
                        <asp:Button ID="btnHitung" runat="server" Text="Total Gaji" OnClick="btnHitung_Click" />
                    </th>
                </tr>
                <tr>
                    <th colspan="2">
                        <asp:Label ID="lblTotal" runat="server" Text="Rp. " />
                    </th>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
