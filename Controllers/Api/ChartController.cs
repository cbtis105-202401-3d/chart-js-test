using ChartJsTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChartJsTest.Controllers.Api;

[ApiController, Route("api/graficas")]
public class ChartController : ControllerBase {

    [HttpGet("rendimiento-individual")]
    public IActionResult RendimientoIndividual() {
        List<CalificacionModel> list = new List<CalificacionModel>();

        list.Add(new CalificacionModel { Materia = "Base de Datos" });
        list.Add(new CalificacionModel { Materia = "Inglés V" });
        list.Add(new CalificacionModel { Materia = "Aplicaciones Web" });
        list.Add(new CalificacionModel { Materia = "Geometría Analítica" });
        list.Add(new CalificacionModel { Materia = "Ecología" });
        list.Add(new CalificacionModel { Materia = "Temas de Física" });

        Random rnd = new Random();
        foreach(CalificacionModel model in list){
            double val = rnd.NextDouble();
            model.Calificacion = decimal.Round((decimal)val * 10M, 0);
        }
        
        return Ok(list);
    }
}