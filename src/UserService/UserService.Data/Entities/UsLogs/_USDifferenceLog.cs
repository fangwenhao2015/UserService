namespace UserService.Data.Entities.Log
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class _USDifferenceLog
    {

        [Key]
        public long ID { get; set; }

        //1=User ,2=Group ,3=GroupUser
        public long Featue { get; set; }

        //数据ID
        public long Data { set; get; }

        //1=Add ,2=Update ,3=Delete
        public long ActionType { get; set; }

        public DateTime TimeStamp { get; set; }

    }
}
