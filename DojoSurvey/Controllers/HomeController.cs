using Microsoft.AspNetCore.Mvc;


// Inherits from the abstract base controller class
// Inherits helpful methods for handling HTTP req/res cycle
public class HomeController : Controller {

    [HttpGet("")]
    public ViewResult Index()
    {
        return View("Index");
    }

    [HttpPost]
    [Route("survey")]
    public IActionResult Survey(string name, string location, string language, string comment) {

        ViewBag.Name = name;
        ViewBag.Location = location;
        ViewBag.Language = language;
        ViewBag.Comment = comment;
        return View("PostResult");
    }

    // [HttpGet("/videos")]
    // public IActionResult Videos() {
    //     List<string> youtubeVideos = new List<string>() {

    //         "yT3_vLQ3jbM", "fbqHK8i-HdA"
    //     };

    //     ViewBag.youtubeVideos = youtubeVideos;
    //     ViewBag.Title = $"Here are {ViewBag.youtubeVideos.Count} of my favorite videos";
    //     return View("Videos");
    // }

    // [HttpGet("/showingModel")]
    // public IActionResult ModelDisplay() {
    //     List<int> myNums = new List<int>() {1, 2, 3};
    //     MyModel someModel = new MyModel("squirtle", myNums);

    //     ViewBag.MyModel = someModel;
    //     return View("ModelDispaly");
    // }


}