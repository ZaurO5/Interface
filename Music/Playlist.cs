public class Playlist
{
    private List<Song> songs;

    public Playlist()
    {
        songs = new List<Song>();
    }
    public void AddSong(Song song)
    {
        songs.Add(song);
    }
    public List<Song> GetAllSongsByGenre(MusicGenre genre)
    {
        return songs.Where(s => s.Genre == genre).ToList();
    }
}