using FingerFood.Base.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerFood.Base.CustomAttributes
{

    public class RequiredFieldAttribute : RequiredAttribute {
        public RequiredFieldAttribute() {
            ErrorMessageResourceType = typeof(Messages);
            ErrorMessageResourceName = "RequiredField";
        }
    }
}
