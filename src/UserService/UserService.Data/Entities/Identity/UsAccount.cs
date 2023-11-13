namespace UserService.Data.Entities.User
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using UserService.Entities;

    /// <summary>
    ///  用户账号
    /// </summary>
    public class UsAccount:UniqueEntityBase
    {
        public Guid UserId { get; set; }

        /// <summary>
        /// 可以系统生成、也可以用户自定义。
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// 账号别名。用户自定义
        /// </summary>
        public string? Alias{get;set; }
    }

}
