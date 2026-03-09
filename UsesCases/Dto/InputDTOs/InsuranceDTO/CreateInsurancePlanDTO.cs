namespace SGCM.UsesCase.DTOs
{
    public record CreateInsurancePlanDTO
    {
        public short InsuranceProviderId {get;set;}
        public string Name {get;set;} = default!;
    }
}