using System.Collections.Generic;
using CompaniesHouse.Response;
using CompaniesHouse.Response.CompanyCharges;
using CompaniesHouse.Response.CompanyFiling;
using CompaniesHouse.Response.CompanyPersonsWithSignificantControl;
using CompaniesHouse.Response.CompanyPersonsWithSignificantControl.Corporate;
using CompaniesHouse.Response.CompanyPersonsWithSignificantControl.Legal;
using CompaniesHouse.Response.CompanyPersonsWithSignificantControl.Statements;
using CompaniesHouse.Response.CompanyPersonsWithSignificantControl.SuperSecure;
using CompaniesHouse.Response.CompanyProfile;

namespace CompaniesHouse.Tests
{
    public static class EnumerationMappings
    {

        public static readonly IReadOnlyDictionary<string, LastAccountsType> PossibleLastAccountsTypes = new Dictionary
            <string, LastAccountsType>()
        {
            {"null", LastAccountsType.Null},
            {"full", LastAccountsType.Full},
            {"small", LastAccountsType.Small},
            {"medium", LastAccountsType.Medium},
            {"group", LastAccountsType.Group},
            {"dormant", LastAccountsType.Dormant},
            {"interim", LastAccountsType.Interim},
            {"initial", LastAccountsType.Initial},
            {"total-exemption-full", LastAccountsType.TotalExemptionFull},
            {"total-exemption-small", LastAccountsType.TotalExemptionSmall},
            {"partial-exemption", LastAccountsType.PartialExemption},
            {"audit-exemption-subsidiary", LastAccountsType.AuditExemptionSubsidiary},
            {"filing-exemption-subsidiary", LastAccountsType.FilingExemptionSubsidiary},
            {"micro-entity", LastAccountsType.MicroEntity}
        };

        public static readonly IReadOnlyDictionary<string, CompanyStatus> PossibleCompanyStatuses = new Dictionary
            <string, CompanyStatus>()
        {
            {"active", CompanyStatus.Active},
            {"dissolved", CompanyStatus.Dissolved},
            {"liquidation", CompanyStatus.Liquidation},
            {"receivership", CompanyStatus.Receivership},
            {"administration", CompanyStatus.Administration},
            {"voluntary-arrangement", CompanyStatus.VoluntaryArrangement},
            {"converted-closed", CompanyStatus.ConvertedClosed},
            {"insolvency-proceedings", CompanyStatus.InsolvencyProceedings}
        };

        public static readonly IReadOnlyDictionary<string, CompanyStatusDetail> PossibleCompanyStatusDetails = new Dictionary
            <string, CompanyStatusDetail>()
        {
            {"transferred-from-uk", CompanyStatusDetail.TransferredFromUk},
            {"active-proposal-to-strike-off", CompanyStatusDetail.ActiveProposalToStrikeOff},
            {"petition-to-restore-dissolved", CompanyStatusDetail.PetitionToRestoreDissolved},
            {"transformed-to-se", CompanyStatusDetail.TransformedToSe},
            {"converted-to-plc", CompanyStatusDetail.ConvertedToPlc}
        };

        public static readonly IReadOnlyDictionary<string, Jurisdiction> PossibleJurisdictions = new Dictionary
            <string, Jurisdiction>()
        {
            {"england-wales", Jurisdiction.EnglandAndWales},
            {"wales", Jurisdiction.Wales},
            {"scotland", Jurisdiction.Scotland},
            {"northern-ireland", Jurisdiction.NorthernIreland},
            {"european-union", Jurisdiction.EuropeanUnion},
            {"united-kingdom", Jurisdiction.UnitedKingdom},
            {"england", Jurisdiction.England},
            {"noneu", Jurisdiction.NonEu}
        };

        public static readonly IReadOnlyDictionary<string, OfficerRole> PossibleOfficerRoles = new Dictionary
            <string, OfficerRole>()
        {
            {"cic-manager", OfficerRole.CicManager},
            {"corporate-director", OfficerRole.CorporateDirector},
            {"corporate-llp-designated-member", OfficerRole.CorporateLlpDesignatedMember},
            {"corporate-llp-member", OfficerRole.CorporateLlpMember},
            {"corporate-manager-of-an-eeig", OfficerRole.CorporateManagerOfAnEeig},
            {"corporate-member-of-a-management-organ", OfficerRole.CorporateMemberOfAManagementOrgan},
            {"corporate-member-of-a-supervisory-organ", OfficerRole.CorporateMemberOfASupervisoryOrgan},
            {"corporate-member-of-an-administrative-organ", OfficerRole.CorporateMemberOfAnAdministrativeOrgan},
            {"corporate-nominee-director", OfficerRole.CorporateNomineeDirector},
            {"corporate-nominee-secretary", OfficerRole.CorporateNomineeSecretary},
            {"corporate-secretary", OfficerRole.CorporateSecretary},
            {"director", OfficerRole.Director},
            {"general-partner-in-a-limited-partnership", OfficerRole.GeneralPartnerInALimitedPartnership},
            {"judicial-factor", OfficerRole.JudicialFactor},
            {"limited-partner-in-a-limited-partnership", OfficerRole.LimitedPartnerInALimitedPartnership},
            {"llp-designated-member", OfficerRole.LlpDesignatedMember},
            {"llp-member", OfficerRole.LlpMember},
            {"manager-of-an-eeig", OfficerRole.ManagerOfAnEeig},
            {"member-of-a-management-organ", OfficerRole.MemberOfAManagementOrgan},
            {"member-of-a-supervisory-organ", OfficerRole.MemberOfASupervisoryOrgan},
            {"member-of-an-administrative-organ", OfficerRole.MemberOfAnAdministrativeOrgan},
            {"nominee-director", OfficerRole.NomineeDirector},
            {"nominee-secretary", OfficerRole.NomineeSecretary},
            {"person-authorised-to-accept", OfficerRole.PersonAuthorisedToAccept},
            {"person-authorised-to-represent", OfficerRole.PersonAuthorisedToRepresent},
            {"person-authorised-to-represent-and-accept", OfficerRole.PersonAuthorisedToRepresentAndAccept},
            {"receiver-and-manager", OfficerRole.ReceiverAndManager},
            {"secretary", OfficerRole.Secretary}
        };

