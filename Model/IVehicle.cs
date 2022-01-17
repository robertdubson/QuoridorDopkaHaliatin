using System.Numerics;

namespace Model
{
    public interface IVehicle
    {
        int ID { get; set; }
        Vector2 Location { get; set; }
        Vector2 Velocity { get; set; }
        float MaxSpeed { get; set; }
    }
    
}