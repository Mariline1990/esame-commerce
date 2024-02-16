using Antlr.Runtime.Misc;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace esame_commerce
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
               // Per non aggiornare ogni volta la pagina con Card nuove se il MiniaturesList è uguale a zero allora CreateMiniatures 
                if (Miniatures.MiniaturesList.Count == 0)
                {
                    Miniatures.CreateMiniatures();
                }
                // genero con Repeater le cards
                MiniaturesRepeater.DataSource = Miniatures.MiniaturesList;
                MiniaturesRepeater.DataBind();          

        }


        public class Miniatures
        {
            public int Id {  get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public double Price { get; set; }
            public string Image { get; set; }

            //genero la lista
            public static List<Miniatures> MiniaturesList { get; set; } = new List<Miniatures>();


            // creo il l-oggetto Miniatures
            public Miniatures( int id, string name, double price, string description, string image)
            {
                this.Id = id;
                this.Name = name;
                this.Price = price;
                this.Description = description;
                this.Image = image;
            }

            public static void CreateMiniatures()
            {
                // aggiungo nuovi oggetti di tipo Miniatures
                Miniatures marshal = new Miniatures(1,"HIGH MARSHAL HELBRECHT", 3250, "A terrifying and awe-inspiring HQ choice to lead your Black Templars army", "Content/immagini/min7.jpg");
                Miniatures templarsMarchal = new Miniatures(2,"BLACK TEMPLARS MARSHAL", 3250, "A terrifying and awe-inspiring HQ choice to lead your Black Templars army", "Content/immagini/min8.jpg");
                Miniatures captanMaster = new Miniatures(3,"CAPTAIN WITH MASTER-CRAFTED ", 3250, "A terrifying and awe-inspiring HQ choice to lead your Black Templars army", "Content/immagini/min9.jpg");
                Miniatures primarisChaplain = new Miniatures(4,"PRIMARIS CHAPLAIN", 3250, "A terrifying and awe-inspiring HQ choice to lead your Black Templars army", "Content/immagini/min10.jpg");
                Miniatures primarisApothecary = new Miniatures(5,"PRIMARIS APOTHECARY", 3250, "A terrifying and awe-inspiring HQ choice to lead your Black Templars army", "Content/immagini/min11.jpg");
                Miniatures marrowscroll = new Miniatures(6,"MARROWSCROLL HERALD", 3250, "A terrifying and awe-inspiring HQ choice to lead your Black Templars army", "Content/immagini/min12.jpg");
                Miniatures cardinal = new Miniatures(7,"ABHORRANT CARDINAL", 3250, "A terrifying and awe-inspiring HQ choice to lead your Black Templars army", "Content/immagini/min13.jpg");
                Miniatures blackhawk = new Miniatures(8,"UFTHAK BLACKHAWK", 3250, "A terrifying and awe-inspiring HQ choice to lead your Black Templars army", "Content/immagini/min4.jpg");
                Miniatures ushoran = new Miniatures(9,"USHORAN, MORTARCH OF DELUSION ", 3250, "A terrifying and awe-inspiring HQ choice to lead your Black Templars army", "Content/immagini/min5.jpg");
              



                MiniaturesList.Add(marshal);
                MiniaturesList.Add(templarsMarchal);
                MiniaturesList.Add(captanMaster);
                MiniaturesList.Add(primarisChaplain);
                MiniaturesList.Add(primarisApothecary);
                MiniaturesList.Add(marrowscroll);
                MiniaturesList.Add(cardinal);
                MiniaturesList.Add(blackhawk);
                MiniaturesList.Add(ushoran);

            }

        }

          protected void Button_Dettagli(object sender, EventArgs e)

            {

                string allDetails = ((LinkButton)sender).CommandArgument;
                Response.Redirect("Dettagli.aspx?id=" + allDetails);

            }
    }
}