#test cases
x = [4, 6, 1, 3, 5, 7, 25]
y = [4, "Tom", 1, "Michael", 5, 7, "Jimmy Smith"]

#part 1
def draw_stars(list):
    for pos in list:
        print '*'*pos

draw_stars(x)

#part 2
def modified_stars(list):
    for pos in list:
        if isinstance(pos, basestring):
            for first in pos:
                if first == pos[0]:
                    print first.lower() * len(pos)
        else:    
            print '*'*pos

modified_stars(y)
