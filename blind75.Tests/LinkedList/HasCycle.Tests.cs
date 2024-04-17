namespace blind75.LinkedList;

public class HasCycle
{
  [Fact]
  public void HasCycleCorrect()
  {
    ListNode list1 = new(0);
    list1.next = new ListNode(1);
    list1.next.next = new ListNode(4);
    list1.next.next.next = new ListNode(10);
    list1.next.next.next.next = list1.next.next;

    Assert.True(HasCycleClass.HasCycle(list1));
  }
}
