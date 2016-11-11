using FingerFood.Base.Resources;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace FingerFood.Base.CustomAttributes
{

	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
	public class FilePathAttribute : Attribute {
	}
}