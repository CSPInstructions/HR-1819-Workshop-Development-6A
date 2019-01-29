import Foundation

class Node<T: Comparable> {
    var value: T
    var next: Node<T>?
    var previous: Node<T>?
    
    init( value: T ) {
        self.value = value
        self.next = nil
        self.previous = nil
    }
    
    func RemoveNode() {
        if self.next != nil {
            self.next?.previous = self.previous
            
            if self.previous != nil {
                self.previous?.next = self.next
            }
        }
        
        if self.previous != nil {
            self.previous?.next = nil
        }
    }
}

struct LinkedList<T: Comparable> {
    var startingNode: Node<T>?
    init() {
        self.startingNode = nil
    }
    
    mutating func AddRange( values: [T] ) {
        for value in values {
            self.Add( value: value )
        }
    }
    
    mutating func Add( value: T ) {
        let node = Node( value: value )
        
        if self.startingNode == nil {
            self.startingNode = node
        } else {
            var currentNode = self.startingNode
            while currentNode!.next != nil {
                currentNode = currentNode?.next
            }
            
            node.previous = currentNode
            currentNode?.next = node
        }
    }
    
    mutating func Remove( value: T ) {
        if self.startingNode != nil {
            if self.startingNode!.value == value {
                self.startingNode = self.startingNode?.next;
            }
            
            var currentNode = self.startingNode
            while currentNode != nil {
                if currentNode!.value == value {
                    currentNode?.RemoveNode()
                    break
                }
                
                currentNode = currentNode?.next;
            }
        }
    }
    
    func Find( value: T ) -> Node<T>? {
        var currentNode = self.startingNode
        while currentNode != nil {
            if currentNode!.value == value {
                return currentNode;
            }
            
            currentNode = currentNode?.next;
        }
        
        return nil
    }
}

