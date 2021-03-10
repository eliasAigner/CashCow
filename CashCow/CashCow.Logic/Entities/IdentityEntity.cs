//@BaseCode

using CashChow.Contracts;

namespace CashChow.Logic.Entities
{
	internal abstract partial class IdentityEntity : IIdentifiable
	{
		public int Id { get; set; }
	}
}
