using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Estimationtool.Helper
{
   public static class ReflectionExtensions
    {
        public static string getPropertyValue(this object Target,
        string PropertyName
        )
        {
            if (Target == null) return null; //or throw exception

            System.Reflection.PropertyInfo prop = Target.GetType().GetProperty(PropertyName);

            if (prop == null) return null; //or throw exception

            object value = prop.GetValue(Target, null);
            return value.ToString();

       
        }

        public static PropertyInfo getPropertyname(this object Target,
       string PropertyName
       )
        {
            if (Target == null) return null; //or throw exception

            System.Reflection.PropertyInfo prop = Target.GetType().GetProperty(PropertyName);

         
            return prop;


        }





    }
}
