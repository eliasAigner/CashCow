using System;
using CashChow.Contracts.Persistence.CashCow;
namespace CashChow.Logic.Entities.CashCow
{
    partial class Participant : VersionEntity, IParticipant
    {
        public string Name { get; set; }
    }
}
