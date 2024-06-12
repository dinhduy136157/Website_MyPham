<%@ Page Title="" Language="C#" MasterPageFile="~/View/User/AnotherLayout.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Website_MyPham.View.User.Product.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="server">
<div class="main">
    <div class="grid wide">
        <div class="productInfo">
            <div class="row">
                <div class="col l-5 m-12 s-12">
                    <div>
                        <a href="#" class="product">
                            <div id="productImage" class="product__avt" runat="server" style="background-size: cover; background-position: center;">
                            </div>
                        </a>
                    </div>
                </div>
                <div class="col l-7 m-12s s-12 pl">
                    <h3 id="productName" class="productInfo__name" runat="server">

                    </h3>
                    <div class="productInfo__price">
                         <span id="productPrice" class="priceInfo__unit" runat="server">đ</span>
                    </div>
                    <div id="productDescription" class="productInfo__description" runat="server">
                        
                    </div>
                    <div class="productInfo__addToCart">
                    <div class="buttons_added">
                        <input class="minus is-form" type="button" value="-" onclick="minusProduct()">
                        <input aria-label="quantity" class="input-qty" max="10" min="1" name="" type="number" value="1">
                        <input class="plus is-form" type="button" value="+" onclick="plusProduct()">
                    </div>
                    <button type="button" id="btnAddToCart" onclick="addToCart()">Thêm vào giỏ</button>
                    </div>
                    
                    <div class="productIndfo__category ">
                        <p class="productIndfo__category-text"> Danh mục : <a href="# " class="productIndfo__category-link ">Nail</a></p>
                        <p class="productIndfo__category-text"> Hãng : <a href="# " class="productIndfo__category-link ">The Face Shop</a></p>
                        <p class="productIndfo__category-text"> Số lượng đã bán : 322</p>
                        <p class="productIndfo__category-text"> Số lượng trong kho : 322</p>
                    </div>
                </div>
            </div>
        </div>
        <div class="productDetail ">
            <div class="main__tabnine ">
                <div class="grid wide ">
                    <!-- Tab items -->
                    <div class="tabs ">
                        <div class="tab-item active ">
                            Mô tả
                        </div>
                        <div class="line "></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<script>
    function addToCart() {
        // Lấy productID từ query string hoặc cách khác
        var urlParams = new URLSearchParams(window.location.search);
        var productID = urlParams.get('ProductID');

        if (productID) {
            // Sử dụng AJAX để gọi phương thức AddToCart trong code-behind
            var xhttp = new XMLHttpRequest();
            xhttp.onreadystatechange = function () {
                if (this.readyState == 4 && this.status == 200) {
                    alert(this.responseText); // Hiển thị phản hồi từ server
                }
            };
            xhttp.open("POST", "Index.aspx/AddToCart", true);
            xhttp.setRequestHeader("Content-type", "application/json");
            xhttp.send(JSON.stringify({ productID: productID }));
        } else {
            alert("Không tìm thấy ProductID");
        }
    }

    function minusProduct() {
        // Thực hiện giảm số lượng sản phẩm
    }

    function plusProduct() {
        // Thực hiện tăng số lượng sản phẩm
    }
</script>

</asp:Content>
