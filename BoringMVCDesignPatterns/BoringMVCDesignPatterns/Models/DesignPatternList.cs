using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoringMVCDesignPatterns.Models
{
    public class DesignPatternList
    {
        public List<DesignPattern> designPatterns;

        public DesignPatternList()
        {
            designPatterns = new List<DesignPattern>();
        }
    }
}