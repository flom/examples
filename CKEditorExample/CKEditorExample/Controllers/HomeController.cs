using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CKEditorExample.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      string content = (string)HttpContext.Cache["content"];
      if (content == null)
      {
        content = "<h2>Default Title</h2>";
      }
      ViewBag.Content = content;

      return View();
    }

    public ActionResult Edit()
    {
      string content = (string)HttpContext.Cache["content"];
      if (content == null)
      {
        content = "<h2>Default Title</h2>";
      }
      ViewBag.Content = content;

      return View();
    }

    [HttpPost]
    [ValidateInput(false)]
    public JsonResult Edit(string content)
    {
      HttpContext.Cache["content"] = content;
      return Json("OK");
    }

    [HttpPost]
    public ActionResult UploadFromEditor(HttpPostedFileBase upload, string CKEditorFuncNum, string CKEditor, string langCode)
    {
      string url; // url to return
      string message; // message to display (optional)

      using (Stream file = System.IO.File.Create(Path.Combine(Server.MapPath("~/Content/uploads"), upload.FileName)))
      {
        upload.InputStream.CopyTo(file);
      }

      url = Url.Content("~/Content/uploads/" + upload.FileName);

      // passing message success/failure
      message = "";

      // since it is an ajax request it requires this string
      string output = @"<html><body><script>window.parent.CKEDITOR.tools.callFunction(" + CKEditorFuncNum + ", \"" + 
        url + "\", \"" + message + "\");</script></body></html>";
      return Content(output);
    }

    public ActionResult ImageBrowser()
    {
      var images = new List<string>();
      foreach (string image in Directory.GetFiles(Server.MapPath("~/Content/uploads")))
      {
        images.Add(new FileInfo(image).Name);
      }

      return View(images);
    }
  }
}