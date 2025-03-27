using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video bricky = new Video("How is Warhammer 40K Darktide doing now?", "Bricky", 1192);
        Comment vitto = new Comment("vittoriocorbo8301", "Can we get a revisited Bricky?? He has become far more Brickier");
        bricky.AddComment(vitto);
        Comment oni = new Comment("Oniwolfx5", "So far my favorite line is for my zealot which is Blood for the Emperor! Skulls for the golden throne, i have to set down my controller every time to contemplate what i just said");
        bricky.AddComment(oni);
        Comment kaz = new Comment("Kazrel", "I'm really hoping those rumors of a tyranid/genestealer faction coming soon is true. I absolutely love blasting through this game with my friends, but I hope they add new levels down the line");
        bricky.AddComment(kaz);
        videos.Add(bricky);

        Video slime = new Video("Click This Video To Walk Forward", "Slmccl", 2716);
        Comment comm1 = new Comment("Binadra3D", "Thank you for the opportunity to do this 3D animation and participate in this project!");
        Comment comm2 = new Comment("al_CTB017", "I can’t believe they made a walking simulator have the same level of stress as dark souls");
        Comment comm3 = new Comment("distortionistxx", "i really appreciate that while charlie typically has one psychological break every video, he has gifted us with several today. thank you slime.");
        slime.AddComment(comm1);
        slime.AddComment(comm2);
        slime.AddComment(comm3);
        videos.Add(slime);

        Video portal = new Video("Invincible and Spider-Man are NOT the same", "A portal", 126);
        Comment pcomm1 = new Comment("pontosanaz6485", "Every single problem that mark faces is invincible is something he could have averted if he was just selfish. Damn you put it in such great words. Great vid, hope you blow up!");
        Comment pcomm2 = new Comment("RandomUserttt", "I hope spidey get's the Mark treatment");
        Comment pcomm3 = new Comment("Buster419", "Mark abandoned reality, peter forgot it");

        portal.AddComment(pcomm1);
        portal.AddComment(pcomm2);
        portal.AddComment(pcomm3);
        videos.Add(portal);

        foreach(Video video in videos){
            Console.WriteLine(video.GetDisplayText());
        }

    }
}