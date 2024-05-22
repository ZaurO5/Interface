public class Song
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public TimeSpan Duration { get; set; }
    public MusicGenre Genre { get; set; }

    public Song(string title, string artist, TimeSpan duration, MusicGenre genre)
    {
        Title = title;
        Artist = artist;
        Duration = duration;
        Genre = genre;
    }
}