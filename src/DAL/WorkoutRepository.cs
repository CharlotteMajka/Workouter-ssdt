using System;
using System.Collections.Generic;
using Dapper;
using Models;

namespace DAL
{
    public class WorkoutRepository
    {
        public void Insert(double distance, int typeId)
        {
            using(var con = WorkoutDatabase.GetConnection())
            {
                con.Execute("INSERT INTO Workouts (Distance, TypeId) VALUES (@Distance, @TypeId)", new { Distance = distance, TypeId = typeId });
            }
        }

        public IEnumerable<Workout> GetAllWorkouts()
        {
            using(var con = WorkoutDatabase.GetConnection())
            {
                return con.Query<Workout>("SELECT w.Id, w.Distance, wt.Name WorkoutType FROM Workouts w LEFT JOIN WorkoutTypes wt ON w.TypeId = wt.Id");
            }
        }
    }
}
