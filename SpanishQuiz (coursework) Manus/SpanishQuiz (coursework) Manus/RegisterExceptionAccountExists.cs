using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpanishQuiz__coursework__Manus
{
    class RegisterExceptionAccountExists : Exception
    {
        public RegisterExceptionAccountExists(string customMessage)
            : base(customMessage)
        {
            // null
        }
    }
}
