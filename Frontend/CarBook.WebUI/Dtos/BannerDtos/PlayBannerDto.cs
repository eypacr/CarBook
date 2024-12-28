namespace CarBook.WebUI.Dtos.BannerDtos;

public class PlayBannerDto
{
    public string VideoUrl { get; set; }
    public string GetEmbedUrl()
    {
        // YouTube URL'sini embed formatına dönüştürme
        if (!string.IsNullOrEmpty(VideoUrl) && VideoUrl.Contains("youtube.com/watch?v="))
        {
            var videoId = VideoUrl.Split(new string[] { "v=" }, StringSplitOptions.None).Last();
            return $"https://www.youtube.com/embed/{videoId}";
        }

        return VideoUrl; // Eğer URL başka bir formattaysa, olduğu gibi döndür
    }
}
