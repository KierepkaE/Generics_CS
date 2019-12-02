using System;
using System.Threading;

namespace generics {

  public class VideoEncoder {
    // To create an event
    // 1 Define a delegate
    // 2 Define an event
    // 3 Raise the event

    public delegate void VideoEncodedEventHandler (object source, EventArgs args);
    public event VideoEncodedEventHandler VideoEncoded;

    public void Encode (Video video) {
      System.Console.WriteLine ("Encoding video in progress . . . ");
      Thread.Sleep (3000);
      OnVideoEncoded ();
    }

    protected virtual void OnVideoEncoded () {
      if (VideoEncoded != null)
        VideoEncoded (this, EventArgs.Empty);

    }
  }
}