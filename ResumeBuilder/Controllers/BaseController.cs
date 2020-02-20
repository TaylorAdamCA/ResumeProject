using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ResumeBuilder.Controllers
{
    /// <summary>
    /// Base controller for all controllers where users must be authorized
    /// </summary>
    [Authorize]
    public abstract class BaseController : Controller { }
}