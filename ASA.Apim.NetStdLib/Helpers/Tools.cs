using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASA.Apim.NetStdLib.Helpers
{
    public static class Tools
    {
        #region GenericCriteria
        public static string GetCriteria(IEnumerable<string> sourceList)
        {
            string criteria = string.Empty;

            if (sourceList != null && sourceList.Any())
            {
                criteria = string.Join("|", sourceList);
                if (!string.IsNullOrEmpty(criteria))
                {
                    if (criteria.StartsWith("|"))
                    {
                        criteria = criteria.Substring(1);
                    }
                    if (criteria.EndsWith("|"))
                    {
                        criteria = criteria.Remove(criteria.Length - 1);
                    }
                }
            }

            return criteria;

        }
        #endregion
    }
}
