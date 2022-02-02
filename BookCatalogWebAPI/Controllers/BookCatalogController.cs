using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BookCatalogWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookCatalogController
    {
        private readonly ILogger<BookCatalogController> _logger;

        public BookCatalogController(ILogger<BookCatalogController> logger)
        {
            _logger = logger;
        }

    }
}
