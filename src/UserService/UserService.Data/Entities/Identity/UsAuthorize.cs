using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserService.Entities;

namespace UserService.Data.Entities.Identity
{
    /// <summary>
    /// 第三方授权
    /// </summary>
    public class UsAuthorize: UniqueEntityBase
    {
        public Guid UserId { get; set; }

        /// <summary>
        /// 第三方标识
        /// </summary>
        [Required]
        public string?  Identity{get; set;} 


        public DateTime AuthorizeDate { get; set; }


        public IdentityType Type { get; set; }

    }

    public enum IdentityType
    {
        Wechat,
        QQ,
        Weibo,
        Douyin,
        Zhihu,
    }
}
