<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="eMenu.UI.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page-container page-content-inner page-container-bg-solid">
        <!-- BEGIN BREADCRUMBS -->
        <div class="breadcrumbs">
            <div class="container-fluid">
                <h2 class="breadcrumbs-title">Dashboard</h2>
                <ol class="breadcrumbs-list">
                    <li>
                        <a class="breadcrumbs-item-link" href="#">Home</a>
                    </li>
                    <li>
                        <a class="breadcrumbs-item-link" href="#">Features</a>
                    </li>
                    <li>
                        <a class="breadcrumbs-item-link" href="#">Dashboard</a>
                    </li>
                </ol>
            </div>
        </div>

    <div class="row widget-row">
                    <div class="col-md-3">
                        <!-- BEGIN WIDGET THUMB -->
                        <div class="widget-thumb widget-bg-color-white text-uppercase margin-bottom-20 ">
                            <h4 class="widget-thumb-heading">Current Orders</h4>
                            <div class="widget-thumb-wrap">
                                <i class="widget-thumb-icon bg-red icon-screen-desktop"></i>
                                <div class="widget-thumb-body">
                                    <span class="widget-thumb-subtitle"></span>
                                    <span class="widget-thumb-body-stat" data-counter="counterup" data-value="20">0</span>
                                </div>
                            </div>
                        </div>
                        <!-- END WIDGET THUMB -->
                    </div>
                    <div class="col-md-3">
                        <!-- BEGIN WIDGET THUMB -->
                        <div class="widget-thumb widget-bg-color-white text-uppercase margin-bottom-20 ">
                            <h4 class="widget-thumb-heading">Complete Orders</h4>
                            <div class="widget-thumb-wrap">
                                <i class="widget-thumb-icon bg-green icon-layers"></i>
                                <div class="widget-thumb-body">
                                    <span class="widget-thumb-subtitle"></span>
                                    <span class="widget-thumb-body-stat" data-counter="counterup" data-value="60">0</span>
                                </div>
                            </div>
                        </div>
                        <!-- END WIDGET THUMB -->
                    </div>
                    <%--<div class="col-md-3">
                        <!-- BEGIN WIDGET THUMB -->
                        <div class="widget-thumb widget-bg-color-white text-uppercase margin-bottom-20 ">
                            <h4 class="widget-thumb-heading">Biggest Purchase</h4>
                            <div class="widget-thumb-wrap">
                                <i class="widget-thumb-icon bg-purple icon-screen-desktop"></i>
                                <div class="widget-thumb-body">
                                    <span class="widget-thumb-subtitle">USD</span>
                                    <span class="widget-thumb-body-stat" data-counter="counterup" data-value="815">0</span>
                                </div>
                            </div>
                        </div>
                        <!-- END WIDGET THUMB -->
                    </div>
                    <div class="col-md-3">
                        <!-- BEGIN WIDGET THUMB -->
                        <div class="widget-thumb widget-bg-color-white text-uppercase margin-bottom-20 ">
                            <h4 class="widget-thumb-heading">Average Monthly</h4>
                            <div class="widget-thumb-wrap">
                                <i class="widget-thumb-icon bg-blue icon-bar-chart"></i>
                                <div class="widget-thumb-body">
                                    <span class="widget-thumb-subtitle">USD</span>
                                    <span class="widget-thumb-body-stat" data-counter="counterup" data-value="5,071">0</span>
                                </div>
                            </div>
                        </div>
                        <!-- END WIDGET THUMB -->
                    </div>--%>
                </div>





</asp:Content>
