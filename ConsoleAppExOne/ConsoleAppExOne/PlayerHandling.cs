using NUnit.Framework;


namespace ConsoleAppExOne
{[TestFixture]
    public class PlayerHandling
    {
        [Test] 
        public void TestOne()
        {
            
            foreach (var p in Program.PlayerList())
            {
                Assert.IsNotNull(p.PlayerId);
                Assert.IsNotNull(p.PlayerName);
                Assert.IsNotNull(p.PlayerTeam);
            }
        }
    }
   
}
