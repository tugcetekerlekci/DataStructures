public class MyHashSet {

    HashSet<int> MySet {get; set;}
    /** Initialize your data structure here. */
    public MyHashSet() {
        MySet = new HashSet<int>();
    }
    
    public void Add(int key) {
        MySet.Add(key);
    }
    
    public void Remove(int key) {
        MySet.Remove(key);
    }
    
    /** Returns true if this set contains the specified element */
    public bool Contains(int key) {
        
        return MySet.Contains(key) == true ?  true : false;
    }
}
