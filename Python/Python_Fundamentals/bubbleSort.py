#get random module to build random lists to test
import random

def bubbleSort(list):
    #how many comparissons in this "lap"? we need to start fr
    for lap in range(len(list)-1,0,-1):
        for i in range(lap):
            if list[i] > list[i+1]:
                temp = list[i]
                list[i] = list[i+1]
                list[i+1] = temp
    return list



#random list generator
def randomList(pos):
    list = []
    for i in range(pos):
         list.append(int(round(random.random()*1000)))
    return list

print bubbleSort(randomList(15))
print bubbleSort(randomList(15))
print bubbleSort(randomList(25))
print bubbleSort(randomList(25))
print 'EXTREME TEST CAAAAAASE!!!'
print bubbleSort(randomList(105))
print bubbleSort(randomList(25005))
