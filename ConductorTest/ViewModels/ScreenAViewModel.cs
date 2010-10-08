using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Caliburn.Micro;

namespace ConductorTest.ViewModels
{
    public class ScreenAViewModel : Screen
    {
        public string Title { get; set; }

        public ScreenAViewModel()
        {
            Title = "Screen A";
        }
    }
}
