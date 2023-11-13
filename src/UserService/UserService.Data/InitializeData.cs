using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace UserService.Data
{
    public static class DataManager
    {
        static Guid AUTHOR = new Guid("00000000-0000-0000-0000-000000000000");
        static DateTime NOW = DateTime.Now;
        public static void Initialize(this DbContext db)
        {
            db.SaveChanges();
        }

        public static void ResetInitialize(this DbContext db)
        {
            //先执行清理；
            ClearSystem(db);

            db.SaveChanges();
        }


        /// <summary>
        /// 创建一个默认的Administrator用户，没有初始密码
        /// </summary>
        public static void UserInit()
        {


        }


        //清理全库
        public static void ClearFull(this DbContext db)
        {
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            //db.del
            //var types=db.Model.GetEntityTypes();
            //var method = db.GetType().GetMethod("Set");
            //foreach (var type in types)
            //{
            //    RelationalQueryableExtensions new IQuery()
                   
            //    var s=  method.MakeGenericMethod(type.ClrType).Invoke(db, null) as IQueryable<>;
            //    s.
            //}
        }


        static void ClearSystem(DbContext db)
        {

        }

    }
}
