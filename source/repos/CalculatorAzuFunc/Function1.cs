using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace CalculatorAzuFunc
{
    public static class sum
    {
        [FunctionName("sum")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            //string name = req.Query["name"];

            //string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            //dynamic data = JsonConvert.DeserializeObject(requestBody);
            //name = name ?? data?.name;
            int x = int.Parse(req.Query["x"]);
            int y = int.Parse(req.Query["y"]);
            int result = x + y;

            //string responseMessage = string.IsNullOrEmpty(name)
            //    ? "This HTTP triggered function executed successfully. Pass a name in the query string or in the request body for a personalized response."
            //    : $"Hello, {name}. This HTTP triggered function executed successfully.";

            //return new OkObjectResult(responseMessage);
            return new OkObjectResult(result);
        }
    }
    public static class sub
    {
        [FunctionName("sub")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            int x = int.Parse(req.Query["x"]);
            int y = int.Parse(req.Query["y"]);
            int result = x - y;

            return new OkObjectResult(result);
        }
    }
    public static class div
    {
        [FunctionName("div")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            int x = int.Parse(req.Query["x"]);
            int y = int.Parse(req.Query["y"]);
            int result = x / y;

            return new OkObjectResult(result);
        }
    }
    public static class mult
    {
        [FunctionName("mult")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            int x = int.Parse(req.Query["x"]);
            int y = int.Parse(req.Query["y"]);
            int result = x * y;

            return new OkObjectResult(result);
        }
    }
}
