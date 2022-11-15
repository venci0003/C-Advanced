namespace P02.Graphic_Editor.Models
{
    using System;
    using P02.Graphic_Editor.Models.Contracts;

    public class GraphicEditor
    {
        public void DrawShape(IShape shape)
        {
            Console.WriteLine(shape.Draw());
        }
    }
}
