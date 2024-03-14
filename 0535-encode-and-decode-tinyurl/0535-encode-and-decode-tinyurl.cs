public class Codec
{
    private Dictionary<int, string> d = new();

    public string encode(string longUrl)
    {
        int hash = longUrl.GetHashCode();
        d.Add(hash, longUrl);
        return $"http://somekindofsmallerurls.com/{hash}";
    }

    public string decode(string shortUrl)
    {
        var inputArr = shortUrl.Split('/');
        int hash = int.Parse(inputArr[^1]);
        return d[hash];
    }
}