using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        videos.Add(new Video("Funniest Cats And Dogs Videos","Funniest Animals Ever",1541));
        videos.Add(new Video("Funny ANIMALS videos Funniest CATS and DOGS 2024","World Fun Animals", 3110));
        videos.Add(new Video("Baby Animals 4K - Amazing World Of Young Animals | Scenic Relaxation Film", "Scenic Scenes",2709 )); 

        videos[0].AddComment("Yoshi Yorkshire", "Super FUNNY video  have a EXCELLENT weekend  Kisses from little Yoshi bark bark ");
        videos[0].AddComment("blakecparis6626", "Funny and hilarious and adorable and touching as per usual");
        videos[1].AddComment("user-hs1ey4rk3z", "Honey the cat got a concussion again");
        videos[1].AddComment("kitsunee9", "the last stick was cool");
        videos[2].AddComment("trr444", "Very funny");
        videos[2].AddComment("23geter", "Cutes animals");

        foreach (Video video in videos)
        {
            Console.WriteLine($"** Video: {video.Title} **");
            Console.WriteLine($" Made by: {video.Author}");
            Console.WriteLine($" Length: {video.Length} seconds");
            Console.WriteLine($" Comments: {video.GetCommentCount()}");

            Console.WriteLine("  -Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"  {comment.Commenter}: {comment.Text}");
            }

            Console.WriteLine(); 
        }


        
    }

}