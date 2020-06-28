using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Solution.Materials.Dtos
{
    public class BOMDto : AuditedEntityDto<Guid>
    {
        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        public string Name { get; set; }

        public Guid ProductId { get; set; }

        [StringLength(MySolutionConsts.StringLength64)]
        public string Version { get; set; }

        public Guid MaterialId { get; set; }

        public int Count { get; set; }

        public bool IsEnabled { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        public string Remark { get; set; }
    }
}