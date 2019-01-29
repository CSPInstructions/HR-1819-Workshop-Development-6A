package nl.cspconnections;

public class Main {

    public static void main(String[] args) {
        Stack<String> computerBooks = new Stack<String>();

        computerBooks.Push( "Building Maintainable Software");
        computerBooks.Push( "Introduction To Algorithms");
        computerBooks.Push( "Programming with Minecraft");

        System.out.println( computerBooks.Peek() );
        System.out.println( computerBooks.Pop() );
        System.out.println( computerBooks.Peek() );
    }
}

