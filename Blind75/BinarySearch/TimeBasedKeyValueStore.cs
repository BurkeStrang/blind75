namespace Blind75.BinarySearch;

/*

Design a time-based key-value data structure that
can store multiple values for the same key at different time stamps and retrieve the key's value at a certain timestamp.

Implement the TimeMap class:

TimeMap() Initializes the object of the data structure.
void set(String key, String value, int timestamp) Stores the key key with the value value at the given time timestamp.
String get(String key, int timestamp) Returns a value such that set was called previously, with timestamp_prev <= timestamp.
If there are multiple such values,
it returns the value associated with the largest timestamp_prev. If there are no values, it returns "".
 

Example 1:
Input
["TimeMap", "set", "get", "get", "set", "get", "get"]
[[], ["foo", "bar", 1], ["foo", 1], ["foo", 3], ["foo", "bar2", 4], ["foo", 4], ["foo", 5]]
Output
[null, null, "bar", "bar", null, "bar2", "bar2"]

Explanation
TimeMap timeMap = new TimeMap();
timeMap.Set("foo", "bar", 1);  // store the key "foo" and value "bar" along with timestamp = 1.
timeMap.Get("foo", 1);         // return "bar"
timeMap.Get("foo", 3);         // return "bar",
    since there is no value corresponding to foo at timestamp 3 and timestamp 2, then the only value is at timestamp 1 is "bar".
timeMap.Set("foo", "bar2", 4); // store the key "foo" and value "bar2" along with timestamp = 4.
timeMap.Get("foo", 4);         // return "bar2"
timeMap.Get("foo", 5);         // return "bar2"

*/

public class TimeMap
{
    private readonly Dictionary<string, List<(int timestamp, string value1)>> _dict;

    public TimeMap()
    {
        _dict = new Dictionary<string, List<(int, string)>>();
    }

    public void Set(string key, string value, int timestamp)
    {
        List<(int, string)> value1 = [];
        _dict.TryAdd(key, value1);
        _dict[key].Add((timestamp, value));
    }

    public string Get(string key, int timestamp)
    {
        if (!_dict.TryGetValue(key, out List<(int timestamp, string value1)>? value))
        {
            return "";
        }

        int left = 0;
        int right = value.Count;
        string result = "";

        while (left < right)
        {
            int mid = (left + right) / 2;
            if (value[mid].timestamp == timestamp)
            {
                result = value[mid].value1;
                return result;
            }
            else if (value[mid].timestamp < timestamp)
            {
                left = mid + 1;
                result = value[mid].value1;
            }
            else
            {
                right = mid;
            }
        }

        return result;
    }
}
