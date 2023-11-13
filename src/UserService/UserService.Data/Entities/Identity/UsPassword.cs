using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserService.Entities;

namespace UserService.Data.Entities.User
{
    /// <summary>
    /// 用户密码
    /// </summary>
    public class UsPassword: UniqueEntityBase
    {

        public Guid UserId { get; set; }

        /// <summary>
        /// 盐
        /// </summary>
        [Required]
        public string? Salt { get; set; }

        /// <summary>
        /// 散列. Base64存储。
        /// </summary>
        [Required]
        public string? Hash { get; set; }
    }
}
