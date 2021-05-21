using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourcesExample.Domain
{
    public class BookService
    {
        private readonly IStringLocalizer<SharedResource> _sharedLocalizer;

        public BookService(IStringLocalizer<SharedResource> sharedLocalizer)
        {
            _sharedLocalizer = sharedLocalizer;
        }

        public IEnumerable<string> GetBookTitles()
        {
            return new string[]
            {
                _sharedLocalizer["Harry Potter and the Philosopher's Stone"],
                _sharedLocalizer["The Lord of the Rings: The Fellowship of the Ring"],
                _sharedLocalizer["The Mists of Avalon"]
            };
        }
    }
}
