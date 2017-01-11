#PART 1
students = [ 
     {'first_name':  'Michael', 'last_name' : 'Jordan'},
     {'first_name' : 'John', 'last_name' : 'Rosales'},
     {'first_name' : 'Mark', 'last_name' : 'Guillen'},
     {'first_name' : 'KB', 'last_name' : 'Tonel'}
]

def names1(list):
    for dict in list:
        print dict['first_name'] + " " + dict['last_name']
#names1(students)

#PART 2

users = {
 'Students': [ 
     {'first_name':  'Michael', 'last_name' : 'Jordan'},
     {'first_name' : 'John', 'last_name' : 'Rosales'},
     {'first_name' : 'Mark', 'last_name' : 'Guillen'},
     {'first_name' : 'KB', 'last_name' : 'Tonel'}
  ],
 'Instructors': [
     {'first_name' : 'Michael', 'last_name' : 'Choi'},
     {'first_name' : 'Martin', 'last_name' : 'Puryear'}
  ]
 }

def names2(dict):
    for list in dict:
        print list
        for person in enumerate(dict[list], 1):
            full = person[1]['first_name'] + person[1]['last_name']
            print str(person[0]) + ' - ' + person[1]['first_name'] + ' ' + person[1]['last_name'] + ' - ' + str(len(full))
            

names2(users)
