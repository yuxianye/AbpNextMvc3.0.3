using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Solution.Materials.Dtos
{
    public class CreateUpdateBOMDto
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