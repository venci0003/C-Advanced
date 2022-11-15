namespace P01.Stream_Progress.Models
{
    public interface IFile
    {
        public int Length { get; }

        public int BytesSent { get; }
    }
}
