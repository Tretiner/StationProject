namespace StationProject.Domain;

public record Product(
    int Id,
    string Name,
    int Price,
    string PriceTemplate,
    string Description,
    Dictionary<string, string> Parameters
);

public record ProductShort(
    int Id,
    string Name,
    string Price
);

// public record 