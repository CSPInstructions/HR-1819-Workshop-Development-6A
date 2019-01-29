def sequentialSearch( data, item ):
    for index in range( len( data ) ):
        if data[index] == item:
            return index
    return -1


def binarySearch( data, item ):
    startingPoint = 0
    endingPoint = len( data ) - 1

    while startingPoint <= endingPoint:
        middlePoint = ( startingPoint + endingPoint ) // 2

        if item > data[middlePoint]:
            startingPoint = middlePoint + 1

        elif item < data[middlePoint]:
            endingPoint = middlePoint - 1

        else:
            return middlePoint
    return -1


firstNumberCollection = [ 1, 2, 3 ]
secondNumberCollection = [ 4, 5, 6 ]
thirdNumberCollection = [ 4, 2, 6 ]

print( sequentialSearch( firstNumberCollection, 2 ) )
print( sequentialSearch( secondNumberCollection, 4 ) )
print( sequentialSearch( thirdNumberCollection, 5 ) )

print( binarySearch( firstNumberCollection, 3 ) )
print( binarySearch( secondNumberCollection, 1 ) )