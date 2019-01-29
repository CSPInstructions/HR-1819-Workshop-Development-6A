emptyList = list()
numberList = list([1, 2, 3, 4, 5, 6, 7, 8, 9])

numberList.append(0)
numberList.remove(1)

print("First Item {0}\nLast Item {1}".format(numberList[0], numberList[len(numberList) - 1]))