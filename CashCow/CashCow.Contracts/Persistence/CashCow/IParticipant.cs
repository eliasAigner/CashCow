using CommonBase.Attributes;

namespace CashChow.Contracts.Persistence.CashCow
{
    [ContractInfo(ContextType = ContextType.Table)]
    public partial interface IParticipant : IVersionable
    {
        [ContractPropertyInfo(Required = true)]
        public string Name { get; set; }
    }
}