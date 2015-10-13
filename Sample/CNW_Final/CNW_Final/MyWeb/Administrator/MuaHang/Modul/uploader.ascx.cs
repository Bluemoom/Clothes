using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyWeb.Common;
using System.IO;

public partial class Modul_Uploader1 : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btlTaiLen_Click(object sender, EventArgs e)
    {
        HttpPostedFile files = FileUploadHinhAnh.PostedFile;
        if (FileUploadHinhAnh.HasFile == false || files.ContentLength > 2000000)
        {
            WebMsgBox.Show("Ảnh không hợp lệ!");
        }
        else
        {
            string _fileExt =Path.GetExtension(FileUploadHinhAnh.FileName);
            if (_fileExt.ToLower() == ".gif" || _fileExt.ToLower() == ".png" || _fileExt.ToLower() == ".bmp" ||
                _fileExt.ToLower() == ".jpeg" || _fileExt.ToLower() == ".jpg")
            {
                try
                {
                    string AdsFile = FileUploadHinhAnh.FileName + "_" + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + Path.GetExtension(FileUploadHinhAnh.FileName);
                    FileUploadHinhAnh.SaveAs(Request.PhysicalApplicationPath + "Images/" + Session["folder"] + "/" + AdsFile);
                    Session["upload"] = "/Images/" + Session["folder"] + "/" + AdsFile;
                    WebMsgBox.Show("Tải thành công!");
                }
                catch
                {
                    WebMsgBox.Show("Trùng tên hoặc chưa chọn hình!");
                }
            }
            else
            {
                WebMsgBox.Show("Không đúng định dạng ảnh!");
            }
        }
    }
}