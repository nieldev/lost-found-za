using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LostAndFound.Data;

namespace LostAndFound.BaseClasses
{
    public abstract class BaseController : Controller
    {
        protected LostAndFoundContext _context;

 
        protected BaseController()
        {


            if (_context == null)
            {
                _context = new LostAndFoundContext();
            }

        }

       
    }
}