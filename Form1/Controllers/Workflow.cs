using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Form1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Workflow(IWorkflowFactory workflowFactory) : ControllerBase
    {
        private IWorkflowFactory WorkflowFactory { get; set; } = workflowFactory;
        
        // GET: api/<Workflow>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Workflow>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            if (id == (int)WorkflowType.Renewal)
            {
                var workflow1 = await WorkflowFactory.Create<RenewalWorkflow>();
                return Ok($"Create workflow {workflow1.ClassName}");
            }

            if (id == (int)WorkflowType.EarlyTermination)
            {
                var workflow2 = await WorkflowFactory.Create<EarlyTerminationWorkflow>();
                return Ok($"Create workflow {workflow2.ClassName}");
            }
            else
            {
                return BadRequest("Workflow type not supported");
            }
        }

        // POST api/<Workflow>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Workflow>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Workflow>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
