using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UserService.Data.Entities;

namespace UserService.Entities
{
    //风格。
    public abstract class UniqueEntityBase:EntityBase
    {
        [Key]
        public Guid Id { get; set; }
    }
}
