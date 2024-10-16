namespace UserService.Data.Entities.Identity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using UserService.Entities;

    /// <summary>
    ///  存储用户标识
    /// </summary>
    public class UsUser : UniqueEntityBase
    {
        /// <summary>
        /// 这个名称相当于显示给用户的标识，根据策略，可以存储用户Account.Name， 手机号，邮箱，第三方账号等。
        /// </summary>

        public string Name { get; set; }

        /// <summary>
        /// 显示名
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// 一个状态标识。 快速判断账户是否可用只有Active是可用状态。
        /// </summary>
        public AccountState State { get; set; }

    }

    public enum AccountState
    {
        Active,
        Inactive,

    }
}
