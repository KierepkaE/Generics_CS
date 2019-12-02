using System;
using System.Threading;

namespace generics {

  public class VideoEncoder {
    public void Encode (Video video) {
      System.Console.WriteLine ("Encoding video in progress . . . ");
      Thread.Sleep (3000);
    }
  }
}