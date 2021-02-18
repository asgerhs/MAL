student(andreas).
student(martin).
student(asger).
student(william).

room(200).
room(201).
room(202).
room(203).

class(dbd, andreas).
class(dbd, william).
class(dbd, martin).

class(mal, andreas).
class(mal, asger).
class(mal, william).
class(mal, martin).

class(dsc, none).

class(ufo, andreas).
class(ufo, asger).
class(ufo, martin).
class(ufo, william).

schedule(monday, mal, 200).
schedule(monday, ufo, 200).
schedule(tuesday, dsc, 201).
schedule(wednesday, dbd, 202).
schedule(thursday, dbd, 202).
schedule(friday, ufo, 203).

/* Ligegyldig regel, samme resultat kan fås
ved at skrive class(Class, Student)
afhængigt af hvad man vil have ud. */
studies(Student, Class) :-
    student(Student),
    class(Class, Student).

scheduledAssignment(Student, Day, Class, Room) :-
    student(Student),
    schedule(Day, Class, Room),
    class(Class, Student).