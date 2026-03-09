namespace SGCM.UsesCases.DTOs.Autentication
{
    public record LoginRequest
    {
        public  string Email {get;init;}
        public  string Password {get;init;}
    }
}