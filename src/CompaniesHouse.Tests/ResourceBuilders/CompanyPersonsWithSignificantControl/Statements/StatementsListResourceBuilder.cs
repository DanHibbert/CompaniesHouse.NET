using System.Linq;
using CompaniesHouse.Response.CompanyPersonsWithSignificantControl.Statements;

namespace CompaniesHouse.Tests.ResourceBuilders.CompanyPersonsWithSignificantControl.Statements
{
    public class StatementsListResourceBuilder
    {
        private readonly StatementList _statementList;

        public StatementsListResourceBuilder(StatementList statementList)
        {
            _statementList = statementList;
        }

        //public string Create()
        //{
        //    return $@"{{
        //               ""etag"" : ""{_companyPersonsWithSignificantControl.ETag}"",
        //               ""filing_history_status"" : ""{_companyPersonsWithSignificantControl.HistoryStatus}"",
        //               ""items"" : [
        //                   {string.Join(",", _companyPersonsWithSignificantControl.Items.Select(GetItemJsonBlock))}
        //               ],
        //               ""items_per_page"" : ""{_companyPersonsWithSignificantControl.ItemsPerPage}"",
        //               ""kind"" : ""{_companyFilingHistory.Kind}"",
        //               ""start_index"" : ""{_companyFilingHistory.StartIndex}"",
        //               ""total_count"" : ""{_companyFilingHistory.TotalCount}""
        //            }}";
        //}

        public string Create()
        {
            return $@"{{
  ""total_results"": {_statementList.Items.Count},
  ""ceased_count"": 0,
  ""active_count"": {_statementList.Items.Count},
  ""start_index"": 0,
  ""items_per_page"": 25
  ""links"": {{
    ""self"": ""{_statementList.Links.Self}"",
    ""persons_with_significant_control_list"": ""{_statementList.Links.PersonWithSignificantControl}""
  }},
  ""items"": [
    {string.Join(",", _statementList.Items.Select(GetItemJsonBlock))}
  ]
}}";
        }

        private string GetItemJsonBlock(StatementItem item)
        {
            return $@"{{
      ""etag"": ""{item.Etag}"",
      ""statement"": ""{item.Statement}"",
      ""links"": {{
        ""self"": ""{item.Links.Self}""
        ""person_with_significant_control"": ""{item.Links.PersonWithSignificantControl}""
      }},
      ""kind"": ""{item.Kind}"",
      ""notified_on"": ""{item.NotifiedOn:yyyy-MM-dd}""
    }}";
        }

    }
}
