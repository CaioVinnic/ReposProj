using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AtualizaLatLon_Google_Cep
{
    public static class Extensions
    {
        public static List<T> ToList<T>(this DataTable dataTable) where T : new()
        {
            var dataList = new List<T>();

            //Define what attributes to be read from the class
            const BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;

            //Read Attribute Names and Types
            var objFieldNames = typeof(T).GetProperties(flags).Cast<PropertyInfo>().
                Select(item => new
                {
                    Name = item.Name,
                    Type = Nullable.GetUnderlyingType(item.PropertyType) ?? item.PropertyType
                }).ToList();

            //Read Datatable column names and types
            var dtlFieldNames = dataTable.Columns.Cast<DataColumn>().
                Select(item => new
                {
                    Name = item.ColumnName,
                    Type = item.DataType
                }).ToList();

            foreach (DataRow dataRow in dataTable.Select().ToList())
            {
                var classObj = new T();

                foreach (var dtField in dtlFieldNames)
                {
                    PropertyInfo propertyInfos = classObj.GetType().GetProperty(dtField.Name);

                    var field = objFieldNames.Find(x => x.Name == dtField.Name);

                    if (field != null)
                    {
                        if (propertyInfos.PropertyType == typeof(DateTime?))
                        {
                            object value = dataRow[dtField.Name];
                            propertyInfos.SetValue
                            (
                            classObj, value == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dataRow[dtField.Name]), null);
                        }
                        else if (propertyInfos.PropertyType == typeof(DateTime))
                        {
                            object value = dataRow[dtField.Name];
                            propertyInfos.SetValue
                            (
                            classObj, value == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dataRow[dtField.Name]), null);
                        }
                        else if (propertyInfos.PropertyType == typeof(int))
                        {
                            object value = dataRow[dtField.Name];
                            propertyInfos.SetValue
                                (classObj, value == DBNull.Value ? (int?)null : Convert.ToInt32(dataRow[dtField.Name]), null);
                        }
                        else if (propertyInfos.PropertyType == typeof(long))
                        {
                            object value = dataRow[dtField.Name];
                            propertyInfos.SetValue
                            (classObj, value == DBNull.Value ? (long?)null : Convert.ToInt64(dataRow[dtField.Name]), null);
                        }
                        else if (propertyInfos.PropertyType == typeof(decimal))
                        {
                            object value = dataRow[dtField.Name];
                            propertyInfos.SetValue
                            (classObj, value == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dataRow[dtField.Name]), null);
                        }
                        else if (propertyInfos.PropertyType == typeof(String))
                        {
                            if (dataRow[dtField.Name].GetType() == typeof(DateTime))
                            {
                                propertyInfos.SetValue
                                (classObj, Convert.ToDateTime(dataRow[dtField.Name]), null);
                            }
                            else
                            {
                                propertyInfos.SetValue
                                (classObj, (dataRow[dtField.Name]).ToString(), null);
                            }
                        }
                        else if (propertyInfos.PropertyType == typeof(byte[]))
                        {
                            object value = dataRow[dtField.Name];
                            propertyInfos.SetValue
                            (classObj, value == DBNull.Value ? (byte?)null : dataRow[dtField.Name], null);
                        }
                    }
                }
                dataList.Add(classObj);
            }
            return dataList;
        }

    }
}
