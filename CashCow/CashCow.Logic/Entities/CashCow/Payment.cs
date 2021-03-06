using CashChow.Contracts.Persistence.CashCow;
using System;

namespace CashChow.Logic.Entities.CashCow
{
    partial class Payment : VersionEntity, IPayment
    {
        public DateTime Date { get; set; }
        public IParticipant Participant { get; set; }
        public double Amount { get; set; }
        public string Title { get; set; }
    }
}
