namespace KassB.Core
{
    public class Ball
    {
        private readonly Velocity _velocity;

        public float Radius { get; }
        public float PositionX { get; }
        public float PositionY { get; }

        public Ball(
            float radius,
            float positionX,
            float positionY)
        {
            Radius = radius;
            PositionX = positionX;
            PositionY = positionY;
            _velocity = new Velocity(0, 0);
        }
    }
}
