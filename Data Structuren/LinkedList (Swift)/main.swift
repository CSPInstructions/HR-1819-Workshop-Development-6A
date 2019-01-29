import Foundation

var numbers = LinkedList<Int>()
numbers.AddRange( values: Array( 1...3 ) )

let firstFind = numbers.Find( value: 3 )?.value
print( firstFind != nil ? firstFind! : "Empty" )

numbers.Remove( value: 3 )

let secondFind = numbers.Find( value: 3 )?.value
print( secondFind != nil ? secondFind! : "Empty"  )
