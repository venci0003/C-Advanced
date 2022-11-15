namespace P02.Graphic_Editor
{
    using Models;
    using P02.Graphic_Editor.Models.Contracts;

    class Program
    {
        static void Main()
        {
            IShape rectangle = new Rectangle();

            IShape circle = new Circle();

            GraphicEditor editor = new GraphicEditor();

            editor.DrawShape(rectangle);

            editor.DrawShape(circle);
        }
    }
}
