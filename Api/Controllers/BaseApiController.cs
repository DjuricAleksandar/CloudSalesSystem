﻿using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public abstract class BaseApiController : ControllerBase;