# Prolog opgave til uge 1

## For at køre programmet

Kræver at docker er installeret på din computer, og du derefter laver et image ud fra den dockerfile der ligger her. 
Dette gøres ved at skrive følgende kommando i roden af denne fil:

`docker build -t prolog .`

Eller, hvis docker er installeret som extension af VSCode, kan dockerfilen højre clickes og derefter tryk på `Build Image...` og tryk derefter enter. 

Derefter skal der laves en interaktiv container, dette gøres ved brug af følgende kommando i roden af denne fil: 

`docker run -it --rm prolog`

## Brug af programmet

Følger prolog syntax, skriv f.eks. `class(ufo, Student).` for at få alle studerende der går til ufo. 

Der er en regel i programmet der kan bruges til at få fremvist skema information:   
`scheduledAssignment(Student, Day, Class, Room)`

Denne regel kan bruges til at få skema information om den enkelte studerende på en pågældende dag, eller flere. Eksempel brug:

`scheduledAssignment(william, monday, Class, Room).`

Vi har en student der hedder william, og vi vil gerne se hvad for nogle timer han har om mandagen. Dette returnere alle williams timer, samt hvilket rum det er afholdt i. 

source:
[hello_world.pl](./hello_world.pl)
