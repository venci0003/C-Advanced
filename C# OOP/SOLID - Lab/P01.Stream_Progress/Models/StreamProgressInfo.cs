namespace P01.Stream_Progress.Models
{
    public class StreamProgressInfo
    {
        private IFile file;

        // If we want to stream a music file, we can't
        public StreamProgressInfo(IFile file)
        {
            this.file = file;
        }

        public int CalculateCurrentPercent()
        {
            return file.BytesSent * 100 / file.Length;
        }
    }
}
