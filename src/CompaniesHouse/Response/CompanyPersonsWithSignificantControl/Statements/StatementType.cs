using System.Runtime.Serialization;

namespace CompaniesHouse.Response.CompanyPersonsWithSignificantControl.Statements
{
    public enum StatementType
    {
        [EnumMember(Value = "")]
        None = 0,
        [EnumMember(Value = "no-individual-or-entity-with-signficant-control")]
        NoIndividualOrEntityWithSignficantControl,

        [EnumMember(Value = "psc-exists-but-not-identified")]
        PscExistsButNotIdentified,

        [EnumMember(Value = "psc-details-not-confirmed")]
        PscDetailsNotConfirmed,

        [EnumMember(Value = "steps-to-find-psc-not-yet-completed")]
        StepsToFindPscNotYetCompleted,

        [EnumMember(Value = "psc-contacted-but-no-response")]
        PscContactedButNoResponse,

        [EnumMember(Value = "psc-has-failed-to-confirm-changed-details")]
        PscHasFailedToConfirmChangedDetails,

        [EnumMember(Value = "restrictions-notice-issued-to-psc")]
        RestrictionsNoticeIssuedToPsc,

        [EnumMember(Value = "no-individual-or-entity-with-signficant-control-partnership")]
        NoIndividualOrEntityWithSignficantControlPartnership,

        [EnumMember(Value = "psc-exists-but-not-identified-partnership")]
        PscExistsButNotIdentifiedPartnership,

        [EnumMember(Value = "psc-details-not-confirmed-partnership")]
        PscDetailsNotConfirmedPartnership,

        [EnumMember(Value = "steps-to-find-psc-not-yet-completed-partnership")]
        StepsToFindPscNotYetCompletedPartnership,

        [EnumMember(Value = "psc-contacted-but-no-response-partnership")]
        PscContactedButNoResponsePartnership,

        [EnumMember(Value = "psc-has-failed-to-confirm-changed-details-partnership")]
        PscHasFailedToConfirmChangedDetailsPartnership,

        [EnumMember(Value = "restrictions-notice-issued-to-psc-partnership")]
        RestrictionsNoticeIssuedToPscPartnership,

    }
}