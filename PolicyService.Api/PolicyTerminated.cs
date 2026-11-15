using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace PolicyService.Api.Events;

public class PolicyTerminated : INotification
{
    public string PolicyNumber { get; set; }
    public DateTime PolicyTo { get; set; }
    public decimal AmountToReturn { get; set; }
}