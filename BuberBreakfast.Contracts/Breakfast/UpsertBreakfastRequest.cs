namespace BuberBreakfast.Contracts.Breakfast;

public record UpsertBreatfastResponse(
    string Name;
    string Description;
    DateTime StartDateTime;
    DateTime EndDateTime;
    List<string> Savory;
    List<string> Sweet;
)
