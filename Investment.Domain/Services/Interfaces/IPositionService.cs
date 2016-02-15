using System.Collections.Generic;

namespace Investment.Domain.Services.Interfaces
{
    public interface IPositionService
    {
        IEnumerable<CurrentPosition> GetCurrentPosition();
    }
}
