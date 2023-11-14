namespace DapperGET
{
    public class Error
    {
        public DateTime ThrownAt { get; set; }
        public int LogLevel { get; set; }
        public string Message { get; set; } = string.Empty;
        public Dictionary<string, string>? Parameters { get; set; } // Assuming it's a key-value dictionary
        public string ExceptionType { get; set; } = string.Empty;
        public string Source { get; set; } = string.Empty;
        public string Language { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public List<string>? Claims { get; set; }

    }
}
