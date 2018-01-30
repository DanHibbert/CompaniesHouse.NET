using System.Collections.Generic;
using CompaniesHouse.Response;
using CompaniesHouse.Response.CompanyCharges;
using CompaniesHouse.Response.CompanyFiling;
using CompaniesHouse.Response.CompanyPersonsWithSignificantControl.Legal;
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
            {"persons-with-significant-control", FilingCategory.PersonsWithSignificantControl}
        };
        #region Company Charges

        public static readonly IReadOnlyDictionary<string, AssetsCeasedReleasedType> PossibleAssetsCeasedReleasedType = new Dictionary
    <string, AssetsCeasedReleasedType>()
        {
            { "property-ceased-to-belong",         AssetsCeasedReleasedType.PropertyCeasedToBelong},
            { "part-property-release-and-ceased-to-belong",
        AssetsCeasedReleasedType.PartPropertyReleaseAndCeasedToBelong},
            {"part-property-released",
       AssetsCeasedReleasedType.PartPropertyReleased},
            {"part-property-ceased-to-belong",
        AssetsCeasedReleasedType.PartPropertyCeasedToBelong},
            {"whole-property-released",
        AssetsCeasedReleasedType.WholePropertyReleased},
            {"multiple-filings",
        AssetsCeasedReleasedType.MultipleFilings },
            { "whole-property-released-and-ceased-to-belong",
        AssetsCeasedReleasedType.WholePropertyReleasedAndCeasedToBelong },
        };

        public static readonly IReadOnlyDictionary<string, ClassificationType> PossibleClassificationType = new Dictionary
 <string, ClassificationType>()
        {
{"ownership-of-shares-25-to-50-percent",ClassificationType.OwnershipOfShares25To50Percent},
{"ownership-of-shares-50-to-75-percent",ClassificationType.OwnershipOfShares50To75Percent},
{"ownership-of-shares-75-to-100-percent",ClassificationType.OwnershipOfShares75To100Percent},
{"ownership-of-shares-25-to-50-percent-as-trust",ClassificationType.OwnershipOfShares25To50PercentAsTrust},
{"ownership-of-shares-50-to-75-percent-as-trust",ClassificationType.OwnershipOfShares50To75PercentAsTrust},
{"ownership-of-shares-75-to-100-percent-as-trust",ClassificationType.OwnershipOfShares75To100PercentAsTrust},
{"ownership-of-shares-25-to-50-percent-as-firm",ClassificationType.OwnershipOfShares25To50PercentAsFirm},
{"ownership-of-shares-50-to-75-percent-as-firm",ClassificationType.OwnershipOfShares50To75PercentAsFirm},
{"ownership-of-shares-75-to-100-percent-as-firm",ClassificationType.OwnershipOfShares75To100PercentAsFirm},
{"voting-rights-25-to-50-percent",ClassificationType.VotingRights25To50Percent},
{"voting-rights-50-to-75-percent",ClassificationType.VotingRights50To75Percent},
{"voting-rights-75-to-100-percent",ClassificationType.VotingRights75To100Percent},
{"voting-rights-25-to-50-percent-as-trust",ClassificationType.VotingRights25To50PercentAsTrust},
{"voting-rights-50-to-75-percent-as-trust",ClassificationType.VotingRights50To75PercentAsTrust},
{"voting-rights-75-to-100-percent-as-trust",ClassificationType.VotingRights75To100PercentAsTrust},
{"voting-rights-25-to-50-percent-as-firm",ClassificationType.VotingRights25To50PercentAsFirm},
{"voting-rights-50-to-75-percent-as-firm",ClassificationType.VotingRights50To75PercentAsFirm},
{"voting-rights-75-to-100-percent-as-firm",ClassificationType.VotingRights75To100PercentAsFirm},
{"right-to-appoint-and-remove-directors",ClassificationType.RightToAppointAndRemoveDirectors},
{"right-to-appoint-and-remove-directors-as-trust",ClassificationType.RightToAppointAndRemoveDirectorsAsTrust},
{"right-to-appoint-and-remove-directors-as-firm",ClassificationType.RightToAppointAndRemoveDirectorsAsFirm},
{"significant-influence-or-control",ClassificationType.SignificantInfluenceOrControl},
{"significant-influence-or-control-as-trust",ClassificationType.SignificantInfluenceOrControlAsTrust},
{"significant-influence-or-control-as-firm",ClassificationType.SignificantInfluenceOrControlAsFirm},
{"right-to-share-surplus-assets-25-to-50-percent-limited-liability-partnership",ClassificationType.RightToShareSurplusAssets25To50PercentLimitedLiabilityPartnership},
{"right-to-share-surplus-assets-50-to-75-percent-limited-liability-partnership",ClassificationType.RightToShareSurplusAssets50To75PercentLimitedLiabilityPartnership},
{"right-to-share-surplus-assets-75-to-100-percent-limited-liability-partnership",ClassificationType.RightToShareSurplusAssets75To100PercentLimitedLiabilityPartnership},
{"right-to-share-surplus-assets-25-to-50-percent-as-trust-limited-liability-partnership",ClassificationType.RightToShareSurplusAssets25To50PercentAsTrustLimitedLiabilityPartnership},
{"right-to-share-surplus-assets-50-to-75-percent-as-trust-limited-liability-partnership",ClassificationType.RightToShareSurplusAssets50To75PercentAsTrustLimitedLiabilityPartnership},
{"right-to-share-surplus-assets-75-to-100-percent-as-trust-limited-liability-partnership",ClassificationType.RightToShareSurplusAssets75To100PercentAsTrustLimitedLiabilityPartnership},
{"right-to-share-surplus-assets-25-to-50-percent-as-firm-limited-liability-partnership",ClassificationType.RightToShareSurplusAssets25To50PercentAsFirmLimitedLiabilityPartnership},
{"right-to-share-surplus-assets-50-to-75-percent-as-firm-limited-liability-partnership",ClassificationType.RightToShareSurplusAssets50To75PercentAsFirmLimitedLiabilityPartnership},
{"right-to-share-surplus-assets-75-to-100-percent-as-firm-limited-liability-partnership",ClassificationType.RightToShareSurplusAssets75To100PercentAsFirmLimitedLiabilityPartnership},
{"voting-rights-25-to-50-percent-limited-liability-partnership",ClassificationType.VotingRights25To50PercentLimitedLiabilityPartnership},
{"voting-rights-50-to-75-percent-limited-liability-partnership",ClassificationType.VotingRights50To75PercentLimitedLiabilityPartnership},
{"voting-rights-75-to-100-percent-limited-liability-partnership",ClassificationType.VotingRights75To100PercentLimitedLiabilityPartnership},
{"voting-rights-25-to-50-percent-as-trust-limited-liability-partnership",ClassificationType.VotingRights25To50PercentAsTrustLimitedLiabilityPartnership},
{"voting-rights-50-to-75-percent-as-trust-limited-liability-partnership",ClassificationType.VotingRights50To75PercentAsTrustLimitedLiabilityPartnership},
{"voting-rights-75-to-100-percent-as-trust-limited-liability-partnership",ClassificationType.VotingRights75To100PercentAsTrustLimitedLiabilityPartnership},
{"voting-rights-25-to-50-percent-as-firm-limited-liability-partnership",ClassificationType.VotingRights25To50PercentAsFirmLimitedLiabilityPartnership},
{"voting-rights-50-to-75-percent-as-firm-limited-liability-partnership",ClassificationType.VotingRights50To75PercentAsFirmLimitedLiabilityPartnership},
{"voting-rights-75-to-100-percent-as-firm-limited-liability-partnership",ClassificationType.VotingRights75To100PercentAsFirmLimitedLiabilityPartnership},
{"right-to-appoint-and-remove-members-limited-liability-partnership",ClassificationType.RightToAppointAndRemoveMembersLimitedLiabilityPartnership},
{"right-to-appoint-and-remove-members-as-trust-limited-liability-partnership",ClassificationType.RightToAppointAndRemoveMembersAsTrustLimitedLiabilityPartnership},
{"right-to-appoint-and-remove-members-as-firm-limited-liability-partnership",ClassificationType.RightToAppointAndRemoveMembersAsFirmLimitedLiabilityPartnership},
{"significant-influence-or-control-limited-liability-partnership",ClassificationType.SignificantInfluenceOrControlLimitedLiabilityPartnership},
{"significant-influence-or-control-as-trust-limited-liability-partnership",ClassificationType.SignificantInfluenceOrControlAsTrustLimitedLiabilityPartnership},
{"significant-influence-or-control-as-firm-limited-liability-partnership",ClassificationType.SignificantInfluenceOrControlAsFirmLimitedLiabilityPartnership},
{"part-right-to-share-surplus-assets-25-to-50-percent",ClassificationType.PartRightToShareSurplusAssets25To50Percent},
{"part-right-to-share-surplus-assets-50-to-75-percent",ClassificationType.PartRightToShareSurplusAssets50To75Percent},
{"part-right-to-share-surplus-assets-75-to-100-percent",ClassificationType.PartRightToShareSurplusAssets75To100Percent},
{"part-right-to-share-surplus-assets-25-to-50-percent-as-trust",ClassificationType.PartRightToShareSurplusAssets25To50PercentAsTrust},
{"part-right-to-share-surplus-assets-50-to-75-percent-as-trust",ClassificationType.PartRightToShareSurplusAssets50To75PercentAsTrust},
{"part-right-to-share-surplus-assets-75-to-100-percent-as-trust",ClassificationType.PartRightToShareSurplusAssets75To100PercentAsTrust},
{"part-right-to-share-surplus-assets-25-to-50-percent-as-firm",ClassificationType.PartRightToShareSurplusAssets25To50PercentAsFirm},
{"part-right-to-share-surplus-assets-50-to-75-percent-as-firm",ClassificationType.PartRightToShareSurplusAssets50To75PercentAsFirm},
{"part-right-to-share-surplus-assets-75-to-100-percent-as-firm",ClassificationType.PartRightToShareSurplusAssets75To100PercentAsFirm},
{"right-to-appoint-and-remove-person",ClassificationType.RightToAppointAndRemovePerson},
{"right-to-appoint-and-remove-person-as-firm",ClassificationType.RightToAppointAndRemovePersonAsFirm},
{"right-to-appoint-and-remove-person-as-trust",ClassificationType.RightToAppointAndRemovePersonAsTrust }
        };

        public static readonly IReadOnlyDictionary<string, ParticularsType> PossibleParticularsType = new Dictionary
