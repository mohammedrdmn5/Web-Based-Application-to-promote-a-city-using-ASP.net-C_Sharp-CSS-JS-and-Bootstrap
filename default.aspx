<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    Home
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <li role="presentation" class="nav-item mx-0 mx-lg-1"></li>

    <li role="presentation" class="nav-item mx-0 mx-lg-1"><a class="nav-link py-3 px-0 px-lg-3 rounded js-scroll-trigger" href="#Dishes">Dishes</a></li>
    <li role="presentation" class="nav-item mx-0 mx-lg-1"><a class="nav-link py-3 px-0 px-lg-3 rounded js-scroll-trigger" href="#activities">Activities</a></li>
    <li role="presentation" class="nav-item mx-0 mx-lg-1"><a class="nav-link py-3 px-0 px-lg-3 rounded js-scroll-trigger" href="#Events">Events</a></li>
    <li role="presentation" class="nav-item mx-0 mx-lg-1"><a class="nav-link py-3 px-0 px-lg-3 rounded js-scroll-trigger" href="Apply.aspx">Apply</a></li>

</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <div class="simple-slider">
        <div class="swiper-container">
            <div class="swiper-wrapper">
                <asp:Image class="swiper-slide" ID="imgSlider1" runat="server" />
                <asp:Image class="swiper-slide" ID="imgSlider2" runat="server" />
                <asp:Image class="swiper-slide" ID="imgSlider3" runat="server" />
                <asp:Image class="swiper-slide" ID="imgSlider4" runat="server" />
                <asp:Image class="swiper-slide" ID="imgSlider5" runat="server" />
                <asp:Image class="swiper-slide" ID="imgSlider6" runat="server" />
                <asp:Image class="swiper-slide" ID="imgSlider7" runat="server" />
                <asp:Image class="swiper-slide" ID="imgSlider8" runat="server" />

            </div>
            <div class="swiper-pagination"></div>
            <div class="swiper-button-prev"></div>
            <div class="swiper-button-next"></div>
        </div>
    </div>


    <section class="masthead bg-primary text-white text-center  ">
        <div class="container ">
            <div class="row align-items-center">
                <div class="col-lg-6 order-lg-2">
                    <div class="p-5">
                        <img class="rounded-circle img-fluid" src="assets/img/JeddahOnMap.PNG" />
                    </div>
                </div>
                <div class="col-lg-6 order-lg-1">
                    <div class="p-5">
                        <h2 class="text-uppercase section-heading">About Jeddah </h2>
                        <hr class="star-light" />
                        <p>Jeddah, a Saudi Arabian port city on the Red Sea, is a modern commercial hub and gateway for pilgrimages to the Islamic holy cities Mecca and Medina. Resort hotels, beaches, and outdoor sculptures line the Corniche, a seafront promenade anchored by the iconic King Fahd’s Fountain. The city’s Al-Balad historic district dates to the 7th century and retains traditional homes built from coral.</p>
                    <asp:button id="btnSendToApply" class="btn btn-primary" runat="server" text="Get started!" OnClick="btnSendToApply_Click"  />
                    </div>
                </div>
            </div>
        </div>
    </section>



    <section id="Events" class="Events">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <h2 class="text-uppercase section-heading">Events </h2>
                    <hr class="star-light" />
                    <h3 class="section-subheading text-muted">The most popular Events</h3>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-6 col-md-4 portfolio-item">
                    <div class="portfolio-hover">
                    </div>
                    <asp:Image ID="imgEvents1" class="img-fluid" runat="server" />
                    <div class="portfolio-caption">
                        <h4>
                            <asp:Label ID="lEvents1" runat="server"></asp:Label></h4>
                    </div>
                </div>
                <div class="col-sm-6 col-md-4 portfolio-item">
                    <div class="portfolio-hover">
                    </div>
                    <asp:Image ID="imgEvents2" class="img-fluid" runat="server" />
                    <div class="portfolio-caption">
                        <h4>
                            <asp:Label ID="lEvents2" runat="server"></asp:Label></h4>


                    </div>
                </div>
                <div class="col-sm-6 col-md-4 portfolio-item">
                    <div class="portfolio-hover">
                    </div>
                    <asp:Image ID="imgEvents3" class="img-fluid" runat="server" />
                    <div class="portfolio-caption">
                        <h4>
                            <asp:Label ID="lEvents3" runat="server"></asp:Label></h4>
                    </div>
                </div>

            </div>
        </div>
    </section>


    <section id="activities" class="bg-primary text-white mb-0">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <h2 class="text-uppercase section-heading">activities </h2>
                    <hr class="star-light" />
                    <h3 class="section-subheading text-muted">The most popular activities</h3>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-6 col-md-4 portfolio-item">
                    <div class="portfolio-hover">
                    </div>
                    <asp:Image ID="imgActivities1" class="img-fluid" runat="server" />

                    <div class="portfolio-caption">
                        <h4>
                            <asp:Label ID="lActivities1" runat="server"></asp:Label></h4>

                    </div>
                </div>
                <div class="col-sm-6 col-md-4 portfolio-item">
                    <div class="portfolio-hover">
                    </div>
                    <asp:Image ID="imgActivities2" class="img-fluid" runat="server" />
                    <div class="portfolio-caption">
                        <h4>
                            <asp:Label ID="lActivities2" runat="server"></asp:Label></h4>
                    </div>
                </div>
                <div class="col-sm-6 col-md-4 portfolio-item">
                    <div class="portfolio-hover">
                    </div>
                    <asp:Image ID="imgActivities3" class="img-fluid" runat="server" />
                    <div class="portfolio-caption">
                        <h4>
                            <asp:Label ID="lActivities3" runat="server"></asp:Label></h4>
                    </div>
                </div>

            </div>
        </div>
    </section>


    <section id="Dishes" class="Events">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <h2 class="text-uppercase section-heading">Dishes </h2>
                    <hr class="star-light" />
                    <h3 class="section-subheading text-muted">The most popular Dishes</h3>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-6 col-md-4 portfolio-item">
                    <div class="portfolio-hover">
                    </div>
                    <asp:Image ID="imgdishes1" runat="server" class="img-fluid"></asp:Image>

                    <div class="portfolio-caption">
                        <h4>

                            <asp:Label ID="ldishes1" runat="server"></asp:Label>
                        </h4>

                    </div>
                </div>
                <div class="col-sm-6 col-md-4 portfolio-item">
                    <div class="portfolio-hover">
                    </div>
                    <asp:Image ID="imgdishes2" runat="server" class="img-fluid"></asp:Image>

                    <div class="portfolio-caption">
                        <h4>
                            <asp:Label ID="ldishes2" runat="server"></asp:Label></h4>

                    </div>
                </div>
                <div class="col-sm-6 col-md-4 portfolio-item">
                    <div class="portfolio-hover">
                    </div>
                    <asp:Image ID="imgdishes3" runat="server" class="img-fluid"></asp:Image>

                    <div class="portfolio-caption">
                        <h4>
                            <asp:Label ID="ldishes3" runat="server"></asp:Label></h4>

                    </div>
                </div>

            </div>
        </div>
    </section>


    <%--   ------------------ advertisement------------------%>

    <section class="bg-primary text-white mb-0">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">

                    <hr class="star-light" />

                </div>
            </div>
            <div class="row">
                <div class="col-sm-6 col-md-4 portfolio-item">
                    <div class="portfolio-hover">
                    </div>
                    <asp:AdRotator ID="adrAdvertisment1" Style="width: 100%" runat="server" AdvertisementFile="~/Ads.xml" />
                </div>
                <div class="col-sm-6 col-md-4 portfolio-item">
                    <div class="portfolio-hover">
                    </div>
                    <asp:AdRotator ID="adrAdvertisment2" runat="server" AdvertisementFile="~/Ads.xml" />

                </div>
                <div class="col-sm-6 col-md-4 portfolio-item">
                    <div class="portfolio-hover">
                    </div>
                    <asp:AdRotator ID="adrAdvertisment3" runat="server" AdvertisementFile="~/Ads.xml" />
                </div>

            </div>
        </div>
    </section>


















</asp:Content>



