using Kalan.Lib.Utils.Core.Extensions;
using System;
using System.Collections.Generic;
using System.IO;

namespace Kalan.Lib.Utils.Core.Options
{
	/// <summary>
	/// 模块通用配置项
	/// </summary>
	public class ModuleCommonOptions
	{
		private string _uploadPath;

		/// <summary>
		/// 文件上传存储跟路径
		/// </summary>
		public string UploadPath
		{
			get => _uploadPath.IsNull() ? Path.Combine(AppContext.BaseDirectory, "Upload") : _uploadPath;
			set => _uploadPath = value;
		}

		/// <summary>
		/// 临时文件存储根路径
		/// </summary>
		public string TempPath { get; set; }
	}
}
