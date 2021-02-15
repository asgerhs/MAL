student(andreas).
student(martin).
student(asger).
student(william).

room(202).
room(203).
room(204).
room(205).

class(dbd).
class(mal).
class(dsc).
class(ufo).

classroom(Class, Room) :-
    class(Class),
    room(Room).

assignedclass(Class, Student) :-
    student(Student),
    classroom(Class, Room).

assignedclass(dbd, andreas).
assignedclass(dbd, william).
assignedclass(dbd, martin).

assignedclass(mal, andreas).
assignedclass(mal, asger).
assignedclass(mal, william).
assignedclass(mal, martin).

assignedclass(dsc, none).

assignedclass(ufo, andreas).
assignedclass(ufo, asger).
assignedclass(ufo, martin).
assignedclass(ufo, william).

schedule(Day, Class, Room) :-
    class(Class),
    room(Room).

schedule(monday, mal, 202).
schedule(tuesday, dsc, 404).
schedule(tuesday, mal, 202).
schedule(wednesday, dbd, 203).
schedule(thursday, dbd, 209).
schedule(friday, ufo, 205).
