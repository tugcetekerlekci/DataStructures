public class MyHashMap {

    Dictionary<int,int> MyDictionary {get; set;}
    /** Initialize your data structure here. */
    public MyHashMap() {
        MyDictionary = new Dictionary<int,int>();
    }
    
    /** value will always be non-negative. */
    public void Put(int key, int value) {
        if (MyDictionary.ContainsKey(key))
        {

            MyDictionary[key] = value; 
        }
        else
        {
            MyDictionary.Add(key,value);
        }
    }
    
    /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
    public int Get(int key) {
        
        return MyDictionary.ContainsKey(key) == true ? MyDictionary[key] : -1;
    }
    
    /** Removes the mapping of the specified value key if this map contains a mapping for the key */
    public void Remove(int key) {
        if (MyDictionary.ContainsKey(key))
        {
            MyDictionary.Remove(key);
        }
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */
