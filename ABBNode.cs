namespace BinaryTree;

public class ABBNode<TKey> : IABBNode<TKey> where TKey : IComparable<TKey>
{
    public TKey Key { get; set; }
    public ABBNode(TKey key)
    {
        Key = key;
        LChild = null;
        RChild = null;
    }
    public ABBNode(TKey key, ABBNode<TKey> lChild, ABBNode<TKey> rChild)
    {
        RChild = rChild;
        LChild = lChild;
        Key = key;
    }
    public override string ToString() => Key.ToString();
    public ABBNode<TKey> LChild { get; set; }
    public ABBNode<TKey> RChild { get; set; }
    public void TreeLeft(TKey key)
    {
        this.LChild = new ABBNode<TKey>(key);
    }
    public void TreeRight(TKey key)
    {
        this.RChild = new ABBNode<TKey>(key);
    }

    public bool IsLeaf
    {
        get
        {
            if ((LChild == null) && (RChild == null)) return true;
            else return false;
        }
    }
    public bool OnlyLeftSon
    {
        get
        {
            if ((LChild is not null) && (RChild is null)) return true;
            else return false;
        }
    }
    public bool OnlyRightSon
    {
        get
        {
            if ((RChild is not null) && (LChild is null)) return true;
            else return false;
        }
    }
}