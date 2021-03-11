using System;
using System.Collections.Generic;
using Models;

namespace UI.Models
{
    public class IndexViewModel
    {
        public IEnumerable<WorkoutType> WorkoutTypes { get; internal set; }
        public IEnumerable<Workout> Workouts { get; internal set; }
    }
}
