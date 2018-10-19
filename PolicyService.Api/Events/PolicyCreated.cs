﻿using MediatR;
using PolicyService.Api.Commands.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolicyService.Api.Events
{
    public class PolicyCreated : INotification
    {
        public string PolicyNumber { get; set; }
        public string ProductCode { get; set; }
        public DateTimeOffset PolicyFrom { get; set; }
        public DateTimeOffset PolicyTo { get; set; }
        public PersonDto PolicyHolder { get; set; }
        public decimal TotalPremium { get; set; }
    }
}
