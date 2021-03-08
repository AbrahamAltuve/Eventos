using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Eventos
{
    public partial class Eventos : System.Web.UI.Page
    {
        private string[] eventos = new string[9];

        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("PreInit<br/>");
            eventos.Append("PreInit");
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Init<br/>");
        }

        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Response.Write("Init Complete<br/>");
        }

        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Response.Write("PreLoad<br/>");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Load<br/>");
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Response.Write("Load Complete<br/>");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("PreRender <br/>");
        }

        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            Response.Write("PreRender Complete <br/>");
            DataTable dt = new DataTable();
            GridViewEventos.DataSource = dt;
            GridViewEventos.DataBind();
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            //Response.Write("Unload");
        }



    }
}