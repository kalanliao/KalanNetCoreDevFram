using System;
using System.ComponentModel.DataAnnotations;
using Kalan.Lib.Data.Query;

namespace Kalan.Module.Quartz.Domain.JobLog.Models
{
    public class JobLogQueryModel : QueryModel
    {
        /// <summary>
        /// ������
        /// </summary>
        [Required(ErrorMessage = "��ѡ������")]
        public Guid JobId { get; set; }

        /// <summary>
        /// ��ʼ����
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public DateTime? EndDate { get; set; }
    }
}
