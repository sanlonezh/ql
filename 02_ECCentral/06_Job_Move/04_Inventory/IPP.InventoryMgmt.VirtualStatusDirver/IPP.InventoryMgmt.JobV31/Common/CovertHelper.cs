﻿using System;
using System.Collections.Generic;
using System.Reflection;

namespace IPP.OrderMgmt.JobV31
{
    public static class CovertHelper
    {
        public static string ToListString<T>(this List<T> list)
        {
            string result = string.Empty;
            foreach (var item in list)
            {
                if (item.GetType() == typeof(string))
                {
                    result += "'" + item + "',";
                }
                else
                {
                    result += item + ",";
                }
            }
            return result.TrimEnd(',');
        }

        public static string ToListString<T>(this List<T> list,string PropName)
        {
            string result = string.Empty;           
            Type ty = typeof(T);
            PropertyInfo pty = ty.GetProperty(PropName);           
            foreach (var item in list)
            {
                if (pty!=null)
                {
                    object obj= pty.GetValue(item, null);
                    result += string.Format(obj.GetType() == typeof(Int32) ? "{0}," : "'{0}',", obj); 
                }                
            }
            return result.TrimEnd(',');
        }
    }
}
