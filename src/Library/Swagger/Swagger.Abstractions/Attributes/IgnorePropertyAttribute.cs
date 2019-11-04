using System;
using System.Collections.Generic;
using System.Text;

namespace Kalan.Lib.Swagger.Abstractions.Attributes
{
	/// <summary>
	/// Swagger：隐藏属性
	/// </summary>
	[AttributeUsage(AttributeTargets.Property)]
	public class IgnorePropertyAttribute : Attribute
	{
	}
}
