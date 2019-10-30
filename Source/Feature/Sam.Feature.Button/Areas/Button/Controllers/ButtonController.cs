using Glass.Mapper.Sc.Web.Mvc;
using Sam.Feature.Button.Areas.Button.Models.Rendering_Parameters;
using Sam.Feature.Button.Areas.Button.Models.ScModels;
using Sam.Feature.Button.Areas.Button.Models.ViewModels;
using System.Web.Mvc;

namespace Sam.Feature.Button.Areas.Button.Controllers
{
    public class ButtonController : GlassController
    {
        //private readonly IButtonService _buttonService;
        //public ButtonController(IMvcContext mvcContext, IButtonService buttonService) : base(mvcContext)
        //{
        //    _buttonService = buttonService;
        //}
        
        [HttpGet]
        public ActionResult ButtonAction()
        {
            var vm = new ButtonViewModel(GetDataSourceItem<ButtonScModel>(), GetRenderingParameters<ButtonRP>());
            //var vm = _buttonService.Get(_mvcContext);
            return View("~/Areas/Button/Views/Button/Button.cshtml", vm);
        }
    }
}