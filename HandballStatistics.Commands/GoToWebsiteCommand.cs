using HandballStatistics.Interfaces.Navigators;
using HandballStatistics.Websites;

namespace HandballStatistics.Commands
{
    public class GoToWebsiteCommand : CommandBase
    {
        public override void Execute(object parameter)
        {
            if (parameter is Link link)
            {
                switch (link)
                {
                    case Link.Facebook:
                        System.Diagnostics.Process.Start(new Facebook().URL);
                        break;
                    case Link.Instagram:
                        System.Diagnostics.Process.Start(new Instagram().URL);
                        break;
                    case Link.Twitter:
                        System.Diagnostics.Process.Start(new Twitter().URL);
                        break;
                }
            }
        }
    }
}
