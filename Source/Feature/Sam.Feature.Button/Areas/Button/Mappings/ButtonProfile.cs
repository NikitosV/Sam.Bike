using AutoMapper;
using Sam.Feature.Button.Areas.Button.Models.Rendering_Parameters;
using Sam.Feature.Button.Areas.Button.Models.ScModels;
using Sam.Feature.Button.Areas.Button.Models.ViewModels;

namespace Sam.Feature.Button.Areas.Button.Mappings
{
    public class ButtonProfile : Profile
    {
        public ButtonProfile()
        {
            CreateMap<ButtonScModel, ButtonViewModel>()
                .ReverseMap();

            CreateMap<ButtonRP, ButtonViewModel>()
                .ForMember(vm => vm.Id, opt => opt.Ignore())
                .ForMember(vm => vm.Class, opt => opt.MapFrom(rp => rp.Style.Class));
        }
    }
}