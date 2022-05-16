//using System.Linq.Expressions;

//namespace EnvironmentPathCleanup
//{
//  internal class Scratch<T>
//  {

//    public int NotAProperty;

//    public int AProperty { get; set; }


//    public string GetPropertyName<P>(Expression<Func<T,P>> expression!!)// where P : IComparable
//    {
//      var member = ((MemberExpression)expression.Body).Member;

//      return member.MemberType == System.Reflection.MemberTypes.Property
//        ? member.Name
//        : throw new ArgumentException($"{typeof(T).FullName}.{member.Name} is not Property.");

//    }


//  }
//}
