﻿<%@ Page Title="Πίνακας Ασθενών" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="peristatika.aspx.vb" Inherits="dimoskopisi.peristatika" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">
        .tooltip123 {
			border-bottom: 1px dotted #000000; color: #000000; outline: none;
			cursor: help; text-decoration: none;
			position: relative;
		}
		.tooltip123 span {
			margin-left: -999em;
			position: absolute;
		}
		.tooltip123:hover span {
			border-radius: 5px 5px; -moz-border-radius: 5px; -webkit-border-radius: 5px; 
			box-shadow: 5px 5px 5px rgba(0, 0, 0, 0.1); -webkit-box-shadow: 5px 5px rgba(0, 0, 0, 0.1); -moz-box-shadow: 5px 5px rgba(0, 0, 0, 0.1);
			font-family: Calibri, Tahoma, Geneva, sans-serif;
			position: absolute; left: 1em; top: 2em; z-index: 99;
			margin-left: 0; width: 250px;
		}
		.tooltip123:hover img {
			border: 0; margin: -10px 0 0 -55px;
			float: left; position: absolute;
		}
		.tooltip123:hover em {
			font-family: Candara, Tahoma, Geneva, sans-serif; font-size: 1.2em; font-weight: bold;
			display: block; padding: 0.2em 0 0.6em 0;
		}
		.classic { padding: 0.8em 1em; }
		.custom { padding: 0.5em 0.8em 0.8em 2em; }
		* html a:hover { background: transparent; }
		.classic {background: #FFFFAA; border: 1px solid #FFAD33; }
		.critical { background: #FFCCAA; border: 1px solid #FF3334;	}
		.help { background: #9FDAEE; border: 1px solid #2BB0D7;	}
		.info { background: #9FDAEE; border: 1px solid #2BB0D7;	}
		.warning { background: #FFFFAA; border: 1px solid #FFAD33; }

    </style>
    <br />
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large"></asp:Label>
    <br />
    <asp:Table ID="Table1" runat="server" CellPadding="6" CellSpacing="2">
    </asp:Table> 
</asp:Content>
