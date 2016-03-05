<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MenuItem.aspx.cs" Inherits="eMenu.UI.MenuItem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script type="text/javascript">

        function GetCategory() {

            $.ajax({
                url: "../Services/MenuService.asmx/GetAllCategories",
                dataType: "json",
                contentType: "application/json; charset=utf-8",
                type: "POST",
                success: function (result) {
                    var html = "";
                    html += "<select id=cmbCat class=form-control >";
                    for (var i = 0; i < result.d.length; i++) {

                        html += "<option value=" + result.d[i].Catid + ">" + result.d[i].itemname + "</option>";
                    }

                    html += "</select>";

                    $('#divCat').append(html);
                }, error: function (request, status, error) {
                    alert("Error! Cannot Load Categorie.");
                }
            });
        }


        function InsertCat() {

            var txtItemName = document.getElementById("txtFItemName").value.trim();

            var sendData = JSON.stringify({ itemName: txtItemName });

            $.ajax({

                url: "../Services/MenuService.asmx/SaveItem",
                data: sendData,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                type: "POST",
                success: function (result) {

                    alert("Added");
                    popHTMLContent = '<div class="alert alert-success"><strong>Success!</strong> The recored has been added.</div>';
                    bootbox.dialog({
                        message: popHTMLContent,
                        title: "",
                        closeButton: true,
                    });



                }, error: function (request, status, error) {

                    alert("Error");
                    popHTMLContent = '<div class="alert alert-danger"><strong>Error!</strong> Please fill the Customer Name & Phone No.</div>';
                    bootbox.dialog({
                        message: popHTMLContent,
                        title: "<h3 class='page-title'>Invalid details<small></small></h3>",
                        closeButton: true,
                    });
                }
            });
        }

        function InsertFood() {


            var txtFoodName = document.getElementById("txtFoodName").value.trim();


            var txtprice = document.getElementById("txtPrice").value.trim();
            //var txtQuantity = document.getElementById("txtQty").value;

            var e = document.getElementById("cmbCat");
            var Category = e.options[e.selectedIndex].value.trim();

            var sendData = JSON.stringify({ name: txtFoodName, price: txtprice, CatId: Category });

            $.ajax({

                url: "../Services/FoodItemsService.asmx/SaveItem",
                data: sendData,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                type: "POST",
                success: function (result) {

                    popHTMLContent = '<div class="alert alert-success"><strong>Success!</strong> The page has been added. </div>';
                    bootbox.dialog({
                        message: popHTMLContent,
                        title: "",
                        closeButton: true,
                    });



                }, error: function (request, status, error) {

                    popHTMLContent = '<div class="alert alert-danger"><strong>Error!</strong> Please fill the Customer Name & Phone No.</div>';
                    bootbox.dialog({
                        message: popHTMLContent,
                        title: "<h3 class='page-title'>Invalid details<small></small></h3>",
                        closeButton: true,
                    });
                }
            });
        }

    </script>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <body onload="GetCategory();">
        <div class="page-container page-content-inner page-container-bg-solid">
            <!-- BEGIN BREADCRUMBS -->
            <div class="breadcrumbs">
                <div class="container-fluid">
                </div>
            </div>


            <div class="portlet-body form" style="display: block;">
                <!-- BEGIN FORM-->
                <form id="Master" action="#" class="horizontal-form">
                    <div class="form-body">
                        <h3 class="caption-subject font-green-haze bold uppercase">Food Category </h3>
                        <label id="lblItemCode" class="control-label"></label>
                        <div class="row">
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label class="control-label">Food Category Name</label>
                                    <input type="text" id="txtFItemName" class="form-control" placeholder="-Category Name-">
                                </div>
                            </div>
                            <!--/span-->
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label class="control-label">Image of Food Category</label>
                                    <input id="CatImg" type="file" name="pic" accept="image/*" class="form-control" placeholder="">
                                </div>
                            </div>
                            <!--/span-->
                        </div>
                        <!--/row-->
                        <div class="row">
                            
                            <!--/span-->
                            <div class="col-md-1">
                                
                                <div id="btnb1" class="form-group">

                                    <button id="btnAddCat" type="button" class="btn green-meadow" style="width: 120px" onclick="InsertCat();">Add Category</button>
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
                        <h3 class="caption-subject font-green-haze bold uppercase">Food Items </h3>
                        <label id="lblItemCode1" class="control-label"></label>
                        <div class="row">
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label>Food Category</label>
                                    <div id="divCat"></div>
                                    <%--<select class="form-control">
                                    <option value="1">Pizza</option>
                                    <option value="2">Submarine</option>
                                    <option value="3">Burgers</option>
                                    <option value="4">Appetizers</option>
                                    <option value="5">Beverages</option>
                                </select>--%>
                                </div>

                            </div>

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
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label class="control-label">Price</label>
                                    <input type="text" id="txtPrice" class="form-control" placeholder="-Food Price-">
                                </div>
                            </div>
                            <!--/span-->

                        </div>
                        <div class="row">
                            <div class="col-md-6">
                                <div class="form-group">
                                    
                                </div>
                            </div>
                            <div class="col-md-8">
                                <div id="btnb" class="form-group">

                                    <button id="btnAddFood" type="button" class="btn green-meadow" style="width: 120px" onclick="InsertFood();">Add Food</button>
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
    </body>
</asp:Content>
