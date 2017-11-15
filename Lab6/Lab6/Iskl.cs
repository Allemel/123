using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    [Serializable]
    class CustomException:Exception
    {
        
        public CustomException() { }

        public CustomException(string message) : base(message) { }

        public CustomException(string message, Exception inner) : base(message, inner) { }

        protected CustomException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    

    }

    class EmptyNameException:Exception
    {
         public EmptyNameException() { }

        public EmptyNameException(string message) : base(message) { }

        public EmptyNameException(string message, Exception inner) : base(message, inner) { }

        protected EmptyNameException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    
    }

    class ZeroException:Exception
    {
         public ZeroException() { }

        public ZeroException(string message) : base(message) { }

        public ZeroException(string message, Exception inner) : base(message, inner) { }

        protected ZeroException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    
    }
}
