using System;

namespace generics {

  public class MessageService {
    public void OnVideoEncoded (object source, EventArgs e) {
      System.Console.WriteLine ("Sending an message . . .  ");
    }
  }
}