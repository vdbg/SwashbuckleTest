﻿using Swagger_Test.Models;
using System.Web.Http;

namespace Swagger_Test.Controllers
{
    [RoutePrefix("api/FromUri")]
    public class FromUriController : ApiController
    {
        [Route("Test1_WithFromUri")]
        public ViewModelTest GetWith([FromUri] ViewModelTest v)
        {
            return v;
        }

        [Route("Test2_NoFromUri")]
        public ViewModelTest GetWithout(ViewModelTest v)
        {
            return v;
        }
    }
}