namespace UserService.Data.Entities.Log
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class _USLog
    {

        [Key]
        public long ID { get; set; }

        public long User { get; set; }

        public long Type { get; set; }

        public string? Info { set; get; }

        public string? Data { get; set; }

        public string? Host { get; set; }

        public long TerminalType { get; set; }

        public string? TerminalName { get; set; }

        public string? Loction { get; set; }

        public DateTime Time { get; set; }

        public DateTime TimeStamp { get; set; }

    }
}
