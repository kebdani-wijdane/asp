using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercice_2__les_contrôles_DropDownList_et_Button
{
    public partial class exercice2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (this.IsPostBack==false)
            {
                ListItem x1 = new ListItem("Euro", "0,7436");
                drpTypeDevise.Items.Add(x1);
                drpTypeDevise.Items.Add(new ListItem("Yen Japonais ", "81,0"));
                drpTypeDevise.Items.Add(new ListItem("Dollars  Canadien", "0,9996"));
                imgGraph.Visible = false;

            }
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                    

                    decimal montantUs = Decimal.Parse(txtDollards.Text);

                if (montantUs <= 0)
                {
                    txtDollards.BackColor =Color.Red;
                    txtDollards.Text = "Spécifier un nombre positif";
                }
                else
                {
                    txtDollards.BackColor = Color.White;
                    int indiceSelectionner = drpTypeDevise.SelectedIndex;
                    decimal valueMonnaie = decimal.Parse(drpTypeDevise.Items[indiceSelectionner].Value);
                    string nomMonnaie = drpTypeDevise.Items[indiceSelectionner].Text;

                    decimal totaleconverti = montantUs * valueMonnaie;

                    lblDollarsEnDevise.Text = montantUs.ToString() + " DollarsU.S = ";
                    lblDollarsEnDevise.Text += totaleconverti.ToString() + " " + nomMonnaie;
                }   


            }
            catch(Exception ex) { Response.Write(ex.Message); }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // drpTypeDevise.SelectedIndex 0 1 2

            imgGraph.ImageUrl = "images/pic" +drpTypeDevise.SelectedIndex + ".png";
            imgGraph.Visible = true;
        }
    }
}