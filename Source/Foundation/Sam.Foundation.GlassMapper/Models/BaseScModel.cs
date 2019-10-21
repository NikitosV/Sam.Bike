using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sam.Foundation.GlassMapper.Models
{
    public class BaseScModel
    {
        [SitecoreId]
        public virtual Guid Id { get; set; }
    }
}