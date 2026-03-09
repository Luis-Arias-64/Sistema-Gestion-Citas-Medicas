using SGCM.Entities.Appointments;
using SGCM.UsesCase.Repository;

namespace SGCM.UsesCase.Features.AppointmentUsesCases
{
    public class CreateAppointmentUsesCases
    {
        public readonly IAppointmentRepository _context;

        public CreateAppointmentUsesCases(IAppointmentRepository appointmentRepository)
        {
            appointmentRepository = _context;
        }

    }
}