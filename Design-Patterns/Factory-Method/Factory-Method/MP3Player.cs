namespace Factory_Method
{
    public class MP3Player : ElectronicProductBase
    {
        public MP3Player()
        {
            Name = "MP3 Player";
            Description = "MP3 Player is used for listening songs";
        }
        public string SupportedAudioFormats { get; set; }
        public string Frequency { get; set; }
    }
}
