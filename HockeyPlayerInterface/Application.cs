namespace HockeyPlayerInterface
{
    public class Application
    {
        private IHockeyPlayerRepository _repository;
        
        

        public void Run()
        {
            _repository = new DataBaseHockeyPlayerRepository();
            FileHockeyPlayerRepository Repository = new FileHockeyPlayerRepository();

            var list = Repository.ListAllPlayers();

            foreach(var player in list)
            {
                Console.WriteLine(player);
            }

        }
    }

}