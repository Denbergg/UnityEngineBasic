using System.Collections.Generic;
using System.Linq;

public interface IState
{
    
}

public class Test
{
    List<int> list = new List<int>();

    void TT()
    {
        list = Enumerable.Repeat(UnityEngine.Random.Range(0, 100), 100).ToList();
        list.FindAll(x => x < 50);
    }
}