namespace SGCM.UsesCase.DTOs
{
    public record DoctorResponseDTO : PersonalResponseDTO
    {
        public string LicenceNumber {get;set;}
    }
}