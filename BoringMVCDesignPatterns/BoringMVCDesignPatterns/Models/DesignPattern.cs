using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoringMVCDesignPatterns.Models
{
    public class DesignPattern
    {

        public string Name;
        public Category Category;
        public string Description;


        public DesignPattern()
        {
            Name = "Change Me";
            Category = Category.Unknown;
            Description = "A brief synopsis of the pattern goes here...";
        }
    }
}