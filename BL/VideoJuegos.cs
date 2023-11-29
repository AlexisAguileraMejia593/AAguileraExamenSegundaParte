using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class VideoJuegos
    {
        public static ML.VideoJuegos GetAll()
        {
            ML.VideoJuegos videoJuegosOBJ = new ML.VideoJuegos();
            videoJuegosOBJ.VideoJuegoss = new List<ML.VideoJuegos>();
            try
            {
                using (DL.AAguileraExamenSegundaParteEntities context = new DL.AAguileraExamenSegundaParteEntities())
                {
                    var query = context.VideoJuegosGetAll();
                    if(query != null)
                    {
                        foreach(var registro in query)
                        {
                            ML.VideoJuegos videoJuegos = new ML.VideoJuegos();
                            videoJuegos.IdVideoJuegos = registro.IdVideoJuegos;
                            videoJuegos.Nombre = registro.Nombre;
                            videoJuegos.Descripcion = registro.Descripcion;
                            videoJuegos.Año = registro.AÑO;
                            videoJuegos.Compañia = registro.Compañia;
                            videoJuegos.Ventas = registro.Ventas.Value;
                            videoJuegosOBJ.VideoJuegoss.Add(videoJuegos);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No hay ningun registro en la tabla");
                    }
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return videoJuegosOBJ;
        }

        public static ML.VideoJuegos GetById(int IdVideoJuegos)
        {
            ML.VideoJuegos result = null;
            try
            {
                using(DL.AAguileraExamenSegundaParteEntities context = new DL.AAguileraExamenSegundaParteEntities())
                {
                    var query = context.VideoJuegosGetById(IdVideoJuegos).FirstOrDefault();
                    if(query != null)
                    {
                        ML.VideoJuegos videoJuegos = new ML.VideoJuegos();
                        videoJuegos.IdVideoJuegos = query.IdVideoJuegos;
                        videoJuegos.Nombre = query.Nombre;
                        videoJuegos.Descripcion = query.Descripcion;
                        videoJuegos.Año = query.AÑO;
                        videoJuegos.Compañia = query.Compañia;
                        videoJuegos.Ventas = query.Ventas.Value;

                        result = videoJuegos;
                    }
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        public static string Add(ML.VideoJuegos videoJuegos)
        {
            try
            {
                using (DL.AAguileraExamenSegundaParteEntities context = new DL.AAguileraExamenSegundaParteEntities())
                {
                    var query = context.VideoJuegosAdd(
                                        videoJuegos.Nombre,
                                        videoJuegos.Descripcion,
                                        videoJuegos.Año,
                                        videoJuegos.Compañia,
                                        videoJuegos.Ventas);
                    if (query > 0)
                    {
                        return query.ToString();
                    }
                    else
                    {
                        return "false";
                    }
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "";
        }
        public static bool Update(ML.VideoJuegos videoJuegos)
        {
            try
            {
                using (DL.AAguileraExamenSegundaParteEntities context = new DL.AAguileraExamenSegundaParteEntities())
                {
                    var query = context.VideoJuegosUpdate(
                                        videoJuegos.IdVideoJuegos,
                                        videoJuegos.Nombre,
                                        videoJuegos.Descripcion,
                                        videoJuegos.Año,
                                        videoJuegos.Compañia,
                                        videoJuegos.Ventas);
                    if (query > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        public static bool Delete(int IdVideoJuegos)
        {
            try
            {
                using(DL.AAguileraExamenSegundaParteEntities context = new DL.AAguileraExamenSegundaParteEntities())
                {
                    var query = context.VideoJuegosDelete(IdVideoJuegos);
                    if(query > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}