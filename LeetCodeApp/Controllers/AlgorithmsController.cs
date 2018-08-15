using System.Collections.Generic;
using LeetCode.Manager;
using LeetCode.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LeetCodeApp.Controllers
{
    [Route("api/algorithms")]
    public class AlgorithmsController : Controller
    {
        private readonly TaskManager _taskManager = new TaskManager();

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Task> Get()
        {
            return _taskManager.GetTaskList();
        }

        //// GET api/<controller>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<controller>
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/<controller>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
