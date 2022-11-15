namespace HockeyPlayerInterface
{
    class DataBaseHockeyPlayerRepository : IHockeyPlayerRepository
    {
        private List<HockeyPlayer> _hockeyPlayers = new List<HockeyPlayer>();


        public void AddPlayer(HockeyPlayer player)
        {
            int last = 0;
            foreach (var hockeyPlayer in _hockeyPlayers)
                if ( hockeyPlayer.Id > last)
                    last = hockeyPlayer.Id;
            last = last + 1;
            _hockeyPlayers.Add(player);
                
        }

        public List<HockeyPlayer> ListAllPlayers()
        {
            return _hockeyPlayers;
        }

        public void UpdatePlayer(HockeyPlayer player)
        {
            foreach(var hockeyPlayer in _hockeyPlayers)
                if( hockeyPlayer.Id == player.Id)
                {
                    hockeyPlayer.Team = player.Team;
                    hockeyPlayer.Name = player.Name;
                    hockeyPlayer.JerseyNum = player.JerseyNum;
                }

        }
    }

}