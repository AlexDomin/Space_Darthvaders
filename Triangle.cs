using System.Windows.Media;

namespace Space_Invaders
{
    internal class Triangle
    {
        public string Tag { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public SolidColorBrush Fill { get; set; }
        public SolidColorBrush Stroke { get; set; }
    }
}