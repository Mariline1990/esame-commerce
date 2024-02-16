using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static esame_commerce._Default;

namespace esame_commerce
{
    public partial class Dettagli : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
               
                if (Request.QueryString["id"] != null)
                {
                    int id = Convert.ToInt32(Request.QueryString["Id"]);
                
                    Miniatures selectedMiniature = null;
                    foreach (Miniatures miniature in Miniatures.MiniaturesList)
                    {
                        if (miniature.Id == id)
                        {
                            selectedMiniature = miniature;
                            break; 
                        }
                    }
                    if (selectedMiniature != null)
                    {
                        
                        stampa.InnerText = selectedMiniature.Description;
                        Image1.ImageUrl = selectedMiniature.Image;

                    }
                    else
                    {
                       
                        stampa.InnerText = "Miniatura non trovata.";
                    }
                }
            }


        }


        protected void Aggiungi(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                int id = Convert.ToInt32(Request.QueryString["Id"]);

          
                Miniatures selectedMiniature = null;

                foreach (Miniatures miniature in Miniatures.MiniaturesList)
                {
                    if (miniature.Id == id)
                    {
                        selectedMiniature = miniature;
                        break; 
                    }
                }
                if (selectedMiniature != null)
                {               
                    HttpCookie carrelloCookie = Request.Cookies["Carrello"];

                    if (carrelloCookie == null)
                    {
                        carrelloCookie = new HttpCookie("Carrello");
                      
                    }

                    carrelloCookie.Values[selectedMiniature.Id.ToString()] = selectedMiniature.Name;

                    carrelloCookie.Expires = DateTime.Now.AddDays(10);
       
                    Response.Cookies.Add(carrelloCookie);

                    
                    
                }
                else
                {
                    stampa.InnerText = "Miniatura non trovata.";
                }
            }
        }

    }

}