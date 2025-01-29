using System.Xml.Serialization;
using Radiance;
using Radiance.Bufferings;
using Radiance.Primitives;
using static Radiance.Utils;

public class Character(vec4 ballColor, int tamanho, float x, float y)
{
    dynamic charRender = render((vec2 dx, val size) =>
    {
        zoom(size);
        move(dx);
        color = ballColor;
        fill();
    });
    Polygon polygon = Polygons.Circle;
    public void Draw()
    {
        charRender(polygon, X, Y, Size);
    }

    public float X { get; set; } = x;
    public float Y { get; set; } = y;

    public int Size { get; set; } = tamanho;

    State? state = null;
    public void SetState(State state)
    {
        this.state = state;
        this.state.SetContext(this);
    }

    public void Act() => state?.Act();
}