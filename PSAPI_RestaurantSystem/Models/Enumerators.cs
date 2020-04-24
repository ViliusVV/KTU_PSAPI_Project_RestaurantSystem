using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSAPIRestaurantSystem.Models
{
    enum WorkState
    {
        Working,
        Holiday,
        Fired
    }

    enum OrderState
    {
        Created,
        Made,
        Taked,
        Canceled,
        Submitted
    }

    enum ReservationState
    {
        NotConfirmed,
        Confirmed,
        Canceled
    }
}
