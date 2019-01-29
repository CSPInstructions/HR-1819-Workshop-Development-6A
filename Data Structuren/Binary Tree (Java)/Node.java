package nl.cspconnections;

class Node<T extends Comparable> {
    private T value;
    private Node<T> left;
    private Node<T> right;

    Node( T value ) {
        this.value = value;
    }

    boolean hasChildren() {
        return this.getLeft() != null || this.getRight() != null;
    }

    void setLeft( Node<T> left ) {
        this.left = left;
    }

    void setRight( Node<T> right ) {
        this.right = right;
    }

    T getValue() {
        return value;
    }

    Node<T> getLeft() {
        return left;
    }

    Node<T> getRight() {
        return right;
    }
}
