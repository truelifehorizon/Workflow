using Domain;
using Microsoft.AspNetCore.Mvc;

namespace Form1.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController(IWorkflowFactory workflowFactory) : ControllerBase
{
    private IWorkflowFactory WorkflowFactory { get; set; } = workflowFactory;

    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<ActionResult> Get()
    {
        var workflow = await  WorkflowFactory.Create<RenewalWorkflow>();
        return Ok($"Create workflow {workflow.ClassName}");
    }
}