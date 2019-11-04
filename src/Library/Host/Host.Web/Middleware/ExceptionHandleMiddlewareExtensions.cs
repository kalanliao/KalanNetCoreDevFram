using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kalan.Lib.Host.Web.Middleware
{
	public static class ExceptionHandleMiddlewareExtensions
	{
		public static IApplicationBuilder UseExceptionHandle(this IApplicationBuilder app)
		{
			app.UseMiddleware<ExceptionHandleMiddleware>();

			return app;
		}
	}
}
