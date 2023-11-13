namespace UserService.Data.Entities.Identity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using UserService.Entities;

    /// <summary>
    ///  手机号码
    /// </summary>
    public class UsPhone : UniqueEntityBase
    {

        public Guid UserId { get; set; }

        [Required]
        public string? CountryCode{get;set; }
        /// <summary>
        /// 号码
        /// </summary>
        [Required]
        public string? Number { get; set; }

        /// <summary>
        /// 是否经过验证
        /// </summary>
        public bool  Confirmed{get;set; }

        /// <summary>
        /// 验证时间
        /// </summary>
        public DateTime ConfirmedDate { get; set; }

    }

 
}
