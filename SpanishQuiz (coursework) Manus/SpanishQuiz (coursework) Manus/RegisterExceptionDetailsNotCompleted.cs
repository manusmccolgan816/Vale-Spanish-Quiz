using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpanishQuiz__coursework__Manus
{
    class RegisterExceptionDetailsNotCompleted : Exception
    {
        public RegisterExceptionDetailsNotCompleted(string customMessage)
            : base(customMessage)
        {
            // null
        }
    }
}
