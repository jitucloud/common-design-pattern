using System;
namespace BridgePattern
{
    public class LocalCabelTv : IVideoSource
    {
	    string SOURCE_NAME = "Local Cabel TV";

        public string VideoType { 
            get
            {
                return SOURCE_NAME;
            }
            set
            {
                SOURCE_NAME = value;
            }
        }

        public string GetTvGudie()
		{
			return string.Format("Getting TV guide from - {0}", SOURCE_NAME);
		}

        public string PlayVideo()
		{
			return string.Format("Playing - {0}", SOURCE_NAME);
		}

    }
}
