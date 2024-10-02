using System.Collections;

namespace GenericSortedList.Logic;

public class SortedList<T> : ISortedList<T> where T : IComparable<T>
{
  public T this[ int index ]
  { 
    get => throw new NotImplementedException(); 
    set => throw new NotImplementedException(); 
  }

  public int Count => throw new NotImplementedException();

  public void Add(T item)
  {
    throw new NotImplementedException();
  }

  public void Clear()
  {
    throw new NotImplementedException();
  }

  public IEnumerator<T> GetEnumerator()
  {
    throw new NotImplementedException();
  }

  public void Remove(T item)
  {
    throw new NotImplementedException();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    throw new NotImplementedException();
  }
}
