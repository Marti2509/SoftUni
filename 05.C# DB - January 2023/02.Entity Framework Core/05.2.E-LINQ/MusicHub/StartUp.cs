namespace MusicHub;

using MusicHub.Data;

public class StartUp
{
    public static void Main()
    {
        MusicHubDbContext context =
            new MusicHubDbContext();


    }

    public static string ExportAlbumsInfo(MusicHubDbContext context, int producerId)
    {
        throw new NotImplementedException();
    }

    public static string ExportSongsAboveDuration(MusicHubDbContext context, int duration)
    {
        throw new NotImplementedException();
    }
}