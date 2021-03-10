using CommonBase.Extensions;
using CashChow.Contracts.Persistence.MusicStore;

namespace CashChow.Logic.Entities.MusicStore
{
	internal partial class Genre : VersionEntity, IGenre
	{
		public string Name { get; set; }

		public void CopyProperties(IGenre other)
		{
			other.CheckArgument(nameof(other));

			Id = other.Id;
			RowVersion = other.RowVersion;
			Name = other.Name;
		}
	}
}
