package nl.cspconnections;

class BinaryTree<T extends Comparable> {
    private Node<T> TreeRoot;
    private int Count;

    BinaryTree() {
        this.TreeRoot = null;
    }

    int Count() {
        return this.Count;
    }

    void Add( T value ) {
        this.AddNode( new Node<T>( value ) );
    }

    private void AddNode( Node<T> node ) {
        if ( this.TreeRoot == null ) {
            this.TreeRoot = node;
        } else {
            Node<T> currentNode = this.TreeRoot;
            while ( currentNode != null ) {
                if ( currentNode.getValue().compareTo( node.getValue() ) > 0 ) {
                    if ( currentNode.getLeft() == null ) {
                        currentNode.setLeft( node );
                        break;
                    }

                    currentNode = currentNode.getLeft();
                } else {
                    if ( currentNode.getRight() == null ) {
                        currentNode.setRight( node );
                        break;
                    }

                    currentNode = currentNode.getRight();
                }
            }
        }
    }

    Node<T> Find( T value ) {
        Node<T> currentNode = this.TreeRoot;
        while ( currentNode != null ) {
            if ( currentNode.getValue().equals( value ) ) {
                return currentNode;
            }

            currentNode = currentNode.getValue().compareTo( value ) > 0
                ? currentNode.getLeft()
                : currentNode.getRight();
        }

        return null;
    }

    void Delete( T value ) {
        if ( this.TreeRoot != null ) {
            if ( this.TreeRoot.getValue().equals( value ) ) {
                Node<T> rightNode = this.TreeRoot.getRight();
                this.TreeRoot = this.TreeRoot.getLeft();

                if ( rightNode != null ) {
                    this.AddNode( rightNode );
                }
            }

            Node<T> currentNode = this.TreeRoot;
            while ( currentNode != null && currentNode.hasChildren() ) {
                if ( this.DeleteNode( currentNode, value ) ) {
                    break;
                } else {
                    currentNode = currentNode.getValue().compareTo( value ) > 0
                        ? currentNode.getLeft()
                        : currentNode.getRight();
                }
            }
        }
    }

    private boolean DeleteNode( Node<T> currentNode, T value ) {
        if ( currentNode.getLeft() != null ) {
            if ( currentNode.getLeft().getValue().equals( value ) ) {
                Node<T> rightNode = currentNode.getLeft().getRight();
                currentNode.setLeft( currentNode.getLeft().getLeft() );
                this.AddNode(rightNode);
                return true;
            }
        }

        if ( currentNode.getRight() != null ) {
            if (currentNode.getRight().getValue().equals(value)) {
                Node<T> rightNode = currentNode.getRight().getRight();
                currentNode.setRight(currentNode.getRight().getLeft());
                this.AddNode(rightNode);
                return true;
            }
        }

        return false;
    }
}
