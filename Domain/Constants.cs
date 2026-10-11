namespace Domain;

public enum WorkflowType
{
    NewSpace = 1,
    Renewal = 2,
    MonthToMonthOverhold = 3,
    NaturalExpiry = 4,
    EarlyTermination = 5,
    VacateLeased = 6,
    VacateOwned = 7,
    TransferFromVacantSpace = 8,
    Transfer = 9,
    ReMeasurement = 12,
    GovernmentOwnedRateChange = 13,
    AmendNewSpace = 14,
    AmendRenewal = 15,
    AmendMonthToMonthOverhold = 16,
    AmendNaturalExpiry = 17,
    AmendEarlyTermination = 18,
    AmendReMeasurement = 19,
    AmendGovernmentOwnedRateChange = 21,
}
