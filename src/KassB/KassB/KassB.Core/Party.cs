namespace KassB.Core
{
    public class Party
    {
        private const float _playGroundWidth = 1024f;
        private const float _playGroundHeight = 768f;

        private const float _ballRadius = 25f;
        private const float _ballInitialPositionX = 512f;
        private const float _ballInitialPositionY = 650f;

        public PlayGround PlayGround { get; }

        public Ball Ball { get; }

        public Party()
        {
            PlayGround = new PlayGround(_playGroundWidth, _playGroundHeight);
            Ball = new Ball(
                _ballRadius,
                _ballInitialPositionX,
                _ballInitialPositionY);
        }
    }
}