        public static readonly IReadOnlyDictionary<string, CompanyType> ExpectedCompanyTypesMap = new Dictionary
            <string, CompanyType>()
        {
            {"private-unlimited", CompanyType.PrivateUnlimited},
            {"ltd", CompanyType.Ltd},
            {"plc", CompanyType.Plc},
            {"old-public-company", CompanyType.OldPublicCompany},
            {"private-limited-guarant-nsc-limited-exemption", CompanyType.PrivateLimitedGuarantNscLimitedExemption},
            {"limited-partnership", CompanyType.LimitedPartnership},
            {"private-limited-guarant-nsc", CompanyType.PrivateLimitedGuarantNsc},
            {"converted-or-closed", CompanyType.ConvertedOrClosed},
            {"private-unlimited-nsc", CompanyType.PrivateUnlimitedNsc},
            {"private-limited-shares-section-30-exemption", CompanyType.PrivateLimitedSharesSection30Exemption},
            {"assurance-company", CompanyType.AssuranceCompany},
            {"oversea-company", CompanyType.OverseaCompany},
            {"eeig", CompanyType.Eeig},
            {"icvc-securities", CompanyType.IcvcSecurities},
            {"icvc-warrant", CompanyType.IcvcWarrant},
            {"icvc-umbrella", CompanyType.IcvcUmbrella},
            {"industrial-and-provident-society", CompanyType.IndustrialAndProvidentSociety},
            {"northern-ireland", CompanyType.NorthernIreland},
            {"northern-ireland-other", CompanyType.NorthernIrelandOther},
            {"llp", CompanyType.Llp},
            {"royal-charter", CompanyType.RoyalCharter},
            {"investment-company-with-variable-capital", CompanyType.InvestmentCompanyWithVariableCapital},
            {"unregistered-company", CompanyType.UnregisteredCompany},
            {"other", CompanyType.Other},
            {"european-public-limited-liability-company-se", CompanyType.EuropeanPublicLimitedLiabilityCompanySe},
            {"registered-society-non-jurisdictional", CompanyType.RegisteredSociety }
        };

        public static readonly IReadOnlyDictionary<string, ResolutionCategory> PossibleResolutionCategories = new Dictionary
            <string, ResolutionCategory>()
        {
            {"miscellaneous", ResolutionCategory.Miscellaneous}
        };

        public static readonly IReadOnlyDictionary<string, FilingHistoryStatus> PossibleFilingHistoryStatus = new Dictionary
            <string, FilingHistoryStatus>()
        {
            {"filing-history-available", FilingHistoryStatus.FilingHistoryAvailable}
        };

        public static readonly IReadOnlyDictionary<string, FilingSubcategory> PossibleFilingSubcategories = new Dictionary
            <string, FilingSubcategory>()
        {
            {"resolution", FilingSubcategory.Resolution}
        };

        public static readonly IReadOnlyDictionary<string, FilingCategory> PossibleFilingCategories = new Dictionary
            <string, FilingCategory>()
        {
            {"accounts", FilingCategory.Accounts},
            {"address", FilingCategory.Address},
            {"annual-return", FilingCategory.AnnualReturn},
            {"capital", FilingCategory.Capital},
            {"change-of-name", FilingCategory.ChangeOfName},
            {"incorporation", FilingCategory.Incorporation},
            {"liquidation", FilingCategory.Liquidation},
            {"miscellaneous", FilingCategory.Miscellaneous},
            {"mortgage", FilingCategory.Mortgage},
            {"officers", FilingCategory.Officers},
            {"resolution", FilingCategory.Resolution},
            {"confirmation-statement", FilingCategory.ConfirmationStatement},
            {"persons-with-significant-control", FilingCategory.PersonsWithSignificantControl},
             {"dissolution", FilingCategory.Dissolution}

        };
        #region Company Charges

        public static readonly IReadOnlyDictionary<string, AssetsCeasedReleasedType> PossibleAssetsCeasedReleasedType = new Dictionary
    <string, AssetsCeasedReleasedType>()
        {
            { "property-ceased-to-belong",AssetsCeasedReleasedType.PropertyCeasedToBelong},
            { "part-property-release-and-ceased-to-belong", AssetsCeasedReleasedType.PartPropertyReleaseAndCeasedToBelong},
            {"part-property-released",AssetsCeasedReleasedType.PartPropertyReleased},
            {"part-property-ceased-to-belong",AssetsCeasedReleasedType.PartPropertyCeasedToBelong},
            {"whole-property-released",AssetsCeasedReleasedType.WholePropertyReleased},
            {"multiple-filings",AssetsCeasedReleasedType.MultipleFilings },
            { "whole-property-released-and-ceased-to-belong",AssetsCeasedReleasedType.WholePropertyReleasedAndCeasedToBelong }
        };

        public static readonly IReadOnlyDictionary<string, ClassificationType> PossibleClassificationType = new Dictionary
  <string, ClassificationType>()
        {
            { "charge-description", ClassificationType.ChargeDescription},
            { "nature-of-charge",ClassificationType.NatureOfCharge}

        };

