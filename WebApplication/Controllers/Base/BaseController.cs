﻿using System.Threading.Tasks;
 using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.HttpSys;

namespace WebApplication.Controllers.Base
{
    [ApiController]
    public abstract class BaseController<Req , Res>:Controller
    {
        public abstract Task<ApiResponse<Res>> Response(Req request);
    }
}