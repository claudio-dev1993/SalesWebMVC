using System;

namespace SalesWebMVC.Services.Excpetions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base(message)
        {

        }
    }
}