        public static readonly IReadOnlyDictionary<string, StatusType> PossibleStatusType = new Dictionary<string, StatusType>()
        {
            { "outstanding", StatusType.Outstanding},
            { "fully-satisfied", StatusType.FullySatisfied},
            { "part-satisfied", StatusType.PartSatisfied},
            { "satisfied", StatusType.Satisfied}
        };



        public static readonly IReadOnlyDictionary<string, ParticularsType> PossibleParticularsType = new Dictionary<string, ParticularsType>()
        {
            {"short-particulars",ParticularsType.ShortParticulars},
            {"charged-property-description",ParticularsType.ChargedPropertyDescription},
            {"charged-property-or-undertaking-description",ParticularsType.ChargedPropertyOrUndertakingDescription},
            {"brief-description",ParticularsType.BriefDescription}
        };

        public static readonly IReadOnlyDictionary<string, SecuredDetailsType> PossibleSecuredDetailsType = new Dictionary<string, SecuredDetailsType>()
        {
            {"amount-secured",SecuredDetailsType.AmountSecured},
            {"obligations-secured",SecuredDetailsType.ObligationsSecured}
        };

        public static readonly IReadOnlyDictionary<string, FilingType> PossibleFilingType = new Dictionary<string, FilingType>()
        {
            {"create-charge", FilingType.CreateCharge},
            {"create-charge-with-deed-with-charles-court-order", FilingType.CreateChargeWithDeedWithCharlesCourtOrder},
            {"create-charge-with-deed-with-court-order", FilingType.CreateChargeWithDeedWithCourtOrder},
            {"create-charge-with-deed", FilingType.CreateChargeWithDeed},
            {"create-charge-with-deed-with-charles-court-order-limited-liability-partnership", FilingType.CreateChargeWithDeedWithCharlesCourtOrderLimitedLiabilityPartnership},
            {"create-charge-with-deed-with-court-order-limited-liability-partnership", FilingType.CreateChargeWithDeedWithCourtOrderLimitedLiabilityPartnership},
            {"create-charge-with-deed-limited-liability-partnership", FilingType.CreateChargeWithDeedLimitedLiabilityPartnership},
            {"acquire-charge-with-deed-with-charles-court-order", FilingType.AcquireChargeWithDeedWithCharlesCourtOrder},
            {"acquire-charge-with-deed-with-court-order", FilingType.AcquireChargeWithDeedWithCourtOrder},
            {"acquire-charge-with-deed", FilingType.AcquireChargeWithDeed},
            {"acquire-charge-with-deed-with-charles-court-order-limited-liability-partnership", FilingType.AcquireChargeWithDeedWithCharlesCourtOrderLimitedLiabilityPartnership},
            {"acquire-charge-with-deed-with-court-order-limited-liability-partnership", FilingType.AcquireChargeWithDeedWithCourtOrderLimitedLiabilityPartnership},
            {"acquire-charge-with-deed-limited-liability-partnership", FilingType.AcquireChargeWithDeedLimitedLiabilityPartnership},
            {"debenture-with-deed-with-charles-court-order", FilingType.DebentureWithDeedWithCharlesCourtOrder},
            {"debenture-with-deed-with-court-order", FilingType.DebentureWithDeedWithCourtOrder},
            {"debenture-with-deed", FilingType.DebentureWithDeed},
            {"debenture-with-deed-with-charles-court-order-limited-liability-partnership", FilingType.DebentureWithDeedWithCharlesCourtOrderLimitedLiabilityPartnership},
            {"debenture-with-deed-with-court-order-limited-liability-partnership", FilingType.DebentureWithDeedWithCourtOrderLimitedLiabilityPartnership},
            {"debenture-with-deed-limited-liability-partnership", FilingType.DebentureWithDeedLimitedLiabilityPartnership},
            {"charge-satisfaction", FilingType.ChargeSatisfaction},
            {"charge-satisfaction-limited-liability-partnership", FilingType.ChargeSatisfactionLimitedLiabilityPartnership},
            {"charge-whole-release", FilingType.ChargeWholeRelease},
            {"charge-whole-cease", FilingType.ChargeWholeCease},
            {"charge-whole-both", FilingType.ChargeWholeBoth},
            {"charge-part-release", FilingType.ChargePartRelease},
            {"charge-part-cease", FilingType.ChargePartCease},
            {"charge-part-both", FilingType.ChargePartBoth},
            {"charge-release-cease", FilingType.ChargeReleaseCease},
            {"charge-whole-release-limited-liability-partnership", FilingType.ChargeWholeReleaseLimitedLiabilityPartnership},
            {"charge-whole-cease-limited-liability-partnership", FilingType.ChargeWholeCeaseLimitedLiabilityPartnership},
            {"charge-whole-both-limited-liability-partnership", FilingType.ChargeWholeBothLimitedLiabilityPartnership},
            {"charge-part-release-limited-liability-partnership", FilingType.ChargePartReleaseLimitedLiabilityPartnership},
            {"charge-part-cease-limited-liability-partnership", FilingType.ChargePartCeaseLimitedLiabilityPartnership},
            {"charge-part-both-limited-liability-partnership", FilingType.ChargePartBothLimitedLiabilityPartnership},
            {"charge-release-cease-limited-liability-partnership", FilingType.ChargeReleaseCeaseLimitedLiabilityPartnership},
            {"trustee-acting", FilingType.TrusteeActing},
            {"trustee-acting-as-limited-liability-partnership", FilingType.TrusteeActingAsLimitedLiabilityPartnership},
            {"alter-charge", FilingType.AlterCharge},
            {"alter-charge-limited-liability-partnership", FilingType.AlterChargeLimitedLiabilityPartnership},
            {"create-charge-without-deed-with-charles-court-order", FilingType.CreateChargeWithoutDeedWithCharlesCourtOrder},
            {"create-charge-without-deed-with-court-order", FilingType.CreateChargeWithoutDeedWithCourtOrder},
            {"create-charge-without-deed", FilingType.CreateChargeWithoutDeed},
            {"create-charge-without-deed-with-charles-court-order-limited-liability-partnership", FilingType.CreateChargeWithoutDeedWithCharlesCourtOrderLimitedLiabilityPartnership},
            {"create-charge-without-deed-with-court-order-limited-liability-partnership", FilingType.CreateChargeWithoutDeedWithCourtOrderLimitedLiabilityPartnership},
            {"create-charge-without-deed-limited-liability-partnership", FilingType.CreateChargeWithoutDeedLimitedLiabilityPartnership},
            {"acquire-charge-without-deed-with-charles-court-order", FilingType.AcquireChargeWithoutDeedWithCharlesCourtOrder},
            {"acquire-charge-without-deed-with-court-order", FilingType.AcquireChargeWithoutDeedWithCourtOrder},
            {"acquire-charge-without-deed", FilingType.AcquireChargeWithoutDeed},
            {"acquire-charge-without-deed-with-charles-court-order-limited-liability-partnership", FilingType.AcquireChargeWithoutDeedWithCharlesCourtOrderLimitedLiabilityPartnership},
            {"acquire-charge-without-deed-with-court-order-limited-liability-partnership", FilingType.AcquireChargeWithoutDeedWithCourtOrderLimitedLiabilityPartnership},
            {"acquire-charge-without-deed-limited-liability-partnership", FilingType.AcquireChargeWithoutDeedLimitedLiabilityPartnership},
            {"debenture-without-deed-with-charles-court-order", FilingType.DebentureWithoutDeedWithCharlesCourtOrder},
            {"debenture-without-deed-with-court-order", FilingType.DebentureWithoutDeedWithCourtOrder},
            {"debenture-without-deed", FilingType.DebentureWithoutDeed},
            {"debenture-without-deed-with-charles-court-order-limited-liability-partnership", FilingType.DebentureWithoutDeedWithCharlesCourtOrderLimitedLiabilityPartnership},
            {"debenture-without-deed-with-court-order-limited-liability-partnership", FilingType.DebentureWithoutDeedWithCourtOrderLimitedLiabilityPartnership},
            {"debenture-without-deed-limited-liability-partnership", FilingType.DebentureWithoutDeedLimitedLiabilityPartnership},
            {"alter-floating-charge", FilingType.AlterFloatingCharge},
            {"alter-floating-charge-limited-liability-partnership", FilingType.AlterFloatingChargeLimitedLiabilityPartnership},
            {"create-charge-pre-april-2013", FilingType.CreateChargePreApril2013},
            {"create-charge-scotland-pre-april-2013", FilingType.CreateChargeScotlandPreApril2013},
            {"create-charge-pre-april-2013-limited-liability-partnership", FilingType.CreateChargePreApril2013LimitedLiabilityPartnership},
            {"create-charge-pre-2006-companies-act", FilingType.CreateChargePre2006CompaniesAct},
            {"create-charge-pre-2006-companies-act-limited-liability-partnership", FilingType.CreateChargePre2006CompaniesActLimitedLiabilityPartnership},
            {"create-charge-scotland-pre-2006-companies-act", FilingType.CreateChargeScotlandPre2006CompaniesAct},
            {"charge-satisfaction-pre-april-2013", FilingType.ChargeSatisfactionPreApril2013},
            {"charge-satisfaction-scotland-pre-april-2013", FilingType.ChargeSatisfactionScotlandPreApril2013},
            {"charge-satisfaction-pre-2006-companies-act", FilingType.ChargeSatisfactionPre2006CompaniesAct},
            {"charge-satisfaction-scotland-pre-2006-companies-act", FilingType.ChargeSatisfactionScotlandPre2006CompaniesAct},
            {"charge-satisfaction-pre-april-2013-limited-liability-partnership", FilingType.ChargeSatisfactionPreApril2013LimitedLiabilityPartnership},
            {"charge-satisfaction-floating-charge-in-scotland-pre-april-2013", FilingType.ChargeSatisfactionFloatingChargeInScotlandPreApril2013},
            {"charge-part-or-whole-release-pre-april-2013", FilingType.ChargePartOrWholeReleasePreApril2013},
            {"charge-part-or-whole-release-scotland-pre-april-2013", FilingType.ChargePartOrWholeReleaseScotlandPreApril2013},
            {"charge-part-or-whole-release-limited-liability-partnership-pre-april-2013", FilingType.ChargePartOrWholeReleaseLimitedLiabilityPartnershipPreApril2013},
            {"charge-released-floating-charge-in-scotland-pre-april-2013", FilingType.ChargeReleasedFloatingChargeInScotlandPreApril2013},
            {"charge-released-floating-charge-in-pre-2006-companies-act", FilingType.ChargeReleasedFloatingChargeInPre2006CompaniesAct},
            {"charge-released-floating-charge-in-scotland-pre-2006-companies-act", FilingType.ChargeReleasedFloatingChargeInScotlandPre2006CompaniesAct},
            {"acquire-charge-pre-april-2013", FilingType.AcquireChargePreApril2013},
            {"acquire-charge-scotland-pre-april-2013", FilingType.AcquireChargeScotlandPreApril2013},
            {"acquire-charge-limited-liability-partnership-pre-april-2013", FilingType.AcquireChargeLimitedLiabilityPartnershipPreApril2013},
            {"acquire-charge-pre-2006-companies-act", FilingType.AcquireChargePre2006CompaniesAct},
            {"acquire-charge-scotland-pre-2006-companies-act", FilingType.AcquireChargeScotlandPre2006CompaniesAct},
            {"create-charge-series-debentures-pre-april-2013", FilingType.CreateChargeSeriesDebenturesPreApril2013},
            {"create-charge-series-debentures-scotland-pre-april-2013", FilingType.CreateChargeSeriesDebenturesScotlandPreApril2013},
            {"create-charge-series-debentures-limited-liability-partnership", FilingType.CreateChargeSeriesDebenturesLimitedLiabilityPartnership},
            {"create-charge-series-debentures-pre-2006-companies-act", FilingType.CreateChargeSeriesDebenturesPre2006CompaniesAct},
            {"create-charge-series-debentures-scotland-pre-2006-companies-act", FilingType.CreateChargeSeriesDebenturesScotlandPre2006CompaniesAct},
            {"create-issue-out-of-series-debentures-scotland-pre-2006-companies-act", FilingType.CreateIssueOutOfSeriesDebenturesScotlandPre2006CompaniesAct},
            {"create-issue-of-secured-debentures-pre-april-2013", FilingType.CreateIssueOfSecuredDebenturesPreApril2013},
            {"create-issue-of-secured-debentures-scotland-pre-april-2013", FilingType.CreateIssueOfSecuredDebenturesScotlandPreApril2013},
            {"create-issue-of-secured-debentures-pre-2006-companies-act", FilingType.CreateIssueOfSecuredDebenturesPre2006CompaniesAct},
            {"create-issue-of-secured-debentures-limited-liability-partnership-pre-april-2013", FilingType.CreateIssueOfSecuredDebenturesLimitedLiabilityPartnershipPreApril2013},
            {"create-issue-of-secured-debentures-limited-liability-partnership-scotland-pre-april-2013", FilingType.CreateIssueOfSecuredDebenturesLimitedLiabilityPartnershipScotlandPreApril2013},
            {"liquidation-appointment-of-receiver", FilingType.LiquidationAppointmentOfReceiver},
            {"liquidation-appointment-of-receiver-pre-april-2013", FilingType.LiquidationAppointmentOfReceiverPreApril2013},
            {"liquidation-appointment-of-receiver-limited-liability-partnership", FilingType.LiquidationAppointmentOfReceiverLimitedLiabilityPartnership},
            {"liquidation-appointment-of-receiver-scotland", FilingType.LiquidationAppointmentOfReceiverScotland},
            {"liquidation-appointment-of-receiver-by-court-scotland", FilingType.LiquidationAppointmentOfReceiverByCourtScotland},
            {"liquidation-appointment-of-receiver-pre-2006-companies-act", FilingType.LiquidationAppointmentOfReceiverPre2006CompaniesAct},
            {"liquidation-appointment-of-liquidator", FilingType.LiquidationAppointmentOfLiquidator},
            {"liquidation-cease-to-act-receiver", FilingType.LiquidationCeaseToActReceiver},
            {"liquidation-cease-to-act-receiver-pre-april-2013", FilingType.LiquidationCeaseToActReceiverPreApril2013},
            {"liquidation-cease-to-act-receiver-limited-liability-partnership", FilingType.LiquidationCeaseToActReceiverLimitedLiabilityPartnership},
            {"liquidation-cease-to-act-receiver-pre-2006-companies-act", FilingType.LiquidationCeaseToActReceiverPre2006CompaniesAct},
            {"liquidation-ceasing-to-act-receiver-scotland", FilingType.LiquidationCeasingToActReceiverScotland},
            {"create-charge-northern-ireland-pre-2006-companies-act-form-402", FilingType.CreateChargeNorthernIrelandPre2006CompaniesActForm402},
            {"create-charge-northern-ireland-pre-2006-companies-act-form-402DF", FilingType.CreateChargeNorthernIrelandPre2006CompaniesActForm402Df},
            {"create-charge-northern-ireland-pre-2006-companies-act-form-402PP", FilingType.CreateChargeNorthernIrelandPre2006CompaniesActForm402Pp},
            {"create-charge-northern-ireland-pre-2006-companies-act-form-402R", FilingType.CreateChargeNorthernIrelandPre2006CompaniesActForm402R},
            {"create-charge-northern-ireland-pre-2006-companies-act-form-407", FilingType.CreateChargeNorthernIrelandPre2006CompaniesActForm407},
            {"create-charge-by-judgement-enforcement-office-northern-ireland-pre-2006-companies-act-form-408", FilingType.CreateChargeByJudgementEnforcementOfficeNorthernIrelandPre2006CompaniesActForm408},
            {"supporting-evidence-create-charge-northern-ireland-pre-2006-companies-act", FilingType.SupportingEvidenceCreateChargeNorthernIrelandPre2006CompaniesAct},
            {"charge-satisfaction-northern-ireland-pre-2006-companies-act", FilingType.ChargeSatisfactionNorthernIrelandPre2006CompaniesAct},
            {"charge-release-cease-northern-ireland-pre-2006-companies-act", FilingType.ChargeReleaseCeaseNorthernIrelandPre2006CompaniesAct},
            {"charge-part-satisfaction", FilingType.ChargePartSatisfaction},
            {"charge-part-satisfaction-limited-liability-partnership", FilingType.ChargePartSatisfactionLimitedLiabilityPartnership},
            {"charge-satisfaction-cease-release-northen-pre-2006-companies-act-ireland", FilingType.ChargeSatisfactionCeaseReleaseNorthenPre2006CompaniesActIreland},
            {"create-floating-charge-scotland", FilingType.CreateFloatingChargeScotland},
            {"create-charge-pre-april-2013-limited-liability-partnership-scotland", FilingType.CreateChargePreApril2013LimitedLiabilityPartnershipScotland},
            {"charge-satisfaction-pre-april-2013-limited-liability-partnership-scotland", FilingType.ChargeSatisfactionPreApril2013LimitedLiabilityPartnershipScotland},
            {"charge-satisfaction-floating-charge-in-scotland-pre-april-2013-limited-liability-partnership", FilingType.ChargeSatisfactionFloatingChargeInScotlandPreApril2013LimitedLiabilityPartnership},
            {"charge-part-or-whole-release-pre-april-2013--limited-liability-partnership-scotland", FilingType.ChargePartOrWholeReleasePreApril2013LimitedLiabilityPartnershipScotland},
            {"charge-released-floating-charge-in-scotland-pre-april-2013--limited-liability-partnership", FilingType.ChargeReleasedFloatingChargeInScotlandPreApril2013LimitedLiabilityPartnership},
            {"acquire-charge-limited-liability-partnership-pre-april-2013-scotland", FilingType.AcquireChargeLimitedLiabilityPartnershipPreApril2013Scotland},
            {"create-charge-series-debentures-limited-liability-partnership-scotland", FilingType.CreateChargeSeriesDebenturesLimitedLiabilityPartnershipScotland},
            {"charge-satisfaction-pre-2006-companies-act-limited-liability-partnership", FilingType.ChargeSatisfactionPre2006CompaniesActLimitedLiabilityPartnership},
            {"charge-released-floating-charge-in-pre-2006-companies-act-limited-liability-partnership", FilingType.ChargeReleasedFloatingChargeInPre2006CompaniesActLimitedLiabilityPartnership},
            {"charge-satisfaction-scotland-pre-2006-companies-act-limited-liability-partnership", FilingType.ChargeSatisfactionScotlandPre2006CompaniesActLimitedLiabilityPartnership},
            {"charge-released-floating-charge-in-scotland-pre-2006-companies-act-limited-liability-partnership", FilingType.ChargeReleasedFloatingChargeInScotlandPre2006CompaniesActLimitedLiabilityPartnership},
            {"liquidation-appointment-of-receiver-pre-april-2013-limited-liability-partnership", FilingType.LiquidationAppointmentOfReceiverPreApril2013LimitedLiabilityPartnership},
            {"liquidation-cease-to-act-receiver-pre-april-2013-limited-liability-partnership", FilingType.LiquidationCeaseToActReceiverPreApril2013LimitedLiabilityPartnership},
            {"liquidation-appointment-of-receiver-pre-april-2013-overseas", FilingType.LiquidationAppointmentOfReceiverPreApril2013Overseas},
            {"liquidation-cease-to-act-receiver-pre-april-2013-overseas", FilingType.LiquidationCeaseToActReceiverPreApril2013Overseas},
            {"supporting-evidence-create-charge-northern-ireland-pre-2006-companies-act-limited-liability-partnership", FilingType.SupportingEvidenceCreateChargeNorthernIrelandPre2006CompaniesActLimitedLiabilityPartnership},
            {"charge-satisfaction-northern-ireland-pre-2006-companies-act-limited-liability-partnership", FilingType.ChargeSatisfactionNorthernIrelandPre2006CompaniesActLimitedLiabilityPartnership},
            {"charge-release-cease-northern-ireland-pre-2006-companies-act-limited-liability-partnership", FilingType.ChargeReleaseCeaseNorthernIrelandPre2006CompaniesActLimitedLiabilityPartnership},
            {"create-charge-northern-ireland-pre-2006-companies-act-form-402-limited-liability-partnership", FilingType.CreateChargeNorthernIrelandPre2006CompaniesActForm402LimitedLiabilityPartnership},
            {"create-charge-northern-ireland-pre-2006-companies-act-form-C402", FilingType.CreateChargeNorthernIrelandPre2006CompaniesActFormC402},
            {"create-charge-by-judgement-enforcement-office-northern-ireland-pre-2006-companies-act-form-C408", FilingType.CreateChargeByJudgementEnforcementOfficeNorthernIrelandPre2006CompaniesActFormC408},
            {"charge-certificate-northern-ireland-pre-2006-companies-act-form-C404", FilingType.ChargeCertificateNorthernIrelandPre2006CompaniesActFormC404}

        };



