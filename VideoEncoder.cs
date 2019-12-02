using System;
using System.Threading;

namespace generics {

  public class VideoEncoder {
    // To create an event
    // 1 Define a delegate
    // 2 Define an event
    // 3 Raise the event

    public event EventHandler<VideoEventArgs> VideoEncoded;

    public void Encode (Video video) {
      System.Console.WriteLine ("Encoding video in progress . . . ");
      Thread.Sleep (3000);
      OnVideoEncoded (video);
    }

    protected virtual void OnVideoEncoded (Video video) {
      if (VideoEncoded != null)
        VideoEncoded (this, new VideoEventArgs () { Video = video });

    }
  }
}