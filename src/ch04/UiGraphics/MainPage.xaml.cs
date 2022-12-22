namespace UiGraphics;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
}

public class GraphicsDrawable : IDrawable
{
    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        canvas.FillColor = Colors.DarkBlue;
        canvas.FillCircle(100, 100, 80);
        canvas.StrokeColor = Colors.LightPink;
        canvas.StrokeSize = 1;
        double rad = 0;
        float x1 = 200;
        float y1 = 100;
        for ( int i=0; i<100; i++ )
        {
            float x2 = (float)(Math.Cos(rad) * 100) + 100;
            float y2 = (float)(Math.Sin(rad) * 100) + 100;
            canvas.DrawLine(x1, y1, x2, y2);
            x1 = x2;
            y1 = y2;
            rad += Math.PI * (170.0 / 180.0);
         }
    }
}

