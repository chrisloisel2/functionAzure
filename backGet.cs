using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Company.Function
{

	public class Post{
		public string titre {get; set;}
		public string contenu {get; set;}
	}

    public class backGet
    {
        private readonly ILogger<backGet> _logger;

        public backGet(ILogger<backGet> logger)
        {
            _logger = logger;
        }

        [Function("backGet")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
			Post post = new Post{
				titre = "Vacances au soleil",
				contenu = "https://i.imgur.com/eLBait7.jpg"
			};
            return new OkObjectResult(post);
        }

    }
}
