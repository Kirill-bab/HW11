using DepsWebApp.Models;
using DepsWebApp.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace DepsWebApp.Controllers
{
    /// <summary>
    /// Controller for Authorization and Registration of new
    /// users
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    [Consumes(MediaTypeNames.Application.Json)]
    [Produces(MediaTypeNames.Application.Json)]
    [TypeFilter(typeof(ExceptionFilter))]
    public class AuthorizationController
    {
        private readonly ILogger<AuthorizationController> _logger;

        /// <summary>
        /// public constructor of Authorization controller
        /// </summary>
        /// <param name="loggerFactory"></param>
        public AuthorizationController(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<AuthorizationController>();
        }

        /// <summary>
        /// Post method for registration
        /// </summary>
        /// <param name="model">User login and password</param>
        /// <returns>Exception code</returns>
        [HttpPost]
        [Route("register")]
        [ProducesResponseType(typeof(ProcessedError), 200)]
        public IActionResult Register([FromBody] RegisterValidationModel model)
        {
            throw new NotImplementedException();
        }
    }
}
