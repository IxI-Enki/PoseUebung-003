namespace GenericSortedList.Logic;

#region Element with primary Constructor
// SHORT

public class Element<E>(E data , Element<E>? next = null)
{
  public E Data { get; set; } = data;
  public Element<E>? Next { get; set; } = next;
}
#endregion

/// -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

#region Element with normal Constructor
// LONG

public class Element2<Ele>
{
  public Element2(Element2<Ele> data , Element2<Ele>? next = null)
  {
    Data = data;
    Next = next;
  }
  public Element2<Ele> Data { get; set; }
  public Element2<Ele>? Next { get; set; }
}
#endregion
