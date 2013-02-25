using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using BLL;
using Model;

public partial class Login : System.Web.UI.Page
{


    private UserManager userManager;

    public UserManager UserManager
    {
        get { return userManager; }
        set { userManager = value; }
    }



    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string name = this.txtLoginName.Text.Trim();
        string pwd = this.txtLoginPwd.Text.Trim();

        Users user = userManager.Login(name,pwd);

        if (null == user)
        {
            Response.Write("<script>alert('用户名或者密码错误')</script>");
        }
        else
        {
            Response.Write("<script>alert('OK')</script>");
        }
        
    }
}
