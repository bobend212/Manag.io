**KONTA UZYTKOWNIKOW**

- [ ] Rejestrowanie(dodawanie) uzytkownikow do systemu [MANAGER, LEADER]
- [ ] Usuwanie uzytkownikow z systemu
- [ ] Edycja kont uzytkownikow w systemie [MANAGER, ADMIN]
- [x] Mozliwosc logowania [ALL]
- [x] Mozliwosc wylogowywania
- [x] Edycja swojego konta [ALL]
- [ ] Role
- [ ] Przypisywanie rol, usuwanie, zmienianie. [MANAGER, ADMIN]
- [ ] Funkcjonalnosc zmiany/przypomnienia hasla do konta.

**PROJEKTY/KLIENCI**

- [x] Lista projektow/klientow [ALL]
- [x] Filtrowanie tabeli z projektami
- [ ] Zmiana statusu projektu przez uzytkownika. [zalogowany]
- [ ] Wypisanie lub zapisanie sie do danego projektu. [zalogowany]
- [ ] Mozliwosc edycji, usuwania i dodawania projektu do bazy.
- [ ] ustawic defaultowy status dla tworzonego projektu 'New'.

**WORKFLOW**

- [ ] Project Workflow [ALL] (widok, kto na jakim projekcie w danej chwili sie znajduje) >> SIATKA kafelkow
- [ ] Przypisywanie uzytkownikow do projektu [MANAGER, LEADER] >> drag and drop? albo z listy rozwijanej
- [ ] Edycja statusu projektu // not ready, in progress, ready, done, on hold (dopracowac)

**TIMESHEET**

- [ ] Stworzenie miesiaca dla nowego timesheeta, nastepnie praca na tym miesiacu.
- [ ] Wyslanie timesheeta do zatwierdzenia?? 
- [ ] Dodawanie do bazy swojego czasu pracy. (Timesheet) [USERS ALL] >> DATE, TYPE, PROJECT, TIME(h)
- [ ] CRUD na Timesheecie (tabeli)


**OTHER**

- [ ] Mozliwosc generowania raportu do PDF/Excel/csv

---

<<---- ENDPOINTS ---->>

*PROJECT*
http://localhost:5000/projects  = GET ALL PROJECTS
http://localhost:5000/projects/{projectId} = GET PROJECT DETAILS
http://localhost:5000/projects/{projectId} = DELETE PROJECT
http://localhost:5000/projects/{projectId} = EDIT PROJECT

*TIMESHEET*
-Id
-UserId
-Month
-Year

http://localhost:5000/timesheets = get all timesheeets
http://localhost:5000/timesheets/{timesheetId} = timesheet details with records
http://localhost:5000/timesheets/{timesheetId} = delete details with records
http://localhost:5000/timesheets/{timesheetId} = edit details with records


--> /// Testy Jednostkowe /// <--
--> /// Stworzyc koncepcje UI /// <--
--> /// Opracowac DB Schema! /// <--


**UI**

- [x] ogarnac warunkowe wyswietlanie komponentow 16/07 (home component)

---

###statusy projektow
W systemie znajduje sie kilka statusow jakie mozna ustawiac dla projektow.
Kazdy nowo dodany projekt musi posiadac status 'New'.

Lista statusow:
In Progress, Done, On Hold, Checking, Cancelled, New

---