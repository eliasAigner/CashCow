//@BaseCode

namespace CashChow.Contracts
{
	public partial interface ICopyable<T>
	{
		void CopyProperties(T other);
	}
}
