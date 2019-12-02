using System;

namespace generics {

  public class MessageService {
    public void OnVideoEncoded (object source, VideoEventArgs e) {
      System.Console.WriteLine ("Sending an message . . .  " + E.Video.Title);
    }
  }
}