namespace HockeyPlayerInterface
{
    class FileHockeyPlayerRepository : IHockeyPlayerRepository
    {
        

        public void AddPlayer(HockeyPlayer player)
        {
            var all = ListAllPlayers();
            int last = 0;
            foreach (var item in all)
            {
                if (item.JerseyNum > last)
                    last = item.JerseyNum;
                last = last + 1;
                player.JerseyNum = last;
                all.Add(player);
                Save(all);
            }
        }

        private void Save(List<HockeyPlayer> all)
        {
            var strings = new List<string>();
            foreach (var item in all)
            {
                strings.Add($"{item.Id},{item.JerseyNum},{item.Name},{item.Name}");
            }
            File.WriteAllLines("Players.txt", strings);
        }

        public List<HockeyPlayer> ListAllPlayers()
        {
            var list = new List<HockeyPlayer>();

            if (!File.Exists("Players.txt")) return list;
            foreach(var line in File.ReadLines("Player.txt"))
            {
                var parts = line.Split(',');
                var player = new HockeyPlayer();
                player.Id = int.Parse(parts[0]);
                player.JerseyNum = int.Parse(parts[1]);
                player.Name = parts[2];
                player.Team = parts[3];

                list.Add(player);
            }

            return list;
        }

        public void UpdatePlayer(HockeyPlayer player)
        {
            var all = ListAllPlayers();

            foreach (var item in all)
            {
                if(item.Id == player.Id)
                {
                    item.Name = player.Name;
                    item.Team = player.Team;
                    item.JerseyNum = player.JerseyNum;
                }

                Save(all);

            }
        }
    }

}