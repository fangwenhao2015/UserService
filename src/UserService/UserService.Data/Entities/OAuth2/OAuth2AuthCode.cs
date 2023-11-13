using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace UserService.Data.Entities.OAuth2
{
    /// <summary>
    /// 适用于OAuth2的授权码
    /// </summary>
    public class OAuth2AuthCode
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// 授权码
        /// </summary>
        [Required]
        public string? AuthCode { get; set; }

        /// <summary>
        /// 授予客户端Id，即应用程序
        /// </summary>
        public Guid ClientId { get; set; }

        /// <summary>
        /// 授予的用户
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// 重定向URL
        /// </summary>
        [Required]
        public string? RedirectUri { get; set; }

        /// <summary>
        /// 到期后自动更改状态
        /// </summary>
        public DateTime ExpireDate { get; set; }


        /// <summary>
        /// 授权码已授予
        /// </summary>
        public AuthCodeState State { get; set; }

        /// <summary>
        /// 状态时间
        /// </summary>
        public DateTime StateDate { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        public DateTime? TimeStamp { get; set; }

        [Timestamp]
        public byte[]? EntityVersion { get; set; }
    }

    /// <summary>
    /// 授权码状态
    /// </summary>
    public enum AuthCodeState
    {
        Available = 1, //用户刚刚生成
        Authenticated = 2,//已经认证，应用程序已经换取token
        Expired = 3 //因为到期时间，已经过有效期。
    }
}
