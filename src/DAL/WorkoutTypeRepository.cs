using Models;
using Dapper;
using System.Collections.Generic;

namespace DAL
{
    public class WorkoutTypeRepository
    {
        public IEnumerable<WorkoutType> GetWorkoutTypes()
        {
            using(var con = WorkoutDatabase.GetConnection())
            {
                return con.Query<WorkoutType>("SELECT Id, Name FROM WorkoutTypes");
            }
        }
    }
}
