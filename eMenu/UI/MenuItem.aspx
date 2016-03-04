<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MenuItem.aspx.cs" Inherits="eMenu.UI.MenuItem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   <div class="portlet-body form" style="display: block;">
        <!-- BEGIN FORM-->
        <form id="Master" action="#" class="horizontal-form">
            <div class="form-body">
                <h3 class="form-section">Food Category </h3>
                <label id="lblItemCode" class="control-label"></label>
                <div class="row">
                    <div class="col-md-6">
                        <div class="form-group">
                            <label class="control-label">Food Category Name</label>
                            <input type="text" id="txtFItemName" class="form-control" placeholder="-Category Name-">
                        </div>
                    </div>
                    <!--/span-->
                    
                    <!--/span-->
                </div>
                <!--/row-->
                <div class="row">
                    <div class="col-md-6">
                        <div class="form-group">
                            <label class="control-label">Image of Food Category</label>
                            <input id="CatImg" type="file" name="pic" accept="image/*" class="form-control" placeholder="">
                            
                        </div>
                    </div>
                    <!--/span-->
                    <div class="col-md-1">
                        </br></br></br>
                        <div id="btnb1" class="form-group">

                                <button id="btnAddCat" type="button" class="btn green-meadow" style="width: 120px" onclick="">Add Category</button>
                        </div>
                    </div>
                 </div>


                    <!--/span-->

                    <!--/span-->
               

                <!--/row-->
            </div>
            <!--/row-->
            
        </form>

       <form id="Master2" action="#" class="horizontal-form">
            <div class="form-body">
                <h3 class="form-section">Food Items </h3>
                <label id="lblItemCode1" class="control-label"></label>
                <div class="row">
                    <div class="col-md-6">
                        <div class="form-group">
                            <label class="control-label">Food Name</label>
                            <input type="text" id="txtFoodName" class="form-control" placeholder="-Food Name-">
                        </div>
                    </div>
                    <!--/span-->
                    
                    <!--/span-->
                </div>
                <!--/row-->
                <div class="row">
                    <div class="col-md-6">
                        <div class="form-group">
                            <label class="control-label">Image of Food</label>
                            <input id="CatFoodImg" type="file" name="pic" accept="image/*" class="form-control" placeholder="">
                            
                        </div>
                    </div>
                    <!--/span-->
                    <div class="col-md-1">
                        </br></br></br>
                        <div id="btnb" class="form-group">

                                <button id="btnAddFood" type="button" class="btn green-meadow" style="width: 120px" onclick="">Add Food</button>
                        </div>
                    </div>
                 </div>


                    <!--/span-->

                    <!--/span-->
               

                <!--/row-->
            </div>
            <!--/row-->
            
        </form>
        <!-- END FORM-->
    </div>


</asp:Content>
