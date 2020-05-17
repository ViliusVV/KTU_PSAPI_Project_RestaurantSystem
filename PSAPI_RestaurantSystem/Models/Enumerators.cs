using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSAPIRestaurantSystem.Models
{
    public enum WorkState
    {
        Working = 1,
        Holiday,
        Fired
    }

    public enum OrderState
    {
        Created = 1,
        Made,
        Taked,
        Canceled,
        Submitted
    }

    public enum ReservationState : int
    {
        Active = 1,
        Done,
        Canceled
    }
}
