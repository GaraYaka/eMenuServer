<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HotDishes.aspx.cs" Inherits="eMenu.UI.HotDishes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">


        function InsertHotDish() {


            var txtFoodName = document.getElementById("txtFoodName").value.trim();


            var txtprice = document.getElementById("txtPrice").value.trim();
            //var txtQuantity = document.getElementById("txtQty").value;


            var sendData = JSON.stringify({ name: txtFoodName, price: txtprice });

            $.ajax({

                url: "../Services/soapService.asmx/SaveHotDish",
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


        function LoadGridData() {

            $.ajax({
                url: "../Services/soapService.asmx/GetAllHotDish",
                dataType: "json",
                contentType: "application/json; charset=utf-8",
                type: "POST",

                success: function (result) {

                    $("#ItemTable tbody").empty();
                    //var table = '<table class="table table-hover"><thead><tr><td>Item Code</td><td>Item Name</td><td>Item Category</td><td>Re-Oreder Qty</td></tr></thead></table><tbody>';
                    var table = document.getElementById("ItemTable").getElementsByTagName("tbody")[0];

                    //document.getElementById("lblItemCode").innerText = parseInt(result.d[result.d.length - 1].RnItemID) + parseInt(1);

                    //document.getElementById("txtItemCode").value = parseInt(result.d[result.d.length - 1].RnItemID) + parseInt(1);
                    for (var i = 0; i < result.d.length; i++) {



                        var row = document.createElement("tr");
                        var col1 = document.createElement("td");
                        var col2 = document.createElement("td");
                        var col3 = document.createElement("td");


                        col1.innerHTML = result.d[i].ID;
                        col2.innerHTML = result.d[i].name;
                        col3.innerHTML = result.d[i].price;

                        //col5.style.visibility = "hidden";

                        row.appendChild(col1);
                        row.appendChild(col2);
                        row.appendChild(col3);


                        table.appendChild(row);

                        // document.getElementById("ItemTable").getElementsByTagName("tbody")[0];

                        row.onclick = function () {


                            document.getElementById("txtFoodID").value = table.rows[this.rowIndex - 1].cells[0].innerHTML.trim();
                            document.getElementById("txtFoodName").value = table.rows[this.rowIndex - 1].cells[1].innerHTML.trim();
                            document.getElementById("txtPrice").value = table.rows[this.rowIndex - 1].cells[2].innerHTML.trim();





                            var html = "";
                            html += "<button id=btnUpdate type=button class=btn green-meadow onclick= style=width: 56px;>Update</button>";


                            $('#btn').append(html);

                        };
                    }



                }, error: function (request, status, error) {
                    alert("Error! Cannot Load table.");
                }
            });
        }


    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <body onload="">
        <div class="page-container page-content-inner page-container-bg-solid">
            <form id="Master2" action="#" class="horizontal-form">
                <div class="form-body">
                    <h3 class="caption-subject font-green-haze bold uppercase">Hot Dishes</h3>
                    <label id="lblItemCode1" class="control-label"></label>
                    <div class="row">


                        <div class="col-md-6">
                            <div class="form-group">
                                <label class="control-label">Food Name</label>
                                <input type="text" id="txtFoodName" class="form-control" placeholder="-Food Name-">
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group">

                                <input type="hidden" id="txtFoodID" class="form-control">
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

                                <button id="btnAddFood" type="button" class="btn green-meadow" style="width: 120px" onclick="InsertHotDish();location.reload();">Add Food</button>
                            </div>
                        </div>
                        <div class="col-md-9">
                            <div id="btnb1" class="form-group">

                                <button id="btnGetFood" type="button" class="btn blue btn-outline" style="width: 150px" onclick="LoadGridData();">Get ALL Hot Dishes</button>

                                
                            </div>

                            <div id="btn">
                                </div>

                        </div>

                    </div>


                    <!--/span-->

                    <!--/span-->


                    <!--/row-->
                </div>
                <!--/row-->

            </form>



            <div class="portlet box blue">
                <div class="portlet-title">
                    <div class="caption">
                        <i class="fa fa-cogs"></i>Hot Dishes Table
                    </div>
                    <div class="tools">
                        <a href="javascript:;" class="collapse" data-original-title="" title=""></a>

                    </div>
                </div>
                <div class="portlet-body">
                    <div id="divTable">
                        <table id="ItemTable" class="table table-hover">
                            <thead>
                                <tr>

                                    <th style="height: 24px">Hot Dish ID
                                    </th>
                                    <th style="height: 24px">Food Name
                                    </th>
                                    <th style="height: 24px">Price
                                    </th>

                                    <th id="ID" style="height: 24px"></th>

                                </tr>
                            </thead>
                            <tbody>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </body>





</asp:Content>
