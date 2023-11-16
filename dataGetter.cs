namespace kosend 
{
    public class NeedData 
    {
        public string Content { get; set; }
        public long Size { get; set; }
        public DateTime CreationTime { get; set; }

        // issue with this that I don't understand currently...
        public NeedData(string Content, long Size, DateTime CreationTime)
        {
            Content = Content;
            Size = Size;
            CreationTime = CreationTime;
        }
    }

    public static class GetData
    {
        public static NeedData Read(string filePath)
        {
            string content = File.ReadAllText(filePath);
            FileInfo metadata = new FileInfo(filePath);

            return new NeedData (
                content,
                metadata.Length,
                metadata.CreationTime
            );
        }
    }
}
