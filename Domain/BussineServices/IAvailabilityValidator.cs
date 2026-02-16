namespace ICitaService
{
    public interface IAvailabilityValidator
    {
        Task ValidateAvailabilityAsync(Guid doctorId, DateTime date);
    }
}