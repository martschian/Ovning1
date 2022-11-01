# Övning1

Ett enkelt terminalprogram skivet i C#.

Uppgiften var att skriva ett personalregister som kan visa nuvarande personal 
samt lägga till ny personal.

Jag valde att skapa en registerklass (som wrappar C#:s inbyggda List-klass) med 
metoder för att lägga till samt visa personal. Varje anställd är i sin tur en 
instans av klassen Employee som har två attribut, name resp. wage. 

Urprungligen hade Employee en metod för att presentera detaljerna för varje anställd, 
men till slut valde jag att override:a ToString() istället.
