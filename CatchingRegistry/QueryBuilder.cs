using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchingRegistry
{
    public class QueryBuilder
    {
        private static QueryBuilder instance;
        private StringBuilder stringbuilder;
        private List<string> conditions;

        public static QueryBuilder GetInstance()
        {
            if (instance == null)
                instance = new QueryBuilder();

            return instance;
        }

        public QueryBuilder SelectFrom(string tableName)
        {
            stringbuilder = new("SELECT * FROM ");
            conditions = new List<string>();
            stringbuilder.Append(tableName);
            return this;
        }

        public QueryBuilder ByCondition(Dictionary<string, string> dictionary)
        {
            foreach (var condition in dictionary)
                if(!string.IsNullOrWhiteSpace(condition.Value))
                    conditions.Add($"{condition.Key} LIKE '%{condition.Value}%'");

            return this;
        }

        public string GetResult()
        {
            if(conditions.Count > 0)
                stringbuilder.Append(" WHERE ");

            var conditionString = string.Join(" AND ", conditions);
            stringbuilder.Append(conditionString);
            return stringbuilder.ToString();
        }
    }
}
