namespace Cars.Game.Lollipop
{
    interface ILollipopData
    {
        void SaveLollipop();
        void LoadLollipop();

        int Collected { get; set; }
    }
}
