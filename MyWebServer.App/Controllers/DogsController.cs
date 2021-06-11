﻿namespace MyWebServer.App.Controllers
{
    using MyWebServer.App.Models.Animals;
    using MyWebServer.Controllers;
    using MyWebServer.Http;

    public class DogsController : Controller
    {
        public DogsController(HttpRequest request) 
            : base(request)
        {
        }

        [HttpGet]
        public HttpResponse Create() => View();

        [HttpPost]
        public HttpResponse Create(DogFormModel model)
            => Text($"Dog: {model.Name} - {model.Age} - {model.Breed}");
    }
}