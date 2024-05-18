namespace Blind75.Graphs;

/*

There are a total of numCourses courses you have to take, labeled from 0 to numCourses - 1.
You are given an array prerequisites where prerequisites[i] = [ai, bi]
indicates that you must take course bi first if you want to take course ai.

For example, the pair [0, 1], indicates that to take course 0 you have to first take course 1.
Return the ordering of courses you should take to finish all courses. If there are many valid answers,
return any of them. If it is impossible to finish all courses, return an empty array.

Example 1:
Input: numCourses = 2, prerequisites = [[1,0]]
Output: [0,1]
Explanation: There are a total of 2 courses to take.
To take course 1 you should have finished course 0. So the correct course order is [0,1].

Example 2:
Input: numCourses = 4, prerequisites = [[1,0],[2,0],[3,1],[3,2]]
Output: [0,2,1,3]
Explanation: There are a total of 4 courses to take.
To take course 3 you should have finished both courses 1 and 2.
Both courses 1 and 2 should be taken after you finished course 0.
So one correct course order is [0,1,2,3]. Another correct ordering is [0,2,1,3].

Example 3:
Input: numCourses = 1, prerequisites = []
Output: [0]

Constraints:
1 <= numCourses <= 2000
0 <= prerequisites.length <= numCourses * (numCourses - 1)
prerequisites[i].length == 2
0 <= ai, bi < numCourses
ai != bi
All the pairs [ai, bi] are distinct.

*/

public static class CourseScheduleII
{
    private static List<int>? s_output = null;

    public static int[] FindOrder(int numCourses, int[][] prerequisites)
    {
        Dictionary<int, List<int>> preMap = [];
        HashSet<int> visited = [];
        HashSet<int> cycle = [];
        s_output = [];

        // Initialize the dictionary with an empty list for each course
        for (int i = 0; i < numCourses; i++)
        {
            preMap[i] = [];
        }

        // Fill the dictionary with the prerequisites
        foreach (int[] course in prerequisites)
        {
            int courseToTake = course[0];
            int courseDependOn = course[1];
            preMap[courseToTake].Add(courseDependOn);
        }

        // Perform DFS for each course
        for (int c = 0; c < numCourses; c++)
        {
            if (!DfsGraphTopologicalSort(preMap, visited, cycle, c))
            {
                return [];
            }
        }

        return [.. s_output];
    }

    private static bool DfsGraphTopologicalSort(
        Dictionary<int, List<int>> preMap,
        HashSet<int> visited,
        HashSet<int> cycle,
        int course)
    {
        if (cycle.Contains(course))
            return false;
        if (visited.Contains(course))
            return true;

        cycle.Add(course);
        foreach (int prereq in preMap[course])
        {
            if (!DfsGraphTopologicalSort(preMap, visited, cycle, prereq))
            {
                return false;
            }
        }

        cycle.Remove(course);
        visited.Add(course);
        s_output?.Add(course);
        return true;
    }
}
