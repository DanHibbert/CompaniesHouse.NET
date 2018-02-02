using System.Collections.Generic;
using System.Linq;

namespace CompaniesHouse.Tests.ResourceBuilders.CompanyChargesResource
{
    public class CompanyChargesResourceBuilder
    {
        private readonly CompanyCharges _companyCharges;

        public CompanyChargesResourceBuilder(CompanyCharges companyCharges)
        {
            _companyCharges = companyCharges;
        }

        public string Create()
        {
            return $@"{{
   ""etag"" : ""{_companyCharges.Etag}"",
   ""items"" : [
  {string.Join(",", _companyCharges.Items.Select(GetItemJsonBlock))}
   ],
   ""part_satisfied_count"" : ""{_companyCharges.PartSatisfiedCount}"",
   ""satisfied_count"" : ""{_companyCharges.SatisfiedCount}"",
   ""total_count"" : ""{_companyCharges.TotalCount}"",
   ""unfiletered_count"" : ""{_companyCharges.UnfilteredCount}""
}}";
        }

        private string GetItemJsonBlock(ChargeItem item)
        {
            return $@"{{
         ""acquired_on"" : ""{item.AcquiredOn:yyyy-MM-dd}"",
         ""assets_ceased_released"" : ""{item.AssetsCeasedReleasedType}"",
         ""charge_code"" : ""{item.ChargeCode}"",
         ""charge_number"" : ""{item.ChargeNumber}"",
         ""classification"" : {{
            ""description"" : ""{item.Classification.Description}"",
            ""type"" : ""{item.Classification.ClassificationType}""
         }},
         ""covering_instrument_date"" : ""{item.CoveringInstrumentDate:yyyy-MM-dd}"",
         ""created_on"" : ""{item.CreatedOn:yyyy-MM-dd}"",
         ""delivered_on"" : ""{item.DeliveredOn:yyyy-MM-dd}"",
         ""etag"" : ""{item.Etag}"",
         ""id"" : ""{item.Id}"",
         ""insolvency_cases"" : [
  {string.Join(",", item.InsolvencyCases.Select(GetInsolvencyBlock))}
         ],
         ""links"" : {{
            ""self"" : ""{item.Links.Self}""
         }},
         ""more_than_four_persons_entitled"" : ""{item.MoreThanFourPersonsEntitled}"",
         ""particulars"" : {{
            ""chargor_acting_as_bare_trustee"" : ""{item.Particulars.ChargorActingAsBareTrustee}"",
            ""contains_fixed_charge"" : ""{item.Particulars.ContainsFixedCharge}"",
            ""contains_floating_charge"" : ""{item.Particulars.ContainsFloatingCharge}"",
            ""contains_negative_pledge"" : ""{item.Particulars.ContainsNegativePledge}"",
            ""description"" : ""{item.Particulars.Description}"",
            ""floating_charge_covers_all"" : ""{item.Particulars.FloatingChargeCoversAll}"",
            ""type"" : ""{item.Particulars.Type}""
         }},
         ""persons_entitled"" : [
  {string.Join(",", item.PersonsEntitled.Select(GetPersonsEntitleBlock))}
         ],
         ""resolved_on"" : ""{item.ResolvedOn:yyyy-MM-dd}"",
         ""satisfied_on"" : ""{item.SatisfiedOn:yyyy-MM-dd}"",
         ""scottish_alterations"" : {{
            ""has_alterations_to_order"" : ""{item.ScottishAlterations.HasAlterationsToOrder}"",
            ""has_alterations_to_prohibitions"" : ""{item.ScottishAlterations.HasAlterationsToProhibitions}"",
            ""has_restricting_provisions"" : ""{item.ScottishAlterations.HasRestrictingProvisions}""
         }},
         ""secured_details"" : {{
            ""description"" : ""{item.SecuredDetails.Description}"",
            ""type"" : ""{item.SecuredDetails.Type}""
         }},
         ""status"" : ""{item.StatusType}"",
         ""transactions"" : [
  {string.Join(",", item.Transactions.Select(GetTransactionsBlock))}
         ]
      }}
";
        }

        private object GetTransactionsBlock(Transaction transaction)
        {
            return $@"            {{
               ""delivered_on"" : ""{transaction.DeliveredOn}"",
               ""filing_type"" : ""{transaction.FilingType}"",
               ""insolvency_case_number"" : ""{transaction.InsolvencyCaseNumber}"",
               ""links"" : {{
                  ""filing"" : ""{transaction.Links.Filing}"",
                  ""insolvency_case"" : ""{transaction.Links.InsolvencyCase}""
               }},
               ""transaction_id"" : ""{transaction.TransactionId}""
            }}
";
        }

        private object GetPersonsEntitleBlock(PersonsEntitled personEntitled)
        {
            return $@"{{
               ""name"" : ""{personEntitled.Name}""
            }}";        }

        private object GetInsolvencyBlock(InsolvencyCases insolvencyCase)
        {
            return $@"{{
               ""case_number"" : ""{insolvencyCase.CaseNumber}"",
               ""links"" : {{
                  ""case"" : ""{insolvencyCase.Links.Case}""
               }},
               ""transaction_id"" : ""{insolvencyCase.TransactionId}""
            }}
";        }

        private string GetDictionaryJsonBlock(KeyValuePair<string, string> pair)
        {
            return $@"""{pair.Key}"" : ""{pair.Value}""";
        }

    }
}
