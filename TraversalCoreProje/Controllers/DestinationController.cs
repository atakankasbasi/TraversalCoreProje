using BusinessLayer.Concrete;
using DataAccesslayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers
{
	public class DestinationController : Controller
	{
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
		{
            var values = destinationManager.TGetList();
            return View(values);
		}
	}
}
