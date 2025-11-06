using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoxLogProConsole;

namespace BoxLogProConsole
{
    public static class ExerciseRepository
    {
        public static List<Exercise> GetAvailableExercises()
        {
            return new List<Exercise>
        {
            new Exercise { Id = 1, Name = "Shadow Boxing" },
            new Exercise { Id = 2, Name = "Heavy Bag" },
            new Exercise { Id = 3, Name = "Footwork Drills" },
            new Exercise { Id = 4, Name = "Sparring" },
            new Exercise { Id = 5, Name = "Speed Ladder" }
        };
        }
    }
}
