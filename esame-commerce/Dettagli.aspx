<%@ Page Title="Dettagli" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dettagli.aspx.cs" Inherits="esame_commerce.Dettagli" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" cssClass="justify-content-center">
    <main aria-labelledby="title">
       <div class="card " style="width: 30rem;">
        
        <div class="card-body">
            <asp:Image ID="Image1" CssClass="w-100" runat="server" AlternateText="Miniatura" />
            <h5 class="card-title" runat="server"> </h5>
            <p class="card-text" id="stampa" runat="server" >.</p>
            <p class="card-price" runat="server"></p>
            <asp:Button ID="Button1" runat="server" Text="Aggiungi al carrello" CssClass="btn btn-danger" onClick="Aggiungi"/>
            
        </div>
    </div>
    </main>
</asp:Content>
