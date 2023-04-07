namespace BinaryTree;
/// <summary>   La interfaz común para todas las estructuras de datos
///   que sean Árbol Binario de Búsqueda.
///</summary>
public interface IABBNode<TKey> where TKey : IComparable<TKey>
{

    /// <summary> El valor del nodo. </summary>
    TKey Key { get; set; }
    /// <summary>Verdadero si el nodo es hoja.</summary>
    bool IsLeaf { get; }
    /// <summary>Verdadero si el nodo solo tiene hijo izquierdo.</summary>
    bool OnlyLeftSon { get; }
    /// <summary>Verdadero si el nodo solo tiene hijo derecho.</summary>
    bool OnlyRightSon { get; }
    /// <summary>El valor llevado a string.</summary>
    string ToString();
    /// <summary>Añadir un hijo izquierdo.</summary>
    void TreeLeft(TKey key);
    /// <summary>Añadir un hijo derecho.</summary>
    void TreeRight(TKey key);
}
