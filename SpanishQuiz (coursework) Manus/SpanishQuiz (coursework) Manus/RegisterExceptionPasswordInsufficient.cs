using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpanishQuiz__coursework__Manus
{
    class RegisterExceptionPasswordInsufficient : Exception
    {
        public RegisterExceptionPasswordInsufficient(string customMessage)
            : base(customMessage)
        {
            // null
        }
    }
}
