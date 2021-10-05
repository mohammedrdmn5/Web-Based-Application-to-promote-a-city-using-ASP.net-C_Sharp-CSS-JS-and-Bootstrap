<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Apply.aspx.cs" Inherits="Apply" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    Apply
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <li role="presentation" class="nav-item mx-0 mx-lg-1"></li>
    <li role="presentation" class="nav-item mx-0 mx-lg-1"><a class="nav-link py-3 px-0 px-lg-3 rounded js-scroll-trigger" href="default.aspx">Home</a></li>
</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

    <section id="secInfo" runat="server" class="masthead bg-primary text-white text-center  ">
        <div class="container ">
            <div class="row align-items-center">
                <div class="col-lg-6 order-lg-2">
                    <div class="p-5">
                        <asp:Image class="rounded-circle img-fluid" ID="imgApply" runat="server" ImageUrl="~/assets/img/apply.png" style="border-radius: 10% !important;"/>
                    </div>
                </div>
                <div class="col-lg-6 order-lg-1">
                    <div class="p-5">
                        <h2 class="text-uppercase section-heading">Apply for a visit</h2>
                        <hr class="star-light" />
                        <p>Fill out the following form and submit it to us, and we will contact you as soon as possible to prepare all your travel procedures</p>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section id="secPersonalInfo" runat="server" class="Events">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <hr class="star-light" style="border-color: #d4cec4" />
                    <h3 class="section-subheading text-muted">Personal Informaion</h3>
                    <div class="RadioButton">
                        <asp:radiobuttonlist id="rbtnPersonalTitle" runat="server" class="btn btn-primary " style="margin-top: 1px; border-color: white;" repeatdirection="Horizontal">
                            <asp:ListItem>Mr</asp:ListItem>
                            <asp:ListItem>Mrs</asp:ListItem>
                            <asp:ListItem>Miss</asp:ListItem>
                            <asp:ListItem>Ms</asp:ListItem>
                        </asp:radiobuttonlist>
                    </div>
                </div>
                <div class="col-lg-12 text-center">
                </div>
            </div>
            <div class="row">
                <div class="col-sm-6 col-md-4 portfolio-item">
                    <div class="portfolio-hover">
                    </div>
                    <h3 class="section-subheading text-muted" style="font-size: 90%;">Name:</h3>
                    <div>
                        <asp:textbox id="tbName" class="form-control-lg" runat="server" placeholder="Name"></asp:textbox>
                    </div>
                    <div class="portfolio-caption">
                        <h4></h4>
                    </div>
                </div>
                <div class="col-sm-6 col-md-4 portfolio-item">
                    <div class="portfolio-hover">
                    </div>
                    <h3 class="section-subheading text-muted" style="font-size: 90%;">Email-address:</h3>
                    <div>
                        <asp:textbox id="tbEmail" class="form-control-lg" runat="server" textmode="email" placeholder="Email-address"></asp:textbox>
                    </div>
                    <div class="portfolio-caption">
                        <h4>
                    </div>
                </div>
                <div class="col-sm-6 col-md-4 portfolio-item">
                    <div class="portfolio-hover">
                    </div>
                    <h3 class="section-subheading text-muted" style="font-size: 90%;">Phone No:</h3>
                    <div>
                        <asp:textbox id="tbPhone" class="form-control-lg" runat="server" textmode="phone" placeholder="Phone No"></asp:textbox>
                    </div>
                    <div class="portfolio-caption">
                        <h4>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-6 col-md-4 portfolio-item">
                    <div class="portfolio-hover">
                    </div>
                    <h3 class="section-subheading text-muted" style="font-size: 90%;">Date of birth:</h3>
                    <div>
                        <asp:textbox id="tbDateOfBirth" class="form-control-lg" runat="server" textmode="Date" placeholder="Date of birth"></asp:textbox>
                    </div>
                    <div class="portfolio-caption">
                        <h4></h4>
                    </div>
                </div>
                <div class="col-sm-6 col-md-4 portfolio-item">
                    <div class="portfolio-hover">
                    </div>
                    <h3 class="section-subheading text-muted" style="font-size: 90%;">Nationality:</h3>
                    <div>
                        <asp:dropdownlist id="ddlNationality" runat="server" class="btn btn-primary dropdown-toggle" style="margin-top: 1px;" autopostback="false">
                        </asp:dropdownlist>
                    </div>
                    <div class="portfolio-caption">
                        <h4>
                    </div>
                </div>
                <div class="col-sm-6 col-md-4 portfolio-item">
                    <div class="portfolio-hover">
                    </div>
                    <h3 class="section-subheading text-muted" style="font-size: 90%;">city</h3>
                    <div>
                        <asp:textbox id="tbCity" class="form-control-lg" runat="server" placeholder="City"></asp:textbox>
                    </div>
                    <div class="portfolio-caption">
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-12 text-center">
                    <hr class="star-light" />
                    <h3 class="section-subheading text-muted">Select the Activities</h3>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-6 col-md-4 portfolio-item">
                    <div class="portfolio-hover">
                    </div>
                    <asp:listbox id="lbActivities" selectionmode="Multiple" style="width: 100%; height: 100%"
                        runat="server"></asp:listbox>
                </div>
                <div class="col-sm-6 col-md-4 portfolio-item">
                    <div class="portfolio-hover">
                    </div>
                    <asp:button id="btnAddActivities" class="btn btn-primary" style="display: block; margin: auto; margin-left: inherit;" runat="server" text="Add" onclick="btnAddActivities_Click" />
                    <asp:button id="btnRemoveActivities" class="btn btn-primary" style="display: block; margin: auto; margin-right: inherit;" runat="server" text="Remove" onclick="btnRemoveActivities_Click" />
                </div>
                <div class="col-sm-6 col-md-4 portfolio-item">
                    <div class="portfolio-hover">
                    </div>
                    <asp:listbox id="lbSelectedActivities" selectionmode="Multiple" style="width: 100%; height: 100%"
                        runat="server"></asp:listbox>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-12 text-center">
                    <hr class="star-light" style="border-color: #d4cec4" />
                    <h3 class="section-subheading text-muted">Select the Events</h3>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-6 col-md-4 portfolio-item">
                    <div class="portfolio-hover">
                    </div>
                    <asp:listbox id="lbEvents" selectionmode="Multiple" style="width: 100%; height: 100%"
                        runat="server"></asp:listbox>
                </div>
                <div class="col-sm-6 col-md-4 portfolio-item">
                    <div class="portfolio-hover">
                    </div>
                    <asp:button id="btnAddEvents" class="btn btn-primary" style="display: block; margin: auto; margin-left: inherit;" runat="server" text="Add" onclick="btnAddEvents_Click" />
                    <asp:button id="btnRemoveEvents" class="btn btn-primary" style="display: block; margin: auto; margin-right: inherit;" runat="server" text="Remove" onclick="btnRemoveEvents_Click" />
                </div>
                <div class="col-sm-6 col-md-4 portfolio-item">
                    <div class="portfolio-hover">
                    </div>
                    <asp:listbox id="lbSelectedEvents" selectionmode="Multiple" style="width: 100%; height: 100%"
                        runat="server"></asp:listbox>
                </div>
            </div>
        </div>
    </section>
    <section id="secHotel" runat="server" class="bg-primary text-white mb-0">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <h3 class="section-subheading text-muted">Hotel</h3>
                </div>
                <div class="col-lg-12 text-center">

                    <hr class="star-light" />
                </div>
            </div>
            <div class="row">
                <div class="col-sm-6 col-md-4 portfolio-item">
                    <div class="portfolio-hover">
                    </div>
                    <h3 class="section-subheading text-muted" style="font-size: 90%;">Type:</h3>
                    <div>
                        <asp:dropdownlist id="ddlHotelsType" runat="server" class="btn btn-primary dropdown-toggle" style="margin-top: 1px;" autopostback="false">
                        </asp:dropdownlist>
                    </div>
                    <div class="portfolio-caption">
                        <h4>
                    </div>
                </div>
                <div class="col-sm-6 col-md-4 portfolio-item">
                    <div class="portfolio-hover">
                    </div>
                    <h3 class="section-subheading text-muted" style="font-size: 90%;">Check-in date:</h3>
                    <div>
                        <asp:textbox id="tbCheckInDate" class="form-control-lg" runat="server" textmode="Date"></asp:textbox>
                    </div>
                    <div class="portfolio-caption">
                        <h4></h4>
                    </div>
                </div>
                <div class="col-sm-6 col-md-4 portfolio-item">
                    <div class="portfolio-hover">
                    </div>
                    <h3 class="section-subheading text-muted" style="font-size: 90%;">Check-out date:</h3>
                    <div>
                        <asp:textbox id="tbCheckOutDate" class="form-control-lg" runat="server" textmode="Date"></asp:textbox>
                    </div>
                    <div class="portfolio-caption">
                        <h4></h4>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-12 text-center">
                    <hr class="star-light" />
                    <h3 class="section-subheading text-muted">Meals</h3>
                </div>
                <div class="col-lg-12 text-center">
                    <div class="dropdown">
                        <asp:dropdownlist id="ddlmealsType" runat="server" class="btn btn-primary dropdown-toggle" style="margin-top: 1px;" onselectedindexchanged="ddlmealsType_SelectedIndexChanged" autopostback="True">
                            <asp:ListItem>select type</asp:ListItem>
                            <asp:ListItem>Breakfast</asp:ListItem>
                            <asp:ListItem>Lunch</asp:ListItem>
                            <asp:ListItem>Dinner</asp:ListItem>
                        </asp:dropdownlist>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-6 col-md-4 portfolio-item">
                    <div class="portfolio-hover">
                    </div>
                    <asp:listbox id="lbMeals" selectionmode="Multiple" style="width: 100%; height: 100%"
                        runat="server"></asp:listbox>
                </div>
                <div class="col-sm-6 col-md-4 portfolio-item">
                    <div class="portfolio-hover">
                    </div>
                    <asp:button id="btnAddMeals" class="btn btn-primary" style="display: block; margin: auto; margin-left: inherit;" runat="server" text="Add" onclick="btnAddMeals_Click" />
                    <asp:button id="btnRemoveMeals" class="btn btn-primary" style="display: block; margin: auto; margin-right: inherit;" runat="server" text="Remove" onclick="btnRemoveMeals_Click" />
                </div>
                <div class="col-sm-6 col-md-4 portfolio-item">
                    <div class="portfolio-hover">
                    </div>
                    <asp:listbox id="lbSelectedMeals" selectionmode="Multiple" style="width: 100%; height: 100%"
                        runat="server"></asp:listbox>
                </div>
            </div>
        </div>
    </section>

    <section id="secAgreement" runat="server" class="Events">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <hr class="star-light" />
                    <asp:checkbox id="cbAgreement" runat="server" class="btn btn-primary " bordercolor="White" text="I understand that I agreed to all terms and conditions" />
                    <br />
                    <asp:button id="btnSubmit" class="btn btn-primary" runat="server" text="Submit" onclick="btnSubmit_Click" />
                </div>
            </div>

        </div>
    </section>


    <<section id="secCheckValidation" visible="false" runat="server" class="bg-primary text-white mb-0">
        <div class="container">
            <table class="table">
                <thead>
                </thead>
                <tbody>
                    <tr>
                        <th scope="row">Name:</th>
                        <td>
                            <asp:label id="lblName" runat="server"></asp:label>
                        </td>
                    </tr>
                    <tr>
                        <th scope="row">Email-address:</th>
                        <td>
                            <asp:label id="lblEmail" runat="server"></asp:label>
                        </td>
                    </tr>
                    <tr>
                        <th scope="row">Phone No:
                        </th>
                        <td>
                            <asp:label id="lblPhone" runat="server"></asp:label>
                        </td>
                    </tr>
                    <tr>
                        <th scope="row">Date of Birth:
                        </th>
                        <td>
                            <asp:label id="lblDateOfBirth" runat="server"></asp:label>
                        </td>
                    </tr>
                    <tr>
                        <th scope="row">Nationality:
                        </th>
                        <td>
                            <asp:label id="lblNationality" runat="server"></asp:label>
                        </td>
                    </tr>
                    <tr>
                        <th scope="row">city
                        </th>
                        <td>
                            <asp:label id="lblCity" runat="server"></asp:label>
                        </td>
                    </tr>
                    <tr>
                        <th scope="row">Selected activities:
                        </th>
                        <td>
                            <asp:label id="lblSelectedActivities" runat="server"></asp:label>
                        </td>
                    </tr>
                    <tr>
                        <th scope="row">Selected events:
                        </th>
                        <td>
                            <asp:label id="lblSelectedEvents" runat="server"></asp:label>
                        </td>
                    </tr>
                    <tr>
                        <th scope="row">hotel Type:
                        </th>
                        <td>
                            <asp:label id="lblHotelType" runat="server"></asp:label>
                        </td>
                    </tr>
                    <tr>
                        <th scope="row">Check-in date:
                        </th>
                        <td>
                            <asp:label id="lblCheckInDate" runat="server"></asp:label>
                        </td>
                    </tr>
                    <tr>
                        <th scope="row">Check-out date:
                        </th>
                        <td>
                            <asp:label id="lblCheckOutDate" runat="server"></asp:label>
                        </td>
                    </tr>
                    <tr>
                        <th scope="row">Selected meal:
                        </th>
                        <td>
                            <asp:label id="lblSelectedMeal" runat="server"></asp:label>
                        </td>
                    </tr>
                    <tr>
                        <th scope="row">Agreement
                        </th>
                        <td>
                            <asp:label id="lblAgreement" runat="server"></asp:label>
                        </td>
                    </tr>
                </tbody>
            </table>
            <div class="col-lg-12 text-center">
                <asp:label id="lblConfirm" runat="server"></asp:label>
                <br />
                <asp:button id="btnConfirmOrder" class="btn btn-primary" runat="server" text="Confirm" onclick="btnConfirmOrder_Click" />
            </div>

        </div>
    </section>

    <section id="secSuccessOrder" visible="false" runat="server" class="masthead bg-primary text-white text-center  ">
        <div class="container ">
            <div class="row align-items-center">
                <div class="col-lg-6 order-lg-2">
                    <div class="p-5">
                        <img class="rounded-circle img-fluid" src="assets/img/success.png" />
                    </div>
                </div>
                <div class="col-lg-6 order-lg-1">
                    <div class="p-5">
                        <h2 class="text-uppercase section-heading">Successful </h2>
                        <hr class="star-light" />
                        <h5>You have sent your order Successfully, we will reply you soon. </h5>
                    </div>
                </div>
            </div>
        </div>
    </section>


</asp:Content>

