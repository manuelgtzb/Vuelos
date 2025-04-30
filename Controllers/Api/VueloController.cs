using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/vuelos")]

public class VueloController : Controller {
    [HttpGet("aterrizados")]

    public IActionResult Aterrizado() {
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Aeropuerto");
        var collection = db.GetCollection<Vuelo>("Vuelos");

        var filtro = Builders<Vuelo>.Filter.Eq(x => x.estatus_vuelo, "Aterrizado");   
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
        }
}