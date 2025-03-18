namespace Backend

{
    public sealed class Activity
    {
        public string Name { get; private set; } = string.Empty;
        public string Description { get; private set; } = string.Empty;
        public int Priority { get; private set; } = 0;
        public bool Done { get; private set; } = false;

        public Activity(string name, string description, int priority, bool done = false)
        {
            Name = name;
            Description = description;
            Priority = priority;
            Done = done;
        }
        internal Activity(string name, bool status)
        {
            Name = name;
            Done = status;
        }

        public Activity SetName(string name)
        {
            Name = name;
            return this;
        }

        public Activity SetDescription(string description)
        {
            Description = description;
            return this;
        }

        public Activity SetPriority(int priority)
        {
            if (priority < 0 || priority > 10)
                throw new ArgumentOutOfRangeException(nameof(priority), "Priority must be between 0 and 10.");

            Priority = priority;
            return this;
        }

        public Activity MarkAsDone(bool status)
        {
            Done = status;
            return this;
        }

    }
}