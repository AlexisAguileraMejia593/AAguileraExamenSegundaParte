using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class VideoJuegosController : Controller
    {
        // GET: VideoJuegos
        public ActionResult Index()
        {
            ML.VideoJuegos videoJuegos = BL.VideoJuegos.GetAll();
            var result = videoJuegos.VideoJuegoss;
            return View(videoJuegos);
        }
        [HttpGet]
        public ActionResult Form(int? IdVideoJuegos)
        {
            ML.VideoJuegos videoJuegos = new ML.VideoJuegos();

            if (IdVideoJuegos != null)
            {
                var result = BL.VideoJuegos.GetById(IdVideoJuegos.Value);
                if (result != null)
                {
                    //UNBOXING
                    videoJuegos = (ML.VideoJuegos)result;
                }

            }
            return View(videoJuegos);
        }
        [HttpPost]
        public ActionResult Form(ML.VideoJuegos VideoJuegos)
        {
            if (ModelState.IsValid)
            {
                if (VideoJuegos.IdVideoJuegos == 0)
                {
                    var result = BL.VideoJuegos.Add(VideoJuegos);
                    if (result != null)
                    {
                        ViewBag.Mensaje = "Se ha ingresado correctamente la informacion del VideoJuego";
                    }
                    else
                    {
                        ViewBag.Mensaje = "No se ha ingresado correctamente la informacion del VideoJuego. Error: " + result;
                    }
                }
                else
                {
                    bool result = BL.VideoJuegos.Update(VideoJuegos);
                    if (result)
                    {
                        ViewBag.Mensaje = "se ha actualizado correctamente la informacion del VideoJuego";
                    }
                    else
                    {
                        ViewBag.Mensaje = "No se ha podido actualizar correctamente la informacion del VideoJuego. Error: " + result;
                    }
                }
            }
            else
            {

            }
            return PartialView("Modal");
        }
        public ActionResult Delete(int? IdVideoJuegos)
        {
            bool result = BL.VideoJuegos.Delete(IdVideoJuegos.Value);
            if (result)
            {
                ViewBag.Mensaje = "Se ha eliminado correctamente la informacion del VideoJuego";
            }
            else
            {
                ViewBag.Mensaje = "NO se ha eliminado correctamente la informacion del VideoJuego. Error: ";
            }
            return PartialView("Modal");
        }
    }
}