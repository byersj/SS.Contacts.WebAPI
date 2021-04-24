using Microsoft.AspNetCore.Mvc;
using SS.Contacts.WebAPI.Interfaces;
using SS.Contacts.WebAPI.POCOs;
using System;

namespace SS.Contacts.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        #region Variables

        private readonly IContactsSvc _contactsSvc;

        #endregion

        #region Constructors

        public ContactsController(IContactsSvc contactsSvc)
        {
            _contactsSvc = contactsSvc;
        }

        #endregion

        // GET: api/<contacts>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_contactsSvc.SelectAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // GET api/<contacts>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_contactsSvc.Select(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // POST api/<contacts>
        [HttpPost]
        public IActionResult Post([FromBody] Contact contact)
        {
            try
            {
                return Ok(_contactsSvc.Insert(contact));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // PUT api/<contacts>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Contact contact)
        {
            try
            {
                return Ok(_contactsSvc.Update(id, contact));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // DELETE api/<contacts>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                return Ok(_contactsSvc.Delete(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // GET api/<contacts>/call-list
        [Route("call-list")]
        [HttpGet]
        public IActionResult GetCallList()
        {
            try
            {
                return Ok(_contactsSvc.GetCallList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}