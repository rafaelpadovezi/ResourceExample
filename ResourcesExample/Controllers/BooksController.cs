using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using ResourcesExample.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResourcesExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IStringLocalizer<BooksController> _localizer;
        private readonly IStringLocalizer<SharedResource> _sharedLocalizer;
        private readonly BookService _bookService;

        public BooksController(
            IStringLocalizer<BooksController> localizer,
            IStringLocalizer<SharedResource> sharedLocalizer,
            BookService bookService)
        {
            _localizer = localizer;
            _sharedLocalizer = sharedLocalizer;
            _bookService = bookService;
        }

        [HttpGet]
        public IEnumerable<string> GetBooks()
        {
            return new string[]
           {
                _localizer["Harry Potter and the Philosopher's Stone"],
                _localizer["The Lord of the Rings: The Fellowship of the Ring"],
                _localizer["The Mists of Avalon"]
           };
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetBook(int id)
        {
            return BadRequest(_localizer["Book not found"].ToString());
        }
    }
}
