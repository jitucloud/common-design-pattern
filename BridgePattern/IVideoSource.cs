using System;
namespace BridgePattern
{
    public interface IVideoSource
    {
        string GetTvGudie();
        string PlayVideo();
        string VideoType { get; set; }
    }
}
