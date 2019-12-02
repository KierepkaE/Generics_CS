using System;

namespace generics {

    class Program {
        static void Main (string[] args) {
            // Lambda
            // number => number * number

            Func<int, int> square = number => number * number;
            Console.WriteLine (square (5));
            const int factor = 5;
            Func<int, int> multiply = n => n * factor;
            var result = multiply (10);
            System.Console.WriteLine (result);

            var video = new Video () { Title = "Video 1" };
            var videoEncoder = new VideoEncoder (); // publisher
            var mailService = new MailService (); // subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.Encode (video);

        }
    }
}