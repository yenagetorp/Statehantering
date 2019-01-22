using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StateHantering.Models
{
    public class StateHandler
    {
        Controller controller;
        public StateHandler(Controller controller)
        {
            this.controller = controller;
        }

        internal void SetTempData(string message)
        {
            controller.TempData["Message"] = message;
        }

        internal string GetTempData()
        {
            return (string)controller.TempData["Message"];
        }
    }
}
