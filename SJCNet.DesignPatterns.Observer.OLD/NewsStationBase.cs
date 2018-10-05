using System;
using System.Timers;

namespace SJCNet.DesignPatterns.Observer.Old
{
    public abstract class NewsStationBase : INewsStationBase
    {

        private const int _articlesToGenerateInTest = 5;
        private int _currentArticleCount = 0;
        private const int _minValue = 1;
        private const int _maxValue = 5;
        private Timer _timer;
        private Article _currentArticle;

        public NewsStationBase()
        {}

        #region Private Implementation Details

        private void Initialise()
        {
            this.IsActive = true;

            // Generate an article at random intervals
            _timer = new Timer();
            _timer.Elapsed += TimerElapsed;
            _timer.Interval = GenerateInterval();
            _timer.Start();
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            GenerateArticles();
            _timer.Interval = GenerateInterval();
        }

        private double GenerateInterval()
        {
            var random = new Random();
            return TimeSpan.FromSeconds(random.Next(_minValue, _maxValue)).TotalMilliseconds;
        }
        
        private void GenerateArticles()
        {
            // Check if we should stop the timers
            _currentArticleCount++;
            if(_currentArticleCount >= _articlesToGenerateInTest)
            {
                _timer.Stop();
                _timer.Dispose();
                this.IsActive = false;
            }

            // Get which type of article to generate
            var random = new Random();
            var articleType = (ArticleTypes)random.Next(1, 3);

            // Create the article
            _currentArticle = new Article
            {
                Type = articleType,
                Headline = Faker.Lorem.Sentence()
            };

            // Raise event
            NewHeadlineAvailable();
        }
        
        private string GetHeadline(ArticleTypes type)
        {
            if (_currentArticle == null || _currentArticle.Type != type)
            {
                return string.Empty;
            }

            return _currentArticle.Headline;
        }

        private class Article
        {
            public ArticleTypes Type { get; set; }

            public string Headline { get; set; }
        }

        private enum ArticleTypes
        {
            Sport = 1,
            CurrentAffairs = 2,
            Finance = 3
        }

        #endregion

        public void BeginBroadcasting()
        {
            Initialise();
        }

        public bool IsActive { get; set; }

        public abstract void NewHeadlineAvailable();

        public string GetSportsHeadline()
        {
            return GetHeadline(ArticleTypes.Sport);
        }

        public string GetCurrentAffairsHeadline()
        {
            return GetHeadline(ArticleTypes.CurrentAffairs);
        }

        public string GetFinanceHeadline()
        {
            return GetHeadline(ArticleTypes.Finance);
        }
    }
}