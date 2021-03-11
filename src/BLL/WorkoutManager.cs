using Models;
using DAL;
using System.Collections.Generic;

namespace BLL
{
    public class WorkoutManager
    {
        private readonly WorkoutRepository workoutRepository = new WorkoutRepository();
        private readonly WorkoutTypeRepository workoutTypeRepository = new WorkoutTypeRepository();

        public IEnumerable<WorkoutType> GetAllTypes()
        {
            return workoutTypeRepository.GetWorkoutTypes();
        }

        public void Save(double distance, int typeId)
        {
            workoutRepository.Insert(distance, typeId);
        }

        public IEnumerable<Workout> GetAllWorkouts()
        {
            return workoutRepository.GetAllWorkouts();
        }
    }
}
