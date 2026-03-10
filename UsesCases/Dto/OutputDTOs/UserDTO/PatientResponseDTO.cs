namespace SGCM.UsesCase.DTOs
{
    public record PatientResponseDTO : PersonResposeDTO
    {
        public string EmergencyName {get; set;} = default!; 
        public string EmergencyPhone {get; set;} = default!;
    }
}