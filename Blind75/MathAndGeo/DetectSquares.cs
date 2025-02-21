using static System.Math;
namespace Blind75.MathAndGeo;

/*

You are given a stream of points on the X-Y plane. Design an algorithm that:

Adds new points from the stream into a data structure.
Duplicate points are allowed and should be treated as different points.
Given a query point,
counts the number of ways to choose three points from the data structure such that
the three points and the query point form an axis-aligned square with positive area.
An axis-aligned square is a square whose edges are all the same length
and are either parallel or perpendicular to the x-axis and y-axis.

Implement the DetectSquares class:

DetectSquares() Initializes the object with an empty data structure.
void add(int[] point) Adds a new point point = [x, y] to the data structure.
int count(int[] point) Counts the number of ways to form axis-aligned squares with point point = [x, y] as described above.
 

Example 1:
Input
["DetectSquares", "add", "add", "add", "count", "count", "add", "count"]
[[], [[3, 10]], [[11, 2]], [[3, 2]], [[11, 10]], [[14, 8]], [[11, 2]], [[11, 10]]]
Output
[null, null, null, null, 1, 0, null, 2]

Explanation
DetectSquares detectSquares = new DetectSquares();
detectSquares.add([3, 10]);
detectSquares.add([11, 2]);
detectSquares.add([3, 2]);
detectSquares.count([11, 10]); // return 1. You can choose:
                               //   - The first, second, and third points
detectSquares.count([14, 8]);  // return 0. The query point cannot form a square with any points in the data structure.
detectSquares.add([11, 2]);    // Adding duplicate points is allowed.
detectSquares.count([11, 10]); // return 2. You can choose:
                               //   - The first, second, and third points
                               //   - The first, third, and fourth points

Constraints:
point.length == 2
0 <= x, y <= 1000
At most 3000 calls in total will be made to add and count.

 * Your DetectSquares object will be instantiated and called as such:
 * DetectSquares obj = new DetectSquares();
 * obj.Add(point);
 * int param_2 = obj.Count(point);
 
*/

public class DetectSquares
{
    private readonly Dictionary<(int x, int y), int> _pointsCounter = [];
    private readonly List<(int x, int y)> _points = [];

    public void Add(int[] point)
    {
        (int, int) p = (point[0], point[1]);
        _points.Add(p);
        _pointsCounter[p] = 1 + _pointsCounter.GetValueOrDefault(p, 0);
    }

    public int Count(int[] point)
    {
        int px = point[0],
            py = point[1];
        int result = 0;

        foreach ((int x, int y) in _points)
        {
            // Check if (x, y) can form a diagonal of a square with (px, py)
            if (Abs(px - x) != Abs(py - y) || x == px || y == py)
                continue;
            // Calculate the number of squares that can be formed
            result +=
                _pointsCounter.GetValueOrDefault((px, y), 0)
                * _pointsCounter.GetValueOrDefault((x, py), 0);
        }
        return result;
    }
}
