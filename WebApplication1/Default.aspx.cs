using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var ctx = new ProductSupportEntities())
            {
                var Name = ctx.UserInfoes.Where(c => c.ID == 3).FirstOrDefault();

                var First = ctx.UserInfoes.Where(x => x.Name == "John").FirstOrDefault();

                string test = "";
            }
        }
    }
}