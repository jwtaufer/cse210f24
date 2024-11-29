using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        
        //https://www.youtube.com/watch?v=wJO_vIDZn-I&t=12s        

        Video video1 = new Video(
            "A Minecraft Movie | Official Trailer", 
            "Minecraft",
            150
        );

        video1.AddComment(
            "@VygoOG",
            "The sentence 'I yearned for the mines' should become a splash text when you open the game"
        );

        video1.AddComment(
            "@Hot_dog_jello",
            "I like how absolutely no one cares about the trailer itself but more how kids yearn for the mines"
        );

        video1.AddComment(
            "@Lucas_Rash",
            "Teaser Trailer: 'I... Am Steve' \nOfficial Clip: 'This... is a crafting table' \nOfficial Trailer: 'As a child... I yearned for the mines'"
        );

        videos.Add(video1);

        //https://www.youtube.com/watch?v=5lzoxHSn0C0

        Video video2 = new Video(
            "How To Train Your Dragon | Official Teaser Trailer",
            "Universal Pictures",
            75
        );

        video2.AddComment(
            "@BMoneyruiz",
            "An animated version of this would be sick!"
        );

        video2.AddComment(
            "@Redwood_",
            "I'm glad they made Toothless look basically the same. I hope he is just as expressive as in the animated as well."
        );

        video2.AddComment(
            "@connection7405",
            "Perfect casting for Toothless!"
        );

        videos.Add(video2);

        //https://www.youtube.com/watch?v=eYKr6j5RamU
        
        
        Video video3 = new Video(
            "The Dark Knight but Kermit is The Joker",
            "Film Haze",
            84
        );

        video3.AddComment(
            "@Someone_wrf",
            "He's kermitting a crime, everyone."
        );

        video3.AddComment(
            "@AZ-im3ik",
            "After all these years, no one can come close to Kermit's performance of the Croaker."
        );

        video3.AddComment(
            "@TriTomMaximum",
            "'This interrogation was brought to you by the letter B.'"
        );

        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideo();
        }
    }
}