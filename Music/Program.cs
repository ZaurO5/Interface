class Program
{
    static void Main(string[] args)
    {
        Playlist playlist = new Playlist();

        playlist.AddSong(new Song("Song 1", "Artist 1", TimeSpan.FromMinutes(3), MusicGenre.Pop));
        playlist.AddSong(new Song("Song 2", "Artist 2", TimeSpan.FromMinutes(4), MusicGenre.Rock));
        playlist.AddSong(new Song("Song 3", "Artist 3", TimeSpan.FromMinutes(5), MusicGenre.Jazz));
        playlist.AddSong(new Song("Song 4", "Artist 4", TimeSpan.FromMinutes(6), MusicGenre.Classical));
        playlist.AddSong(new Song("Song 5", "Artist 5", TimeSpan.FromMinutes(7), MusicGenre.Pop));

        MusicGenre searchGenre = MusicGenre.Pop;
        List<Song> popSongs = playlist.GetAllSongsByGenre(searchGenre);
        Console.WriteLine($"{searchGenre} songs:");
        foreach (var song in popSongs)
        {
            Console.WriteLine($"{song.Title} - {song.Artist} - {song.Duration}");
        }
    }
}