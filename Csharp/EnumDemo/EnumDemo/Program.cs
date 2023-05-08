namespace EnumDemo
{
    internal class Program
    {
        enum MusicPlayer { play,pause,Forward,Record,Stop}
        static void Main(string[] args)
        {
            Console.WriteLine((int)MusicPlayer.play);
            Console.WriteLine((int)MusicPlayer.pause);
            Console.WriteLine((int)MusicPlayer.Forward);
            Console.WriteLine((int)MusicPlayer.Record);
            Console.WriteLine((int)MusicPlayer.Stop);
        }
    }
}