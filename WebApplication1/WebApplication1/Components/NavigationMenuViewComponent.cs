using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IRepository repository;

        public NavigationMenuViewComponent(IRepository repo)
        {
            repository = repo;
        }
    }
}
