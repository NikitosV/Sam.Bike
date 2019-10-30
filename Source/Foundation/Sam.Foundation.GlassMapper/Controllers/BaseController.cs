using Glass.Mapper.Sc.Web.Mvc;
using Sitecore.Mvc.Controllers;
using System;
using System.Web.Mvc;

namespace Sam.Foundation.GlassMapper.Controllers
{
    public abstract class BaseController : Controller
    {
        protected readonly IMvcContext _mvcContext;

        public BaseController(IMvcContext mvcContext)
        {
            _mvcContext = mvcContext ?? throw new ArgumentNullException(nameof(mvcContext));
        }
    }
}