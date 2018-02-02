using System.Runtime.Serialization;

namespace CompaniesHouse.Response.CompanyCharges
{
    public enum FilingType
    {
        [EnumMember(Value = "")]
        None = 0,
        [EnumMember(Value = "create-charge")]
        CreateCharge,
        [EnumMember(Value = "create-charge-with-deed-with-charles-court-order")]
        CreateChargeWithDeedWithCharlesCourtOrder,
        [EnumMember(Value = "create-charge-with-deed-with-court-order")]
        CreateChargeWithDeedWithCourtOrder,
        [EnumMember(Value = "create-charge-with-deed")]
        CreateChargeWithDeed,
        [EnumMember(Value = "create-charge-with-deed-with-charles-court-order-limited-liability-partnership")]
        CreateChargeWithDeedWithCharlesCourtOrderLimitedLiabilityPartnership,
        [EnumMember(Value = "create-charge-with-deed-with-court-order-limited-liability-partnership")]
        CreateChargeWithDeedWithCourtOrderLimitedLiabilityPartnership,
        [EnumMember(Value = "create-charge-with-deed-limited-liability-partnership")]
        CreateChargeWithDeedLimitedLiabilityPartnership,
        [EnumMember(Value = "acquire-charge-with-deed-with-charles-court-order")]
        AcquireChargeWithDeedWithCharlesCourtOrder,
        [EnumMember(Value = "acquire-charge-with-deed-with-court-order")]
        AcquireChargeWithDeedWithCourtOrder,
        [EnumMember(Value = "acquire-charge-with-deed")]
        AcquireChargeWithDeed,
        [EnumMember(Value = "acquire-charge-with-deed-with-charles-court-order-limited-liability-partnership")]
        AcquireChargeWithDeedWithCharlesCourtOrderLimitedLiabilityPartnership,
        [EnumMember(Value = "acquire-charge-with-deed-with-court-order-limited-liability-partnership")]
        AcquireChargeWithDeedWithCourtOrderLimitedLiabilityPartnership,
        [EnumMember(Value = "acquire-charge-with-deed-limited-liability-partnership")]
        AcquireChargeWithDeedLimitedLiabilityPartnership,
        [EnumMember(Value = "debenture-with-deed-with-charles-court-order")]
        DebentureWithDeedWithCharlesCourtOrder,
        [EnumMember(Value = "debenture-with-deed-with-court-order")]
        DebentureWithDeedWithCourtOrder,
        [EnumMember(Value = "debenture-with-deed")]
        DebentureWithDeed,
        [EnumMember(Value = "debenture-with-deed-with-charles-court-order-limited-liability-partnership")]
        DebentureWithDeedWithCharlesCourtOrderLimitedLiabilityPartnership,
        [EnumMember(Value = "debenture-with-deed-with-court-order-limited-liability-partnership")]
        DebentureWithDeedWithCourtOrderLimitedLiabilityPartnership,
        [EnumMember(Value = "debenture-with-deed-limited-liability-partnership")]
        DebentureWithDeedLimitedLiabilityPartnership,
        [EnumMember(Value = "charge-satisfaction")]
        ChargeSatisfaction,
        [EnumMember(Value = "charge-satisfaction-limited-liability-partnership")]
        ChargeSatisfactionLimitedLiabilityPartnership,
        [EnumMember(Value = "charge-whole-release")]
        ChargeWholeRelease,
        [EnumMember(Value = "charge-whole-cease")]
        ChargeWholeCease,
        [EnumMember(Value = "charge-whole-both")]
        ChargeWholeBoth,
        [EnumMember(Value = "charge-part-release")]
        ChargePartRelease,
        [EnumMember(Value = "charge-part-cease")]
        ChargePartCease,
        [EnumMember(Value = "charge-part-both")]
        ChargePartBoth,
        [EnumMember(Value = "charge-release-cease")]
        ChargeReleaseCease,
        [EnumMember(Value = "charge-whole-release-limited-liability-partnership")]
        ChargeWholeReleaseLimitedLiabilityPartnership,
        [EnumMember(Value = "charge-whole-cease-limited-liability-partnership")]
        ChargeWholeCeaseLimitedLiabilityPartnership,
        [EnumMember(Value = "charge-whole-both-limited-liability-partnership")]
        ChargeWholeBothLimitedLiabilityPartnership,
        [EnumMember(Value = "charge-part-release-limited-liability-partnership")]
        ChargePartReleaseLimitedLiabilityPartnership,
        [EnumMember(Value = "charge-part-cease-limited-liability-partnership")]
        ChargePartCeaseLimitedLiabilityPartnership,
        [EnumMember(Value = "charge-part-both-limited-liability-partnership")]
        ChargePartBothLimitedLiabilityPartnership,
        [EnumMember(Value = "charge-release-cease-limited-liability-partnership")]
        ChargeReleaseCeaseLimitedLiabilityPartnership,
        [EnumMember(Value = "trustee-acting")]
        TrusteeActing,
        [EnumMember(Value = "trustee-acting-as-limited-liability-partnership")]
        TrusteeActingAsLimitedLiabilityPartnership,
        [EnumMember(Value = "alter-charge")]
        AlterCharge,
        [EnumMember(Value = "alter-charge-limited-liability-partnership")]
        AlterChargeLimitedLiabilityPartnership,
        [EnumMember(Value = "create-charge-without-deed-with-charles-court-order")]
        CreateChargeWithoutDeedWithCharlesCourtOrder,
        [EnumMember(Value = "create-charge-without-deed-with-court-order")]
        CreateChargeWithoutDeedWithCourtOrder,
        [EnumMember(Value = "create-charge-without-deed")]
        CreateChargeWithoutDeed,
        [EnumMember(Value = "create-charge-without-deed-with-charles-court-order-limited-liability-partnership")]
        CreateChargeWithoutDeedWithCharlesCourtOrderLimitedLiabilityPartnership,
        [EnumMember(Value = "create-charge-without-deed-with-court-order-limited-liability-partnership")]
        CreateChargeWithoutDeedWithCourtOrderLimitedLiabilityPartnership,
        [EnumMember(Value = "create-charge-without-deed-limited-liability-partnership")]
        CreateChargeWithoutDeedLimitedLiabilityPartnership,
        [EnumMember(Value = "acquire-charge-without-deed-with-charles-court-order")]
        AcquireChargeWithoutDeedWithCharlesCourtOrder,
        [EnumMember(Value = "acquire-charge-without-deed-with-court-order")]
        AcquireChargeWithoutDeedWithCourtOrder,
        [EnumMember(Value = "acquire-charge-without-deed")]
        AcquireChargeWithoutDeed,
        [EnumMember(Value = "acquire-charge-without-deed-with-charles-court-order-limited-liability-partnership")]
        AcquireChargeWithoutDeedWithCharlesCourtOrderLimitedLiabilityPartnership,
        [EnumMember(Value = "acquire-charge-without-deed-with-court-order-limited-liability-partnership")]
        AcquireChargeWithoutDeedWithCourtOrderLimitedLiabilityPartnership,
        [EnumMember(Value = "acquire-charge-without-deed-limited-liability-partnership")]
        AcquireChargeWithoutDeedLimitedLiabilityPartnership,
        [EnumMember(Value = "debenture-without-deed-with-charles-court-order")]
        DebentureWithoutDeedWithCharlesCourtOrder,
        [EnumMember(Value = "debenture-without-deed-with-court-order")]
        DebentureWithoutDeedWithCourtOrder,
        [EnumMember(Value = "debenture-without-deed")]
        DebentureWithoutDeed,
        [EnumMember(Value = "debenture-without-deed-with-charles-court-order-limited-liability-partnership")]
        DebentureWithoutDeedWithCharlesCourtOrderLimitedLiabilityPartnership,
        [EnumMember(Value = "debenture-without-deed-with-court-order-limited-liability-partnership")]
        DebentureWithoutDeedWithCourtOrderLimitedLiabilityPartnership,
        [EnumMember(Value = "debenture-without-deed-limited-liability-partnership")]
        DebentureWithoutDeedLimitedLiabilityPartnership,
        [EnumMember(Value = "alter-floating-charge")]
        AlterFloatingCharge,
        [EnumMember(Value = "alter-floating-charge-limited-liability-partnership")]
        AlterFloatingChargeLimitedLiabilityPartnership,
        [EnumMember(Value = "create-charge-pre-april-2013")]
        CreateChargePreApril2013,
        [EnumMember(Value = "create-charge-scotland-pre-april-2013")]
        CreateChargeScotlandPreApril2013,
        [EnumMember(Value = "create-charge-pre-april-2013-limited-liability-partnership")]
        CreateChargePreApril2013LimitedLiabilityPartnership,
        [EnumMember(Value = "create-charge-pre-2006-companies-act")]
        CreateChargePre2006CompaniesAct,
        [EnumMember(Value = "create-charge-pre-2006-companies-act-limited-liability-partnership")]
        CreateChargePre2006CompaniesActLimitedLiabilityPartnership,
        [EnumMember(Value = "create-charge-scotland-pre-2006-companies-act")]
        CreateChargeScotlandPre2006CompaniesAct,
        [EnumMember(Value = "charge-satisfaction-pre-april-2013")]
        ChargeSatisfactionPreApril2013,
        [EnumMember(Value = "charge-satisfaction-scotland-pre-april-2013")]
        ChargeSatisfactionScotlandPreApril2013,
        [EnumMember(Value = "charge-satisfaction-pre-2006-companies-act")]
        ChargeSatisfactionPre2006CompaniesAct,
        [EnumMember(Value = "charge-satisfaction-scotland-pre-2006-companies-act")]
        ChargeSatisfactionScotlandPre2006CompaniesAct,
        [EnumMember(Value = "charge-satisfaction-pre-april-2013-limited-liability-partnership")]
        ChargeSatisfactionPreApril2013LimitedLiabilityPartnership,
        [EnumMember(Value = "charge-satisfaction-floating-charge-in-scotland-pre-april-2013")]
        ChargeSatisfactionFloatingChargeInScotlandPreApril2013,
        [EnumMember(Value = "charge-part-or-whole-release-pre-april-2013")]
        ChargePartOrWholeReleasePreApril2013,
        [EnumMember(Value = "charge-part-or-whole-release-scotland-pre-april-2013")]
        ChargePartOrWholeReleaseScotlandPreApril2013,
        [EnumMember(Value = "charge-part-or-whole-release-limited-liability-partnership-pre-april-2013")]
        ChargePartOrWholeReleaseLimitedLiabilityPartnershipPreApril2013,
        [EnumMember(Value = "charge-released-floating-charge-in-scotland-pre-april-2013")]
        ChargeReleasedFloatingChargeInScotlandPreApril2013,
        [EnumMember(Value = "charge-released-floating-charge-in-pre-2006-companies-act")]
        ChargeReleasedFloatingChargeInPre2006CompaniesAct,
        [EnumMember(Value = "charge-released-floating-charge-in-scotland-pre-2006-companies-act")]
        ChargeReleasedFloatingChargeInScotlandPre2006CompaniesAct,
        [EnumMember(Value = "acquire-charge-pre-april-2013")]
        AcquireChargePreApril2013,
        [EnumMember(Value = "acquire-charge-scotland-pre-april-2013")]
        AcquireChargeScotlandPreApril2013,
        [EnumMember(Value = "acquire-charge-limited-liability-partnership-pre-april-2013")]
        AcquireChargeLimitedLiabilityPartnershipPreApril2013,
        [EnumMember(Value = "acquire-charge-pre-2006-companies-act")]
        AcquireChargePre2006CompaniesAct,
        [EnumMember(Value = "acquire-charge-scotland-pre-2006-companies-act")]
        AcquireChargeScotlandPre2006CompaniesAct,
        [EnumMember(Value = "create-charge-series-debentures-pre-april-2013")]
        CreateChargeSeriesDebenturesPreApril2013,
        [EnumMember(Value = "create-charge-series-debentures-scotland-pre-april-2013")]
        CreateChargeSeriesDebenturesScotlandPreApril2013,
        [EnumMember(Value = "create-charge-series-debentures-limited-liability-partnership")]
        CreateChargeSeriesDebenturesLimitedLiabilityPartnership,
        [EnumMember(Value = "create-charge-series-debentures-pre-2006-companies-act")]
        CreateChargeSeriesDebenturesPre2006CompaniesAct,
        [EnumMember(Value = "create-charge-series-debentures-scotland-pre-2006-companies-act")]
        CreateChargeSeriesDebenturesScotlandPre2006CompaniesAct,
        [EnumMember(Value = "create-issue-out-of-series-debentures-scotland-pre-2006-companies-act")]
        CreateIssueOutOfSeriesDebenturesScotlandPre2006CompaniesAct,
        [EnumMember(Value = "create-issue-of-secured-debentures-pre-april-2013")]
        CreateIssueOfSecuredDebenturesPreApril2013,
        [EnumMember(Value = "create-issue-of-secured-debentures-scotland-pre-april-2013")]
        CreateIssueOfSecuredDebenturesScotlandPreApril2013,
        [EnumMember(Value = "create-issue-of-secured-debentures-pre-2006-companies-act")]
        CreateIssueOfSecuredDebenturesPre2006CompaniesAct,
        [EnumMember(Value = "create-issue-of-secured-debentures-limited-liability-partnership-pre-april-2013")]
        CreateIssueOfSecuredDebenturesLimitedLiabilityPartnershipPreApril2013,
        [EnumMember(Value = "create-issue-of-secured-debentures-limited-liability-partnership-scotland-pre-april-2013")]
        CreateIssueOfSecuredDebenturesLimitedLiabilityPartnershipScotlandPreApril2013,
        [EnumMember(Value = "liquidation-appointment-of-receiver")]
        LiquidationAppointmentOfReceiver,
        [EnumMember(Value = "liquidation-appointment-of-receiver-pre-april-2013")]
        LiquidationAppointmentOfReceiverPreApril2013,
        [EnumMember(Value = "liquidation-appointment-of-receiver-limited-liability-partnership")]
        LiquidationAppointmentOfReceiverLimitedLiabilityPartnership,
        [EnumMember(Value = "liquidation-appointment-of-receiver-scotland")]
        LiquidationAppointmentOfReceiverScotland,
        [EnumMember(Value = "liquidation-appointment-of-receiver-by-court-scotland")]
        LiquidationAppointmentOfReceiverByCourtScotland,
        [EnumMember(Value = "liquidation-appointment-of-receiver-pre-2006-companies-act")]
        LiquidationAppointmentOfReceiverPre2006CompaniesAct,
        [EnumMember(Value = "liquidation-appointment-of-liquidator")]
        LiquidationAppointmentOfLiquidator,
        [EnumMember(Value = "liquidation-cease-to-act-receiver")]
        LiquidationCeaseToActReceiver,
        [EnumMember(Value = "liquidation-cease-to-act-receiver-pre-april-2013")]
        LiquidationCeaseToActReceiverPreApril2013,
        [EnumMember(Value = "liquidation-cease-to-act-receiver-limited-liability-partnership")]
        LiquidationCeaseToActReceiverLimitedLiabilityPartnership,
        [EnumMember(Value = "liquidation-cease-to-act-receiver-pre-2006-companies-act")]
        LiquidationCeaseToActReceiverPre2006CompaniesAct,
        [EnumMember(Value = "liquidation-ceasing-to-act-receiver-scotland")]
        LiquidationCeasingToActReceiverScotland,
        [EnumMember(Value = "create-charge-northern-ireland-pre-2006-companies-act-form-402")]
        CreateChargeNorthernIrelandPre2006CompaniesActForm402,
        [EnumMember(Value = "create-charge-northern-ireland-pre-2006-companies-act-form-402DF")]
        CreateChargeNorthernIrelandPre2006CompaniesActForm402Df,
        [EnumMember(Value = "create-charge-northern-ireland-pre-2006-companies-act-form-402PP")]
        CreateChargeNorthernIrelandPre2006CompaniesActForm402Pp,
        [EnumMember(Value = "create-charge-northern-ireland-pre-2006-companies-act-form-402R")]
        CreateChargeNorthernIrelandPre2006CompaniesActForm402R,
        [EnumMember(Value = "create-charge-northern-ireland-pre-2006-companies-act-form-407")]
        CreateChargeNorthernIrelandPre2006CompaniesActForm407,
        [EnumMember(Value = "create-charge-by-judgement-enforcement-office-northern-ireland-pre-2006-companies-act-form-408")]
        CreateChargeByJudgementEnforcementOfficeNorthernIrelandPre2006CompaniesActForm408,
        [EnumMember(Value = "supporting-evidence-create-charge-northern-ireland-pre-2006-companies-act")]
        SupportingEvidenceCreateChargeNorthernIrelandPre2006CompaniesAct,
        [EnumMember(Value = "charge-satisfaction-northern-ireland-pre-2006-companies-act")]
        ChargeSatisfactionNorthernIrelandPre2006CompaniesAct,
        [EnumMember(Value = "charge-release-cease-northern-ireland-pre-2006-companies-act")]
        ChargeReleaseCeaseNorthernIrelandPre2006CompaniesAct,
        [EnumMember(Value = "charge-part-satisfaction")]
        ChargePartSatisfaction,
        [EnumMember(Value = "charge-part-satisfaction-limited-liability-partnership")]
        ChargePartSatisfactionLimitedLiabilityPartnership,
        [EnumMember(Value = "charge-satisfaction-cease-release-northen-pre-2006-companies-act-ireland")]
        ChargeSatisfactionCeaseReleaseNorthenPre2006CompaniesActIreland,
        [EnumMember(Value = "create-floating-charge-scotland")]
        CreateFloatingChargeScotland,
        [EnumMember(Value = "create-charge-pre-april-2013-limited-liability-partnership-scotland")]
        CreateChargePreApril2013LimitedLiabilityPartnershipScotland,
        [EnumMember(Value = "charge-satisfaction-pre-april-2013-limited-liability-partnership-scotland")]
        ChargeSatisfactionPreApril2013LimitedLiabilityPartnershipScotland,
        [EnumMember(Value = "charge-satisfaction-floating-charge-in-scotland-pre-april-2013-limited-liability-partnership")]
        ChargeSatisfactionFloatingChargeInScotlandPreApril2013LimitedLiabilityPartnership,
        [EnumMember(Value = "charge-part-or-whole-release-pre-april-2013--limited-liability-partnership-scotland")]
        ChargePartOrWholeReleasePreApril2013LimitedLiabilityPartnershipScotland,
        [EnumMember(Value = "charge-released-floating-charge-in-scotland-pre-april-2013--limited-liability-partnership")]
        ChargeReleasedFloatingChargeInScotlandPreApril2013LimitedLiabilityPartnership,
        [EnumMember(Value = "acquire-charge-limited-liability-partnership-pre-april-2013-scotland")]
        AcquireChargeLimitedLiabilityPartnershipPreApril2013Scotland,
        [EnumMember(Value = "create-charge-series-debentures-limited-liability-partnership-scotland")]
        CreateChargeSeriesDebenturesLimitedLiabilityPartnershipScotland,
        [EnumMember(Value = "charge-satisfaction-pre-2006-companies-act-limited-liability-partnership")]
        ChargeSatisfactionPre2006CompaniesActLimitedLiabilityPartnership,
        [EnumMember(Value = "charge-released-floating-charge-in-pre-2006-companies-act-limited-liability-partnership")]
        ChargeReleasedFloatingChargeInPre2006CompaniesActLimitedLiabilityPartnership,
        [EnumMember(Value = "charge-satisfaction-scotland-pre-2006-companies-act-limited-liability-partnership")]
        ChargeSatisfactionScotlandPre2006CompaniesActLimitedLiabilityPartnership,
        [EnumMember(Value = "charge-released-floating-charge-in-scotland-pre-2006-companies-act-limited-liability-partnership")]
        ChargeReleasedFloatingChargeInScotlandPre2006CompaniesActLimitedLiabilityPartnership,
        [EnumMember(Value = "liquidation-appointment-of-receiver-pre-april-2013-limited-liability-partnership")]
        LiquidationAppointmentOfReceiverPreApril2013LimitedLiabilityPartnership,
        [EnumMember(Value = "liquidation-cease-to-act-receiver-pre-april-2013-limited-liability-partnership")]
        LiquidationCeaseToActReceiverPreApril2013LimitedLiabilityPartnership,
        [EnumMember(Value = "liquidation-appointment-of-receiver-pre-april-2013-overseas")]
        LiquidationAppointmentOfReceiverPreApril2013Overseas,
        [EnumMember(Value = "liquidation-cease-to-act-receiver-pre-april-2013-overseas")]
        LiquidationCeaseToActReceiverPreApril2013Overseas,
        [EnumMember(Value = "supporting-evidence-create-charge-northern-ireland-pre-2006-companies-act-limited-liability-partnership")]
        SupportingEvidenceCreateChargeNorthernIrelandPre2006CompaniesActLimitedLiabilityPartnership,
        [EnumMember(Value = "charge-satisfaction-northern-ireland-pre-2006-companies-act-limited-liability-partnership")]
        ChargeSatisfactionNorthernIrelandPre2006CompaniesActLimitedLiabilityPartnership,
        [EnumMember(Value = "charge-release-cease-northern-ireland-pre-2006-companies-act-limited-liability-partnership")]
        ChargeReleaseCeaseNorthernIrelandPre2006CompaniesActLimitedLiabilityPartnership,
        [EnumMember(Value = "create-charge-northern-ireland-pre-2006-companies-act-form-402-limited-liability-partnership")]
        CreateChargeNorthernIrelandPre2006CompaniesActForm402LimitedLiabilityPartnership,
        [EnumMember(Value = "create-charge-northern-ireland-pre-2006-companies-act-form-C402")]
        CreateChargeNorthernIrelandPre2006CompaniesActFormC402,
        [EnumMember(Value = "create-charge-by-judgement-enforcement-office-northern-ireland-pre-2006-companies-act-form-C408")]
        CreateChargeByJudgementEnforcementOfficeNorthernIrelandPre2006CompaniesActFormC408,
        [EnumMember(Value = "charge-certificate-northern-ireland-pre-2006-companies-act-form-C404")]
        ChargeCertificateNorthernIrelandPre2006CompaniesActFormC404,

    }
}