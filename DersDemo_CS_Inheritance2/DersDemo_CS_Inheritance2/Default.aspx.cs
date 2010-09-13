using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DersDemo_CS_Inheritance2
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            l.Text = "Deneme";
            TextBox tb = new TextBox();
            tb.ID = "tb";
            p.Controls.Add(tb);

            Image i = new Image();
            p.Controls.Add(i);

            GridView gw = new GridView();
            p.Controls.Add(gw);
        }
    }
}
