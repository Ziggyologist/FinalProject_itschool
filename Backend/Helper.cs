using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public static class Helper
    {
        private static List<Activity> _activities = [];
        public static List<Activity> ActivityList => _activities;

        public static Activity AddNewActivity(string name, string description = "", int priority = 0, bool done = false)
        {
            Activity activity = CreateActivity(name, description, priority, done);
            //_activities.Add(activity);
            return activity;
        }

        public static Activity CreateActivity(string name, string description, int priority, bool done = false)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (string.IsNullOrEmpty(description))
            {
                throw new ArgumentNullException(nameof(description));
            }
            if (priority < 0 || priority > 10)
            {
                throw new ArgumentNullException(nameof(priority));
            }

            Activity activity = new Activity(name, description, priority);
            _activities.Add(activity);

            Sort();

            return activity;
        }

        public static void Sort()
        {
            _activities = [.. _activities.OrderBy(x => x.Priority)];
        }

        public static Activity SetDone(this Activity activity, bool done)
        {
            return activity.MarkAsDone(done);
        }
    }
}
