﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Formular.aspx.cs" Inherits="VacationLocation.Formular" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h3>Formular</h3>

    <table class="nav-justified">
        <tr>
            <td style="width: 227px">Varsta dumneavoastra:</td>
            <td style="width: 128px">
                <asp:TextBox ID="txtAge" runat="server" Width="245px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="reqAge" runat="server" ControlToValidate="txtAge" ErrorMessage="Camp obligatoriu" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 227px">&nbsp;</td>
            <td style="width: 128px">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 227px">Status social:</td>
            <td style="width: 128px">
                <asp:DropDownList ID="ddStatus" runat="server">
                    <asp:ListItem Selected="True"></asp:ListItem>
                    <asp:ListItem>Single</asp:ListItem>
                    <asp:ListItem>In o relatie/Casatorit(a)</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ddStatus" ErrorMessage="Camp obligatoriu" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 227px">&nbsp;</td>
            <td style="width: 128px">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 227px; height: 21px;">Aveti copii?</td>
            <td style="width: 128px; height: 21px;">
                <asp:RadioButton ID="rbYes" runat="server" Text="Da" GroupName="kids" />
                <asp:RadioButton ID="rbNo" runat="server" Text="Nu" GroupName="kids" />
            </td>
            <td style="height: 21px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 227px">&nbsp;</td>
            <td style="width: 128px">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 227px">Loc de nastere:</td>
            <td style="width: 128px">
                <asp:TextBox ID="txtBirthPlace" runat="server" Width="245px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtBirthPlace" ErrorMessage="Camp obligatoriu" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 227px">&nbsp;</td>
            <td style="width: 128px">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 227px">Loc de resedinta:</td>
            <td style="width: 128px">
                <asp:TextBox ID="txtLivingPlace" runat="server" Width="245px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtLivingPlace" ErrorMessage="Camp obligatoriu" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 227px">&nbsp;</td>
            <td style="width: 128px">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <!-- ToDo: add more options like tropical-->
            <td style="width: 227px; height: 22px;">Preferinte clima:</td>
            <td style="width: 128px; height: 22px">
                <asp:DropDownList ID="ddClimate" runat="server">
                    <asp:ListItem Selected="True"></asp:ListItem>
                    <asp:ListItem Value="hotClimate">Cald - America de sud, India, Ecuator</asp:ListItem>
                    <asp:ListItem Value="tempClimate">Temperat - Europa centrala si de vest, Coasta de Est a Americii de Nord</asp:ListItem>
                    <asp:ListItem Value="coldClimate">Rece - Suedia, Norvegia, Canada, Tarile Baltice</asp:ListItem>
                    <asp:ListItem Value="anyClimate">Orice clima</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="height: 22px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="ddClimate" ErrorMessage="Camp obligatoriu" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 227px; height: 22px;">&nbsp;</td>
            <td style="width: 128px; height: 22px">
                &nbsp;</td>
            <td style="height: 22px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 227px">Genul de destinatie:</td>
            <td style="width: 128px">
                <asp:DropDownList ID="ddDestination" runat="server">
                    <asp:ListItem Selected="True"></asp:ListItem>
                    <asp:ListItem Value="bigCity">Oras mare/capitala - multe atractii turistice clasice, cultura, parcuri, etc.</asp:ListItem>
                    <asp:ListItem Value="smallDest">Oras mediu/provincie - atractii turistice alternative, mai putina aglomeratie.</asp:ListItem>
                    <asp:ListItem Value="tinyDest">Sat/comuna/zona izolata - agroturism, liniste, tratamente balneo-climaterice, traditii locale, etc.</asp:ListItem>
                    <asp:ListItem Value="anyDest">Orice destinatie</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="ddDestination" ErrorMessage="Camp obligatoriu" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 227px">&nbsp;</td>
            <td style="width: 128px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>

        <tr>
            <td style="width: 227px">Tipul de relief:</td>
            <td style="width: 128px">
                <asp:DropDownList ID="ddRelief" runat="server">
                    <asp:ListItem Selected="True"></asp:ListItem>
                    <asp:ListItem Value="mare">Mare</asp:ListItem>
                    <asp:ListItem Value="campie">Campie</asp:ListItem>
                    <asp:ListItem Value="podis">Podis</asp:ListItem>
                    <asp:ListItem Value="munte">Munte</asp:ListItem>
                    <asp:ListItem Value="desert">Desert</asp:ListItem>
                    <asp:ListItem Value="anyRel">Orice destinatie</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="ddRelief" ErrorMessage="Camp obligatoriu" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 227px">&nbsp;</td>
            <td style="width: 128px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
 
        <tr>
            <td style="width: 227px">&nbsp;</td>
            <td style="width: 128px">
                <asp:Button ID="btnSubmit" runat="server" OnClick="Button1_Click" Text="Submit" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 227px">&nbsp;</td>
            <td style="width: 128px">
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConexiuneaLuiDumnezeu %>" SelectCommand="SELECT * FROM [Destinatii]"></asp:SqlDataSource>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>
