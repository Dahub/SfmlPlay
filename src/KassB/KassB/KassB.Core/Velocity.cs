namespace KassB.Core
{
    internal class Velocity
    {
        public Velocity(float velocityX, float velocityY)
        {
            VelocityX = velocityX;
            VelocityY = velocityY;
        }

        public float VelocityX { get; private set; }
        public float VelocityY { get; private set; }
    }
}
