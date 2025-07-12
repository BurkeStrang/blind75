namespace Blind75.Tests.LinkedList;

public class MergeTwoList
{
    [Fact]
    public void MergeTwoListCorrect()
    {
        ListNode list1 = new(0)
        {
            next = new(1)
            {
                next = new(4)
                {
                    next = new(10)
                }

            }
        };

        ListNode list2 = new(2)
        {
            next = new(3)
            {
                next = new(11)
            }
        };

        ListNode expectedList = new(0)
        {
            next = new(1)
            {
                next = new(2)
                {
                    next = new(3)
                    {
                        next = new(4)
                        {
                            next = new(10)
                            {
                                next = new(11)
                            }
                        }
                    }
                }
            }
        };

        ListNode? res = MergeTwoListClass.MergeTwoLists(list1, list2);

        res.ShouldBeEquivalentTo(expectedList);

        // Assert.Equivalent(expectedList, MergeTwoListClass.MergeTwoLists(list1, list2));
    }
}
