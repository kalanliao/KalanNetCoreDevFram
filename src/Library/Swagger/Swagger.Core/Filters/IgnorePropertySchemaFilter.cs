using Kalan.Lib.Swagger.Abstractions.Attributes;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Linq;
using System.Reflection;

namespace Kalan.Lib.Swagger.Core.Filters
{
	public class IgnorePropertySchemaFilter : ISchemaFilter
	{
		public void Apply(OpenApiSchema schema, SchemaFilterContext context)
		{
			if (schema?.Properties == null)
			{
				return;
			}

			var ignoreProperties = context.ApiModel.Type.GetProperties().Where(t => t.GetCustomAttribute<IgnorePropertyAttribute>() != null);

			foreach (var ignorePropertyInfo in ignoreProperties)
			{
				var propertyToRemove = schema.Properties.Keys.SingleOrDefault(x => x.ToLower() == ignorePropertyInfo.Name.ToLower());

				if (propertyToRemove != null)
				{
					schema.Properties.Remove(propertyToRemove);
				}
			}

		}
	}
}
