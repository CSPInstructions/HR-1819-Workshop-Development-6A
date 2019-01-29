package nl.cspconnections;

import java.util.ArrayList;
import java.util.List;

class Stack<T> {
    private List<T> stack;

    Stack() {
        this.stack = new ArrayList<>();
    }

    void Push(T newElement) {
        this.stack.add( newElement );
    }

    T Peek() {
        return this.stack.isEmpty() ? null : this.stack.get( this.stack.size() - 1 );
    }

    T Pop() {
        if ( this.stack.isEmpty() ) {
            return null;
        }

        T lastItem = this.Peek();
        this.stack.remove( lastItem );
        return lastItem;
    }
}
