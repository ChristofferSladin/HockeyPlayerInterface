namespace HockeyPlayerInterface
{
    interface IHockeyPlayerRepository
    {
        void AddPlayer(HockeyPlayer player);
        void UpdatePlayer(HockeyPlayer player);
        List<HockeyPlayer> ListAllPlayers();
    }

}