        #endregion

        #region PersonWithSignificantControl
        public static readonly IReadOnlyDictionary<string, LegalPersonType> PossibleLegalPersonType = new Dictionary<string, LegalPersonType>()
        {
            {"legal-person-with-significant-control",LegalPersonType.LegalPersonWithSignificantControl}
        };

        public static readonly IReadOnlyDictionary<string, CorporateEntityType> PossibleCorporateEntitityType = new Dictionary<string, CorporateEntityType>()
        {
            {"corporate-entity-person-with-significant-control",CorporateEntityType.CorporateEntityPersonPersonWithSignificantControl}
        };

        public static readonly IReadOnlyDictionary<string, SuperSecurePersonDescriptionType> PossibleSuperSecurePersonDescriptionType = new Dictionary<string, SuperSecurePersonDescriptionType>()
        {
            {"super-secure-person-with-significant-control",SuperSecurePersonDescriptionType.SuperSecurePersonWithSignificantControl}
        };
        public static readonly IReadOnlyDictionary<string, NaturesOfControlType> PossibleNaturesOfControlType = new Dictionary<string, NaturesOfControlType>()
        {
            {"ownership-of-shares-25-to-50-percent",NaturesOfControlType.OwnershipOfShares25To50Percent},
            {"ownership-of-shares-50-to-75-percent",NaturesOfControlType.OwnershipOfShares50To75Percent},
            {"ownership-of-shares-75-to-100-percent",NaturesOfControlType.OwnershipOfShares75To100Percent},
            {"ownership-of-shares-25-to-50-percent-as-trust",NaturesOfControlType.OwnershipOfShares25To50PercentAsTrust},
            {"ownership-of-shares-50-to-75-percent-as-trust",NaturesOfControlType.OwnershipOfShares50To75PercentAsTrust},
            {"ownership-of-shares-75-to-100-percent-as-trust",NaturesOfControlType.OwnershipOfShares75To100PercentAsTrust},
            {"ownership-of-shares-25-to-50-percent-as-firm",NaturesOfControlType.OwnershipOfShares25To50PercentAsFirm},
            {"ownership-of-shares-50-to-75-percent-as-firm",NaturesOfControlType.OwnershipOfShares50To75PercentAsFirm},
            {"ownership-of-shares-75-to-100-percent-as-firm",NaturesOfControlType.OwnershipOfShares75To100PercentAsFirm},
            {"voting-rights-25-to-50-percent",NaturesOfControlType.VotingRights25To50Percent},
            {"voting-rights-50-to-75-percent",NaturesOfControlType.VotingRights50To75Percent},
            {"voting-rights-75-to-100-percent",NaturesOfControlType.VotingRights75To100Percent},
            {"voting-rights-25-to-50-percent-as-trust",NaturesOfControlType.VotingRights25To50PercentAsTrust},
            {"voting-rights-50-to-75-percent-as-trust",NaturesOfControlType.VotingRights50To75PercentAsTrust},
            {"voting-rights-75-to-100-percent-as-trust",NaturesOfControlType.VotingRights75To100PercentAsTrust},
            {"voting-rights-25-to-50-percent-as-firm",NaturesOfControlType.VotingRights25To50PercentAsFirm},
            {"voting-rights-50-to-75-percent-as-firm",NaturesOfControlType.VotingRights50To75PercentAsFirm},
            {"voting-rights-75-to-100-percent-as-firm",NaturesOfControlType.VotingRights75To100PercentAsFirm},
            {"right-to-appoint-and-remove-directors",NaturesOfControlType.RightToAppointAndRemoveDirectors},
            {"right-to-appoint-and-remove-directors-as-trust",NaturesOfControlType.RightToAppointAndRemoveDirectorsAsTrust},
            {"right-to-appoint-and-remove-directors-as-firm",NaturesOfControlType.RightToAppointAndRemoveDirectorsAsFirm},
            {"significant-influence-or-control",NaturesOfControlType.SignificantInfluenceOrControl},
            {"significant-influence-or-control-as-trust",NaturesOfControlType.SignificantInfluenceOrControlAsTrust},
            {"significant-influence-or-control-as-firm",NaturesOfControlType.SignificantInfluenceOrControlAsFirm},
            {"right-to-share-surplus-assets-25-to-50-percent-limited-liability-partnership",NaturesOfControlType.RightToShareSurplusAssets25To50PercentLimitedLiabilityPartnership},
            {"right-to-share-surplus-assets-50-to-75-percent-limited-liability-partnership",NaturesOfControlType.RightToShareSurplusAssets50To75PercentLimitedLiabilityPartnership},
            {"right-to-share-surplus-assets-75-to-100-percent-limited-liability-partnership",NaturesOfControlType.RightToShareSurplusAssets75To100PercentLimitedLiabilityPartnership},
            {"right-to-share-surplus-assets-25-to-50-percent-as-trust-limited-liability-partnership",NaturesOfControlType.RightToShareSurplusAssets25To50PercentAsTrustLimitedLiabilityPartnership},
            {"right-to-share-surplus-assets-50-to-75-percent-as-trust-limited-liability-partnership",NaturesOfControlType.RightToShareSurplusAssets50To75PercentAsTrustLimitedLiabilityPartnership},
            {"right-to-share-surplus-assets-75-to-100-percent-as-trust-limited-liability-partnership",NaturesOfControlType.RightToShareSurplusAssets75To100PercentAsTrustLimitedLiabilityPartnership},
            {"right-to-share-surplus-assets-25-to-50-percent-as-firm-limited-liability-partnership",NaturesOfControlType.RightToShareSurplusAssets25To50PercentAsFirmLimitedLiabilityPartnership},
            {"right-to-share-surplus-assets-50-to-75-percent-as-firm-limited-liability-partnership",NaturesOfControlType.RightToShareSurplusAssets50To75PercentAsFirmLimitedLiabilityPartnership},
            {"right-to-share-surplus-assets-75-to-100-percent-as-firm-limited-liability-partnership",NaturesOfControlType.RightToShareSurplusAssets75To100PercentAsFirmLimitedLiabilityPartnership},
            {"voting-rights-25-to-50-percent-limited-liability-partnership",NaturesOfControlType.VotingRights25To50PercentLimitedLiabilityPartnership},
            {"voting-rights-50-to-75-percent-limited-liability-partnership",NaturesOfControlType.VotingRights50To75PercentLimitedLiabilityPartnership},
            {"voting-rights-75-to-100-percent-limited-liability-partnership",NaturesOfControlType.VotingRights75To100PercentLimitedLiabilityPartnership},
            {"voting-rights-25-to-50-percent-as-trust-limited-liability-partnership",NaturesOfControlType.VotingRights25To50PercentAsTrustLimitedLiabilityPartnership},
            {"voting-rights-50-to-75-percent-as-trust-limited-liability-partnership",NaturesOfControlType.VotingRights50To75PercentAsTrustLimitedLiabilityPartnership},
            {"voting-rights-75-to-100-percent-as-trust-limited-liability-partnership",NaturesOfControlType.VotingRights75To100PercentAsTrustLimitedLiabilityPartnership},
            {"voting-rights-25-to-50-percent-as-firm-limited-liability-partnership",NaturesOfControlType.VotingRights25To50PercentAsFirmLimitedLiabilityPartnership},
            {"voting-rights-50-to-75-percent-as-firm-limited-liability-partnership",NaturesOfControlType.VotingRights50To75PercentAsFirmLimitedLiabilityPartnership},
            {"voting-rights-75-to-100-percent-as-firm-limited-liability-partnership",NaturesOfControlType.VotingRights75To100PercentAsFirmLimitedLiabilityPartnership},
            {"right-to-appoint-and-remove-members-limited-liability-partnership",NaturesOfControlType.RightToAppointAndRemoveMembersLimitedLiabilityPartnership},
            {"right-to-appoint-and-remove-members-as-trust-limited-liability-partnership",NaturesOfControlType.RightToAppointAndRemoveMembersAsTrustLimitedLiabilityPartnership},
            {"right-to-appoint-and-remove-members-as-firm-limited-liability-partnership",NaturesOfControlType.RightToAppointAndRemoveMembersAsFirmLimitedLiabilityPartnership},
            {"significant-influence-or-control-limited-liability-partnership",NaturesOfControlType.SignificantInfluenceOrControlLimitedLiabilityPartnership},
            {"significant-influence-or-control-as-trust-limited-liability-partnership",NaturesOfControlType.SignificantInfluenceOrControlAsTrustLimitedLiabilityPartnership},
            {"significant-influence-or-control-as-firm-limited-liability-partnership",NaturesOfControlType.SignificantInfluenceOrControlAsFirmLimitedLiabilityPartnership},
            {"part-right-to-share-surplus-assets-25-to-50-percent",NaturesOfControlType.PartRightToShareSurplusAssets25To50Percent},
            {"part-right-to-share-surplus-assets-50-to-75-percent",NaturesOfControlType.PartRightToShareSurplusAssets50To75Percent},
            {"part-right-to-share-surplus-assets-75-to-100-percent",NaturesOfControlType.PartRightToShareSurplusAssets75To100Percent},
            {"part-right-to-share-surplus-assets-25-to-50-percent-as-trust",NaturesOfControlType.PartRightToShareSurplusAssets25To50PercentAsTrust},
            {"part-right-to-share-surplus-assets-50-to-75-percent-as-trust",NaturesOfControlType.PartRightToShareSurplusAssets50To75PercentAsTrust},
            {"part-right-to-share-surplus-assets-75-to-100-percent-as-trust",NaturesOfControlType.PartRightToShareSurplusAssets75To100PercentAsTrust},
            {"part-right-to-share-surplus-assets-25-to-50-percent-as-firm",NaturesOfControlType.PartRightToShareSurplusAssets25To50PercentAsFirm},
            {"part-right-to-share-surplus-assets-50-to-75-percent-as-firm",NaturesOfControlType.PartRightToShareSurplusAssets50To75PercentAsFirm},
            {"part-right-to-share-surplus-assets-75-to-100-percent-as-firm",NaturesOfControlType.PartRightToShareSurplusAssets75To100PercentAsFirm},
            {"right-to-appoint-and-remove-person",NaturesOfControlType.RightToAppointAndRemovePerson},
            {"right-to-appoint-and-remove-person-as-firm",NaturesOfControlType.RightToAppointAndRemovePersonAsFirm},
            {"right-to-appoint-and-remove-person-as-trust",NaturesOfControlType.RightToAppointAndRemovePersonAsTrust }
        };

