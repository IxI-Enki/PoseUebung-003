using System.Collections;

namespace GenericSortedList.Logic;

public class SortedList<Ele> : ISortedList<Ele> where Ele : IComparable<Ele>
{
  #region FIELDS
  private Element<Ele> _first;
  #endregion

  public Ele this[ int index ]
  {
    get => throw new NotImplementedException();
    set => throw new NotImplementedException();
  }

  public int Count => throw new NotImplementedException();

  public void Add(Ele item)
  {
    throw new NotImplementedException();
  }

  public void Clear()
  {
    throw new NotImplementedException();
  }

  public IEnumerator<Ele> GetEnumerator()
  {
    throw new NotImplementedException();
  }

  public void Remove(Ele item)
  {
    throw new NotImplementedException();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    throw new NotImplementedException();
  }
}
