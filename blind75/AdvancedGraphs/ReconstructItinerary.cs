namespace Blind75.Graphs;

/*

You are given a list of airline tickets where tickets[i] = [fromi, toi]
represent the departure and the arrival airports of one flight. Reconstruct the itinerary in order and return it.
All of the tickets belong to a man who departs from "JFK", thus, the itinerary must begin with "JFK".
If there are multiple valid itineraries,
you should return the itinerary that has the smallest lexical order when read as a single string.
For example, the itinerary ["JFK", "LGA"] has a smaller lexical order than ["JFK", "LGB"].
You may assume all tickets form at least one valid itinerary. You must use all the tickets once and only once.

Example 1:
Input: tickets = [["MUC","LHR"],["JFK","MUC"],["SFO","SJC"],["LHR","SFO"]]
Output: ["JFK","MUC","LHR","SFO","SJC"]

Example 2:
Input: tickets = [["JFK","SFO"],["JFK","ATL"],["SFO","ATL"],["ATL","JFK"],["ATL","SFO"]]
Output: ["JFK","ATL","JFK","SFO","ATL","SFO"]
Explanation: Another possible reconstruction is ["JFK","SFO","ATL","JFK","ATL","SFO"] but it is larger in lexical order.

Constraints:
1 <= tickets.length <= 300
tickets[i].length == 2
fromi.length == 3
toi.length == 3
fromi and toi consist of uppercase English letters.
fromi != toi

*/

public class ReconstructItinerary
{
    public static IList<string> FindItinerary(IList<IList<string>> tickets)
    {
        // Create a dictionary to store the adjacency list of the graph
        Dictionary<string, List<string>> flightMap = [];

        // Populate the adjacency list from the tickets
        foreach (IList<string> ticket in tickets)
        {
            if (!flightMap.TryAdd(ticket[0], [ticket[1]]))
                flightMap[ticket[0]].Add(ticket[1]);
        }

        // Sort each adjacency list in reverse lexicographical order
        foreach (List<string> destinationList in flightMap.Values)
        {
            destinationList.Sort((a, b) => string.Compare(b, a));
        }

        // Stack to store the result itinerary in reverse order
        Stack<string> itineraryStack = new();

        // Start DFS from the "JFK" airport
        DepthFirstSearch(flightMap, "JFK", itineraryStack);

        // Convert the stack to a list to get the itinerary in correct order
        return itineraryStack.ToList();
    }

    private static void DepthFirstSearch(
        Dictionary<string, List<string>> flightMap,
        string currentAirport,
        Stack<string> itineraryStack
    )
    {
        // If the current airport has destinations to visit
        if (flightMap.TryGetValue(currentAirport, out List<string>? destinations))
        {
            // Visit each destination using DFS
            while (destinations.Count > 0)
            {
                string nextDestination = destinations.Last();
                destinations.RemoveAt(destinations.Count - 1);
                DepthFirstSearch(flightMap, nextDestination, itineraryStack);
            }
        }

        // Add the current airport to the stack (itinerary)
        itineraryStack.Push(currentAirport);
    }
}
