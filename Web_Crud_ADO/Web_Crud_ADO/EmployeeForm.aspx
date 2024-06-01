<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeForm.aspx.cs" Inherits="Web_Crud_ADO.EmployeeForm" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title  %>.</h2>
    <h3>Employee Form</h3>
    <div id="empFormId">

        <table class="nav-justified">
            <tr>
                <td id="empId" style="height: 22px">
                    <asp:Label ID="lbl_empId" runat="server" Enabled="False" Text="Employee Id"></asp:Label>
                </td>
                <td style="height: 22px">
                    <asp:TextBox ID="txt_EmpId" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td id="lbl_firstName" style="height: 20px">First Name</td>
                <td style="height: 20px">
                    <asp:TextBox ID="txt_firstName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td id="lbl_LastName">Last Name</td>
                <td>
                    <asp:TextBox ID="txt_lastName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td id="lbl_email" style="height: 20px">Email</td>
                <td style="height: 20px">
                    <asp:TextBox ID="txt_Email" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td id="lbl_phoneNumber" style="height: 20px">Phone Number</td>
                <td style="height: 20px">
                    <asp:TextBox ID="txt_phoneNumber" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td id="lbl_hireDate" style="height: 20px">Hire Date</td>
                <td style="height: 20px">
                    <asp:TextBox ID="txt_hireDate" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td id="lbl_jobId" style="height: 20px">Job ID</td>
                <td style="height: 20px">
                    <asp:TextBox ID="txt_jobId" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td id="lbl_salary" style="height: 20px">Salary</td>
                <td style="height: 20px">
                    <asp:TextBox ID="txt_salary" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                 <td id="lbl_managerId" style="height: 20px">Manager Id</td>
                <td style="height: 20px">
                    <asp:TextBox ID="txt_managerId" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                 <td id="lbl_deptId" style="height: 20px">Department Id</td>
                <td style="height: 20px">
                    <asp:TextBox ID="txt_deptId" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btn_Insert" runat="server" Text="INSERT" OnClick="btnInsert_Click" />
                </td><td></td>
            </tr>
            <tr>
                <td></td><td></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:GridView ID="Employee_Grid" runat="server">
                    </asp:GridView>
                </td><td></td>
            </tr>
            </table>

    </div>
</asp:Content>
