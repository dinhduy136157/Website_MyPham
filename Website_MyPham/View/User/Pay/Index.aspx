<%@ Page Title="" Language="C#" MasterPageFile="~/View/User/AnotherLayout.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Website_MyPham.View.User.Pay.Index" %>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="../assets/css/pay.css">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="server">
    <div class="main">
        <div class="grid wide">
            <div class="row">
                <div class="col l-7 m-12 s-12">
                    <div class="pay-information">
                        <div class="pay__heading">Thông tin thanh toán</div>
                        <div class="form-group">
                            <label for="account" class="form-label">Họ Tên *</label>
                            <input runat="server" id="customer_name" name="account" type="text" class="form-control">
                        </div>
                        <div class="form-group">
                            <label for="account" class="form-label">Địa chỉ *</label>
                            <input runat="server" id="customer_address" name="account" type="text" class="form-control">
                            <span class="form-message"></span>
                        </div>
                        <div class="form-group">
                            <label for="account" class="form-label">Số điện thoại *</label>
                            <input runat="server" id="customer_phone" name="account" type="text" class="form-control">
                            <span class="form-message"></span>
                        </div>
                        <div class="form-group">
                            <label for="account" class="form-label">Đơn vị vận chuyển: </label>
                            <input runat="server" id="shipment" name="account" value="Giao hàng nhanh" type="text" class="form-control">
                        </div>
                    </div>
                </div>
                <div class="col l-5 m-12 s-12">
                    <div class="pay-order">
                        <div class="pay__heading">Đơn hàng của bạn</div>
                        <div class="pay-info">
                            <div class="main__pay-text">
                                Azrouel dress variable</div>
                            <div class="main__pay-price">
                                1,120,000 ₫
                            </div>
                        </div>
                        <div class="pay-info">
                            <div class="main__pay-text">
                                Azrouel dress variable </div>
                            <div class="main__pay-amount">
                                3
                            </div>
                            <div class="main__pay-price">
                                1,120,000 ₫
                            </div>
                        </div>
                        <div class="pay-info">
                            <div class="main__pay-text">
                                Azrouel dress variable </div>
                            <div class="main__pay-price">
                                1,120,000 ₫
                            </div>
                        </div>
                        <div class="pay-info">
                            <div class="main__pay-text special">
                                Giao hàng
                            </div>
                            <div class="main__pay-text">
                                Giao hàng miễn phí
                            </div>

                        </div>
                        <div class="pay-info">
                            <div class="main__pay-text special">
                                Tổng thành tiền</div>
                            <div class="main__pay-price">
                                1,120,000 ₫
                            </div>
                        </div>
                        <div class="btn btn--default">Đặt hàng</div>
                    </div>

                </div>
            </div>
        </div>
    </div>
</asp:Content>
