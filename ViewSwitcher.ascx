﻿<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ViewSwitcher.ascx.vb" Inherits="dimoskopisi.ViewSwitcher" %>
<div id="viewSwitcher">
    <%: CurrentView %> view | <a href="<%: SwitchUrl %>">Switch to <%: AlternateView %></a>
</div>
