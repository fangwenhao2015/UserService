namespace UserService.Data.Entities.Preference
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// 用户偏好设置。例如语言、主题、背景等
    /// </summary>
    public class UsPreference
    {
        public Guid UserId { get; set; }

        public long User { get; set; }
        public long Type { get; set; }
        public string? Key { get; set; }
        public string? Value { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