        public static  readonly IReadOnlyDictionary<string, StatementType> PossibleStatementType = new Dictionary<string, StatementType>()
        {
            {"no-individual-or-entity-with-signficant-control", StatementType.NoIndividualOrEntityWithSignficantControl} ,
            {"psc-exists-but-not-identified", StatementType.PscExistsButNotIdentified} ,
            {"psc-details-not-confirmed", StatementType.PscDetailsNotConfirmed} ,
            {"steps-to-find-psc-not-yet-completed", StatementType.StepsToFindPscNotYetCompleted} ,
            {"psc-contacted-but-no-response", StatementType.PscContactedButNoResponse} ,
            {"psc-has-failed-to-confirm-changed-details", StatementType.PscHasFailedToConfirmChangedDetails} ,
            {"restrictions-notice-issued-to-psc", StatementType.RestrictionsNoticeIssuedToPsc} ,
            {"no-individual-or-entity-with-signficant-control-partnership", StatementType.NoIndividualOrEntityWithSignficantControlPartnership} ,
            {"psc-exists-but-not-identified-partnership", StatementType.PscExistsButNotIdentifiedPartnership} ,
            {"psc-details-not-confirmed-partnership", StatementType.PscDetailsNotConfirmedPartnership} ,
            {"steps-to-find-psc-not-yet-completed-partnership", StatementType.StepsToFindPscNotYetCompletedPartnership} ,
            {"psc-contacted-but-no-response-partnership", StatementType.PscContactedButNoResponsePartnership} ,
            {"psc-has-failed-to-confirm-changed-details-partnership", StatementType.PscHasFailedToConfirmChangedDetailsPartnership} ,
            {"restrictions-notice-issued-to-psc-partnership", StatementType.RestrictionsNoticeIssuedToPscPartnership} ,
        };
        #endregion
    }
}