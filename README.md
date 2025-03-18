# FinalProject

#Documentatie de design
template initial: https://ziggyologist.github.io/MoodTrackerApp/habit_page.html
Avand in vedere ca aplicatia de Windows Forms are scopuri diferite fata de cea realizata in React.js, am adaptat designul pentru a se alinia noilor cerinte. Activitatile nu mai sunt organizate dupa data, ci in functie de prioritate. De asemenea, din cauza limitarilor de timp si a imposibilitatii de a lucra cu fisiere SVG, am fost nevoita sa fac modificari si sa utilizez alte imagini. Am pastrat culorile din designul initial: #96645d, #e3bfba si #c2c2c2, precum si tema naturii (muntii, cerbul).
Alte elemente de design: Activitatile se marcheaza ca facute sau nefacute prin schimbarea culorii triunghiului din gri in verde. Butoanele au un efect de hover ca pointer. S-a luat decizia de a da dimensiuni standard aplicatiei, atat din motive de design, cat si de functionalitate.

#Logica aplicatiei
Aplicatia are 4 functionalitati principale:
1. Adaugarea de noi activitati: Dupa apasarea butonului plus, se deschide o fereastra in care utilizatorul trebuie sa adauge un nume, o descriere si o prioritate pentru activitatea respectiva. Toate activitatile sunt tratate initial ca nefacute, iar utilizatorul nu poate marca activitatea ca facuta la momentul crearii. Fiecare camp are limitari de lungime a caracterelor, iar prioritatea poate fi setata intre 0 si 10.
2. Afisarea activitatilor in ordinea prioritatilor: Odata ce lista de activitati a fost creata, acestea este afisata intotdeauna in ordinea prioritatilor, de la cel mai mic la cel mai mare. 0 reprezinta prioritatea cu cel mai inalt grad de urgenta.
3. Marcarea activitatilor ca facute sau nefacute: Se face prin apasarea pe triunghiul gri. Triunghiul are si functia de toggle, iar utilizatorul poate marca o activitate ca facuta sau nefacuta doar apasand pe acesta. O fereastra instiinteaza userul ca a marcat o activitate ca facuta sau nefasta.
4. Stergerea activitatii: Utilizatorul poate sterge o activitate prin apasarea butonului de click stanga pe numele activitatii. O noua fereastra va afisa lista completa a activitatilor si statutul acestora (facute sau nu), iar utilizatorului i se va cere sa confirme stergerea activitatii respective. Odata stearsa, activitatea dispare si din lista.
