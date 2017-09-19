using System;
namespace BridgePattern
{
    public class MySuperSmartTV
    {
		IVideoSource currentVideoSource = null;

		public IVideoSource VideoSource
		{
			get
			{
				return currentVideoSource;
			}
			set
			{
				currentVideoSource = value;
			}
		}

		public void ShowTvGuide()
		{
			if (currentVideoSource != null)
			{
                Console.WriteLine(currentVideoSource.GetTvGudie());
			}
			else
			{
				Console.WriteLine("Please select a Video Source to get TV guide from");
			}
		}

		public void PlayTV()
		{
			if (currentVideoSource != null)
			{
				Console.WriteLine(currentVideoSource.PlayVideo());
			}
			else
			{
				Console.WriteLine("Please select a Video Source to play");
			}
		}
    }
}
