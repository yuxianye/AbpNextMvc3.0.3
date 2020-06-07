using System;
using Volo.Abp.Application.Dtos;

namespace Solution.Materials.Dtos
{
    public class BOMDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public Guid ProductId { get; set; }

        public string Version { get; set; }

        public Guid MaterialId { get; set; }

        public int Count { get; set; }

        public bool IsEnabled { get; set; }

        public string Remark { get; set; }
    }
}