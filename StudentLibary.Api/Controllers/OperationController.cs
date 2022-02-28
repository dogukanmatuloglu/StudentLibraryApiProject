using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentLibrary.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLibrary.Api.Controllers
{
    [Route("api/[controller][action]")]
    [ApiController]
    public class OperationController : ControllerBase
    {
        IOperationService _operationService;

        public OperationController(IOperationService operationService)
        {
            _operationService = operationService;
        }
    }
}
