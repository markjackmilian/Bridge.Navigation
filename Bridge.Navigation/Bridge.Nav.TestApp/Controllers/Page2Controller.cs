﻿using System;
using System.Collections.Generic;
using Bridge.Html5;
using Bridge.Navigation;

namespace Bridge.Nav.TestApp.Controllers
{
    public class Page2Controller : IAmLoadable
    {
        public void OnLoad(Dictionary<string, object> parameters)
        {
            Global.Alert("Hello from Page 2 Controller");
        }

        public void OnLeave()
        {
            Console.Write("Goodbye page2");
        }
    }
}