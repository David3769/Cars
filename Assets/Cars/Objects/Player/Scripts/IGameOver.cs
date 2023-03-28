namespace Cars.Game.Player
{
    interface IGameOver
    {
        void SetGameOver();
        void SetRestartGame();
        States State { get; set; }
    }
}
