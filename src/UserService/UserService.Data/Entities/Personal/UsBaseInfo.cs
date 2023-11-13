namespace UserService.Data.Entities.Personal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    // 用户扩展基本信息
    public class UsBaseInfo
    {
        [Key]
        public long ID { get; set; }
        public long User { get; set; }
        public string? Name { get; set; }
        public long Sex { get; set; }
        public DateTime Birthday { get; set; }
        public string? NickName { get; set; }
        public string? Signature { get; set; }
        public long IconType { get; set; }
        public long? IconLong { get; set; }
        public string? IconString { get; set; }
        public byte[]? IconByte { get; set; }
        public long Level { get; set; }
        public DateTime TimeStamp { get; set; }

    }
}
