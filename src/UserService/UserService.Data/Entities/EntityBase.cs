using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UserService.Data.Entities
{
    /// <summary>
    /// 为了避免与其他类名冲突。所有实体类加上Us前缀（冲突容易导致错误引用类型）
    /// </summary>
    public class EntityBase
    {
        /// <summary>
        /// 更新时间戳
        /// </summary>
        public DateTime TimeStamp { get; set; }

    }
}