<string, ParticularsType>()
        {
{"short-particulars",ParticularsType.ShortParticulars},
{"charged-property-description",ParticularsType.ChargedPropertyDescription},
{"charged-property-or-undertaking-description",ParticularsType.ChargedPropertyOrUndertakingDescription},
{"brief-description",ParticularsType.BriefDescription}
        };

        public static readonly IReadOnlyDictionary<string, SecuredDetailsType> PossibleSecuredDetailsType = new Dictionary
<string, SecuredDetailsType>()
        {
{"amount-secured",SecuredDetailsType.AmountSecured},
{"obligations-secured",SecuredDetailsType.ObligationsSecured}
        };


        #endregion

        #region PersonWithSignificantControl
        public static readonly IReadOnlyDictionary<string, LegalPersonType> PossibleLegalPersonType = new Dictionary
<string, LegalPersonType>()
        {
{"legal-person-with-significant-control",LegalPersonType.LegalPersonWithSignificantControl}
        };

        public static readonly IReadOnlyDictionary<string, SuperSecurePersonDescriptionType> PossibleSuperSecurePersonDescriptionType = new Dictionary
<string, SuperSecurePersonDescriptionType>()
        {
{"super-secure-person-with-significant-control",SuperSecurePersonDescriptionType.SuperSecurePersonWithSignificantControl}
        };

        #endregion
    }
}