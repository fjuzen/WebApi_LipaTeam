using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi_LipaTeam.Models;

namespace WebApi_LipaTeam.Controllers
{
    [AllowAnonymous]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [Route("api/get_response")]
        [HttpPost]
        public MessageModel Get_Response(MessageModel value)
        {
            MessageModel msg = new MessageModel();
            if (value.Text != "")
            {
                msg.Text = "Reponse: " + value.Text;
                return msg;
            }
            return msg;
        }

        [Route("api/get_response1")]
        [HttpGet]
        public async Task<string> Get_Response1()
        {
            var test = "aaa";
            return test;
        }
    }
}
