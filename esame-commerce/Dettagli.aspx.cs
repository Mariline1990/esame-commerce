using System;
using System.Collections.Generic;
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
                // Recupera il valore dell'ID dalla query string               
                if (Request.QueryString["id"] != null)
                {
                    int id = Convert.ToInt32(Request.QueryString["Id"]);

                    // Trova l'oggetto Miniatures corrispondente dall'ID
                    Miniatures selectedMiniature = null;
                    foreach (Miniatures miniature in Miniatures.MiniaturesList)
                    {
                        if (miniature.Id == id)
                        {
                            selectedMiniature = miniature;
                            break; // Esci dal ciclo una volta trovato l'oggetto corrispondente
                        }
                    }

                    if (selectedMiniature != null)
                    {
                        // Stampa la descrizione
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
    }
    
}