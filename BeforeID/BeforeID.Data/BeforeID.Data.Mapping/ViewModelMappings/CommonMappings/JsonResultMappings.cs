using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeforeID.Common.ViewModels.CommonViewModels;

namespace BeforeID.Data.Mapping.ViewModelMappings.CommonMappings
{
    public class JsonResultMappings
    {
        public static JsonResultViewModel Success(object data)
        {
            return new JsonResultViewModel()
                   {
                       Status = true,
                       Data = data,
                       IsValid = true
                   };
        }

        public static JsonResultViewModel Error()
        {
            return new JsonResultViewModel()
            {
                Status = false,
            };
        }
    }
}
