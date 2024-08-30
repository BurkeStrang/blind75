namespace Blind75.Graphs;

// There are a total of numCourses courses you have to take, labeled from 0 to numCourses - 1.
// You are given an array prerequisites where prerequisites[i] = [ai, bi]
// indicates that you must take course bi first if you want to take course ai.

// For example, the pair [0, 1], indicates that to take course 0 you have to first take course 1.
// Return true if you can finish all courses. Otherwise, return false.

// Example 1:

// Input: numCourses = 2, prerequisites = [[1,0]]
// Output: true
// Explanation: There are a total of 2 courses to take.
// To take course 1 you should have finished course 0. So it is possible.

// Example 2:
// Input: numCourses = 2, prerequisites = [[1,0],[0,1]]
// Output: false
// Explanation: There are a total of 2 courses to take.
// To take course 1 you should have finished course 0, and to take course 0 you should also have finished course 1.
// So it is impossible.

public static class CourseScheduleClass
{
    public static bool CanFinish(int numCourses, int[][] prerequisites)
    {
        Dictionary<int, List<int>> preMap = [];
        HashSet<int> visited = [];
        for (int i = 0; i < numCourses; i++)
            preMap.Add(i, []);

        foreach (int[] course in prerequisites)
        {
            int courseToTake = course[0];
            int courseDependOn = course[1];
            preMap[courseToTake].Add(courseDependOn);
        }

        foreach (int course in Enumerable.Range(0, numCourses))
        {
            if (!DfsGraph(preMap, visited, course))
                return false;
        }
        return true;
    }

    public static bool DfsGraph(IDictionary<int, List<int>> preMap, HashSet<int> visited, int course)
    {
        if (visited.Contains(course))
            return false;

        if (preMap[course].Count == 0)
            return true;

        visited.Add(course);

        foreach (int pre in preMap[course])
        {
            if (!DfsGraph(preMap, visited, pre))
                return false;
        }
        // visited.Remove(course);
        // preMap[course] = [];
        return true;
    }
}
