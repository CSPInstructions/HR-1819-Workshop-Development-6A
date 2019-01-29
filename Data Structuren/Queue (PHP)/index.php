<?php include "queue.php"; ?>
<!DOCTYPE html>

<html lang="en">
    <head>
        <title>Queue</title>
    </head>

    <body>
        <?php
            $icecreamQueue = new Queue();

            $icecreamQueue -> Enqueue( "Jimmy" );
            $icecreamQueue -> Enqueue( "Wesley" );
            $icecreamQueue -> Enqueue( "Kiara" );

            echo $icecreamQueue -> Peek() . "<br/>";
            echo $icecreamQueue -> Dequeue() . "<br/>";
            echo $icecreamQueue -> Peek() . "<br/>";
        ?>
    </body>
</html>