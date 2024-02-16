<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="esame_commerce._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        
         <div class="container">
             <div class="container text-end mb-4">
             <asp:Button ID="Button1" CssClass="btn btn-dark" runat="server" Text="Carrello" />
                 </div>
   <div class="row">
        <asp:Repeater ID="MiniaturesRepeater" runat="server">
    <ItemTemplate>
       
            <div class=" col-md-3 col-xs-1  mt-3">
                <div class="card bg-warning bg-opacity-50"> 
                   <img src='<%# Eval("Image") %>' class="w-100"/><br />
                    
                      <div class="card-body text-lg-center">
                        <%# Eval("Name") %><br />
                          <asp:LinkButton ID="Button2" runat="server" CssClass="btn btn-dark mt-2" Text="Dettagli" CommandArgument='<%# Eval("Id") %>' OnClick="Button_Dettagli" ></asp:LinkButton>                        
                      </div>
                </div>
            </div>
      
        
    </ItemTemplate>
</asp:Repeater>
           </div>
 </div>
    </main>

</asp:Content>
