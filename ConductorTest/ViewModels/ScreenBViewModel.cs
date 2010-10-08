using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Caliburn.Micro;

namespace ConductorTest.ViewModels
{
    public class ScreenBViewModel : Screen
    {
        public string Title { get; set; }

        public ScreenBViewModel()
        {
            Title = "Screen B";
        }
    }
}
