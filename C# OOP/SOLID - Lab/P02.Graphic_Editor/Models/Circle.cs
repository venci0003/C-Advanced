using P02.Graphic_Editor.Models.Contracts;

namespace P02.Graphic_Editor.Models
{
    public class Circle : IShape
    {
        public string Draw()
        {
            return "I'm Circle";
        }
    }
}
