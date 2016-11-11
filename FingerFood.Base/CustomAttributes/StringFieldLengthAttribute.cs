using FingerFood.Base.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerFood.Base.CustomAttributes
{

	public class StringFieldLengthAttribute : StringLengthAttribute {
		
		public StringFieldLengthAttribute(int maximumLength)
			: base(maximumLength) {
			ErrorMessageResourceType = typeof(Messages);
			ErrorMessageResourceName = "StringFieldLength";
		}
	}
}
