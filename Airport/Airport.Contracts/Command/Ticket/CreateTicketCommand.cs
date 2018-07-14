﻿using Abstractions.CQRS;
using System;

namespace Airport.Contract.Command.Ticket
{
    public class CreateTicketCommand : ICommand
    {
        public Guid Id { get; set; }
        public double Price { get; set; }
        public int FlightNumber { get; set; }
    }
}
