using Linq.Homework.Domain.Models;
using System.Collections.Generic;

namespace System
{
    public static class EntityHelper
    {

        public static void PrintEntity<T>(this T entity) where T : BaseEntity
        {
            Console.WriteLine("\n\n*********************");
            if (entity == null)
            {
                Console.WriteLine("Entity does not exist");
                return;
            }
            Console.WriteLine($"Printing {entity.GetType().Name} info : ");
            Console.WriteLine(entity.Info());
        }
        public static void PrintEntities<T>(this List<T> list) where T : BaseEntity
        {
            Console.WriteLine("\n\n*********************");
            if (list.IsEmpty())
            {
                Console.WriteLine("Empty list");
                return;
            }
            Console.WriteLine($"Printing {list[0].GetType().Name}'s");
            foreach (T entity in list)
            {
                Console.WriteLine(entity.Info());
            }
        }
        public static bool IsEmpty<T>(this List<T> list) where T : BaseEntity
        {
            return list.Count == 0;
        }
    }
}
