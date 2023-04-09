using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace imt.messages
{
	internal class BaseVM : INotifyPropertyChanged
	{
		protected void RaisePropertyChanged([CallerMemberName] string? propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public event PropertyChangedEventHandler? PropertyChanged;
	}
}
