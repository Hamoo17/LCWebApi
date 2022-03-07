using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.IO;
using System.Text;

namespace LCWebApi.Server.Extentions
{
    public static class DataTableConverter
    {
        public static string ToJson(this DataTable dt) 
        {
           
               var JSONString = new StringBuilder();
            if (dt.Rows.Count > 0)
            {
                JSONString.Append("[ \n");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    JSONString.Append("{ \n");
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        if (j < dt.Columns.Count - 1)
                        {
                            JSONString.Append("\"" + dt.Columns[j].ColumnName.ToString() + "\":" + "\"" + dt.Rows[i][j].ToString() + "\", \n");
                        }
                        else if (j == dt.Columns.Count - 1)
                        {
                            JSONString.Append("\"" + dt.Columns[j].ColumnName.ToString() + "\":" + "\"" + dt.Rows[i][j].ToString() + "\" \n");
                        }
                    }
                    if (i == dt.Rows.Count - 1)
                    {
                        JSONString.Append("}\n");
                    }
                    else
                    {
                        JSONString.Append("},\n");
                    }
                }
                JSONString.Append("]");
            }
            
            return JSONString.ToString();
        }
        public static string SerializeWithoutQuote(this string value)
        {
            var serializer = JsonSerializer.Create(null);

            var stringWriter = new StringWriter();

            using (var jsonWriter = new JsonTextWriter(stringWriter))
            {
                jsonWriter.QuoteName = false;

                serializer.Serialize(jsonWriter, value);

                return stringWriter.ToString();
            }
        }
        public static List<dynamic> ToDynamic(this DataTable dt)
        {
            var dynamicDt = new List<dynamic>();
            foreach (DataRow row in dt.Rows)
            {
                dynamic dyn = new ExpandoObject();
                dynamicDt.Add(dyn);
                foreach (DataColumn column in dt.Columns)
                {
                    var dic = (IDictionary<string, object>)dyn;
                    dic[column.ColumnName] = row[column];
                }
            }
            return dynamicDt;
        }
        public static List<string> GetCulomnsName(this DataTable dt)
        {
            var dynamicDt = new List<string>();
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                dynamicDt.Add(dt.Columns[i].ColumnName);
            }
            return dynamicDt;
        }
    }
}
