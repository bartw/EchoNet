using System.Collections.Generic;

namespace EchoNet.Models
{
    public class License
    {
        public string type { get; set; }
        public string attribution { get; set; }
        //attribution-url
        public string attributionUrl { get; set; }
        public string url { get; set; }
        public string version { get; set; }
    }

    public class Biography
    {
        public string text { get; set; }
        public string site { get; set; }
        public string url { get; set; }
        public License license { get; set; }
        public bool truncated { get; set; }
    }

    public class Blog
    {
        public string name { get; set; }
        public string url { get; set; }
        public string date_posted { get; set; }
        public string date_found { get; set; }
        public string summary { get; set; }
        public string id { get; set; }
    }

    public class Familiarity
    {
        public double familiarity { get; set; }
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Hotttnesss
    {
        public double hotttnesss { get; set; }
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Image
    {
        public string url { get; set; }
        public List<object> tags { get; set; }
        public bool verified { get; set; }
        public License license { get; set; }
    }

    public class News
    {
        public string url { get; set; }
        public string id { get; set; }
        public string date_found { get; set; }
        public string name { get; set; }
        public string summary { get; set; }
    }

    public class Genre
    {
        public string name { get; set; }
        public Urls urls { get; set; }
        public string description { get; set; }
    }

    public class Term
    {
        public double frequency { get; set; }
        public string name { get; set; }
        public double weight { get; set; }
    }

    public class DocCounts
    {
        public int reviews { get; set; }
        public int biographies { get; set; }
        public int video { get; set; }
        public int images { get; set; }
        public int news { get; set; }
        public int blogs { get; set; }
        public int audio { get; set; }
        public int songs { get; set; }
    }

    public class Review
    {
        public string name { get; set; }
        public string url { get; set; }
        public string summary { get; set; }
        public string date_reviewed { get; set; }
        public string date_found { get; set; }
        public string image_url { get; set; }
        public string release { get; set; }
        public string id { get; set; }
    }

    public class YearsActive
    {
        public int start { get; set; }
    }

    public class Video
    {
        public string title { get; set; }
        public string url { get; set; }
        public string site { get; set; }
        public string date_found { get; set; }
        public string image_url { get; set; }
        public string id { get; set; }
    }

    public class Urls
    {
        public string official_url { get; set; }
        public string lastfm_url { get; set; }
        public string twitter_url { get; set; }
        public string myspace_url { get; set; }
        public string wikipedia_url { get; set; }
        public string mb_url { get; set; }
    }

    public class Song
    {
        public int song_currency { get; set; }
        public string title { get; set; }
        public string artist_name { get; set; }
        public List<string> song_type { get; set; }
        public int artist_hotttnesss { get; set; }
        public AudioSummary audio_summary { get; set; }
        public int song_hotttnesss { get; set; }
        public int artist_familiarity { get; set; }
        public string artist_id { get; set; }
        public string id { get; set; }
        public ArtistLocation artist_location { get; set; }
    }

    public class AudioSummary
    {
        public int key { get; set; }
        public string analysis_url { get; set; }
        public double energy { get; set; }
        public double liveness { get; set; }
        public double tempo { get; set; }
        public double speechiness { get; set; }
        public double acousticness { get; set; }
        public int instrumentalness { get; set; }
        public int mode { get; set; }
        public int time_signature { get; set; }
        public double duration { get; set; }
        public double loudness { get; set; }
        public object audio_md5 { get; set; }
        public double valence { get; set; }
        public double danceability { get; set; }
    }

    public class ArtistLocation
    {
        public string city { get; set; }
        public object region { get; set; }
        public string location { get; set; }
        public string country { get; set; }
    }

    public class Artist
    {
        public List<Genre> genres { get; set; }
        public List<Term> terms { get; set; }
        public string name { get; set; }
        public List<Biography> biographies { get; set; }
        public int discovery_rank { get; set; }
        public List<Blog> blogs { get; set; }
        public DocCounts doc_counts { get; set; }
        public double familiarity { get; set; }
        public double hotttnesss { get; set; }
        public List<Review> reviews { get; set; }
        public List<Image> images { get; set; }
        public List<YearsActive> years_active { get; set; }
        public List<Video> video { get; set; }
        public Urls urls { get; set; }
        public int hotttnesss_rank { get; set; }
        public int familiarity_rank { get; set; }
        public List<News> news { get; set; }
        public List<Song> songs { get; set; }
        public string id { get; set; }
        public ArtistLocation artist_location { get; set; }
        public double discovery { get; set; }
    }

    public class Track
    {
        public string status { get; set; }
        public List<string> foreign_release_ids { get; set; }
        public string catalog { get; set; }
        public string audio_md5 { get; set; }
        public string id { get; set; }
        public string song_id { get; set; }
        public string release_image { get; set; }
        public string artist { get; set; }
        public List<string> foreign_ids { get; set; }
        public string title { get; set; }
        public string preview_url { get; set; }
        public string foreign_release_id { get; set; }
        public string release { get; set; }
        public string foreign_id { get; set; }
        public AudioSummary audio_summary { get; set; }
    }
}
