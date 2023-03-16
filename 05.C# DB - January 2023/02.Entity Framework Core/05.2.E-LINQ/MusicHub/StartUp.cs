namespace MusicHub;

using MusicHub.Data;
using MusicHub.Initializer;
using System.Globalization;
using System.Text;

public class StartUp
{
    public static void Main()
    {
        MusicHubDbContext context =
            new MusicHubDbContext();

        DbInitializer.ResetDatabase(context);

        //string result = ExportAlbumsInfo(context, int.Parse(Console.ReadLine()));

        string result = ExportSongsAboveDuration(context, int.Parse(Console.ReadLine()));

        Console.WriteLine(result);
    }

    public static string ExportAlbumsInfo(MusicHubDbContext context, int producerId)
    {
        StringBuilder sb = new StringBuilder();

        var albums = context.Albums
            .Where(a => a.ProducerId.HasValue &&
                    a.ProducerId.Value == producerId)
            .ToArray()
            .OrderByDescending(a => a.Price)
            .Select(a => new
            {
                a.Name,
                ReleaseDate = a.ReleaseDate.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture),
                ProducerName = a.Producer.Name,
                AlbumPrice = a.Price.ToString("f2"),
                Songs = a.Songs
                    .Select(s => new
                    {
                        SongName = s.Name,
                        SongPrice = s.Price.ToString("f2"),
                        SongWriter = s.Writer.Name
                    })
                    .OrderByDescending(s => s.SongName)
                    .ThenBy(s => s.SongWriter)
            })
            .ToArray();

        foreach (var album in albums)
        {
            sb.AppendLine($"-AlbumName: {album.Name}");
            sb.AppendLine($"-ReleaseDate: {album.ReleaseDate}");
            sb.AppendLine($"-ProducerName: {album.ProducerName}");
            sb.AppendLine($"-Songs:");

            int counter = 1;

            foreach (var song in album.Songs)
            {
                sb.AppendLine($"---#{counter}");
                sb.AppendLine($"---SongName: {song.SongName}");
                sb.AppendLine($"---Price: {song.SongPrice}");
                sb.AppendLine($"---Writer: {song.SongWriter}");

                counter++;
            }

            sb.AppendLine($"-AlbumPrice: {album.AlbumPrice}");
        }

        return sb.ToString().Trim();
    }

    public static string ExportSongsAboveDuration(MusicHubDbContext context, int duration)
    {
        StringBuilder sb = new StringBuilder();

        var songs = context.Songs
            .AsEnumerable()
            .Where(s => s.Duration.TotalSeconds > duration)
            .Select(s => new
            {
                SongName = s.Name,
                SongWriter = s.Writer.Name,
                Performers = s.SongPerformers
                    .Select(p => $"{p.Performer.FirstName} {p.Performer.LastName}")
                    .OrderBy(p => p)
                    .ToArray(),
                ProducerName = s.Album.Producer.Name,
                Duration = s.Duration.ToString("c")
            })
            .OrderBy(p => p.SongName)
            .ThenBy(p => p.SongWriter)
            .ToArray();

        int counter = 1;

        foreach (var song in songs)
        {
            sb.AppendLine($"-Song #{counter}");
            sb.AppendLine($"---SongName: {song.SongName}");
            sb.AppendLine($"---Writer: {song.SongWriter}");

            if (song.Performers.Any())
            {
                foreach (var performer in song.Performers)
                {
                    sb.AppendLine($"---Performer: {performer}");
                }
            }

            sb.AppendLine($"---AlbumProducer: {song.ProducerName}");
            sb.AppendLine($"---Duration: {song.Duration}");

            counter++;
        }

        return sb.ToString().Trim();
    }
}