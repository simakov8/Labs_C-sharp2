﻿namespace _053506_SIM__Lab1
{
  interface ICustomCollection<T>
  {
    T this[int index] { get; set; }
    void Reset();
    void Next();
    T Current();
    int Count { get; }
    void Add(T item);
    void Remove(T item);
    T RemoveCurrent();
  }
}
