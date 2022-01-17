using System.Numerics;

namespace Model
{
    public  class Vehicle : IVehicle
    {
        public int ID { get; set; }
        public Vector2 Location { get; set; }
        public Vector2 Velocity { get; set; }
        public float MaxSpeed { get; set; }
    }
}