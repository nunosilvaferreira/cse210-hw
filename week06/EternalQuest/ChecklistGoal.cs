namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int _amountCompleted;
        private int _target;
        private int _bonus;

        public ChecklistGoal(string name, string description, int points, int target, int bonus) 
            : base(name, description, points)
        {
            _amountCompleted = 0;
            _target = target;
            _bonus = bonus;
        }

        public override void RecordEvent()
        {
            _amountCompleted++;
            if (_amountCompleted >= _target)
            {
                _isComplete = true;
            }
        }

        public override bool IsComplete() => _isComplete;

        public override string GetDetailsString()
        {
            return $"{_name} ({_description}) -- Currently completed: {_amountCompleted}/{_target} [{(IsComplete() ? "X" : " ")}]";
        }

        public override string GetStringRepresentation()
        {
            return $"ChecklistGoal:{_name},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
        }

        public override int GetPoints()
        {
            if (IsComplete())
            {
                return (_points * _target) + _bonus;
            }
            return _points * _amountCompleted;
        }
    }
}