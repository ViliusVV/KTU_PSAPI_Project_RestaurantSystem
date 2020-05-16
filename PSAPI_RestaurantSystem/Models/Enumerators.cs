using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSAPIRestaurantSystem.Models
{
    enum WorkState
    {
        Working = 1,
        Holiday,
        Fired
    }

    enum OrderState
    {
        Created = 1,
        Made,
        Taked,
        Canceled,
        Submitted
    }

    enum ReservationState
    {
        NotConfirmed = 1,
        Confirmed,
        Canceled
    }
}
