using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchingRegistry.Utils
{
    public class QueryBuilder
    {
        private static QueryBuilder instance;
        private StringBuilder stringbuilder;
        private List<string> conditions;
        private List<string> filter;

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
            filter = new List<string>();
            stringbuilder.Append(tableName);
            return this;
        }

        public QueryBuilder ByCondition(Dictionary<string, string> dictionary)
        {
            foreach (var condition in dictionary)
            {
                if (!string.IsNullOrWhiteSpace(condition.Value))
                {
                    var filterValue = condition.Value.Split("&")[0];
                    var sortValue = condition.Value.Split("&")[1];
                    if (filterValue.Length > 0)
                        conditions.Add($"{condition.Key} LIKE '%{filterValue}%'");

                    filter.Add($"{condition.Key} {sortValue}");
                }
            }

            return this;
        }

        public string GetResult()
        {
            if (conditions.Count > 0)
                stringbuilder.Append(" WHERE ");

            var conditionString = string.Join(" AND ", conditions);
            stringbuilder.Append(conditionString);

            if (filter.Count > 0)
                stringbuilder.Append(" ORDER BY ");

            var filterString = string.Join(", ", filter);
            stringbuilder.Append(filterString);


            return stringbuilder.ToString();
        }
    }
}
