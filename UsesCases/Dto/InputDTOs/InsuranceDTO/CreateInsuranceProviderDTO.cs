namespace SGCM.UsesCase.DTOs
{
    public record CreateInsuranceProviderDTO
    {
        public string Name { get; init; } = default!;
        public string Phone { get; init; } = default!;
        public string Email { get; init; } = default!;
        public string Address { get; init; } = default!;
        public string City { get; init; } = default!;
        public string? Town {get; init;}
        public string? ZipCode {get; init;}
        public string Country {get; init;} = default!;
        public string? Website {get; init;}
        public string ContactCenter {get; init;} = default!;
    }
}