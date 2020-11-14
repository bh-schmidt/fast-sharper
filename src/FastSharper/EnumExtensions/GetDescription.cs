using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Get the description attribute of the enum value.
        /// </summary>
        /// <param name="myEnum"></param>
        /// <returns></returns>
        public static string? GetDescription(this Enum myEnum)
        {
            if (myEnum.IsNull())
                return null;

            var type = myEnum.GetType();
            var typeInfo = type.GetTypeInfo();
            var memberInfo = typeInfo.GetMember(myEnum.ToString());

            if (memberInfo.IsNullOrEmpty())
                return null;

            var attributes = memberInfo[0].GetCustomAttributes<DescriptionAttribute>();
            var attribute = attributes.FirstOrDefault();

            if (attribute.IsNull())
                return null;

            return attribute.Description;
        }
    }
}
