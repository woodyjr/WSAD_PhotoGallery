using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        displayImages();
    }

    private void displayImages()
    {
        foreach (string strFileName in Directory.GetFiles(Server.MapPath("~/images/")))
        {
            ImageButton imageButton = new ImageButton();
            FileInfo fileInfo = new FileInfo(strFileName);
            imageButton.ImageUrl = "~/images/" + fileInfo.Name;
            imageButton.Width = Unit.Percentage(25);
            imageButton.Height = Unit.Percentage(25);
            imageButton.Style.Add("padding", "5px");

            imageButton.Click += new ImageClickEventHandler(imageButton_Click);
            Panel1.Controls.Add(imageButton);

            

        }
    }

    void imageButton_Click(object sender, ImageClickEventArgs e)
    {
        //Response.Write(((ImageButton)sender).ImageUrl);
        //Response.Redirect(((ImageButton)sender).ImageUrl);
        Response.Redirect("~/display.aspx?ImageURL="+((ImageButton)sender).ImageUrl);
    }

    protected void btnUpload_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            string fileName = FileUpload1.FileName;
            FileUpload1.PostedFile.SaveAs(Server.MapPath("~/images/" + fileName));
        }

        //displayImages();
        Response.Redirect("~/Default.aspx");
        
    }
}