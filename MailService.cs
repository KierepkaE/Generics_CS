using System;

namespace generics {

  public class MailService {
    public void OnVideoEncoded (object source, EventArgs e) {
      System.Console.WriteLine ("Sending an email . . .");
    }
  }
}