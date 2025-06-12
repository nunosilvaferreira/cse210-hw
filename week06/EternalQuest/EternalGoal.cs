namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        private int _timesCompleted;

        public EternalGoal(string name, string description, int points) 
            : base(name, description, points)
        {
            _timesCompleted = 0;
        }

        public override void RecordEvent()
        {
            _timesCompleted++;
        }

        public override bool IsComplete() => false; // Eternal goals are never complete

        public override string GetDetailsString()
        {
            return $"{_name} ({_description}) - Completed {_timesCompleted} times";
        }

        public override string GetStringRepresentation()
        {
            return $"EternalGoal:{_name},{_description},{_points},{_timesCompleted}";
        }

        public override int GetPoints() => _points * _timesCompleted;
    }
}