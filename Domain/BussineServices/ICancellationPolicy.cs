using SGCM.Domain.Entities;

namespace SGCM.Domain.BussinesServices
{
    public interface ICancellationPolicy
    {
        void ValidateCancellation(Appointment appointment);
    }
}