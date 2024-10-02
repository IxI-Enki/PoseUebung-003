# PoseUebung-003 -- Generic Sorted List

> ![image](https://github.com/user-attachments/assets/1a426c4a-2b00-4047-b627-d808c8ed157a)

---  

> Element:
```c#
private class Element(E data , Element? next = null)
{
  #region PROPERTIES
  public E Data { get; set; } = data;
  public Element? Next { get; set; } = next;
  #endregion
}
```

---  

> Enumerator:
```c#
private class Enumerator(Element first) : IEnumerator<E>
{
  #region FIELDS
  private Element? _first = first;
  private Element? _run = null;
  #endregion

  #region PROPPERTIES
  public E Current => _run!.Data;
  object IEnumerator.Current => Current;
  #endregion

  #region METHODS
  public bool MoveNext()
  {
    _run = _run == null ? _first : _run.Next;
    return _run! != null;
  }
  public void Reset() => _run = null;
  public void Dispose() { }
  #endregion
}
```

---  

> Sorted List:
```c#
public class SortedList<E> : ISortedList<E> where E : IComparable<E>
{
  private Element? _first;

  public int Count
  {
    get
    {
      int count = 0;
      Element? run = _first;
      while (run != null)
      {
        count++;
        run = run.Next;
      }
      return count;
    }
  }

  public E this[ int index ]
  {
    get => GetElementByIndex(index).Data;
    set
    {
      Element elem = GetElementByIndex(index);
      Remove(elem.Data);
      Add(value);
    }
  }

  public IEnumerator<E> GetEnumerator() => new Enumerator(_first);
  IEnumerator IEnumerable.GetEnumerator() => new Enumerator(_first);

  private Element GetElementByIndex(int index)
  {
    CheckIndexOutOfRange(index);

    int counter = 0;
    Element? run = _first;

    while (counter < index)
    {
      counter++;
      run = run!.Next;
    }
    return run!;
  }

  private void CheckIndexOutOfRange(int index)
  {
    if (index < 0 || index >= Count)
      throw new ArgumentOutOfRangeException(nameof(index));
  }

```

> Methods:
```c#
  public void Add(E item)
  {
    CheckForNullItem(item);
    if (IsEmptyList() || item.CompareTo(_first!.Data) <= 0) _first = new Element(item , _first);
    else
    {
      Element? run = _first;
      while (HasNextElement(run) && item.CompareTo(run!.Next!.Data) > 0)
        SetToNext(ref run);
      run!.Next = new Element(item , run.Next);
    }
  }

  public void Remove(E item)
  {
    CheckForNullItem(item);
    if (IsEmptyList()) return;
    if (_first!.Data.CompareTo(item) == 0)
    {
      SetToNext(ref _first);
      return;
    }
    Element run = _first;
    while (HasNextElement(run))
    {
      if (run!.Next!.Data.CompareTo(item) == 0)
      {
        run.Next = run.Next.Next;
        return;
      }
      SetToNext(ref run!);
    }
  }
  public void Clear() => _first = null;

  private bool IsEmptyList() => _first == null;
  private static bool HasNextElement(Element? run) => run!.Next != null;
  private static void SetToNext(ref Element? run) => run = run!.Next!;
  private static void CheckForNullItem(E item)
  {
    if (item == null) throw new ArgumentNullException("Item cant be null");
  }
```

----  




![image](https://github.com/user-attachments/assets/93f88244-db81-48a0-a35e-28454ddf7845)
