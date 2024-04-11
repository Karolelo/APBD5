using Microsoft.AspNetCore.Mvc;
using WebApplication1.Controlers;

namespace WebApplication1.Controllers;
[Route("api/visit")]
[ApiController]
public class VisitController: ControllerBase
{
    private static readonly List<Visit> _visists = new()
    {
        new Visit(1,new DateTime(2002,10,10),1,"Bla bla",20),
        new Visit(2,new DateTime(2002,10,10),1,"Bla bla",25),
        new Visit(3,new DateTime(2002,10,10),1,"Bla bla",40),
        new Visit(4,new DateTime(2002,10,10),2,"Bla bla",30)
    };



    [HttpGet("{int:id}")]
    public IActionResult getVisistOfAnimal(int idOfAnimal)
    {
        List<Visit> visitsOfAnimal=new List<Visit>();

        foreach (var visit in _visists)
        {
            if (visit.AnimalId == idOfAnimal)
            {
                visitsOfAnimal.Add(visit);
            }
        }

        if (visitsOfAnimal.Count > 0)
        {
            return Ok(visitsOfAnimal);
        }

        return NotFound($"Not found animal with {idOfAnimal}");
    }

    [HttpPost]
    public IActionResult addVisist(Visit visit)
    {
        _visists.Add(visit);
        return StatusCode(StatusCodes.Status201Created);
    }
    
    
    
}