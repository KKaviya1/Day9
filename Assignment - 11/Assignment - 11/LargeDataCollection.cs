using System;
using System.Collections.Generic;

public class LargeDataCollection : IDisposable
{
    private List<int> data; 

    public LargeDataCollection(IEnumerable<int> initialData)
    {
        data = new List<int>(initialData); 
    }

    public void Add(int element)  
    {
        data.Add(element);
       
    }

    public void Remove(int element) 
    {
        data.Remove(element);
           
    }

    
    public int GetElement(int index) 
    {
        if (index >= 0 && index < data.Count)
        {
            return data[index];
        }
        throw new IndexOutOfRangeException("Index is out of range.");
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            
        }

        data = null; 
    }


    ~LargeDataCollection()
    {
        Dispose(false);
    }
}

