using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using ValidationAttributes.Attributes;

namespace ValidationAttributes.Models
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            Type objectType = obj.GetType();
            PropertyInfo[] properties = objectType.GetProperties().Where(p => p.CustomAttributes.Any(a => a.AttributeType.BaseType == typeof(MyValidationAttribute))).ToArray();
            foreach (PropertyInfo property in properties)
            {
                object valueOfProperty = property.GetValue(obj);
                foreach (CustomAttributeData attribute in property.CustomAttributes)
                {
                    Type attributeType = attribute.AttributeType;
                    object attributeInstance = property.GetCustomAttribute(attributeType);
                    MethodInfo method = attributeType.GetMethods().First(m => m.Name == "IsValid");
                    bool result = (bool)method.Invoke(attributeInstance, new object[] { valueOfProperty});
                    if (!result)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        
    }
}
