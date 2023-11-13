using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using UserService.Entities;

namespace UserService.Data
{
    public static class UniqueEntityExtensions
    {
        //为实体生成新的主键GUID，用于从原有对象创建新对象。
        public static UniqueEntityBase AsNewEntity(this UniqueEntityBase @this)
        {
            @this.Id = Guid.NewGuid();
            return @this;
        }

    }
}
