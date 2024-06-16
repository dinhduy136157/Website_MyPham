﻿<%@ Page Title="" Language="C#" MasterPageFile="~/View/User/AnotherLayout.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Website_MyPham.View.User.OrderDetail.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <link rel="stylesheet" type="text/css" href="../assets/css/cart.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="main">
    <div class="grid wide">
        <div class="row">
            <div class="col l-12 m-12 s-12">
                <div class="main__cart">
                    <div class="row title">
                        <div class="col l-1 m-1 s-0">Chọn</div>
                        <div class="col l-4 m-4 s-8">Sản phẩm</div>
                        <div class="col l-2 m-2 s-0">Giá</div>
                        <div class="col l-2 m-2 s-0">Số lượng</div>
                        <div class="col l-2 m-2 s-4">Tổng</div>
                    </div>
                    <asp:Repeater ID="ProductRepeater" runat="server">
                        <ItemTemplate>
                            <div class="row item">
                                <div class="col l-1 m-1 s-0">
                                    <input type="checkbox" name="a">
                                </div>
                                <div class="col l-4 m-4 s-8">
                                    <div class="main__cart-product">
                                        <img src="../assets/img/product/<%# Eval("Product.image") %>" alt="">
                                        <div class="name"><%# Eval("Product.SKU") %></div>
                                    </div>
                                </div>
                                <div class="col l-2 m-2 s-0">
                                    <div class="main__cart-price"><%# Eval("Product.price") %></div>
                                </div>
                                <div class="col l-2 m-2 s-0">
                                    <div class="buttons_added">
                                        <input aria-label="quantity" class="input-qty" max="10" min="1" name="" type="number" value="<%# Eval("quantity") %>">
                                    </div>
                                </div>
                                <div class="col l-2 m-2 s-4">
                                    <div class="main__cart-price"><%# Eval("totalPrice") %></div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                    <div class="btn btn--default">
                        Cập nhật giỏ hàng
                    </div>
                </div>
            </div>
            
        </div>
    </div>
</div>
</asp:Content>
