using System;
using System.Collections.Generic;
using System.Text;
using MentorshipAutomation.Base.Elements;

namespace MentorshipAutomation.Base
{
    public static class ElementFactory
    {

        public static T Create<T>(Search search) where T : Element, new()
        {
            var element = new T { SearchWrapper = search };
            return element;
        }
    }
}
