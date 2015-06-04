<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="VacationLocation._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div id="carousel-example-generic" class="carousel slide" data-ride="carousel" data-interval="1000">
  <!-- Indicators -->
  <ol class="carousel-indicators">
    <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
    <li data-target="#carousel-example-generic" data-slide-to="1"></li>
    <li data-target="#carousel-example-generic" data-slide-to="2"></li>
  </ol>
 
  <!-- Wrapper for slides -->
  <div class="carousel-inner">
    <div class="item active">
      <img src="http://www.blogcdn.com/slideshows/images/slides/279/787/9/S2797879/slug/l/vacation-1.jpg" style="width="80%"">
      <div class="carousel-caption">
          <h3>Your next vacation, at a click away!</h3>
      </div>
    </div>
  </div> <!-- Carousel -->
<script>
    $('.carousel').carousel({
        interval: 3000
    })
</script>

</asp:Content>
