namespace BinaryTree;

public class ABB{
    /// <summary>The main value of the node </summary>
    public int Value{get; set;}
    public ABB(int value, ABB parent){
        Parent = parent;
        Value = value;
        Left = null;
        Right = null;
    }
    public override string ToString() => Value.ToString();
    /// <summary>If it is the root node then the parent is null.</summary>
    public ABB Parent {get; set;} 
    public ABB Left {get; set;}
    public ABB Right {get; set;}
    public void TreeLeft(int value){
        this.Left = new ABB(value, this);
    }
    public void TreeRight(int value){
        this.Right = new ABB(value, this);
    }
    
    /// <summary>Is true if the node is leaf</summary>
    public bool IsLeaf{
        get{
            if((Left==null)&&(Right==null)) return true;
            else return false;
        }
    }
    public override bool Equals(object obj) => this.ToString() ==obj.ToString();
    

}