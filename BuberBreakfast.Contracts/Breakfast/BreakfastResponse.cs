namespace BuberBreakfast.Contracts.Breakfast;

public record BreatfastResponse(
    Guid Id;
    string Name;
    string Description;
    DateTime StartDateTime;
    DateTime EndDateTime;
    DateTime LastModified;
    List<string> Savory;
    List<string> Sweet;
)
