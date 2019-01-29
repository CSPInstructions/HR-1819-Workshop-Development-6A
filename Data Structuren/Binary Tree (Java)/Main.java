package nl.cspconnections;

public class Main {
    public static void main(String[] args) {
        BinaryTree<Integer> numberTree = new BinaryTree<>();
        numberTree.Add(6 );
        numberTree.Add(3 );
        numberTree.Add(9 );

        Node<Integer> findThree = numberTree.Find( 3 );
        System.out.println( findThree.getValue() );

        numberTree.Delete( 3 );
        numberTree.Delete( 6 );
    }
}
