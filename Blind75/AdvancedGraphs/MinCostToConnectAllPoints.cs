namespace Blind75.Graphs;

/*

You are given an array points representing integer coordinates of some points on a 2D-plane, where points[i] = [xi, yi].
The cost of connecting two points [xi, yi] and [xj, yj] is the manhattan distance between them:
|xi - xj| + |yi - yj|, where |val| denotes the absolute value of val.
Return the minimum cost to make all points connected.
All points are connected if there is exactly one simple path between any two points.

Example 1:
Input: points = [[0,0],[2,2],[3,10],[5,2],[7,0]]
Output: 20
Explanation:
We can connect the points as shown above to get the minimum cost of 20.
Notice that there is a unique path between every pair of points.

Example 2:
Input: points = [[3,12],[-2,5],[-4,1]]
Output: 18

Constraints:
1 <= points.length <= 1000
-106 <= xi, yi <= 106
All pairs (xi, yi) are distinct.

*/

public class MinCostToConnectAllPoints
{
    //T: O(N^2 LogN)
    public static int MinCostConnectPoints(int[][] points)
    {
        //creating the ajacency list.
        int n = points.Length;
        Dictionary<int, List<Tuple<int, int>>> dictionary = []; //Cost and Node

        if (n == 1)
            return 0;

        for (int i = 0; i < n; i++)
        {
            dictionary.Add(i, []);
        }

        for (int i = 0; i < n; i++)
        {
            int x1 = points[i][0];
            int y1 = points[i][1];

            for (int j = i + 1; j < n; j++)
            {
                int x2 = points[j][0];
                int y2 = points[j][1];

                int dist = Math.Abs(x2 - x1) + Math.Abs(y1 - y2);

                dictionary[j].Add(new Tuple<int, int>(dist, i));
                dictionary[i].Add(new Tuple<int, int>(dist, j));
            }
        }

        int res = 0;
        //Prim's
        HashSet<int> visited = [];
        PriorityQueue<(int, int), int> minHeap = new(); // Cost and Node
        minHeap.Enqueue((0, 0), 0);

        while (minHeap.Count > 0)
        {
            (int cost, int point) = minHeap.Dequeue();
            if (visited.Contains(point))
                continue;
            res += cost;
            visited.Add(point);
            List<Tuple<int, int>> adj = dictionary[point];

            for (int i = 0; i < adj.Count; i++)
            {
                if (!visited.Contains(adj[i].Item2))
                    minHeap.Enqueue((adj[i].Item1, adj[i].Item2), adj[i].Item1);
            }
        }

        return res;
    }
}
