using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageLibrary
{
    public class BaseMessage
    {
        public string Content { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (GetType() != obj.GetType()) return false;
            return Content == (obj as BaseMessage).Content;

            //return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return 13 + Content.GetHashCode();
            //return base.GetHashCode();
        }

        public override string ToString()
        {
            return Content.ToString();
        }
    }
}
